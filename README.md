# 凡式框架
## 为自己准备的框架代码
	
	准备历时多年完成他。
	2021年9月28日开始编写。
	修改DB服务为API服务。
	2022年1月14日开始编写业务服务。

## 框架采用跨平台方案
整个框架以DB服务、业务服务、根服务、主程序、时序程序组成

## DB服务
直接面向数据库执行操作，整个行为操作执行双数据库模式，每个行为语句均记录在sqlite数据库中，同时对主数据库进行操作。
主数据库支持：MSSQLSever、MySQL、Sqlite、Access等数据库，行为记录数据库支持：Sqlite
DB服务采用net core5.0框架编写，API服务 运行环境Linux （Centos7为编写环境）

## 业务服务
应对各类任务服务，将每个服务处理后，通过访问DB服务执行。每个业务流程均记录在sqlite数据库中，同时完成业务流程。
业务服务采用net core5.0框架编写，API服务 运行环境Linux （Centos7为编写环境）



# FanFormulaFramework
Framework code for yourself

	Preparation took years to complete him.
	Preparation will begin on September 28, 2021.
	Example Change the DB service to API service.

## The framework adopts cross-platform scheme
The whole framework is composed of DB service, business service, root service, main program and sequence program

## DB service
The actions are performed directly against the database, and the entire action is performed in dual database mode, where each action statement is recorded in the SQLite database and the operation is performed against the primary database.
Main database support: MSSQLSever, MySQL, Sqlite, Access and other databases, behavior record database support: Sqlite
The DB service is written by net core5.0 framework, and the API service running environment is Linux (Centos7 as the writing environment).

## Business service
For various task services, each service is processed and executed by accessing DB services. Each business process is recorded in the SQLite database and the business process is completed at the same time.
Net core5.0 framework is used to write the business service, and the API service running environment is Linux (Centos7 as the writing environment).
