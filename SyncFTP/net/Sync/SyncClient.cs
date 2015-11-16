using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnterpriseDT.Net.Ftp;
using EnterpriseDT.Util.Debug;
using System.Timers;
using System.IO;

namespace EnterpriseDT.Net.Ftp.Sync
{
    public class SyncClient
    {
        private Logger log = Logger.GetLogger("FTPConnection");
        private FTPConnection connection = new FTPConnection();
        private string remote_sync_dir = string.Empty;
        private string local_base_dir = string.Empty;

        public delegate void PrintLog(string msg);

        public PrintLog PrintEventHandler;

        private void PrintOut(string msg)
        {
            //log.Info(msg);
        }

        private Timer sync_timer = new Timer();
        public SyncClient(string address, string port, string user_name, string password, string local_base_dir, Encoding encoding, string remote_sync_dir = null)
        {
            PrintEventHandler = new PrintLog(PrintOut);

            try
            {
                connection.ServerAddress = address;
                connection.ServerPort = Convert.ToInt32(port);
                connection.UserName = user_name;
                connection.Password = password;
                connection.LocalDirectory = local_base_dir;
                this.local_base_dir = local_base_dir;
                connection.ConnectMode = FTPConnectMode.PASV;

                //remote_sync_dir
                if (encoding == null)
                {
                    connection.CommandEncoding = Encoding.GetEncoding("GBK");
                }
                else
                {
                    connection.CommandEncoding = encoding;
                }

                if (remote_sync_dir == null)
                {
                    remote_sync_dir = "/";
                }
                this.remote_sync_dir = remote_sync_dir;

                connection.AutoLogin = true;
            }
            catch (Exception e)
            {
                log.Info("配置有问题");
                log.Error(e);
            }
        }

        private int sync_interval_seconds = 4;
        public bool Start(int sync_interval_seconds)
        {
            this.sync_interval_seconds = sync_interval_seconds;
            try
            {
                connection.Connect();
            }
            catch (Exception e)
            {
                PrintEventHandler("连接失败！" + e.Message);
                return false;
            }


            //timer   sync_interval_seconds
            sync_timer.Interval = sync_interval_seconds * 1000;
            sync_timer.Elapsed += Sync_Data;
            sync_timer.Enabled = true;
            sync_timer.Start();

            return true;
        }

        private void Sync_Data(object sender, EventArgs args)
        {
            try
            {
                if (connection != null)
                {
                    if (!connection.IsConnected)
                    {
                        connection.Connect();
                    }

                    if (connection.IsConnected)
                    {
                        FTPFile[] base_files = connection.GetFileInfos(this.remote_sync_dir);
                        sync_timer.Stop();

                        PrintEventHandler(string.Format("根目录找到{0}项.", base_files.Length));
                        foreach (FTPFile file in base_files)
                        {
                            PrintEventHandler((file.Dir == true ? "[文件夹]:" : "[文  件]:") + file.Path);
                            if (file.fileName != "." && file.fileName != "..")
                            {
                                List_Create_Get(file);
                            }
                        }
                        sync_timer.Start();
                    }
                    else
                    {
                        log.Info("Timer 启动FTP连接失败");
                    }
                }

            }
            catch (Exception e)
            {
                if (!this.CloseByHand)
                {
                    PrintEventHandler("遇到未知异常:" + e.Message + Environment.NewLine);
                    this.AutoRestart();
                }
            }

        }

        /// <summary>
        /// 同步方法
        /// </summary>
        private void List_Create_Get(FTPFile dir_or_file)
        {
            string remote_path = dir_or_file.Path;
            string remote_file_name = dir_or_file.Name;
            string tmp_local_path = string.Empty;
            if (this.remote_sync_dir != "/")
            {
                tmp_local_path = (this.local_base_dir + remote_path.Replace(this.remote_sync_dir, "")).Replace("//", "/");
            }
            else
            {
                tmp_local_path = (this.local_base_dir + remote_path).Replace("//", "/");
            }


            //文件
            if (dir_or_file.Dir)
            {
                connection.LocalDirectory = tmp_local_path;
                if (!Directory.Exists(tmp_local_path))
                {
                    Directory.CreateDirectory(tmp_local_path);
                    PrintEventHandler("#创建文件夹#" + tmp_local_path);
                }

                //deep in
                FTPFile[] files = connection.GetFileInfos(remote_path);
                foreach (FTPFile file in files)
                {
                    if (file.fileName != "." && file.fileName != "..")
                    {
                        List_Create_Get(file);
                    }
                }
            }
            //目录
            else
            {
                bool need_download = false;
                //不存在
                if (!File.Exists(tmp_local_path))
                {
                    need_download = true;
                    PrintEventHandler("#下载文件#" + tmp_local_path);
                }
                else
                {
                    //存在
                    long local_file_size = new FileInfo(tmp_local_path).Length;

                    if (local_file_size != dir_or_file.Size)
                    {
                        need_download = true;
                        PrintEventHandler("#更新文件#" + tmp_local_path);
                    }
                }

                if (need_download)
                {
                    PrintEventHandler("#下载文件#" + tmp_local_path);
                    try
                    {
                        connection.DownloadFile(tmp_local_path, dir_or_file.Path);
                    }
                    catch (Exception e)
                    {
                        if (!this.CloseByHand)
                        {
                            PrintEventHandler("【异常】下载文件:" + e.Message);
                        }
                    }


                }
            }

        }

        private bool CloseByHand = false;
        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            this.CloseByHand = true;
            PrintEventHandler("手动关闭同步.");

            if (sync_timer != null)
            {
                sync_timer.Enabled = false;
                sync_timer.Stop();
            }

            if (connection != null)
            {
                connection.Close();
            }
        }

        public void AutoRestart()
        {
            if (this.CloseByHand)
            {
                PrintEventHandler("手动关闭的连接,不可自动恢复,请手动[启动].");
            }
            else
            {
                PrintEventHandler("尝试重新连接 ...");
                Stop();
                this.Start(this.sync_interval_seconds);
            }
        }

    }
}
