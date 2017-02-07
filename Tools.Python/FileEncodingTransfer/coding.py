#!/usr/bin/python
#coding=utf8
#how to use: python coding.py [utf8/GBK] [file or dir name]
import os
import sys
import codecs

global codings,try_index,to_encoding
codings = ("GBK","UTF-8") #supportted source-encoding
try_index = 0

def convert(file,out_enc="UTF-8",try_index=0):
    if try_index == len(codings):
        print "try to end.\r\n"
        return
    else:
        in_enc = codings[try_index]

    try:
        print "try coding %s" % in_enc
        print ">> converting file:<%s>" % file
        f=codecs.open(file,'r',in_enc)
        new_content=f.read()
        codecs.open(file,'w',out_enc).write(new_content)
        print 'ok\r\n\r\n'
    except IOError as err:
        print ("I/O error: {0}".format(err))
    except UnicodeDecodeError as err2:
        try_index += 1
        print "try next ...\r\n"        
        convert(file, out_enc, try_index)

def explore(dir):
    for root,dirs,files in os.walk(dir):
        #print root, dirs, files
        for file in files:
            path=os.path.join(root,file)
            convert(path,to_encoding)
        for _dir in dirs:
            explore(_dir)

def main():
    print "Attention: utf8 <--> gbk \r\n"

    for path in sys.argv[2:]:
        if(os.path.isfile(path)):
            convert(path)
        elif os.path.isdir(path):
            explore(path)

if __name__=="__main__":
    global to_encoding
    to_encoding  =  sys.argv[1]
    main()