-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-07-2025 a las 00:34:33
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistemafacturacionparcial2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `identificacion` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `nombre`, `email`, `telefono`, `identificacion`) VALUES
(2, 'Luis Huallco', 'Luishuallco2005@gmail.com', '0995455151', '1816164684'),
(3, 'Pedro Sanchez', 'Pepe1959@gmail.com', '095151216', '9895582454'),
(4, 'Juan Carlos', 'Carlos2004@gmail.com', '0986124736', '1598763215'),
(5, 'Santiago Mora', 'Santi450p@Gmail.com', '0945352184', '1896325741'),
(6, 'Maria Pereia', 'Tere1980@hotmail.coom', '0945151512', '1462632514'),
(7, 'Patricio Zambrano', 'Pato22@gmail.com', '09453219862', '1518151562'),
(8, 'Consumidor Final', '', '', '000.000.000.000');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(150) NOT NULL,
  `precio_compra` decimal(10,2) DEFAULT NULL,
  `precio_venta` decimal(10,2) DEFAULT NULL,
  `codigo` varchar(50) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `fecha_compra` date DEFAULT NULL,
  `estado` enum('Activo','Inactivo') DEFAULT 'Activo'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `descripcion`, `precio_compra`, `precio_venta`, `codigo`, `stock`, `fecha_compra`, `estado`) VALUES
(1, 'Atun Real x3', 2.17, 2.25, '1234', 23, '2025-07-16', 'Inactivo'),
(2, 'Azucar 1k', 0.85, 1.00, '1803', 18, '2025-07-16', 'Activo'),
(3, 'Gelatina fresa 400g', 2.00, 2.25, '9678', 9, '2025-07-16', 'Activo'),
(4, 'Aceite Palma de Oro 900ml', 1.70, 1.90, '9959', 24, '2025-07-16', 'Activo'),
(5, 'Cris Sal 2K', 0.70, 0.85, '95762', 31, '2025-07-16', 'Activo'),
(6, 'Cubeta de Huevos', 3.10, 3.50, '95462', 50, '2025-07-16', 'Activo'),
(7, 'Fideo 1Lb', 0.50, 0.60, '45391', 36, '2025-07-16', 'Activo'),
(8, 'Mayonesa Girason ', 0.90, 1.00, '6594', 25, '2025-07-16', 'Activo'),
(9, 'Mermelada Fresa 140ml', 1.30, 1.45, '6384', 34, '2025-07-16', 'Activo'),
(10, 'Galleta Oreo 89g', 0.90, 1.00, '345659', 58, '2025-07-16', 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(11) NOT NULL,
  `producto_id` int(11) DEFAULT NULL,
  `cliente_id` int(11) DEFAULT NULL,
  `fecha_venta` date DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio_total` decimal(10,2) DEFAULT NULL,
  `factura_venta` varchar(20) DEFAULT NULL,
  `estado` enum('Activa','Anulada') DEFAULT 'Activa'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id`, `producto_id`, `cliente_id`, `fecha_venta`, `cantidad`, `precio_total`, `factura_venta`, `estado`) VALUES
(2, 1, 3, '2025-07-16', 2, 4.50, 'FACT-776aba', 'Activa'),
(3, 3, 2, '2025-07-16', 6, 13.50, 'FACT-ca3336', 'Activa'),
(4, 5, 2, '2025-07-16', 5, 4.25, 'FACT-be5d81', 'Activa');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `producto_id` (`producto_id`),
  ADD KEY `cliente_id` (`cliente_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`),
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
