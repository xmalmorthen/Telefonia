/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : dbgeoloc

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2016-05-30 16:29:55
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for cacarriers
-- ----------------------------
DROP TABLE IF EXISTS `cacarriers`;
CREATE TABLE `cacarriers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `carrier` varchar(50) NOT NULL,
  `descrip` varchar(200) DEFAULT NULL,
  `fIns` datetime DEFAULT NULL,
  `fAct` datetime NOT NULL,
  `active` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for cagrupos
-- ----------------------------
DROP TABLE IF EXISTS `cagrupos`;
CREATE TABLE `cagrupos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `grupo` varchar(50) NOT NULL,
  `descrip` varchar(200) DEFAULT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  `isDeleted` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for caperfiles
-- ----------------------------
DROP TABLE IF EXISTS `caperfiles`;
CREATE TABLE `caperfiles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `perfil` varchar(50) NOT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for caroles
-- ----------------------------
DROP TABLE IF EXISTS `caroles`;
CREATE TABLE `caroles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rol` varchar(50) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for causuarios
-- ----------------------------
DROP TABLE IF EXISTS `causuarios`;
CREATE TABLE `causuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `PrimerApellido` varchar(50) NOT NULL,
  `SegundoApellido` varchar(50) DEFAULT NULL,
  `Nombres` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasenia` varchar(200) NOT NULL,
  `cantidadLocalizaciones` int(11) DEFAULT NULL,
  `active` bit(1) NOT NULL DEFAULT b'1',
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `idGpo` int(11) NOT NULL,
  `esSupervisor` bit(1) NOT NULL DEFAULT b'0',
  `idPerfil` int(11) NOT NULL,
  `isDeleted` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  KEY `fk_causuarios_caGrupos_1` (`idGpo`),
  KEY `fk_causuarios_caperfiles_1` (`idPerfil`),
  CONSTRAINT `fk_causuarios_caGrupos_1` FOREIGN KEY (`idGpo`) REFERENCES `cagrupos` (`id`),
  CONSTRAINT `fk_causuarios_caperfiles_1` FOREIGN KEY (`idPerfil`) REFERENCES `caperfiles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for malocalizations
-- ----------------------------
DROP TABLE IF EXISTS `malocalizations`;
CREATE TABLE `malocalizations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idUser` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `asunto` varchar(100) NOT NULL,
  `objetivo` varchar(10) NOT NULL,
  `idNotification` int(11) NOT NULL,
  `idCarrier` int(11) NOT NULL,
  `agendaDe` smallint(1) DEFAULT NULL,
  `agendaA` smallint(1) DEFAULT NULL,
  `agendaFrecuencia` smallint(1) DEFAULT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `active` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  KEY `fk_maLocalizations_cacarriers_1` (`idCarrier`),
  KEY `fk_malocalizations_causuarios_1` (`idNotification`),
  KEY `fk_malocalizations_causuarios_2` (`idUser`),
  CONSTRAINT `fk_maLocalizations_cacarriers_1` FOREIGN KEY (`idCarrier`) REFERENCES `cacarriers` (`id`),
  CONSTRAINT `fk_malocalizations_causuarios_1` FOREIGN KEY (`idNotification`) REFERENCES `causuarios` (`id`),
  CONSTRAINT `fk_malocalizations_causuarios_2` FOREIGN KEY (`idUser`) REFERENCES `causuarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for reperfilroles
-- ----------------------------
DROP TABLE IF EXISTS `reperfilroles`;
CREATE TABLE `reperfilroles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idPerfil` int(11) NOT NULL,
  `idRol` int(11) NOT NULL,
  `fIns` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_rePerfilRoles_caPerfiles_1` (`idPerfil`),
  KEY `fk_rePerfilRoles_caRoles_1` (`idRol`),
  CONSTRAINT `fk_rePerfilRoles_caPerfiles_1` FOREIGN KEY (`idPerfil`) REFERENCES `caperfiles` (`id`),
  CONSTRAINT `fk_rePerfilRoles_caRoles_1` FOREIGN KEY (`idRol`) REFERENCES `caroles` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbllogs
-- ----------------------------
DROP TABLE IF EXISTS `tbllogs`;
CREATE TABLE `tbllogs` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Level` varchar(100) DEFAULT NULL,
  `Message` text,
  `Exception` text,
  `DateTime` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;

-- ----------------------------
-- View structure for vwactivecarriers
-- ----------------------------
DROP VIEW IF EXISTS `vwactivecarriers`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost`  VIEW `vwactivecarriers` AS SELECT
cacarriers.id,
cacarriers.carrier
FROM
cacarriers
WHERE
cacarriers.active = true ;

-- ----------------------------
-- View structure for vwusernotifications
-- ----------------------------
DROP VIEW IF EXISTS `vwusernotifications`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER  VIEW `vwusernotifications` AS SELECT
causuarios.PrimerApellido + ' ' + causuarios.SegundoApellido + ' ' + causuarios.Nombres + ' ' + '[ ' + causuarios.usuario + ' ]' AS Usuario,
causuarios.id,
causuarios.idGpo
FROM
causuarios
INNER JOIN caperfiles ON causuarios.idPerfil = caperfiles.id
INNER JOIN reperfilroles ON reperfilroles.idPerfil = caperfiles.id
INNER JOIN caroles ON reperfilroles.idRol = caroles.id
WHERE
causuarios.active = true AND
caperfiles.activo = true
GROUP BY
causuarios.id ;
