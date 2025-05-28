create database Usuarios;
go

use Usuarios
go

create table Roles (
    IdRol int primary key identity(1,1),
    NombreRol nvarchar(50) NOT NULL UNIQUE
);
go
create table Usuarios (
    IdUsuario int primary key identity(1,1),
    Nombre nvarchar(100) NOT NULL,
    Correo nvarchar(100) NOT NULL UNIQUE,
    Clave nvarchar(100) NOT NULL,
    IdRol int NOT NULL,
    foreign key (IdRol) references Roles(IdRol)
);
go

insert into Roles (NombreRol) values ('Administrador'), ('Usuario');
go

insert into Usuarios (Nombre, Correo, Clave, IdRol)
values ('Juan Pérez', 'juan@mail.com', '1234', 1),-- Admin
('Laura Torres', 'laura@mail.com', 'A1B2', 1),
('Carlos Gómez', 'carlos@mail.com', 'abcd', 2), --Usuario normal
('Ana Ríos', 'ana@mail.com', 'pass123', 2),
('María López', 'maria@mail.com', 'hola2025', 2),
('José Ramírez', 'jose@mail.com', 'test456', 2);
go

create view Usuarios_roles
as
select r.NombreRol,U.* from Usuarios as U
join Roles as r on  U.IdRol  = r.IdRol


go


