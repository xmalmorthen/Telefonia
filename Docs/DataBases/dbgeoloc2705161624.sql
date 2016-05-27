/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : dbgeoloc

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2016-05-27 16:24:23
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
-- Records of cacarriers
-- ----------------------------
INSERT INTO `cacarriers` VALUES ('1', 'TELCEL', null, '2016-05-26 09:36:31', '0000-00-00 00:00:00', '');
INSERT INTO `cacarriers` VALUES ('2', 'IUSACELL', null, '2016-05-26 09:36:51', '0000-00-00 00:00:00', '');
INSERT INTO `cacarriers` VALUES ('3', 'MOVISTAR', null, '2016-05-26 09:37:26', '0000-00-00 00:00:00', '');
INSERT INTO `cacarriers` VALUES ('4', 'NEXTEL', null, '2016-05-26 09:37:36', '0000-00-00 00:00:00', '');

-- ----------------------------
-- Table structure for caperfiles
-- ----------------------------
DROP TABLE IF EXISTS `caperfiles`;
CREATE TABLE `caperfiles` (
  `id` int(11) NOT NULL,
  `perfil` varchar(50) DEFAULT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of caperfiles
-- ----------------------------

-- ----------------------------
-- Table structure for caroles
-- ----------------------------
DROP TABLE IF EXISTS `caroles`;
CREATE TABLE `caroles` (
  `id` int(11) NOT NULL,
  `rol` varchar(50) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of caroles
-- ----------------------------

-- ----------------------------
-- Table structure for causuarios
-- ----------------------------
DROP TABLE IF EXISTS `causuarios`;
CREATE TABLE `causuarios` (
  `id` int(11) NOT NULL,
  `PrimerApellido` varchar(50) NOT NULL,
  `SegundoApellido` varchar(50) DEFAULT NULL,
  `Nombres` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasenia` varchar(200) NOT NULL,
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `active` bit(1) DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of causuarios
-- ----------------------------

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
-- Records of malocalizations
-- ----------------------------

-- ----------------------------
-- Table structure for reperfilroles
-- ----------------------------
DROP TABLE IF EXISTS `reperfilroles`;
CREATE TABLE `reperfilroles` (
  `id` int(11) NOT NULL,
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
-- Records of reperfilroles
-- ----------------------------

-- ----------------------------
-- Table structure for reusuariosperfil
-- ----------------------------
DROP TABLE IF EXISTS `reusuariosperfil`;
CREATE TABLE `reusuariosperfil` (
  `id` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  `idPerfil` int(11) NOT NULL,
  `fIns` datetime NOT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  KEY `fk_reusuariosperfil_caperfiles_1` (`idPerfil`),
  KEY `fk_reusuariosperfil_causuarios_1` (`idusuario`),
  CONSTRAINT `fk_reusuariosperfil_caperfiles_1` FOREIGN KEY (`idPerfil`) REFERENCES `caperfiles` (`id`),
  CONSTRAINT `fk_reusuariosperfil_causuarios_1` FOREIGN KEY (`idusuario`) REFERENCES `causuarios` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reusuariosperfil
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbllogs
-- ----------------------------
INSERT INTO `tbllogs` VALUES ('58', 'Error', 'Validation failed for one or more entities. See \'EntityValidationErrors\' property for more details.', 'System.Data.Entity.Validation.DbEntityValidationException: Validation failed for one or more entities. See \'EntityValidationErrors\' property for more details.\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   en System.Data.Entity.Internal.LazyInternalContext.SaveChanges()\r\n   en System.Data.Entity.DbContext.SaveChanges()\r\n   en CellTrack.Controllers.objetivosController.insertNewTarget(localizationsModel target) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 39', '2016-05-27 13:03:00');
INSERT INTO `tbllogs` VALUES ('59', 'Error', 'No se encontró el registro [ 1 | de57d58f-1d97-472d-8ab0-0855e90d8265 | TELCEL | cab6468c-0 ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | de57d58f-1d97-472d-8ab0-0855e90d8265 | TELCEL | cab6468c-0 ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.editNewTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 57', '2016-05-27 14:03:09');
INSERT INTO `tbllogs` VALUES ('60', 'Error', 'No se encontró el registro [ 1 | 19d6da75-4786-4997-8c81-49a01c87d877 | TELCEL | 5266c905-d ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | 19d6da75-4786-4997-8c81-49a01c87d877 | TELCEL | 5266c905-d ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.deleteTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 85', '2016-05-27 14:09:58');
INSERT INTO `tbllogs` VALUES ('61', 'Error', 'No se encontró el registro [ 1 | 07a82e9f-1aae-4727-9fe8-fad37bae7d5a | TELCEL | 8fe04765-6 ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | 07a82e9f-1aae-4727-9fe8-fad37bae7d5a | TELCEL | 8fe04765-6 ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.deleteTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 85', '2016-05-27 14:11:00');

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
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER  VIEW `vwusernotifications` AS SELECT causuarios.id,
causuarios.PrimerApellido + ' ' + causuarios.SegundoApellido + ' ' + causuarios.Nombres + ' ' + '[ ' + causuarios.usuario + ' ]' as Usuario
FROM
causuarios
INNER JOIN reusuariosperfil ON reusuariosperfil.idusuario = causuarios.id
INNER JOIN caperfiles ON reusuariosperfil.idPerfil = caperfiles.id
INNER JOIN reperfilroles ON reperfilroles.idPerfil = caperfiles.id
INNER JOIN caroles ON reperfilroles.idRol = caroles.id
WHERE
causuarios.active = true AND
reusuariosperfil.activo = true
GROUP BY
causuarios.id ;
