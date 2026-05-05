-- 1. Asegurémonos de tener al menos un par de proveedores más
INSERT INTO Proveedores (nombre_proveedor, telefono_proveedor) VALUES 
('Distribuidora El Éxito', '2255-0011'),
('Librería Nacional', '2100-4455'),
('Papelería Central', '2525-8899');

INSERT INTO Productos (nombre_producto, descripcion_producto, id_proveedor) VALUES 
('Cuaderno Espiral', '100 hojas rayadas', 1),
('Pack Bolígrafos Blue', 'Caja de 12 unidades', 2),
('Resma de Papel Bond', '500 hojas tamaño carta', 1),
('Sacapuntas Eléctrico', 'Uso rinde alto', 3),
('Calculadora Científica', '240 funciones', 2),
('Set de Geometría', 'Piezas de metal', 1),
('Mochila Escolar', 'Impermeable color azul', 3),
('Diccionario Español', 'Edición 2024', 2),
('Marcadores Permanentes', 'Set de 8 colores', 1),
('Engrapadora de Metal', 'Capacidad 25 hojas', 3),
('Cinta Adhesiva', 'Transparente 40 yardas', 1),
('Carpeta de Argollas', 'Capacidad 2 pulgadas', 2);

INSERT INTO Inventario (id_producto, stock_producto, precio_producto) VALUES 
(4, 100, 1.50),
(5, 50, 4.00),
(6, 200, 5.50),
(7, 20, 15.00),
(8, 30, 12.00),
(9, 60, 3.50),
(10, 15, 25.00),
(11, 25, 8.00),
(12, 45, 6.00),
(13, 40, 10.00),
(14, 100, 0.75),
(15, 80, 2.25);