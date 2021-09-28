# FanFormulaFrameworkSystem
为自己准备的框架代码
	
	准备历时多年完成他。
	2021年9月28日开始编写。

##框架采用跨平台方案
整个框架以DB服务、业务服务、根服务、主程序、时序程序组成

##DB服务
直接面向数据库执行操作，整个行为操作执行双数据库模式，每个行为语句均记录在sqlite数据库中，同时对主数据库进行操作。
主数据库支持：MSSQLSever、MySQL、Sqlite、Access等数据库，行为记录数据库支持：Sqlite
DB服务采用net core3.1框架编写，net core控制台运行 运行环境Linux （Centos7为编写环境）


