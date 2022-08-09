use master 
go
create database prueba
go
use prueba
go

create table documento(
Id   char(5) primary key,
Estado bit not null,
Tipo   char(20) not null
)
create table empleado(
Id char(5) primary key,
Estado  bit not null,
Nombres varchar(80) not null,
Apellidos varchar(80) not null,
Tipo      char(5) references documento(Id),
Documento varchar(20) not null,
SalarioBase decimal(10,2) not null,
Ingreso   date not null,
Direccion varchar(Max)
)
--create table dias_libres(
--Id char(5) primary key,
--Estado bit not null,
--Empleado char(5) references empleado(Id),
--desde date not null,
--hasta date not null
--)
--create table vacaciones_acumuladas(
--Id char(5) primary key,
--Estado  bit not null,
--Empleado char(5) references empleado(Id) not null,
--Desde    date not null,
--Hasta    date not null,
--saldo    int not null
--)
--create table vacaciones_pagadas(
--Id char(5)primary key,
--Estado bit not null,
--IdVacaciones char(5) references vacaciones (Id),
--Dias float     not null,
--Monto decimal(10,2) not null,
--descripcion varchar(max)
--)
go
---------------------Procedimieto almacenado documento----------------
--------------------------------------Calculo de vacacions------------------------------------



Go
----------------------------------------------------------------------------------
create procedure sp_listar_documento

as 
begin 
	select * from documento where Estado = 1
end 
go
create procedure sp_listar_documento_id
@Id char(5)
as 
begin 
	select * from documento where Id = @Id and Estado = 1
end 
go
Create procedure sp_listar_documento_nombre
@Nombre char(20)
as 
begin
	select * from documento where Tipo = @Nombre and Estado = 1
end
go
create procedure sp_insertar_documento
@Estado bit,
@Tipo char(20)
as
begin
	Declare @Id char(5)
	set @Id = (Select MAX(Id) from documento)
	set @Id = 'D'+ RIGHT ('0000' + LTRIM(RIGHT(isNull(@Id,'0000'),4)+1),4)
	insert into documento (Id,Estado,Tipo) values(@Id,@Estado,@Tipo)
end
go
create procedure sp_actualizar_documento
@Id  char(5),
@Estado bit,
@Tipo char(20)
as
begin
	update documento set Estado= @Estado,Tipo=@Tipo 
	where Id = @Id 
end
go
create procedure sp_eliminar_documento
@Id  char(5)
as
begin
	update documento set Estado = 0
	where Id = @Id 
end
go
------------------------------Procedimiento almacenado-----------------------------
create procedure sp_listar_empleado
as
begin
 select * from empleado where Estado = 1
end
go
alter procedure sp_listar_empleado_id
@Id char(5)
as 
begin
	select e.Id,(e.Nombres + '  ' + e.Apellidos) as 'Nombre Completo',d.Tipo,e.Documento,e.Ingreso,e.SalarioBase,e.Direccion  from empleado as e inner join documento as d on d.Id = e.Tipo 
	where e.Id like '%'+@Id+'%' and e.Estado = 1
end
go
alter procedure sp_listar_empleado_documento
@documento varchar(20)
as
begin
	select e.Id,e.Nombres,e.Apellidos,e.Estado,d.Tipo,e.Documento,e.Ingreso,e.SalarioBase ,e.Direccion from documento as d inner join  empleado as e on e.Tipo = d.Id
	where d.Tipo like  '%'+@documento+'%' and e.Estado = 1
end
go
create procedure sp_insertar_empleado_documento
@Estado  bit  ,
@Nombres varchar(80)  ,
@Apellidos varchar(80)  ,
@Tipo      char(5)  ,
@Documento varchar(20)  ,
@SalarioBase decimal(10,2)  ,
@Ingreso   date  ,
@Direccion varchar(Max)
as
begin
declare @Id char(5)
	set @Id = (Select MAX(Id) from empleado)
	set @Id = 'E'+ RIGHT ('0000' + LTRIM(RIGHT(isNull(@Id,'0000'),4)+1),4)
	insert into empleado (Id,Estado,Nombres,Apellidos,Tipo,Documento,SalarioBase,Ingreso,Direccion) values(@Id,@Estado,@Nombres,@Apellidos,@Tipo,@Documento,@SalarioBase,@Ingreso,@Direccion)
end
go
create procedure  sp_actualizar_empleado
@Id    char(5),
@Estado  bit  ,
@Nombres varchar(80)  ,
@Apellidos varchar(80)  ,
@Tipo      char(5)  ,
@Documento varchar(20)  ,
@SalarioBase decimal(10,2)  ,
@Ingreso   date  ,
@Direccion varchar(Max)
as
begin
	update empleado set
	Estado = @Estado,
	Nombres = @Nombres,
	Apellidos = @Apellidos,
	Tipo    = @Tipo,
	Documento = @Documento,
	SalarioBase = @SalarioBase,
	Ingreso  = @Ingreso,
	Direccion = @Direccion
	Where Id = @Id and Estado = 1
end
go
create procedure sp_Eliminar_empleado_id
@Id char(5)
as
begin
	update empleado set Estado = 0
	where Id = @Id
end
go


------------------------------Anexo----------------------------------------
create procedure sp_llenar_cmb_documento_id
as
begin
	select Id from documento
end