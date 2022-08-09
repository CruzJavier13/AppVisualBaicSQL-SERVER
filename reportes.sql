use prueba
go
alter  procedure sp_infor_report
@idEmpleado char(5)
as
begin
select Nombres,Apellidos, d.Tipo, Documento, Ingreso, SalarioBase,Direccion from empleado inner join documento as d on empleado.Tipo = d.Id where empleado.Id = @idEmpleado
end
go
alter  procedure sp_infor_report_full
as
begin
select Nombres,Apellidos, d.Tipo, Documento, Ingreso, SalarioBase,Direccion from empleado inner join documento as d on empleado.Tipo = d.Id 
end
go
exec sp_infor_report 'E0003'
go
select * from dias_libres
go
create procedure sp_listar_dias_libres
AS 
begin
	select * from dias_libres 
end
go
ALTER procedure sp_listar_dias_libres_id
@id char(5)
AS 
begin
	select * from dias_libres  where Empleado = @id
end