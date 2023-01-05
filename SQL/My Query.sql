 create table student (name varchar(200), age int, gender varchar(10));

 select * from student

 insert into student (name, age, gender) values('Divya', 23, 'F'), ('Ajay', 23, 'M'), ('Anil', 23, 'M'), ('Raj', 23, 'M');

 insert into student (name, age) values('Akshata', 34), ('Nishant', 30), ('Birjesh', 37), ('Varsha', 25);

 select * from student where gender = 'M';

UPDATE student
SET gender = 'F'
WHERE gender is NULL;

DELETE student
WHERE gender = 'F';

create table student2 (fname varchar(30) unique, age int, email varchar(30));

insert into student2 (age, email) values(2, 'faiz@gmail.com');

update student2 
set fname = 'Faiz'
where fname is null;

select * from student;

create table student_info(
	Id int Primary Key,
	fname varchar(30),
	lname varchar(30) not null,
);

insert into student_info(Id, fname, lname)
values(1, 'Faiz', 'Akkiwat'),
	  (2, 'Ajay', 'Eshwaran'),
	  (3, 'Adarsh', 'Dhulaj'),
	  (4, 'Vishal', 'Chaurasiya'),
	  (5, 'Anil', 'Kuntrapakam'),
	  (6, 'Pragati', 'Ishwara'),
	  (7, 'Namrata', 'Sutar');

select * from student_info;

alter table student_info add mobile_no varchar(200);

update student_info
set mobile_no = 'Not your number'
where mobile_no is null;

alter table student_info drop column mobile_no;

exec sp_help student_info

alter table student_info alter column mobile_no varchar(20);

update student_info
set mobile_no = '7348974744'
where Id = 1;

update student_info
set mobile_no = '6541235644'
where Id = 2;

update student_info
set mobile_no = '2346427599'
where Id = 3;

update student_info
set mobile_no = '2437541233'
where Id = 4;

update student_info
set mobile_no = '2394123022'
where Id = 5;

update student_info
set mobile_no = '2102932344'
where Id = 6;

update student_info
set mobile_no = '1203203244'
where Id = 7;

alter table student_info alter column mobile_no varchar(20);

ALTER TABLE student_info
ADD CONSTRAINT lastname UNIQUE(lname);

update student_info
set lname = 'Dhulaj'
where fname = 'Anil';

select * from student_info;

alter table student_info drop column email;

Select CAST(mobile_no AS BigInt) from student_info;

alter table student_info alter column mobile_no BigInt;

ALTER TABLE student_info
ADD CONSTRAINT PK UNIQUE(Id);

use Student
go

create table person(
	id int not null,
	lname varchar(20),
	fname varchar(20) not null,
	age int
);

alter table person add primary key(id, fname);

exec sp_help person;

insert into person(id, lname, fname)
values
(1, 'akki', 'faiz'),
(2, 'lakki', 'fz'),
(3, 'avlakki', 'f');

select * from person

update person
set age = 23

insert into person(id, lname, fname)
values(1, 'akkiwat', 'faiz');

delete from person
where id = 1

alter table person add constraint ageMismatch check(age <= 25);

update person
set age = 25
where id = 1;

CREATE TABLE Persons (
    Personid int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int
);

insert into Persons(LastName, FirstName, Age)
values
('akki', 'faiz', 12),
('lakki', 'fz', 13),
('avlakki', 'f', 32);

select * from Persons

SET IDENTITY_INSERT Persons off;

insert into Persons(Personid, LastName, FirstName, Age)
values
(10, 'zakki', 'lakki', 23);

insert into Persons(LastName, FirstName, Age)
values
('asda', 'asd', 12),
('laasdakki', 'asd', 13),
('ds', 'fad', 32);

alter table Persons add default 20 for age;

insert into Persons(LastName, FirstName)
values
('asd', 'ad'),
('qe', 'try'),
('xcv', 'hgj');

delete from Persons
where Age = 20;

select * from Persons where Personid <= 12 and age > 13;

select distinct Age from Persons;

select Personid from Persons where Personid < 12;

use Student
go

CREATE TABLE CUSTOMERS(
   ID INT NOT NULL,
   NAME VARCHAR (20) NOT NULL,
   AGE INT NOT NULL,
   ADDRESS CHAR (25) ,
   SALARY DECIMAL (18, 2),       
   PRIMARY KEY (ID)
);

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (1, 'Ramesh', 32, 'Ahmedabad', 2000.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (2, 'Khilan', 25, 'Delhi', 1500.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (3, 'kaushik', 23, 'Kota', 2000.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (4, 'Chaitali', 25, 'Mumbai', 6500.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (5, 'Hardik', 27, 'Bhopal', 8500.00 );

INSERT INTO CUSTOMERS (ID,NAME,AGE,ADDRESS,SALARY)
VALUES (6, 'Komal', 22, 'MP', 4500.00 );

select * from CUSTOMERS;

select count(*) from customers;

select count(age) from customers where age < 25;

SELECT ID, NAME, SALARY FROM CUSTOMERS;

SELECT ID, NAME, SALARY 
FROM CUSTOMERS
WHERE SALARY > 2000 OR age < 25;

update CUSTOMERS
set age = 25
where id = 6;

select distinct age from CUSTOMERS;

select avg(age) from CUSTOMERS;

select min(salary) from CUSTOMERS;

select max(salary) from CUSTOMERS;

select sum(id) from customers;

select count(*) from customers;

select name from customers where name not like '%n';

select name, salary from customers where name in ('khilan', 'kaushik');

select name, salary * 12 annual_salary from CUSTOMERS;

select * from customers;

select * from customers
where id <> 3;

select * from customers
where id != 5;

select * from customers
where id between 2 and 4
and address not in ('Delhi', 'Mumbai');

select * from customers
where id not between 2 and 4;

insert into customers(id,name, age, address, salary)
values (8, 'Rajesh', 33, 'Belgaum', 9800);

update customers
set ADDRESS = null
where address = 'Belgaum';

select * from customers
where address is not null;

select * from customers
order by name asc, id desc;

select * from customers
where address = 'Belarus' and (SALARY <= 5000 and id > 50);

select * from customers
where not address = 'Japan' and not address = 'China';

create table Department (
	ID int primary key,
	DepartmentName nvarchar(50),
	location nvarchar(50),
	DepartmentHead nvarchar(50)
);

insert into Department values(1, 'IT', 'London', 'Rick');
insert into Department values(2, 'Payroll', 'Delhi', 'Ron');
insert into Department values(3, 'HR', 'New York', 'Rick');
insert into Department values(4, 'Other', 'Other Department', 'Cinderella');

select * from Department;

select DepartmentName, Location,
Case
	When ID > 2 Then 'The quantity is greater than 30'
	When ID < 3 Then 'The quantity is 30'
	Else 'The quantity is under 30'
End as QuantityText
From Department;

exec sp_help department;

create table emp (
	id int primary key,
	name varchar(200),
	salary int, 
	gender varchar(100),
	city varchar(100)
);

insert into emp (id, name, salary, gender, city) values (1, 'Georgeta', 97572, 'Female', 'A dos Cunhados');
insert into emp (id, name, salary, gender, city) values (2, 'Julita', 24151, 'Female', 'Huainan');
insert into emp (id, name, salary, gender, city) values (3, 'Wilburt', 77719, 'Male', 'Hadapu Zhen');
insert into emp (id, name, salary, gender, city) values (4, 'Debi', 89439, 'Female', 'San Basilio');
insert into emp (id, name, salary, gender, city) values (5, 'Rainer', 44329, 'Male', 'São José');
insert into emp (id, name, salary, gender, city) values (6, 'Cassius', 57677, 'Male', 'Cẩm Phả Mines');
insert into emp (id, name, salary, gender, city) values (7, 'Trescha', 83179, 'Female', 'Independencia');
insert into emp (id, name, salary, gender, city) values (8, 'Emilee', 67732, 'Female', 'Urozhaynoye');
insert into emp (id, name, salary, gender, city) values (9, 'Melania', 36356, 'Female', 'Barra de Carrasco');
insert into emp (id, name, salary, gender, city) values (10, 'Malachi', 21779, 'Male', 'Verba');
insert into emp (id, name, salary, gender, city) values (11, 'Klarika', 36285, 'Female', 'Halmstad');
insert into emp (id, name, salary, gender, city) values (12, 'Elvyn', 97382, 'Agender', 'Brzączowice');
insert into emp (id, name, salary, gender, city) values (13, 'Fionna', 53722, 'Female', 'Safed');
insert into emp (id, name, salary, gender, city) values (14, 'Drake', 21677, 'Male', 'Ise');
insert into emp (id, name, salary, gender, city) values (15, 'Dolly', 14100, 'Female', 'Hezuo');
insert into emp (id, name, salary, gender, city) values (16, 'Lavina', 19800, 'Female', 'El Guamo');
insert into emp (id, name, salary, gender, city) values (17, 'Chevy', 76751, 'Male', 'Ipojuca');
insert into emp (id, name, salary, gender, city) values (18, 'Cori', 83951, 'Male', 'Sapol');
insert into emp (id, name, salary, gender, city) values (19, 'Erhart', 57090, 'Male', 'Blessington');
insert into emp (id, name, salary, gender, city) values (20, 'Glory', 38505, 'Female', 'Saskylakh');
insert into emp (id, name, salary, gender, city) values (21, 'Linea', 72568, 'Female', 'Lamas');
insert into emp (id, name, salary, gender, city) values (22, 'Wat', 84608, 'Male', 'Dorchester');
insert into emp (id, name, salary, gender, city) values (23, 'Jdavie', 92860, 'Male', 'Bacnar');
insert into emp (id, name, salary, gender, city) values (24, 'Lacie', 18701, 'Female', 'Xinqiao');
insert into emp (id, name, salary, gender, city) values (25, 'Rhett', 34187, 'Male', 'Rybinsk');

select name, salary from emp where salary < 20000;
select * from emp;
drop table emp;

create clustered index aone on emp(salary asc, gender desc);

CREATE CLUSTERED INDEX CIX_EmpDetails_Salary
ON emp(salary DESC);

DROP INDEX CIX_EmpDetails_Salary on emp;

create table prod_order (
	id int primary key,
	cust_name varchar(200),
	amount int, 
	city varchar(100),
	pin_code int
);

insert into prod_order (id, cust_name, amount, city, pin_code) values (1, 'Deeyn', 9595, 'Serra de Água', 906121);
insert into prod_order (id, cust_name, amount, city, pin_code) values (2, 'Adeline', 6590, 'Kriel', 807852);
insert into prod_order (id, cust_name, amount, city, pin_code) values (3, 'Conrado', 8831, 'Minjian', 194436);
insert into prod_order (id, cust_name, amount, city, pin_code) values (4, 'Verney', 6902, 'Changmaoling', 387061);
insert into prod_order (id, cust_name, amount, city, pin_code) values (5, 'Cayla', 6669, 'Heshang', 468511);
insert into prod_order (id, cust_name, amount, city, pin_code) values (6, 'Sherwin', 1149, 'Dřevohostice', 203768);
insert into prod_order (id, cust_name, amount, city, pin_code) values (7, 'Jarrod', 3010, 'Namangan', 689399);
insert into prod_order (id, cust_name, amount, city, pin_code) values (8, 'Pammi', 7725, 'Thành Phố Nam Định', 623306);
insert into prod_order (id, cust_name, amount, city, pin_code) values (9, 'Rafael', 5373, 'Ibara', 230404);
insert into prod_order (id, cust_name, amount, city, pin_code) values (10, 'Farleigh', 6011, 'Kudang', 490371);
insert into prod_order (id, cust_name, amount, city, pin_code) values (11, 'Susannah', 3134, 'Patria', 530846);
insert into prod_order (id, cust_name, amount, city, pin_code) values (12, 'Raynor', 8097, 'Belene', 973861);
insert into prod_order (id, cust_name, amount, city, pin_code) values (13, 'Adina', 8323, 'Yalagüina', 603671);
insert into prod_order (id, cust_name, amount, city, pin_code) values (14, 'Georges', 5310, 'Konstantinovo', 688253);
insert into prod_order (id, cust_name, amount, city, pin_code) values (15, 'Cayla', 4355, 'Bagou', 647571);
insert into prod_order (id, cust_name, amount, city, pin_code) values (16, 'Rosmunda', 7558, 'Castelo', 505386);
insert into prod_order (id, cust_name, amount, city, pin_code) values (17, 'Bent', 2345, 'Bollnäs', 574943);
insert into prod_order (id, cust_name, amount, city, pin_code) values (18, 'Wilmette', 5153, 'Skövde', 389953);
insert into prod_order (id, cust_name, amount, city, pin_code) values (19, 'Jess', 9460, 'Giesteira', 575891);
insert into prod_order (id, cust_name, amount, city, pin_code) values (20, 'Lane', 6776, 'Pasadena', 377268);
insert into prod_order (id, cust_name, amount, city, pin_code) values (21, 'Kipp', 1951, 'Cerro Blanco', 387498);
insert into prod_order (id, cust_name, amount, city, pin_code) values (22, 'Edan', 1019, 'Belyayevka', 107065);
insert into prod_order (id, cust_name, amount, city, pin_code) values (23, 'Francklin', 4661, 'Gradačac', 586556);
insert into prod_order (id, cust_name, amount, city, pin_code) values (24, 'Orsola', 2969, 'Gurung', 468081);
insert into prod_order (id, cust_name, amount, city, pin_code) values (25, 'Jennee', 8855, 'Stupsk', 217960);

select * from prod_order;

create clustered index IX_product_order_customer_name on prod_order(cust_name ASC);

create nonclustered index NIX_product_order_city on prod_order(city, pin_code);

drop index NIX_product_order_city on prod_order;
drop index IX_product_order_customer_name on prod_order;

create table employee (
	id int primary key,
	name varchar(200),
	salary int,
	gender varchar(10),
	departId int
)

create table department (
	departId int primary key,
	deptName varchar(20)
)

insert into department values(1, 'IT'),
(2, 'Payroll'),
(3, 'HR'),
(4, 'Admin');

insert into employee values(1, 'Virat', 5000, 'Male', 1),
(2, 'Rohit', 6000, 'Male', 2),
(3, 'Pandaya', 7000, 'Male', 2),
(4, 'Kapil', 3000, 'Male', 4);

select * from department
select * from employee

select id, name, salary, deptName from employee join department on employee.departId = department.departId;

select id, name, deptName from employee join department on employee.departId = department.departId;

create view details
as
select id, name, deptName from employee join department on employee.departId = department.departId;

select * from details