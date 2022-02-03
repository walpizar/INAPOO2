
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2022 09:24:34
-- Generated from EDMX file: C:\Users\walpi\Desktop\POO\POOINA\CapaDatos\dbPOOModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbPOO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tbEstudiantes_tbPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbEstudiantes] DROP CONSTRAINT [FK_tbEstudiantes_tbPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_tbProductos_tbCategorias]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbProductos] DROP CONSTRAINT [FK_tbProductos_tbCategorias];
GO
IF OBJECT_ID(N'[dbo].[FK_tbProductos_tbImpuestos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbProductos] DROP CONSTRAINT [FK_tbProductos_tbImpuestos];
GO
IF OBJECT_ID(N'[dbo].[FK_tbProductos_tbProveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbProductos] DROP CONSTRAINT [FK_tbProductos_tbProveedores];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tbCategorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbCategorias];
GO
IF OBJECT_ID(N'[dbo].[tbEstudiantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbEstudiantes];
GO
IF OBJECT_ID(N'[dbo].[tbImpuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbImpuestos];
GO
IF OBJECT_ID(N'[dbo].[tbPersona]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbPersona];
GO
IF OBJECT_ID(N'[dbo].[tbProductos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbProductos];
GO
IF OBJECT_ID(N'[dbo].[tbProveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbProveedores];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tbCategorias'
CREATE TABLE [dbo].[tbCategorias] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(50)  NULL
);
GO

-- Creating table 'tbEstudiantes'
CREATE TABLE [dbo].[tbEstudiantes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [carnet] nchar(10)  NULL,
    [grupo] int  NULL,
    [idPersona] int  NULL,
    [horario] nchar(500)  NULL,
    [estado] bit  NULL
);
GO

-- Creating table 'tbImpuestos'
CREATE TABLE [dbo].[tbImpuestos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(50)  NULL,
    [valor] int  NULL
);
GO

-- Creating table 'tbPersona'
CREATE TABLE [dbo].[tbPersona] (
    [id] int  NOT NULL,
    [identificacion] nchar(30)  NOT NULL,
    [tipoId] nchar(10)  NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [apellido1] nchar(30)  NULL,
    [apellido2] nchar(30)  NULL
);
GO

-- Creating table 'tbProductos'
CREATE TABLE [dbo].[tbProductos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [codigo] nchar(30)  NOT NULL,
    [nombre] nchar(30)  NOT NULL,
    [precioCosto] decimal(18,2)  NOT NULL,
    [utilidad] decimal(18,2)  NOT NULL,
    [idImpuesto] int  NOT NULL,
    [precioVenta] decimal(18,2)  NOT NULL,
    [idCategoria] int  NOT NULL,
    [idProveedor] nchar(50)  NOT NULL,
    [estado] bit  NOT NULL
);
GO

-- Creating table 'tbProveedores'
CREATE TABLE [dbo].[tbProveedores] (
    [id] nchar(50)  NOT NULL,
    [nombre] nchar(50)  NOT NULL,
    [apellido1] nchar(50)  NOT NULL,
    [apellido2] nchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'tbCategorias'
ALTER TABLE [dbo].[tbCategorias]
ADD CONSTRAINT [PK_tbCategorias]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbEstudiantes'
ALTER TABLE [dbo].[tbEstudiantes]
ADD CONSTRAINT [PK_tbEstudiantes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbImpuestos'
ALTER TABLE [dbo].[tbImpuestos]
ADD CONSTRAINT [PK_tbImpuestos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbPersona'
ALTER TABLE [dbo].[tbPersona]
ADD CONSTRAINT [PK_tbPersona]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbProductos'
ALTER TABLE [dbo].[tbProductos]
ADD CONSTRAINT [PK_tbProductos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tbProveedores'
ALTER TABLE [dbo].[tbProveedores]
ADD CONSTRAINT [PK_tbProveedores]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idCategoria] in table 'tbProductos'
ALTER TABLE [dbo].[tbProductos]
ADD CONSTRAINT [FK_tbProductos_tbCategorias]
    FOREIGN KEY ([idCategoria])
    REFERENCES [dbo].[tbCategorias]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbProductos_tbCategorias'
CREATE INDEX [IX_FK_tbProductos_tbCategorias]
ON [dbo].[tbProductos]
    ([idCategoria]);
GO

-- Creating foreign key on [idPersona] in table 'tbEstudiantes'
ALTER TABLE [dbo].[tbEstudiantes]
ADD CONSTRAINT [FK_tbEstudiantes_tbPersona]
    FOREIGN KEY ([idPersona])
    REFERENCES [dbo].[tbPersona]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbEstudiantes_tbPersona'
CREATE INDEX [IX_FK_tbEstudiantes_tbPersona]
ON [dbo].[tbEstudiantes]
    ([idPersona]);
GO

-- Creating foreign key on [idImpuesto] in table 'tbProductos'
ALTER TABLE [dbo].[tbProductos]
ADD CONSTRAINT [FK_tbProductos_tbImpuestos]
    FOREIGN KEY ([idImpuesto])
    REFERENCES [dbo].[tbImpuestos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbProductos_tbImpuestos'
CREATE INDEX [IX_FK_tbProductos_tbImpuestos]
ON [dbo].[tbProductos]
    ([idImpuesto]);
GO

-- Creating foreign key on [idProveedor] in table 'tbProductos'
ALTER TABLE [dbo].[tbProductos]
ADD CONSTRAINT [FK_tbProductos_tbProveedores]
    FOREIGN KEY ([idProveedor])
    REFERENCES [dbo].[tbProveedores]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbProductos_tbProveedores'
CREATE INDEX [IX_FK_tbProductos_tbProveedores]
ON [dbo].[tbProductos]
    ([idProveedor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------