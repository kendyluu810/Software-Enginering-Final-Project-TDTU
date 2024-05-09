use master
go

create database aubertcoffee
go

use aubertcoffee
go

--========================TABLE========================
--STAFF
CREATE TABLE staff (
    staffid varchar(10) PRIMARY KEY,
    fullname VARCHAR(255),
    dob DATE,
    role VARCHAR(255),
    gender varchar(6),
    profile_image varchar(MAX),
    phonenumber VARCHAR(15)
);

--ACCOUNT
CREATE TABLE account (
    username VARCHAR(255) PRIMARY KEY,
    password VARCHAR(255),
    status VARCHAR(255),
    staffid varchar(10),
    FOREIGN KEY (staffid) REFERENCES staff(staffid)
);

--PRODUCT
CREATE table product(
	prod_id VARCHAR(10),
    prod_name NVARCHAR(255) NULL,
    prod_type NVARCHAR(255) NULL,
    prod_stock INT NULL,
    prod_price FLOAT NULL,
    prod_status NVARCHAR(10) NULL,
    prod_image NVARCHAR(MAX) NULL,
    PRIMARY KEY (prod_id)
);

--MEMBERSHIP
CREATE Table Membership(
	membership_id varchar(10) primary key, 
	membership_name varchar(255), 
	membership_phonenumber varchar(13), 
	membership_rank varchar(10),
	membership_discount int,
	membership_accumulation float
);

--RECEIPT
CREATE TABLE receipt(
	receipt_id varchar(10),
	staffid varchar(10), --FK
	membership_id varchar(10) NULL, --FK
	created_date smalldatetime,
	payment_method varchar(10) NULL, 
	total_amount float,
	total_quantity int,
	PRIMARY KEY(receipt_id), 
	FOREIGN KEY (staffid) REFERENCES staff(staffid),
	FOREIGN KEY (membership_id) REFERENCES Membership(membership_id)
);

--COUPON
CREATE table Coupon(
	coupon_id varchar(10) primary key, 
	prod_id varchar(10) NOT NULL, 
	coupon_percent int, 
	FOREIGN KEY (prod_id) REFERENCES product(prod_id)
);

--ORDER_DETAIL
CREATE TABLE order_dt(
	receipt_id varchar(10),
	coupon_id varchar(10) NULL,  --FK
	prod_id varchar(10), 
	product_quantity int,
	product_newPrice float,
	FOREIGN KEY (prod_id) REFERENCES product(prod_id),
	FOREIGN KEY (receipt_id) REFERENCES receipt(receipt_id),
	FOREIGN KEY (coupon_id) REFERENCES Coupon(coupon_id),
)

--========================DATA========================

-- Insert data into STAFF table
INSERT INTO staff (staffid, fullname, dob, role, gender, profile_image, phonenumber)
VALUES ('ST001', 'John Doe', '2000-01-01', 'Manager', 'Male', '', '+1234567890'),
       ('ST002', 'Jane Smith', '2004-02-15', 'Cashier', 'Female', '', '+9876543210'),
       ('ST003', 'David Lee', '2003-12-24', 'Manager', 'Male', '', '+0123456789'),
	   ('ST004', 'Anna Browns', '2005-12-24', 'Waitress', 'Female', '', '+0123456689')

select * from staff


-- Insert data into ACCOUNT table (linking to existing staff IDs)
INSERT INTO account (username, password, status, staffid)
VALUES ('john', '123456', 'Active', 'ST001'),
       ('jane', '123456', 'Active', 'ST002'),
       ('admin', 'admin', 'Active', 'ST003');

select * from account

--insert data into product table

select * from product 
INSERT INTO product (prod_id, prod_name, prod_type, prod_stock, prod_price, prod_status, prod_image)
VALUES ('PD0001', 'Espresso', 'Coffee', 100, 3.50, 'Available', ''),
       ('PD0002', 'Latte', 'Coffee', 80, 4.00, 'Available', ''),
       ('PD0003', 'Cappuccino', 'Coffee', 70, 4.50, 'Available', ''),
       ('PD0004', 'Americano', 'Coffee', 50, 3.00, 'Available', ''),
       ('PD0005', 'Mocha', 'Coffee', 60, 4.20, 'Available', ''),
       ('PD0006', 'Black Tea', 'Tea', 120, 2.50, 'Available', ''),
       ('PD0007', 'Green Tea', 'Tea', 100, 2.80, 'Available', ''),
       ('PD0008', 'Milk Tea', 'Tea', 90, 3.80, 'Available', ''),
       ('PD0009', 'Iced Coffee', 'Cold Brew', 40, 4.00, 'Available', ''),
       ('PD0010', 'Iced Latte', 'Cold Brew', 30, 4.50, 'Available', '');

--Membership
INSERT INTO Membership (membership_id, membership_name, membership_phonenumber, membership_rank, membership_discount, membership_accumulation)
VALUES ('M00001', 'John Doe', '123-456-7890', 'Gold', 10, 50.0),
       ('M00002', 'Jane Smith', '987-654-3210', 'Silver', 5, 20.0),
       ('M00003', 'Mike Lee', '567-890-1234', 'Bronze', 2, 10.0),
       ('M00004', 'Alice Johnson', '345-678-9012', 'Gold', 10, 50.0),
       ('M00005', 'David Davis', '789-012-3456', 'Silver', 5, 20.0),
       ('M00006', 'Brianna Miller', '234-567-8901', 'Bronze', 2, 10.0),
       ('M00007', 'Charles Garcia', '678-901-2345', 'Gold', 10, 50.0),
       ('M00008', 'Amanda Hernandez', '102-345-6789', 'Silver', 5, 20.0),
       ('M00009', 'William Moore', '456-789-0123', 'Bronze', 2, 10.0),
       ('M00010', 'Elizabeth Thomas', '890-123-4567', 'Gold', 10, 50.0);
select * from Membership

select * from product