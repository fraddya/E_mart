CREATE TABLE Employee(
Emp_ID int IDENTITY (1,1),
Emp_Name varchar(30),
Emp_address varchar(30), 
Emp_TP int,
Emp_DOB date,
Emp_NIC char(15),
Emp_Email varchar(20),
Reg_Date date,
PRIMARY KEY(Emp_ID),

);
drop table Employee;

