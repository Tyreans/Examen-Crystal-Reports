-- Eliminar la base de datos almacen si existe
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'almacen')
BEGIN
    DROP DATABASE almacen;
END
GO

-- Crear la base de datos almacen
CREATE DATABASE almacen;
GO

-- Usar la base de datos almacen
USE almacen;
GO

-- Crear la tabla Productos con NombreProducto como PRIMARY KEY
CREATE TABLE Productos (
    NombreProducto VARCHAR(100) NOT NULL PRIMARY KEY,
    Cantidad INT NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Descripcion VARCHAR(255) NOT NULL
);
GO

-- Insertar 2 registros en la tabla Productos
INSERT INTO Productos (NombreProducto, Cantidad, Precio, Descripcion)
VALUES ('Audífonos', 50, 199.99, 'Audífonos inalámbricos');

INSERT INTO Productos (NombreProducto, Cantidad, Precio, Descripcion)
VALUES ('Teclado', 20, 999.50, 'Teclado mecánico retroiluminado');
GO