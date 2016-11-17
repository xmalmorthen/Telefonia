/*
Navicat MySQL Data Transfer

Source Server         : geo@geo2016.ddns.net
Source Server Version : 50173
Source Host           : geo2016.ddns.net:3306
Source Database       : dbModems

Target Server Type    : MYSQL
Target Server Version : 50173
File Encoding         : 65001

Date: 2016-08-22 09:43:17
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for caModems
-- ----------------------------
DROP TABLE IF EXISTS `caModems`;
CREATE TABLE `caModems` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `modem` varchar(50) NOT NULL,
  `descrip` varchar(100) DEFAULT NULL,
  `interfaz` varchar(10) NOT NULL,
  `fins` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP,
  `active` bit(1) NOT NULL DEFAULT b'1',
  `status` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
