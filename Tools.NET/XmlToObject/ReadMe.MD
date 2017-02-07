##介绍  
XML解析工具  
用来迁移点点博客导出的数据，最终保存到数据库中。

##设计思路  
1.工具设计成操作树的模式，左边是原来的xml树，右边是选择导出的树的节点。  
  
2.由于最终的目的是数据的转移，所以关键是操作结构,以目的为导向设计。  
A.不需要将xml的内容信息在树上表现，扫描节点和属性。  
B.操作XML采用.net现有的工具。  
C.关注XPATH也许是好的选择。 
D.复杂结构不处理。 
  
3.界面操作的目的是为了找出一系列XPATH，最后组成我需要的对象。  

##使用方法  
见截图  
![XmlToObject](https://raw.githubusercontent.com/tinygg/Tools.Net/master/XmlToObject/XmlToObject.png)  

##说明  
由于没有做到通用，直接使用可能稍有问题，请酌情修改。