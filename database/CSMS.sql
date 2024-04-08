CREATE DATABASE CSMS
USE CSMS

CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(MAX) NULL,
    password NVARCHAR(MAX) NULL,
    role NVARCHAR(MAX) NULL,
    status NVARCHAR(MAX) NULL,
    profile_image NVARCHAR(MAX) NULL,
    date_reg DATE NULL
);
Select * from users


INSERT INTO users (username,password,role,status,profile_image,date_reg) VALUES ('admin','Admin@123','Admin','Active','','2024-02-02')


CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY(1,1),
    prod_id NVARCHAR(MAX) NULL,
    prod_name NVARCHAR(MAX) NULL,
    prod_type NVARCHAR(MAX) NULL,
    prod_stock INT NULL,
    prod_price FLOAT NULL,
    prod_status NVARCHAR(MAX) NULL,
    prod_image NVARCHAR(MAX) NULL,
    date_update DATE NULL,
    date_insert DATE NULL,
    date_delete DATE NULL
);

Select * from products

SELECT * FROM products WHERE id = 2

DELETE FROM products WHERE prod_id ='BK003'


CREATE TABLE customers (
    id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
    total_price FLOAT NULL,
    date DATE NULL,

);

SELECT * FROM customers

ALTER TABLE customers ADD amount FLOAT NULL
ALTER TABLE customers ADD change FLOAT NULL
ALTER TABLE customers ADD users VARCHAR(MAX) NULL

CREATE TABLE orders (
    id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
    prod_id NVARCHAR(MAX) NULL,
    prod_name NVARCHAR(MAX) NULL,
    prod_type NVARCHAR(MAX) NULL,
    prod_price FLOAT NULL,
	order_date DATE NULL,
	delete_order DATE NULL,
);

ALTER TABLE orders ADD qty INT NULL
SELECT * FROM orders
