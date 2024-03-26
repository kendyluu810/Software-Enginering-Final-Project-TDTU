CREATE DATABASE CSMS
USE CSMS

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

CREATE TABLE users (
    id INT PRIMARY KEY,
    username NVARCHAR(50),
    password NVARCHAR(50),
    role NVARCHAR(50),
    status NVARCHAR(50),
    profile_image NVARCHAR(200),
    date_reg NVARCHAR(50)
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


