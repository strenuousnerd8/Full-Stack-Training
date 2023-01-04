 /*
 create table student (name varchar(200), age int, gender varchar(10));
 */

 select * from student

 insert into student (name, age, gender) values('Divya', 23, 'F'), ('Ajay', 23, 'M'), ('Anil', 23, 'M'), ('Raj', 23, 'M');

 insert into student (name, age) values('Akshata', 34), ('Nishant', 30), ('Birjesh', 37), ('Varsha', 25);

 select * from student where gender = 'M';

UPDATE student
SET gender = 'F'
WHERE gender is NULL;

DELETE student
WHERE gender = 'F';

/*
create table student2 (fname varchar(30) unique, age int, email varchar(30));
*/

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

/*
update student_info
set mobile_no = 'Not your number'
where mobile_no is null;
*/

alter table student_info drop column mobile_no;

exec sp_help student_info

alter table student_info alter column mobile_no varchar(20);

/*

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

*/

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

