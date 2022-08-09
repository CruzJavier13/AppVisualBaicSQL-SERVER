use prueba
go
create table dias_libres(
Id char(5) primary key,
Estado bit not null,
Empleado char(5) references empleado(Id),
desde date not null,
hasta date not null
)
create table vacaciones_acumuladas(
Id char(5) primary key,
Estado  bit not null,
Empleado char(5) references empleado(Id) ,
Desde    date not null,
Hasta    date not null,
saldo    float not null
)
create table vacaciones(
Id char(5)primary key,
Estado bit not null,
IdVacaciones char(5) references vacaciones_acumuladas(Id),
Dias float     not null,
Monto decimal(10,2) not null,
descripcion varchar(max)
)
go

----------------------------------------------------------------------------
go
alter procedure sp_guardar_pago_vacacion_generado
@id char(5),
@idvacaciones char(5),
@dias  float,
@monto decimal(10,2),
@descripcion varchar(max)
as
begin
	update vacaciones_acumuladas set Estado = 0 where Id = @idvacaciones
	declare @empleado char(5) = (select Empleado from vacaciones_acumuladas where Id = @idvacaciones)
	update dias_libres set Estado = 0  where  Empleado = @empleado
	insert into vacaciones values(@id,1,@idvacaciones,@dias,@monto,@descripcion)
	
end
select * from dias_libres
go
create procedure sp_generar_pago_vacaciones
@IdVacaciones char(5)
as
begin
	Declare @Id char(5), @nueva float, @dias float, @Monto decimal(10,2)
	set @Id = (Select MAX(Id) from vacaciones)
	set @Id = 'P'+ RIGHT ('0000' + LTRIM(RIGHT(isNull(@Id,'0000'),4)+1),4)
	set @dias = (select saldo from vacaciones_acumuladas  where Id = @IdVacaciones and Estado = 1) * 30
	set @Monto = (@dias / 30) * 2.5

select @Id as Id,1 as Estado,@IdVacaciones as IdVacacion,@dias as Dias,@Monto  as 'Dias a Pagar'
end
----------------------------------------------------------------------------------------------
go
create procedure sp_buscar_vacaciones_a_pagar
as
begin
select * from vacaciones_acumuladas where Estado = 1
end
go
go
create procedure sp_buscar_vacaciones_sin_pagar
@Empleado char(5)
as
begin
select * from vacaciones_acumuladas where Empleado = @Empleado and Estado = 1
end
go

ALTER procedure sp_generar_vacacion
@IdEmpleado char(5),
@desde date,
@hasta  date
as
begin
	Declare @Id char(5), @nueva float
	set @Id = (Select MAX(Id) from vacaciones_acumuladas)
	set @Id = 'A'+ RIGHT ('0000' + LTRIM(RIGHT(isNull(@Id,'0000'),4)+1),4)
	declare @dias float, @diaslibres float
	
	
	if @desde >= (select MAX(Hasta) from vacaciones_acumuladas where Empleado = @IdEmpleado and Estado = 1)begin

		set @diaslibres = (select SUM(DATEDIFF(MONTH,desde,hasta)) DiaLibre from dias_libres where Empleado = @IdEmpleado and Estado = 0)
		set @desde = (select MAX(hasta) from vacaciones_acumuladas where Empleado = @IdEmpleado and Estado = 1)
		set @dias = DATEDIFF(MONTH,@desde,@hasta)
		set @nueva = @dias - @diaslibres
	end
	if (select MAX(Hasta) from vacaciones_acumuladas where Empleado = @IdEmpleado and Estado = 1) is null  begin
		set @diaslibres = (select SUM(DATEDIFF(MONTH,desde,hasta)) DiaLibre from dias_libres where Empleado = @IdEmpleado and Estado = 1)
		set @desde = (select Ingreso Ingreso from empleado where Id =@IdEmpleado)
		set @dias = DATEDIFF(MONTH,@desde,@hasta) 
		set @nueva = (@dias - @diaslibres)
	end
	
	select @Id as Id,1 as Estado,@IdEmpleado as Empleado,@desde as Desde,@hasta as Hasta,@nueva as Saldo
end
go 
create procedure sp_guardar_vacaciones
@Id char(5),
@Empleado  char(5),
@desde  date,
@hasta  date,
@saldo float
as
begin
insert into vacaciones_acumuladas (Id,Estado,Empleado,Desde,Hasta,saldo) values (@Id,1,@Empleado,@desde,@hasta,@saldo)
end
------------------------------------------------------
go
go
create procedure sp_insertar_dia_libre
@empleado  char(5)  ,
@desde     date  ,
@hasta	   date  
as
begin
	Declare @Id char(5)
	set @Id = (Select MAX(Id) from dias_libres)
	set @Id = 'L'+ RIGHT ('0000' + LTRIM(RIGHT(isNull(@Id,'0000'),4)+1),4)
	insert into dias_libres(Id,Estado, Empleado,desde,hasta) values(@Id,1,@empleado,@desde,@hasta)
end
go
create procedure sp_actualizar_lia_libre
@Id        char(5),
@empleado  char(5),
@desde     date  ,
@hasta	   date  
as
begin
update dias_libres set Empleado = @empleado, desde = @desde, hasta = @hasta
where Id = @Id and Estado = 1
end
Go
create procedure sp_listar_codigo_vacaiones
@Id char(5)
as 
begin
select Empleado,desde,hasta from dias_libres where Id = @Id and Estado = 1
end
Go
create procedure sp_encontrar_empleado
@Id char(5)
as
begin
select * from empleado
where Id = @Id and Estado = 1
end
go
create procedure sp_encontrar_vacacion_a_modificar
@Id char(5)
as
begin
select empleado,desde,hasta from dias_libres
where Id = @id and Estado = 1
end