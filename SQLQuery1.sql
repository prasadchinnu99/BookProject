--create table query

CREATE TABLE tbl_USER(
	userid int NOT NULL PRIMARY KEY,
	first_name nvarchar(50) NOT NULL,
	last_name nvarchar(50) NULL,
	email nvarchar(50) NOT NULL,
	password nvarchar(50) NOT NULL,
	mobile nvarchar(50) NULL)
	GO;

CREATE TABLE tbl_BOOKS(
	bookid int NOT NULL PRIMARY KEY,
	bookname nvarchar(50) NOT NULL,
	--categoryid nvarchar(50) NOT NULL,
	categoryname nvarchar(50) NOT NULL FOREIGN KEY REFERENCES tbl_CATEGORYS(categoryname),
	author nvarchar(50)  NULL,
	publisher nvarchar(50)  NULL,
	price decimal(8,2) NOT NULL)
	--categoryid int FOREIGN KEY REFERENCES tbl_CATEGORY(categoryid)
	GO;

CREATE TABLE tbl_CATEGORY(
    categoryid int NOT NULL PRIMARY KEY,
	categoryname nvarchar(50)NOT NULL)
	GO;

--select query

SELECT * FROM tbl_BOOK;
SELECT * FROM tbl_CATEGORY;
SELECT * FROM tbl_USER;

