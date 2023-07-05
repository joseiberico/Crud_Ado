Create database DBCRUDADO
use DBCRUDADO

Create table Contacto(
IdContacto int identity primary key,
Nombre varchar(50),
Telefono varchar(50),
Correo varchar(50)
)
go

Create procedure sp_Listar
as
begin
	select * from Contacto
end
go

Create procedure sp_Obtener
@IdContacto int
as
begin
	select * from Contacto where IdContacto = @IdContacto
end
go

Create procedure sp_Guardar
@Nombre varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
as
begin
	insert into Contacto (Nombre,Telefono,Correo) values (@Nombre,@Telefono,@Correo)
end
go

Create procedure sp_Editar
@IdContacto int,
@Nombre varchar(100),
@Telefono varchar(100),
@Correo varchar(100)
as
begin
	update Contacto set Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo
	where IdContacto = @IdContacto
end
go

Create procedure sp_Eliminar
@IdContacto int
as
begin
	delete from Contacto where IdContacto = @IdContacto
end
go

insert into Contacto values('Carlitos','4634592','carlitos.x_x@hotmail.com')