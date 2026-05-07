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


INSERT INTO Ventas (id_venta, fecha) VALUES (8, '2026-05-02 14:20:00');
INSERT INTO Ventas (id_venta, fecha) VALUES (9, '2026-05-03 09:15:00');
INSERT INTO Ventas (id_venta, fecha) VALUES (10, '2026-05-04 18:45:00');
INSERT INTO Ventas (id_venta, fecha) VALUES (11, '2026-05-05 11:00:00');
INSERT INTO Ventas (id_venta, fecha) VALUES (12, '2026-05-06 16:30:00');

-- Ventas del Ticket 7
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (7, 2, 'Cuaderno Espiral', 5, 2.50);
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (7, 5, 'Lapicero Negro', 10, 0.50);

-- Ventas del Ticket 8
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (8, 10, 'Diccionario Larousse', 2, 15.00);
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (8, 15, 'Resaltadores Pack', 4, 3.75);


-- Ventas del Ticket 10
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (10, 30, 'Calculadora Científica', 1, 12.00);
INSERT INTO Detalle_Venta (id_venta, id_producto, nombre_producto, cantidad, precio) VALUES (10, 2, 'Cuaderno Espiral', 1, 2.50);
