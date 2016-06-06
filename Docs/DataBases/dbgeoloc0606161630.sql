/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : dbgeoloc

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2016-06-06 16:30:35
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
  `fIns` datetime NOT NULL,
  `fAct` datetime DEFAULT NULL,
  `active` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cacarriers
-- ----------------------------
INSERT INTO `cacarriers` VALUES ('1', 'TELCEL', null, '2016-05-26 09:36:31', null, '');
INSERT INTO `cacarriers` VALUES ('2', 'IUSACELL', null, '2016-05-26 09:36:51', null, '');
INSERT INTO `cacarriers` VALUES ('3', 'MOVISTAR', null, '2016-05-26 09:37:26', null, '');
INSERT INTO `cacarriers` VALUES ('4', 'NEXTEL', null, '2016-05-26 09:37:36', null, '');

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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cagrupos
-- ----------------------------
INSERT INTO `cagrupos` VALUES ('7', 'ASD', 'asd', '2016-05-30 15:32:25', '2016-05-31 13:57:29', '', '');
INSERT INTO `cagrupos` VALUES ('8', 'QWE', 'qwe', '2016-05-30 15:32:41', '2016-05-31 13:57:33', '', '');
INSERT INTO `cagrupos` VALUES ('9', 'ZXC', 'zxc', '2016-05-30 15:32:48', '2016-05-30 15:33:07', '', '');
INSERT INTO `cagrupos` VALUES ('10', 'QAZ', null, '2016-05-30 15:33:54', '2016-05-31 13:57:35', '', '');
INSERT INTO `cagrupos` VALUES ('11', 'ZXC', null, '2016-05-30 15:37:40', '2016-05-31 13:57:36', '', '');
INSERT INTO `cagrupos` VALUES ('12', '123', null, '2016-05-30 15:37:53', '2016-05-31 13:57:38', '', '');
INSERT INTO `cagrupos` VALUES ('13', 'ADMINISTRADORES', 'Grupo principal de administradores', '2016-05-31 13:57:58', null, '', '\0');
INSERT INTO `cagrupos` VALUES ('14', 'LOCALIZACIONES', 'Grupo para localizaciones', '2016-05-31 13:59:13', '2016-06-01 14:06:00', '', '\0');

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
  `isDeleted` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of caperfiles
-- ----------------------------
INSERT INTO `caperfiles` VALUES ('3', 'ADMINISTRADOR GENERAL', '2016-05-31 13:56:12', '2016-06-01 08:52:24', '', '\0');
INSERT INTO `caperfiles` VALUES ('4', 'LOCALIZACIÓN', '2016-05-31 13:56:50', '2016-06-01 08:55:02', '', '\0');

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
  `activo` bit(1) NOT NULL DEFAULT b'1',
  `isDeleted` bit(1) NOT NULL DEFAULT b'0',
  `tag` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of caroles
-- ----------------------------
INSERT INTO `caroles` VALUES ('3', 'Investigación', '', '2016-05-31 11:31:16', null, '', '\0', '2');
INSERT INTO `caroles` VALUES ('4', 'Configuraciones', '', '2016-05-31 11:31:44', null, '', '\0', '3');
INSERT INTO `caroles` VALUES ('5', 'Localización - Objetivos', '', '2016-05-31 11:32:11', null, '', '\0', '0-1');
INSERT INTO `caroles` VALUES ('6', 'Localización - PDU', '', '2016-05-31 11:32:26', null, '', '\0', '0-2');
INSERT INTO `caroles` VALUES ('7', 'Localización - SS7', '', '2016-05-31 11:32:41', null, '', '\0', '0-3');
INSERT INTO `caroles` VALUES ('8', 'Localización - SS7 - IMEI', '', '2016-05-31 11:33:00', null, '', '\0', '0-3-1');
INSERT INTO `caroles` VALUES ('9', 'Localización - SS7 - Localización', '', '2016-05-31 11:33:18', null, '', '\0', '0-3-2');
INSERT INTO `caroles` VALUES ('10', 'Localización - Recibidos', '', '2016-05-31 11:33:35', null, '', '\0', '0-4');
INSERT INTO `caroles` VALUES ('11', 'Localización - Seguimiento', '', '2016-05-31 11:33:44', null, '', '\0', '0-5');
INSERT INTO `caroles` VALUES ('12', 'Localización - Supervisión', '', '2016-05-31 11:34:09', null, '', '\0', '0-7');
INSERT INTO `caroles` VALUES ('13', 'Registros - Padrón', '', '2016-05-31 11:35:33', null, '', '\0', '1-1');
INSERT INTO `caroles` VALUES ('14', 'Registros - CFE', '', '2016-05-31 11:35:45', null, '', '\0', '1-2');
INSERT INTO `caroles` VALUES ('15', 'Registros - IMSS', '', '2016-05-31 11:35:55', null, '', '\0', '1-3');
INSERT INTO `caroles` VALUES ('16', 'Registros - RENAUT', '', '2016-05-31 11:36:07', null, '', '\0', '1-4');
INSERT INTO `caroles` VALUES ('17', 'Registros - TELMEX', '', '2016-05-31 11:36:17', null, '', '\0', '1-5');
INSERT INTO `caroles` VALUES ('18', 'Registros - TELCEL', '', '2016-05-31 11:36:29', null, '', '\0', '1-6');
INSERT INTO `caroles` VALUES ('19', 'Registros - NEXTEL', '', '2016-05-31 11:36:39', null, '', '\0', '1-7');
INSERT INTO `caroles` VALUES ('20', 'Localización - BTS', '', '2016-05-31 16:16:50', null, '', '\0', '0-6');
INSERT INTO `caroles` VALUES ('21', 'Localización', '', '2016-05-31 16:24:28', null, '', '\0', '0');
INSERT INTO `caroles` VALUES ('22', 'Registros', '', '2016-05-31 16:24:45', null, '', '\0', '1');

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of causuarios
-- ----------------------------
INSERT INTO `causuarios` VALUES ('7', 'MORTHEN', null, 'XMAL', 'xmalmorthen', '910abaa54f4819fd86599517d6d326b8', null, '', '2016-05-31 13:58:12', null, '13', '', '3', '\0');
INSERT INTO `causuarios` VALUES ('8', 'LOCALIZACIÓN', null, 'USUARIO', 'localiza', '202cb962ac59075b964b07152d234b70', '100', '', '2016-05-31 13:59:25', '2016-06-02 15:59:46', '13', '\0', '4', '\0');

-- ----------------------------
-- Table structure for desmsrecibidos
-- ----------------------------
DROP TABLE IF EXISTS `desmsrecibidos`;
CREATE TABLE `desmsrecibidos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `radio` varchar(50) DEFAULT NULL,
  `MCC` varchar(50) DEFAULT NULL,
  `MNC` varchar(50) DEFAULT NULL,
  `LAC` varchar(50) DEFAULT NULL,
  `BTS` varchar(50) DEFAULT NULL,
  `V` varchar(50) DEFAULT NULL,
  `LAT` double DEFAULT NULL,
  `LNG` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of desmsrecibidos
-- ----------------------------
INSERT INTO `desmsrecibidos` VALUES ('3', 'LTE', '334', '20', '5146', '9135', '0', '20.675159', '-103.35884');
INSERT INTO `desmsrecibidos` VALUES ('4', 'LTE', '334', '20', '5146', '9135', '0', '20.61041251', '-103.280945331');
INSERT INTO `desmsrecibidos` VALUES ('5', 'LTE', '334', '20', '5146', '9135', '0', '20.616525717000002', '-103.310856649');
INSERT INTO `desmsrecibidos` VALUES ('6', 'LTE', '334', '20', '5146', '9135', '0', '20.583513598', '-103.270477622');
INSERT INTO `desmsrecibidos` VALUES ('7', 'LTE', '334', '20', '5146', '9135', '0', '20.527534111', '-103.330717935');
INSERT INTO `desmsrecibidos` VALUES ('8', 'LTE', '334', '20', '5146', '9135', '0', '20.619230273', '-103.295451716');
INSERT INTO `desmsrecibidos` VALUES ('9', 'LTE', '334', '20', '5146', '9135', '0', '20.565360086', '-103.229975061');
INSERT INTO `desmsrecibidos` VALUES ('10', 'LTE', '334', '20', '5146', '9135', '0', '20.581696106', '-103.303195769');
INSERT INTO `desmsrecibidos` VALUES ('11', 'LTE', '334', '20', '5146', '9135', '0', '20.59472915', '-103.308763192');
INSERT INTO `desmsrecibidos` VALUES ('12', 'LTE', '334', '20', '5146', '9135', '0', '20.53434278', '-103.273776007');
INSERT INTO `desmsrecibidos` VALUES ('13', 'LTE', '334', '20', '5146', '9135', '0', '20.561886439', '-103.259743675');
INSERT INTO `desmsrecibidos` VALUES ('14', 'LTE', '334', '20', '5146', '9135', '0', '20.623470755', '-103.237117837');
INSERT INTO `desmsrecibidos` VALUES ('15', 'LTE', '334', '20', '5146', '9135', '0', '20.546112363', '-103.246983535');
INSERT INTO `desmsrecibidos` VALUES ('16', 'LTE', '334', '20', '5146', '9135', '0', '20.547623088', '-103.253449508');
INSERT INTO `desmsrecibidos` VALUES ('17', 'LTE', '334', '20', '5146', '9135', '0', '20.563344118', '-103.246373971');
INSERT INTO `desmsrecibidos` VALUES ('18', 'LTE', '334', '20', '5146', '9135', '0', '20.523538938', '-103.231506103');
INSERT INTO `desmsrecibidos` VALUES ('19', 'LTE', '334', '20', '5146', '9135', '0', '20.518448085', '-103.227443198');

-- ----------------------------
-- Table structure for gmapnetcache
-- ----------------------------
DROP TABLE IF EXISTS `gmapnetcache`;
CREATE TABLE `gmapnetcache` (
  `Type` int(10) NOT NULL,
  `Zoom` int(10) NOT NULL,
  `X` int(10) NOT NULL,
  `Y` int(10) NOT NULL,
  `Tile` longblob NOT NULL,
  PRIMARY KEY (`Type`,`Zoom`,`X`,`Y`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of gmapnetcache
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
  `isDeleted` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  KEY `fk_maLocalizations_cacarriers_1` (`idCarrier`),
  KEY `fk_malocalizations_causuarios_1` (`idNotification`),
  KEY `fk_malocalizations_causuarios_2` (`idUser`),
  CONSTRAINT `fk_maLocalizations_cacarriers_1` FOREIGN KEY (`idCarrier`) REFERENCES `cacarriers` (`id`),
  CONSTRAINT `fk_malocalizations_causuarios_1` FOREIGN KEY (`idNotification`) REFERENCES `causuarios` (`id`),
  CONSTRAINT `fk_malocalizations_causuarios_2` FOREIGN KEY (`idUser`) REFERENCES `causuarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of malocalizations
-- ----------------------------
INSERT INTO `malocalizations` VALUES ('3', '7', 'XMAL MORTHEN', 'PRUEBA', '3121220995', '7', '1', '2', '11', '5', '2016-06-02 14:27:41', '2016-06-02 14:50:04', '', '\0');

-- ----------------------------
-- Table structure for mapdu
-- ----------------------------
DROP TABLE IF EXISTS `mapdu`;
CREATE TABLE `mapdu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(100) DEFAULT NULL,
  `idDetalle` int(11) NOT NULL,
  `idLocalizations` int(11) NOT NULL,
  `fIns` date NOT NULL,
  `toNotify` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  KEY `fk_maPDU_desmsrecibidos_1` (`idDetalle`),
  KEY `fk_mapdu_malocalizations_1` (`idLocalizations`),
  CONSTRAINT `fk_maPDU_desmsrecibidos_1` FOREIGN KEY (`idDetalle`) REFERENCES `desmsrecibidos` (`id`),
  CONSTRAINT `fk_mapdu_malocalizations_1` FOREIGN KEY (`idLocalizations`) REFERENCES `malocalizations` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mapdu
-- ----------------------------
INSERT INTO `mapdu` VALUES ('1', 'GPS/IMEI', '3', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('2', 'GPS/IMEI', '4', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('3', 'GPS/IMEI', '5', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('4', 'GPS/IMEI', '6', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('5', 'GPS/IMEI', '7', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('6', 'GPS/IMEI', '8', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('7', 'GPS/IMEI', '9', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('8', 'GPS/IMEI', '10', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('9', 'GPS/IMEI', '11', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('10', 'GPS/IMEI', '12', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('11', 'GPS/IMEI', '13', '3', '2016-06-06', '\0');
INSERT INTO `mapdu` VALUES ('12', 'GPS/IMEI', '14', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('13', 'GPS/IMEI', '15', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('14', 'GPS/IMEI', '16', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('15', 'GPS/IMEI', '17', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('16', 'GPS/IMEI', '18', '3', '2016-06-06', '');
INSERT INTO `mapdu` VALUES ('17', 'GPS/IMEI', '19', '3', '2016-06-06', '\0');

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
) ENGINE=InnoDB AUTO_INCREMENT=120 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reperfilroles
-- ----------------------------
INSERT INTO `reperfilroles` VALUES ('94', '3', '3', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('95', '3', '4', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('96', '3', '5', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('97', '3', '6', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('98', '3', '7', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('99', '3', '8', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('100', '3', '9', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('101', '3', '10', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('102', '3', '11', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('103', '3', '12', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('104', '3', '13', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('105', '3', '14', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('106', '3', '15', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('107', '3', '16', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('108', '3', '17', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('109', '3', '18', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('110', '3', '19', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('111', '3', '20', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('112', '3', '21', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('113', '3', '22', '2016-06-01 08:52:24');
INSERT INTO `reperfilroles` VALUES ('114', '4', '5', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('115', '4', '6', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('116', '4', '10', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('117', '4', '11', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('118', '4', '12', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('119', '4', '21', '2016-06-01 08:55:02');

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
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbllogs
-- ----------------------------
INSERT INTO `tbllogs` VALUES ('58', 'Error', 'Validation failed for one or more entities. See \'EntityValidationErrors\' property for more details.', 'System.Data.Entity.Validation.DbEntityValidationException: Validation failed for one or more entities. See \'EntityValidationErrors\' property for more details.\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   en System.Data.Entity.Internal.LazyInternalContext.SaveChanges()\r\n   en System.Data.Entity.DbContext.SaveChanges()\r\n   en CellTrack.Controllers.objetivosController.insertNewTarget(localizationsModel target) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 39', '2016-05-27 13:03:00');
INSERT INTO `tbllogs` VALUES ('59', 'Error', 'No se encontró el registro [ 1 | de57d58f-1d97-472d-8ab0-0855e90d8265 | TELCEL | cab6468c-0 ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | de57d58f-1d97-472d-8ab0-0855e90d8265 | TELCEL | cab6468c-0 ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.editNewTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 57', '2016-05-27 14:03:09');
INSERT INTO `tbllogs` VALUES ('60', 'Error', 'No se encontró el registro [ 1 | 19d6da75-4786-4997-8c81-49a01c87d877 | TELCEL | 5266c905-d ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | 19d6da75-4786-4997-8c81-49a01c87d877 | TELCEL | 5266c905-d ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.deleteTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 85', '2016-05-27 14:09:58');
INSERT INTO `tbllogs` VALUES ('61', 'Error', 'No se encontró el registro [ 1 | 07a82e9f-1aae-4727-9fe8-fad37bae7d5a | TELCEL | 8fe04765-6 ], es posible que se haya eliminado desde otra instancia', 'System.NullReferenceException: No se encontró el registro [ 1 | 07a82e9f-1aae-4727-9fe8-fad37bae7d5a | TELCEL | 8fe04765-6 ], es posible que se haya eliminado desde otra instancia\r\n   en CellTrack.Controllers.objetivosController.deleteTarget(localizationsModel Item) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 85', '2016-05-27 14:11:00');
INSERT INTO `tbllogs` VALUES ('62', 'Error', 'An error occurred while updating the entries. See the inner exception for details.', 'System.Data.Entity.Infrastructure.DbUpdateException: An error occurred while updating the entries. See the inner exception for details. ---> System.Data.Entity.Core.UpdateException: An error occurred while updating the entries. See the inner exception for details. ---> MySql.Data.MySqlClient.MySqlException: Cannot add or update a child row: a foreign key constraint fails (\"dbgeoloc\".\"causuarios\", CONSTRAINT \"fk_causuarios_caperfiles_1\" FOREIGN KEY (\"idPerfil\") REFERENCES \"caperfiles\" (\"id\"))\r\n   en MySql.Data.MySqlClient.MySqlStream.ReadPacket()\r\n   en MySql.Data.MySqlClient.NativeDriver.GetResult(Int32& affectedRow, Int64& insertedId)\r\n   en MySql.Data.MySqlClient.Driver.GetResult(Int32 statementId, Int32& affectedRows, Int64& insertedId)\r\n   en MySql.Data.MySqlClient.Driver.NextResult(Int32 statementId, Boolean force)\r\n   en MySql.Data.MySqlClient.MySqlDataReader.NextResult()\r\n   en MySql.Data.MySqlClient.MySqlCommand.ExecuteReader(CommandBehavior behavior)\r\n   en MySql.Data.Entity.EFMySqlCommand.ExecuteDbDataReader(CommandBehavior behavior)\r\n   en System.Data.Common.DbCommand.ExecuteReader(CommandBehavior behavior)\r\n   en System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.<>c__DisplayClassb.<Reader>b__8()\r\n   en System.Data.Entity.Infrastructure.Interception.InternalDispatcher`1.Dispatch[TInterceptionContext,TResult](Func`1 operation, TInterceptionContext interceptionContext, Action`1 executing, Action`1 executed)\r\n   en System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.Reader(DbCommand command, DbCommandInterceptionContext interceptionContext)\r\n   en System.Data.Entity.Internal.InterceptableDbCommand.ExecuteDbDataReader(CommandBehavior behavior)\r\n   en System.Data.Common.DbCommand.ExecuteReader(CommandBehavior behavior)\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.Execute(Dictionary`2 identifierValues, List`1 generatedValues)\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.Update()\r\n   --- Fin del seguimiento de la pila de la excepción interna ---\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.Update()\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.<Update>b__2(UpdateTranslator ut)\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.Update[T](T noChangesResult, Func`2 updateFunction, Boolean throwOnClosedConnection)\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.Update(Boolean throwOnClosedConnection)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.<SaveChangesToStore>b__33()\r\n   en System.Data.Entity.Core.Objects.ObjectContext.ExecuteInTransaction[T](Func`1 func, IDbExecutionStrategy executionStrategy, Boolean startLocalTransaction, Boolean releaseConnectionOnSuccess)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.SaveChangesToStore(SaveOptions options, IDbExecutionStrategy executionStrategy)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass28.<SaveChanges>b__25()\r\n   en System.Data.Entity.Infrastructure.DefaultExecutionStrategy.Execute[TResult](Func`1 operation)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.SaveChanges(SaveOptions options)\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   --- Fin del seguimiento de la pila de la excepción interna ---\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   en System.Data.Entity.Internal.LazyInternalContext.SaveChanges()\r\n   en System.Data.Entity.DbContext.SaveChanges()\r\n   en CellTrack.Controllers.usuarioController.insertNewUser(causuarios newItem) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\usuarioController.cs:línea 70', '2016-05-30 13:11:35');
INSERT INTO `tbllogs` VALUES ('63', 'Error', 'An error occurred while updating the entries. See the inner exception for details.', 'System.Data.Entity.Infrastructure.DbUpdateException: An error occurred while updating the entries. See the inner exception for details. ---> System.Data.Entity.Core.UpdateException: An error occurred while updating the entries. See the inner exception for details. ---> MySql.Data.MySqlClient.MySqlException: Cannot add or update a child row: a foreign key constraint fails (\"dbgeoloc\".\"malocalizations\", CONSTRAINT \"fk_malocalizations_causuarios_1\" FOREIGN KEY (\"idNotification\") REFERENCES \"causuarios\" (\"id\"))\r\n   en MySql.Data.MySqlClient.MySqlStream.ReadPacket()\r\n   en MySql.Data.MySqlClient.NativeDriver.GetResult(Int32& affectedRow, Int64& insertedId)\r\n   en MySql.Data.MySqlClient.Driver.GetResult(Int32 statementId, Int32& affectedRows, Int64& insertedId)\r\n   en MySql.Data.MySqlClient.Driver.NextResult(Int32 statementId, Boolean force)\r\n   en MySql.Data.MySqlClient.MySqlDataReader.NextResult()\r\n   en MySql.Data.MySqlClient.MySqlCommand.ExecuteReader(CommandBehavior behavior)\r\n   en MySql.Data.Entity.EFMySqlCommand.ExecuteDbDataReader(CommandBehavior behavior)\r\n   en System.Data.Common.DbCommand.ExecuteReader(CommandBehavior behavior)\r\n   en System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.<>c__DisplayClassb.<Reader>b__8()\r\n   en System.Data.Entity.Infrastructure.Interception.InternalDispatcher`1.Dispatch[TInterceptionContext,TResult](Func`1 operation, TInterceptionContext interceptionContext, Action`1 executing, Action`1 executed)\r\n   en System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.Reader(DbCommand command, DbCommandInterceptionContext interceptionContext)\r\n   en System.Data.Entity.Internal.InterceptableDbCommand.ExecuteDbDataReader(CommandBehavior behavior)\r\n   en System.Data.Common.DbCommand.ExecuteReader(CommandBehavior behavior)\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.Execute(Dictionary`2 identifierValues, List`1 generatedValues)\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.Update()\r\n   --- Fin del seguimiento de la pila de la excepción interna ---\r\n   en System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator.Update()\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.<Update>b__2(UpdateTranslator ut)\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.Update[T](T noChangesResult, Func`2 updateFunction, Boolean throwOnClosedConnection)\r\n   en System.Data.Entity.Core.EntityClient.Internal.EntityAdapter.Update(Boolean throwOnClosedConnection)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.<SaveChangesToStore>b__33()\r\n   en System.Data.Entity.Core.Objects.ObjectContext.ExecuteInTransaction[T](Func`1 func, IDbExecutionStrategy executionStrategy, Boolean startLocalTransaction, Boolean releaseConnectionOnSuccess)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.SaveChangesToStore(SaveOptions options, IDbExecutionStrategy executionStrategy)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass28.<SaveChanges>b__25()\r\n   en System.Data.Entity.Infrastructure.DefaultExecutionStrategy.Execute[TResult](Func`1 operation)\r\n   en System.Data.Entity.Core.Objects.ObjectContext.SaveChanges(SaveOptions options)\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   --- Fin del seguimiento de la pila de la excepción interna ---\r\n   en System.Data.Entity.Internal.InternalContext.SaveChanges()\r\n   en System.Data.Entity.Internal.LazyInternalContext.SaveChanges()\r\n   en System.Data.Entity.DbContext.SaveChanges()\r\n   en CellTrack.Controllers.objetivosController.insertNewTarget(localizationsModel target) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\objetivosController.cs:línea 44', '2016-06-02 14:23:16');
INSERT INTO `tbllogs` VALUES ('64', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en CellTrack.Controllers.PDUController.PDUFind(localizationsModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 18', '2016-06-03 10:33:19');
INSERT INTO `tbllogs` VALUES ('65', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en CellTrack.Controllers.recibidosController.setMarker(recibidosModel recibidosModel, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\recibidosController.cs:línea 59', '2016-06-03 16:17:54');
INSERT INTO `tbllogs` VALUES ('66', 'Error', 'sudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: 3 intentos de contraseña incorrectos\n', 'System.Exception: sudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: sin tty presente y no hay programa askpass especificado\nSorry, try again.\nsudo: 3 intentos de contraseña incorrectos\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 73', '2016-06-06 13:56:39');
INSERT INTO `tbllogs` VALUES ('67', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 14:54:09');
INSERT INTO `tbllogs` VALUES ('68', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 14:55:36');
INSERT INTO `tbllogs` VALUES ('69', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 14:57:03');
INSERT INTO `tbllogs` VALUES ('70', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 14:57:48');
INSERT INTO `tbllogs` VALUES ('71', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:12:02');
INSERT INTO `tbllogs` VALUES ('72', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:13:05');
INSERT INTO `tbllogs` VALUES ('73', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:14:38');
INSERT INTO `tbllogs` VALUES ('74', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:15:27');
INSERT INTO `tbllogs` VALUES ('75', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:17:12');
INSERT INTO `tbllogs` VALUES ('76', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:17:22');
INSERT INTO `tbllogs` VALUES ('77', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 118\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 61', '2016-06-06 15:18:44');
INSERT INTO `tbllogs` VALUES ('78', 'Error', 'sudo: sorry, you must have a tty to run sudo\n', 'System.Exception: sudo: sorry, you must have a tty to run sudo\n\r\n   en CellTrack.Classes.sshCnn.execute(String command) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 67\r\n   en CellTrack.Controllers.PDUController.sshCmds.PDU(PDUModel item, String& message) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 84', '2016-06-06 15:21:17');
INSERT INTO `tbllogs` VALUES ('79', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 118\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 65', '2016-06-06 15:23:49');
INSERT INTO `tbllogs` VALUES ('80', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 118\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 65', '2016-06-06 15:27:25');
INSERT INTO `tbllogs` VALUES ('81', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 118\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 68', '2016-06-06 15:41:11');
INSERT INTO `tbllogs` VALUES ('82', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 118\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 68', '2016-06-06 15:43:58');

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
causuarios.id,
causuarios.idGpo,
CONCAT_WS(' ',causuarios.PrimerApellido,causuarios.SegundoApellido,causuarios.Nombres, CONCAT('  -  [ ',causuarios.usuario,' ]')) as usuario
FROM
causuarios
INNER JOIN caperfiles ON causuarios.idPerfil = caperfiles.id
INNER JOIN reperfilroles ON reperfilroles.idPerfil = caperfiles.id
INNER JOIN caroles ON reperfilroles.idRol = caroles.id
WHERE
causuarios.active = true AND
caperfiles.activo = true AND
causuarios.isDeleted = false AND
caperfiles.isDeleted = false
GROUP BY
causuarios.id ;
