create database tarea
use tarea;
create table Lolin(
usuario varchar(50)  primary key ,
contraseña varchar (50)not null,
roll varchar (50)not null,
);
drop table Lolin;

insert into Lolin values ('jose','123','Cliente'); 
inseRt into Lolin values ('lusi','456','secretaria'); 
inseRt into Lolin values ('cris','789','Administrador'); 

SELECT *FROM Lolin; 


create table administrador(
id int primary key,
nombre varchar(50) not null,
correo varchar (50)not null,
pais varchar(50)not null,
ocupacion varchar(100)not null,
);

insert into administrador values (1,'Cristopher','cristopher2006@gmail.com','Guatemala','Ingeniero en sistema'); 

SELECT *FROM administrador;