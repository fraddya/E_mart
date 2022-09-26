drop table Client;

CREATE TABLE Client(
Client_ID int IDENTITY (1,1),
Client_Name varchar(30),
Client_address varchar(30), 
Client_TP int,
Client_NIC char(15),
Client_Email varchar(20)
PRIMARY KEY(Client_ID)
);