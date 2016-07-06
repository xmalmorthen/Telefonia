/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : dbgeoloc

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2016-07-06 13:52:40
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
INSERT INTO `caperfiles` VALUES ('3', 'ADMINISTRADOR GENERAL', '2016-05-31 13:56:12', '2016-06-15 09:59:58', '', '\0');
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of caroles
-- ----------------------------
INSERT INTO `caroles` VALUES ('3', 'Investigación', '', '2016-05-31 11:31:16', null, '', '\0', '2');
INSERT INTO `caroles` VALUES ('4', 'Configuraciones', '', '2016-05-31 11:31:44', null, '', '\0', '3');
INSERT INTO `caroles` VALUES ('5', 'Localización - Objetivos', '', '2016-05-31 11:32:11', null, '', '\0', '0-1');
INSERT INTO `caroles` VALUES ('6', 'Localización - PDU', '', '2016-05-31 11:32:26', null, '', '\0', '0-2');
INSERT INTO `caroles` VALUES ('7', 'Localización - SS7', '', '2016-05-31 11:32:41', null, '\0', '\0', '0-3');
INSERT INTO `caroles` VALUES ('8', 'Localización - SS7 - IMEI', '', '2016-05-31 11:33:00', null, '\0', '\0', '0-3-1');
INSERT INTO `caroles` VALUES ('9', 'Localización - SS7 - Localización', '', '2016-05-31 11:33:18', null, '\0', '\0', '0-3-2');
INSERT INTO `caroles` VALUES ('10', 'Localización - Recibidos', '', '2016-05-31 11:33:35', null, '\0', '\0', '0-4');
INSERT INTO `caroles` VALUES ('11', 'Localización - Seguimiento', '', '2016-05-31 11:33:44', null, '', '\0', '0-5');
INSERT INTO `caroles` VALUES ('12', 'Localización - Supervisión', '', '2016-05-31 11:34:09', null, '', '\0', '0-7');
INSERT INTO `caroles` VALUES ('13', 'Registros - Padrón', '', '2016-05-31 11:35:33', null, '', '\0', '1-1');
INSERT INTO `caroles` VALUES ('14', 'Registros - CFE', '', '2016-05-31 11:35:45', null, '', '\0', '1-2');
INSERT INTO `caroles` VALUES ('15', 'Registros - IMSS', '', '2016-05-31 11:35:55', null, '\0', '\0', '1-3');
INSERT INTO `caroles` VALUES ('16', 'Registros - RENAUT', '', '2016-05-31 11:36:07', null, '', '\0', '1-4');
INSERT INTO `caroles` VALUES ('17', 'Registros - TELMEX', '', '2016-05-31 11:36:17', null, '', '\0', '1-5');
INSERT INTO `caroles` VALUES ('18', 'Registros - TELCEL', '', '2016-05-31 11:36:29', null, '', '\0', '1-6');
INSERT INTO `caroles` VALUES ('19', 'Registros - NEXTEL', '', '2016-05-31 11:36:39', null, '', '\0', '1-7');
INSERT INTO `caroles` VALUES ('20', 'Localización - BTS', '', '2016-05-31 16:16:50', null, '', '\0', '0-6');
INSERT INTO `caroles` VALUES ('21', 'Localización', '', '2016-05-31 16:24:28', null, '', '\0', '0');
INSERT INTO `caroles` VALUES ('22', 'Registros', '', '2016-05-31 16:24:45', null, '', '\0', '1');
INSERT INTO `caroles` VALUES ('23', 'Registros - GLOBAL', '', '2016-06-15 09:59:11', null, '\0', '\0', '1-8');

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
  `idMaPDU` int(11) NOT NULL,
  `radio` varchar(50) DEFAULT NULL,
  `MCC` varchar(50) DEFAULT NULL,
  `MNC` varchar(50) DEFAULT NULL,
  `LAC` varchar(50) DEFAULT NULL,
  `BTS` varchar(50) DEFAULT NULL,
  `V` varchar(50) DEFAULT NULL,
  `LAT` double DEFAULT NULL,
  `LNG` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_desmsrecibidos_mapdu_1` (`idMaPDU`),
  CONSTRAINT `fk_desmsrecibidos_mapdu_1` FOREIGN KEY (`idMaPDU`) REFERENCES `mapdu` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of desmsrecibidos
-- ----------------------------
INSERT INTO `desmsrecibidos` VALUES ('35', '1', 'LTE', '334', '20', '4867', '16530689', '0', '19.2596532', '-103.6886847');
INSERT INTO `desmsrecibidos` VALUES ('36', '1', 'LTE', '334', '20', '4867', '16530690', '0', '19.256783199999997', '-103.69368929999999');
INSERT INTO `desmsrecibidos` VALUES ('37', '1', 'LTE', '334', '20', '4867', '16530691', '0', '19.261949299999998', '-103.69720380000001');
INSERT INTO `desmsrecibidos` VALUES ('38', '2', 'UMTS', '334', '20', '31019', '132338599', '0', '19.2422874', '-103.75812599999999');
INSERT INTO `desmsrecibidos` VALUES ('43', '5', 'GSM', '334', '20', '31044', '27125', '0', '32.5065756', '-116.94855009999999');
INSERT INTO `desmsrecibidos` VALUES ('44', '6', 'UMTS', '334', '20', '21042', '133862832', '0', '22.8889529', '-109.9155612');
INSERT INTO `desmsrecibidos` VALUES ('45', '7', 'UMTS', '334', '20', '31019', '132356856', '0', '19.2377716', '-103.7472676');

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
INSERT INTO `malocalizations` VALUES ('4', '7', 'NANIS', 'PRUEBA', '3121329762', '7', '1', null, null, null, '2016-06-30 10:30:25', null, '', '\0');

-- ----------------------------
-- Table structure for mapdu
-- ----------------------------
DROP TABLE IF EXISTS `mapdu`;
CREATE TABLE `mapdu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(100) DEFAULT NULL,
  `idLocalizations` int(11) NOT NULL,
  `fIns` datetime NOT NULL,
  `toNotify` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`),
  KEY `fk_mapdu_malocalizations_1` (`idLocalizations`),
  CONSTRAINT `fk_mapdu_malocalizations_1` FOREIGN KEY (`idLocalizations`) REFERENCES `malocalizations` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mapdu
-- ----------------------------
INSERT INTO `mapdu` VALUES ('1', 'GPS/IMEI', '3', '2016-06-30 00:00:00', '\0');
INSERT INTO `mapdu` VALUES ('2', 'GPS/IMEI', '4', '2016-06-30 00:00:00', '\0');
INSERT INTO `mapdu` VALUES ('5', 'GPS/IMEI', '3', '2016-07-04 12:00:00', '\0');
INSERT INTO `mapdu` VALUES ('6', 'GPS/IMEI', '3', '2016-07-04 00:00:00', '\0');
INSERT INTO `mapdu` VALUES ('7', 'GPS/IMEI', '3', '2016-07-04 00:00:00', '\0');
INSERT INTO `mapdu` VALUES ('8', 'GPS/IMEI', '3', '2016-07-04 00:00:00', '\0');
INSERT INTO `mapdu` VALUES ('9', 'GPS/IMEI', '3', '2016-07-04 00:00:00', '\0');

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
) ENGINE=InnoDB AUTO_INCREMENT=141 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reperfilroles
-- ----------------------------
INSERT INTO `reperfilroles` VALUES ('114', '4', '5', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('115', '4', '6', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('116', '4', '10', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('117', '4', '11', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('118', '4', '12', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('119', '4', '21', '2016-06-01 08:55:02');
INSERT INTO `reperfilroles` VALUES ('120', '3', '3', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('121', '3', '4', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('122', '3', '5', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('123', '3', '6', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('124', '3', '7', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('125', '3', '8', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('126', '3', '9', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('127', '3', '10', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('128', '3', '11', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('129', '3', '12', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('130', '3', '13', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('131', '3', '14', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('132', '3', '15', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('133', '3', '16', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('134', '3', '17', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('135', '3', '18', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('136', '3', '19', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('137', '3', '20', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('138', '3', '21', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('139', '3', '22', '2016-06-15 09:59:58');
INSERT INTO `reperfilroles` VALUES ('140', '3', '23', '2016-06-15 09:59:58');

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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tbllogs
-- ----------------------------
INSERT INTO `tbllogs` VALUES ('1', 'Error', 'Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 189.163.228.237:22', 'System.Net.Sockets.SocketException (0x80004005): Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 189.163.228.237:22\r\n   en System.Net.Sockets.Socket.EndConnect(IAsyncResult asyncResult)\r\n   en Renci.SshNet.Session.SocketConnect(String host, Int32 port)\r\n   en Renci.SshNet.Session.Connect()\r\n   en Renci.SshNet.BaseClient.Connect()\r\n   en CellTrack.Classes.sshCnn..ctor(String user, String pass, String host) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 68\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 65\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-29 08:55:58');
INSERT INTO `tbllogs` VALUES ('2', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 65\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-29 10:02:36');
INSERT INTO `tbllogs` VALUES ('3', 'Error', 'El índice (basado en cero) debe ser mayor o igual a cero y menor que el tamaño de la lista de argumentos.', 'System.FormatException: El índice (basado en cero) debe ser mayor o igual a cero y menor que el tamaño de la lista de argumentos.\r\n   en System.Text.StringBuilder.AppendFormatHelper(IFormatProvider provider, String format, ParamsArray args)\r\n   en System.String.FormatHelper(IFormatProvider provider, String format, ParamsArray args)\r\n   en System.String.Format(String format, Object arg0)\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 46', '2016-06-29 10:04:19');
INSERT INTO `tbllogs` VALUES ('4', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 67\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-29 12:45:16');
INSERT INTO `tbllogs` VALUES ('5', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 67\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-29 14:25:36');
INSERT INTO `tbllogs` VALUES ('6', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 67\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-30 09:55:38');
INSERT INTO `tbllogs` VALUES ('7', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 67\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-06-30 09:55:57');
INSERT INTO `tbllogs` VALUES ('8', 'Error', 'No se pudo geolocalizar por medio del api de google [ CellId: 13231718439672, LAC: 31019, MCC: 334, MNC: 20 ], mensaje recibido del API: Formato mal construido.', 'System.NullReferenceException: No se pudo geolocalizar por medio del api de google [ CellId: 13231718439672, LAC: 31019, MCC: 334, MNC: 20 ], mensaje recibido del API: Formato mal construido.\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 144', '2016-06-30 10:37:42');
INSERT INTO `tbllogs` VALUES ('9', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 127\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 163', '2016-06-30 10:47:32');
INSERT INTO `tbllogs` VALUES ('10', 'Error', 'Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.', 'System.InvalidOperationException: Operación no válida a través de subprocesos: Se tuvo acceso al control \'\' desde un subproceso distinto a aquel en que lo creó.\r\n   en System.Windows.Forms.Control.get_Handle()\r\n   en System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)\r\n   en System.Windows.Forms.Control.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.Refresh()\r\n   en GMap.NET.WindowsForms.GMapControl.ForceUpdateOverlays()\r\n   en GMap.NET.WindowsForms.GMapControl.set_Position(PointLatLng value)\r\n   en CellTrack.Controllers.gMapController.setPosition(markersModel mark, Nullable`1 zoom) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\gMapController.cs:línea 127\r\n   en CellTrack.Controllers.PDUController.PDUFind(PDUModel item, gMapController controller, Boolean onlyCheckSMS) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Controllers\\PDUController.cs:línea 196', '2016-07-04 09:33:30');
INSERT INTO `tbllogs` VALUES ('11', 'Error', 'Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 187.192.141.32:22', 'System.Net.Sockets.SocketException (0x80004005): Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 187.192.141.32:22\r\n   en System.Net.Sockets.Socket.EndConnect(IAsyncResult asyncResult)\r\n   en Renci.SshNet.Session.SocketConnect(String host, Int32 port)\r\n   en Renci.SshNet.Session.Connect()\r\n   en Renci.SshNet.BaseClient.Connect()\r\n   en CellTrack.Classes.sshCnn..ctor(String user, String pass, String host) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 68\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 68\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-07-04 16:03:14');
INSERT INTO `tbllogs` VALUES ('12', 'Error', 'Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 187.192.141.32:22', 'System.Net.Sockets.SocketException (0x80004005): Se produjo un error durante el intento de conexión ya que la parte conectada no respondió adecuadamente tras un periodo de tiempo, o bien se produjo un error en la conexión establecida ya que el host conectado no ha podido responder 187.192.141.32:22\r\n   en System.Net.Sockets.Socket.EndConnect(IAsyncResult asyncResult)\r\n   en Renci.SshNet.Session.SocketConnect(String host, Int32 port)\r\n   en Renci.SshNet.Session.Connect()\r\n   en Renci.SshNet.BaseClient.Connect()\r\n   en CellTrack.Classes.sshCnn..ctor(String user, String pass, String host) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Classes\\sshCnn.cs:línea 68\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 68\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-07-04 16:03:14');
INSERT INTO `tbllogs` VALUES ('13', 'Error', 'Referencia a objeto no establecida como instancia de un objeto.', 'System.NullReferenceException: Referencia a objeto no establecida como instancia de un objeto.\r\n   en System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)\r\n   en System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)\r\n   en CellTrack.Views.frmSshCnn.wrker_DoWork(Object sender, DoWorkEventArgs e) en d:\\Proyectos\\visual_studio\\c#\\Telefonia\\CellTrack\\Views\\frmSshCnn.cs:línea 68\r\n   en System.ComponentModel.BackgroundWorker.OnDoWork(DoWorkEventArgs e)\r\n   en System.ComponentModel.BackgroundWorker.WorkerThreadStart(Object argument)', '2016-07-04 16:07:37');

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
