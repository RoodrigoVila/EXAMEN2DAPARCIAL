CREATE DATABASE EmpresaDB;
GO
drop DATABASE EmpresaDB;
USE EmpresaDB;
GO

create TABLE Trabajadores (
    id INT PRIMARY KEY IDENTITY(1,1) not null,
    nombre VARCHAR(100)not null,
    apellidos VARCHAR(100)not null,
    sueldob DECIMAL(10,2)not null,
    categoria CHAR(1)not null
);
