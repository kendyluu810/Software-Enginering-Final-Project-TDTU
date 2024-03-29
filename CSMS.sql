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
    id INT PRIMARY KEY,
    prod_id NVARCHAR(50),
    prod_name NVARCHAR(100),
    prod_type NVARCHAR(50),
    prod_stock NVARCHAR(50),
    prod_price NVARCHAR(50),
    prod_status NVARCHAR(50),
    prod_image NVARCHAR(200),
    date_insert NVARCHAR(50),
    date_update NVARCHAR(50),
    date_delete NVARCHAR(50)
);

CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    total_price NVARCHAR(50),
    amount NVARCHAR(50),
    change NVARCHAR(50),
    date NVARCHAR(50)
);

CREATE TABLE orders (
    id INT PRIMARY KEY,
    customer_id INT,
    prod_id NVARCHAR(50),
    prod_name NVARCHAR(100),
    prod_type NVARCHAR(50),
    qty INT,
    prod_price NVARCHAR(50),
    date NVARCHAR(50),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);


