drop table Client;

CREATE TABLE Client(
Client_ID int IDENTITY (1,1),
Client_Name varchar(30),
Client_address varchar(30), 
Client_TP int,     
/*dob*/
Client_NIC char(15),
Client_Email varchar(20)
PRIMARY KEY(Client_ID)
);

CREATE TABLE Employee(
Emp_ID int IDENTITY (1,1),
Emp_Name varchar(30)l
Emp_address varchar(30), 
Emp_TP int,
Emp_DOB date,
Emp_NIC char(15),
Emp_Email varchar(20),
Reg_Date date,
PRIMARY KEY(Client_ID),

);
