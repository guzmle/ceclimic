/*
Navicat MySQL Data Transfer

Source Server         : Clickland
Source Server Version : 50510
Source Host           : localhost:3306
Source Database       : ceclimi

Target Server Type    : MYSQL
Target Server Version : 50510
File Encoding         : 65001

Date: 2012-02-24 12:27:18
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cirugia`
-- ----------------------------
DROP TABLE IF EXISTS `cirugia`;
CREATE TABLE `cirugia` (
  `CI_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CI_NOMBRE` varchar(100) NOT NULL,
  `CI_DESCRIPCION` varchar(200) DEFAULT NULL,
  `CI_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`CI_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cirugia
-- ----------------------------
INSERT INTO `cirugia` VALUES ('1', 'Protesis Mamaria', null, '1');
INSERT INTO `cirugia` VALUES ('2', 'Protesis Mamaria + Pexia', null, '1');
INSERT INTO `cirugia` VALUES ('3', 'Liposuccion Simple', null, '1');
INSERT INTO `cirugia` VALUES ('4', 'Liposuccion abdomen, muslos, brazos o pacientes obesas', null, '1');
INSERT INTO `cirugia` VALUES ('5', 'Dermolipectomia', null, '1');
INSERT INTO `cirugia` VALUES ('6', 'Mamoplastia reductora', null, '1');
INSERT INTO `cirugia` VALUES ('7', 'Blefaroplastia Parpados Superiores', null, '1');
INSERT INTO `cirugia` VALUES ('8', 'Lipoescueltura Minima', '', '1');
INSERT INTO `cirugia` VALUES ('9', 'Lipoescultura Intermedia', '', '1');
INSERT INTO `cirugia` VALUES ('10', 'Lipoescultura extensa', '', '1');
INSERT INTO `cirugia` VALUES ('11', 'Minidermolipectomia', '', '1');
INSERT INTO `cirugia` VALUES ('12', 'Dermolipectomia', '', '1');
INSERT INTO `cirugia` VALUES ('13', 'Mamoplastia de aumento', '', '1');
INSERT INTO `cirugia` VALUES ('14', 'Pexia Mamaria', '', '1');
INSERT INTO `cirugia` VALUES ('15', 'Lipoinyeccion Glutea opcion 2', '', '1');
INSERT INTO `cirugia` VALUES ('16', 'Protesis + peaxia pa + vertical', '', '1');

-- ----------------------------
-- Table structure for `cirugia_cirujano`
-- ----------------------------
DROP TABLE IF EXISTS `cirugia_cirujano`;
CREATE TABLE `cirugia_cirujano` (
  `CC_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CC_HONORARIOS` float(12,2) DEFAULT NULL,
  `CC_FK_CIRUJANO` bigint(20) NOT NULL,
  `CC_FK_CIRUGIA` bigint(20) NOT NULL,
  `CC_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`CC_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cirugia_cirujano
-- ----------------------------
INSERT INTO `cirugia_cirujano` VALUES ('1', '2164.30', '1', '1', '1');
INSERT INTO `cirugia_cirujano` VALUES ('2', '3026.80', '1', '2', '1');
INSERT INTO `cirugia_cirujano` VALUES ('3', '2595.55', '1', '3', '1');
INSERT INTO `cirugia_cirujano` VALUES ('4', '3934.84', '1', '4', '1');
INSERT INTO `cirugia_cirujano` VALUES ('5', '3026.80', '1', '5', '1');
INSERT INTO `cirugia_cirujano` VALUES ('6', '3450.00', '1', '6', '1');
INSERT INTO `cirugia_cirujano` VALUES ('7', '2173.50', '1', '7', '1');
INSERT INTO `cirugia_cirujano` VALUES ('8', '2043.55', '2', '8', '1');
INSERT INTO `cirugia_cirujano` VALUES ('9', '3270.60', '2', '9', '1');
INSERT INTO `cirugia_cirujano` VALUES ('10', '5316.22', '2', '10', '1');
INSERT INTO `cirugia_cirujano` VALUES ('11', '3270.60', '2', '11', '1');
INSERT INTO `cirugia_cirujano` VALUES ('12', '4360.80', '2', '12', '1');
INSERT INTO `cirugia_cirujano` VALUES ('13', '3029.10', '2', '13', '1');
INSERT INTO `cirugia_cirujano` VALUES ('14', '3270.60', '2', '14', '1');
INSERT INTO `cirugia_cirujano` VALUES ('15', '1950.00', '2', '15', '1');
INSERT INTO `cirugia_cirujano` VALUES ('16', '3450.00', '1', '16', '1');

-- ----------------------------
-- Table structure for `cirugia_paquete_f`
-- ----------------------------
DROP TABLE IF EXISTS `cirugia_paquete_f`;
CREATE TABLE `cirugia_paquete_f` (
  `CP_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CP_MONTO_PROTESIS` float(12,2) NOT NULL,
  `CP_DESCUENTO` int(11) NOT NULL,
  `CP_MONTO_CIRUJANO` float(12,2) NOT NULL,
  `CP_CIRUGIA_FK` bigint(20) NOT NULL,
  `PF_CIRUJANO_FK` bigint(20) DEFAULT NULL,
  `CP_PAQUETEF_FK` bigint(20) NOT NULL,
  `CP_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`CP_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cirugia_paquete_f
-- ----------------------------
INSERT INTO `cirugia_paquete_f` VALUES ('3', '5000.00', '0', '18244.37', '1', '1', '3', '1');
INSERT INTO `cirugia_paquete_f` VALUES ('4', '0.00', '50', '20688.12', '3', '1', '3', '1');
INSERT INTO `cirugia_paquete_f` VALUES ('5', '0.00', '0', '37898.58', '10', '2', '4', '1');
INSERT INTO `cirugia_paquete_f` VALUES ('6', '0.00', '25', '18823.33', '15', '2', '4', '1');

-- ----------------------------
-- Table structure for `cirujano`
-- ----------------------------
DROP TABLE IF EXISTS `cirujano`;
CREATE TABLE `cirujano` (
  `AU_CI` bigint(20) NOT NULL AUTO_INCREMENT,
  `AU_PRIMER_NOMBRE` varchar(30) NOT NULL,
  `AU_SEGUNDO_NOMBRE` varchar(30) DEFAULT NULL,
  `AU_PRIMER_APELLIDO` varchar(30) NOT NULL,
  `AU_SEGUNDO_APELLIDO` varchar(30) DEFAULT NULL,
  `AU_TELEFONO_MOVIL` varchar(10) NOT NULL,
  `AU_TELEFONO_FIJO` varchar(10) DEFAULT NULL,
  `AU_CORREO` varchar(100) NOT NULL,
  `AU_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`AU_CI`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cirujano
-- ----------------------------
INSERT INTO `cirujano` VALUES ('1', 'Sara', 'Luz', 'Rojas', '', '4166325371', '', '', '1');
INSERT INTO `cirujano` VALUES ('2', 'Jose', '', 'Smitter', '', '4123229999', '', '', '1');

-- ----------------------------
-- Table structure for `paciente`
-- ----------------------------
DROP TABLE IF EXISTS `paciente`;
CREATE TABLE `paciente` (
  `PA_CI` bigint(20) NOT NULL AUTO_INCREMENT,
  `PA_PRIMER_NOMBRE` varchar(15) NOT NULL,
  `PA_SEGUNDO_NOMBRE` varchar(15) DEFAULT NULL,
  `PA_PRIMER_APELLIDO` varchar(15) NOT NULL,
  `PA_SEGUNDO_APELLIDO` varchar(15) DEFAULT NULL,
  `PA_TELEFONO_FIJO` varchar(10) DEFAULT NULL,
  `PA_TELEFONO_MOVIL` varchar(10) DEFAULT NULL,
  `PA_CORREO` varchar(100) DEFAULT NULL,
  `PA_FECHA_INGRESO` date NOT NULL,
  `PA_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`PA_CI`)
) ENGINE=InnoDB AUTO_INCREMENT=18011725 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of paciente
-- ----------------------------
INSERT INTO `paciente` VALUES ('6451270', 'Ana', '', 'Albornoz', '', '', '4127251485', 'anaalbornoz187@hotmail.com', '2012-02-14', '1');
INSERT INTO `paciente` VALUES ('18011724', 'Daniel', 'Antonio', 'Zamora', 'Bustamante', '2125633263', '4123206435', 'danielzamora87@gmail.com', '2012-02-14', '1');

-- ----------------------------
-- Table structure for `pagos`
-- ----------------------------
DROP TABLE IF EXISTS `pagos`;
CREATE TABLE `pagos` (
  `PA_ID` varchar(100) NOT NULL,
  `PA_MONTO` float(12,2) NOT NULL,
  `PA_NOMBRE` varchar(100) NOT NULL,
  `PA_FECHA` date NOT NULL,
  `PA_SEGURO` varchar(100) NOT NULL,
  `PA_TIPO_PAGO` varchar(3) NOT NULL,
  `PA_PACIENTE_FK` bigint(20) NOT NULL,
  `PA_STATUS` int(11) DEFAULT '1',
  `PA_PAQUETE_FK` bigint(20) NOT NULL,
  PRIMARY KEY (`PA_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pagos
-- ----------------------------
INSERT INTO `pagos` VALUES ('H116704', '8765.93', 'Luis Andres Per', '2011-09-15', 'NA', 'Qx', '6451270', '1', '4');
INSERT INTO `pagos` VALUES ('H116859', '4335.77', 'Ana Albornoz', '2011-10-27', 'NA', 'He', '6451270', '1', '4');
INSERT INTO `pagos` VALUES ('H116922', '8284.35', 'Luis Andres Per', '2011-11-16', 'NA', 'Qx', '6451270', '1', '4');
INSERT INTO `pagos` VALUES ('H123', '2000.30', 'Daniel Zamora', '2012-02-14', 'Caracas', 'Qx', '18011724', '1', '3');
INSERT INTO `pagos` VALUES ('H1234', '200.00', 'Claraemir Magin', '2012-02-14', 'Occidental', 'Qx', '18011724', '1', '3');
INSERT INTO `pagos` VALUES ('H124', '200.00', 'Jose Manrique', '2012-02-14', 'Occidental', 'Qx', '18011724', '1', '3');
INSERT INTO `pagos` VALUES ('H125', '200.30', 'Claraemir Magin', '2012-02-14', 'NA', 'Qx', '18011724', '1', '3');
INSERT INTO `pagos` VALUES ('H127021', '4249.40', 'Luis Andres Per', '2012-01-23', 'NA', 'Qx', '6451270', '1', '4');

-- ----------------------------
-- Table structure for `paquete_financiero`
-- ----------------------------
DROP TABLE IF EXISTS `paquete_financiero`;
CREATE TABLE `paquete_financiero` (
  `PF_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `PF_FECHA_PAQUETE` date NOT NULL,
  `PF_FECHA_LIMITE` date NOT NULL,
  `PF_PACIENTE_FK` bigint(20) DEFAULT NULL,
  `PF_STATUS` int(11) DEFAULT '1',
  `PF_FECHA_OPERACION` date NOT NULL,
  `PF_OBSERVACION` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`PF_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of paquete_financiero
-- ----------------------------
INSERT INTO `paquete_financiero` VALUES ('3', '2012-01-01', '2012-06-29', '18011724', '1', '2012-03-20', 'Este paquete financiero se esta haciendo de prueba');
INSERT INTO `paquete_financiero` VALUES ('4', '2012-01-26', '2012-07-24', '6451270', '1', '2012-05-30', '26/01/2012 Acumula Qx 21290,68 - Pqx 4335,77');

-- ----------------------------
-- Table structure for `personal_cirugia`
-- ----------------------------
DROP TABLE IF EXISTS `personal_cirugia`;
CREATE TABLE `personal_cirugia` (
  `PC_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `PC_CIRUGIA_PAQUETE_FK` bigint(20) DEFAULT NULL,
  `PC_PERSONAL_FK` bigint(20) DEFAULT NULL,
  `PC_ESPECIALIZACION` varchar(50) NOT NULL,
  `PC_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`PC_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of personal_cirugia
-- ----------------------------

-- ----------------------------
-- Table structure for `personal_quirurjico`
-- ----------------------------
DROP TABLE IF EXISTS `personal_quirurjico`;
CREATE TABLE `personal_quirurjico` (
  `PQ_CI` bigint(20) NOT NULL AUTO_INCREMENT,
  `PQ_PRIMER_NOMBRE` varchar(30) NOT NULL,
  `PQ_SEGUNDO_NOMBRE` varchar(30) DEFAULT NULL,
  `PQ_PRIMER_APELLIDO` varchar(30) NOT NULL,
  `PQ_SEGUNDO_APELLIDO` varchar(30) DEFAULT NULL,
  `PQ_ESPECIALIZACION` varchar(50) NOT NULL,
  `PQ_TELEFONO_FIJO` varchar(10) DEFAULT NULL,
  `PQ_CORREO` varchar(100) NOT NULL,
  `PQ_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`PQ_CI`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of personal_quirurjico
-- ----------------------------
INSERT INTO `personal_quirurjico` VALUES ('1', 'Claraemir', null, 'Magin', null, '1er ayudante', '2125633263', 'clara@gmail.com', '1');

-- ----------------------------
-- Table structure for `transferencia`
-- ----------------------------
DROP TABLE IF EXISTS `transferencia`;
CREATE TABLE `transferencia` (
  `TR_ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `TR_MONTO` float(12,2) NOT NULL,
  `TR_PACIENTE_OTORGA_FK` bigint(20) NOT NULL,
  `TR_PACIENTE_RECIBE_FK` bigint(20) NOT NULL,
  `TR_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`TR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of transferencia
-- ----------------------------

-- ----------------------------
-- Table structure for `usuario`
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `US_CI` bigint(20) NOT NULL AUTO_INCREMENT,
  `US_NOMBRE` varchar(15) DEFAULT NULL,
  `US_APELLIDO` varchar(15) DEFAULT NULL,
  `US_USUARIO` varchar(10) DEFAULT NULL,
  `US_CONTRASENA` varchar(10) DEFAULT NULL,
  `US_STATUS` int(11) DEFAULT '1',
  PRIMARY KEY (`US_CI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuario
-- ----------------------------

-- ----------------------------
-- Procedure structure for `EliminarCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarCirugia`(IN `ID` bigint)
BEGIN
	UPDATE cirugia SET CI_STATUS=0
where CI_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarCirugiaCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarCirugiaCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarCirugiaCirujano`(IN `ID` bigint)
BEGIN
	UPDATE cirugia_cirujano SET CC_STATUS=0
WHERE CC_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarCirugiaPaqueteF`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarCirugiaPaqueteF`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarCirugiaPaqueteF`(IN `ID` bigint)
BEGIN
	UPDATE cirugia_paquete_f SET CP_STATUS=0 WHERE CP_ID=ID;
	update personal_cirugia set PC_STATUS=0 where PC_CIRUGIA_PAQUETE_FK=ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarCirujano`(IN `ID` bigint)
BEGIN
	UPDATE cirujano SET AU_STATUS=0
WHERE AU_CI=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPaciente`(IN `ID` bigint)
BEGIN
	UPDATE paciente SET PA_STATUS=0 
WHERE PA_CI=ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarPago`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarPago`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPago`(IN `ID` bigint)
BEGIN
	UPDATE pagos SET  PA_STATUS=0
WHERE PA_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarPaqueteFinanciero`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarPaqueteFinanciero`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPaqueteFinanciero`(IN `ID` bigint)
BEGIN
	UPDATE paquete_financiero SET PF_STATUS=0
WHERE PF_ID=ID; 
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarPersonalCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarPersonalCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPersonalCirugia`(IN `ID` bigint)
BEGIN
	UPDATE personal_cirugia SET PC_STATUS=0
WHERE PC_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarPersonalQuirurgico`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarPersonalQuirurgico`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarPersonalQuirurgico`(IN `CI` bigint)
BEGIN
	UPDATE personal_quirurjico SET PQ_STATUS=0
WHERE PQ_CI=CI;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarTransferencia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarTransferencia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarTransferencia`(IN `ID` bigint)
BEGIN
	UPDATE transferencia SET TR_STATUS=0
WHERE TR_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `EliminarUsuario`
-- ----------------------------
DROP PROCEDURE IF EXISTS `EliminarUsuario`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarUsuario`(IN `CI` bigint)
BEGIN
	UPDATE usuario SET US_STATUS=0
WHERE US_CI=CI;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCirugia`(IN `NOMBRE` varchar(100),IN `DESCRIPCION` varchar(200))
    DETERMINISTIC
BEGIN
	INSERT INTO cirugia (CI_NOMBRE,CI_DESCRIPCION) VALUES (NOMBRE,DESCRIPCION);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarCirugiaCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarCirugiaCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCirugiaCirujano`(IN `HONORARIOS` float,IN `CIRUJANO` bigint,IN `CIRUGIA` bigint)
BEGIN
	INSERT INTO cirugia_cirujano (CC_HONORARIOS,CC_FK_CIRUJANO,CC_FK_CIRUGIA) VALUES (HONORARIOS,CIRUJANO,CIRUGIA);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarCirugiaPaqueteF`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarCirugiaPaqueteF`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCirugiaPaqueteF`(IN  `PROTESIS` float,IN `DESCUENTO` FLOAT(12,2),IN `MONTO_CIRUJANO` FLOAT(12,2),IN `CIRUGIA` bigint,IN `CIRUJANO` bigint,IN `PAQUETE` bigint, OUT `MAX_ID` bigint)
BEGIN
	INSERT INTO cirugia_paquete_f (CP_MONTO_PROTESIS,CP_DESCUENTO,CP_MONTO_CIRUJANO,CP_CIRUGIA_FK,PF_CIRUJANO_FK,CP_PAQUETEF_FK) 
				 VALUES (PROTESIS,DESCUENTO,MONTO_CIRUJANO,CIRUGIA,CIRUJANO,PAQUETE);
	select MAX(CP_ID) into max_id from cirugia_paquete_f;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `Insertarcirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `Insertarcirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insertarcirujano`(IN `CEDULA` bigint,IN `PRIMERNOMBRE` varchar(30),IN `SEGUNDONOMBRE` varchar(30),IN `PRIMERAPELLIDO` varchar(30),IN `SEGUNDOAPELLIDO` varchar(30),IN `TELEFONOMOVIL` varchar(30),IN `TELEFONOFIJO` varchar(30),IN `CORREO` varchar(30))
BEGIN
	INSERT INTO cirujano (AU_CI,AU_PRIMER_NOMBRE,AU_SEGUNDO_NOMBRE,AU_PRIMER_APELLIDO,
AU_SEGUNDO_APELLIDO,AU_TELEFONO_MOVIL,AU_TELEFONO_FIJO,AU_CORREO) 
VALUES (CEDULA, PRIMERNOMBRE, SEGUNDONOMBRE, PRIMERAPELLIDO, 
SEGUNDOAPELLIDO, TELEFONOMOVIL, TELEFONOFIJO, CORREO);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPaciente`(IN `CEDULA` bigint,IN `PRIMERNOMBRE` varchar(15),IN `SEGUNDONOMBRE` varchar(15),IN `PRIMERAPELLIDO` varchar(15),IN `SEGUNDOAPELLIDO` varchar(15),IN `TELEFONOFIJO` varchar(10),IN `TELEFONOMOVIL` varchar(10),IN `CORREO` varchar(100),IN `FECHA_INGRESO` date)
BEGIN
	INSERT INTO paciente (PA_CI,PA_PRIMER_NOMBRE,PA_SEGUNDO_NOMBRE,
PA_PRIMER_APELLIDO,PA_SEGUNDO_APELLIDO, PA_TELEFONO_FIJO,
PA_TELEFONO_MOVIL,PA_CORREO,PA_FECHA_INGRESO) 
VALUES (CEDULA, PRIMERNOMBRE, SEGUNDONOMBRE, 
PRIMERAPELLIDO, SEGUNDOAPELLIDO, TELEFONOFIJO,
 TELEFONOMOVIL, CORREO, FECHA_INGRESO );

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarPago`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarPago`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPago`(IN `IDPAGO` varchar(100),IN `MONTO` float(12,2),IN `NOMBRE` varchar(100),IN `FECHA` DATE,IN `SEGURO` VARCHAR(100), IN `TIPO_PAGO` VARCHAR(3),IN `PACIENTE` bigint, IN `PAQUETE` bigint )
BEGIN
	INSERT INTO pagos (PA_ID,PA_MONTO,PA_NOMBRE,PA_FECHA,PA_SEGURO,PA_TIPO_PAGO,PA_PACIENTE_FK,PA_PAQUETE_FK) 
	VALUES (IDPAGO,MONTO,NOMBRE,FECHA,SEGURO,TIPO_PAGO,PACIENTE,PAQUETE);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarPaqueteFinanciero`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarPaqueteFinanciero`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPaqueteFinanciero`(IN `FECHA_PAQUETE` date,IN `FECHA_OPERACION` date,IN `PACIENTE` bigint,OUT `idMax` bigint, IN `OBSERVACION` varchar(500))
    DETERMINISTIC
BEGIN
	INSERT INTO paquete_financiero (PF_FECHA_PAQUETE,PF_FECHA_LIMITE,PF_PACIENTE_FK,PF_FECHA_OPERACION,PF_OBSERVACION) 
	VALUES (FECHA_PAQUETE,ADDDATE(FECHA_PAQUETE,180),PACIENTE,FECHA_OPERACION,OBSERVACION);
  select MAX(PF_ID) into idMax from paquete_financiero;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarPersonalCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarPersonalCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPersonalCirugia`(IN `CIRUGIA_PAQUETE` bigint,IN `PERSONAL` bigint, IN `ESPECIALIZACION` varchar(50))
BEGIN
	INSERT INTO personal_cirugia (PC_CIRUGIA_PAQUETE_FK,PC_PERSONAL_FK,PC_ESPECIALIZACION) 
	VALUES (CIRUGIA_PAQUETE, PERSONAL,ESPECIALIZACION);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarPersonalQuirurgico`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarPersonalQuirurgico`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPersonalQuirurgico`(IN `CEDULA` bigint,IN `PRIMERNOMBRE` varchar(30),IN `SEGUNDONOMBRE` varchar(30),IN `PRIMERAPELLIDO` varchar(30),IN `SEGUNDOAPELLIDO` varchar(30),IN `ESPECIALIZACION` varchar(10),IN `TELEFONO` varchar(10),IN `CORREO` varchar(30))
BEGIN
	INSERT INTO personal_quirurjico (PQ_CI,PQ_PRIMER_NOMBRE,PQ_SEGUNDO_NOMBRE,PQ_PRIMER_APELLIDO,PQ_SEGUNDO_APELLIDO,PQ_ESPECIALIZACION,PQ_TELEFONO_FIJO,PQ_CORREO) 
VALUES (CEDULA, PRIMERNOMBRE,SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,ESPECIALIZACION,TELEFONO,CORREO);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarTransferencia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarTransferencia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarTransferencia`(IN `MONTO` float,IN `PACIENTE_OTORGA` bigint,IN `PACIENTE_RECIBE` bigint)
BEGIN
	INSERT INTO transferencia (TR_MONTO,TR_PACIENTE_OTORGA_FK,TR_PACIENTE_RECIBE_FK) VALUES (MONTO,PACIENTE_OTORGA,PACIENTE_RECIBE);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `InsertarUsuario`
-- ----------------------------
DROP PROCEDURE IF EXISTS `InsertarUsuario`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarUsuario`(IN `CEDULA` bigint,IN `NOMBRE` varchar(15),IN `APELLIDO` varchar(15),IN `USUARIO` varchar(10),IN `CONTRASENA` varchar(10))
BEGIN
	INSERT INTO usuario (US_CI,US_NOMBRE,US_APELLIDO,US_USUARIO,US_CONTRASENA) VALUES (CEDULA,NOMBRE,APELLIDO,USUARIO,CONTRASENA);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarCirugia`(IN `CEDULA` bigint,IN `NOMBRE` varchar(15),IN `DESCRIPCION` varchar(15))
BEGIN
	UPDATE cirugia SET  CI_NOMBRE=NOMBRE, CI_DESCRIPCION=DESCRIPCION
  where CI_ID=CEDULA;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarCirugiaCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarCirugiaCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarCirugiaCirujano`(IN `HONORARIOS` float,IN `CIRUJANO` bigint,IN `CIRUGIA` bigint)
BEGIN
	UPDATE cirugia_cirujano SET CC_HONORARIOS=HONORARIOS
  WHERE CC_FK_CIRUGIA = CIRUGIA AND CC_FK_CIRUJANO = CIRUJANO;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarCirugiaPaquteF`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarCirugiaPaquteF`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarCirugiaPaquteF`(IN `ID` bigint,IN `PROTESIS` float,IN `FECHA_OPERACION` date,IN `CIRUGIA` bigint,IN `PAQUETE` bigint)
BEGIN
	UPDATE cirugia_paquete_f SET CP_MONTO_PROTESIS=PROTESIS, CP_FECHA_OPERACION=FECHA_OPERACION,CP_CIRUGIA_FK=CIRUGIA,CP_PAQUETEF_FK=PAQUETE 
WHERE CP_ID=ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarCirujano`(IN `ID` varchar(30),IN `PRIMERNOMBRE` varchar(30),IN `SEGUNDONOMBRE` varchar(30),`PRIMERAPELLIDO` varchar(30),`SEGUNDOAPELLIDO` varchar(30),`TELEFONOMOVIL` varchar(10),`TELEFONOFIJO` varchar(10),`CORREO` varchar(30))
BEGIN
	UPDATE cirujano SET AU_PRIMER_NOMBRE=PRIMERNOMBRE, AU_SEGUNDO_NOMBRE=SEGUNDONOMBRE, AU_PRIMER_APELLIDO=PRIMERAPELLIDO,
											AU_SEGUNDO_APELLIDO=SEGUNDOAPELLIDO,AU_TELEFONO_MOVIL=TELEFONOMOVIL,AU_TELEFONO_FIJO=TELEFONOFIJO,AU_CORREO=CORREO
WHERE AU_CI=ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarPaciente`(IN `CEDULA`bigint ,IN `PRIMERNOMBRE`varchar(15) ,IN `SEGUNDONOMBRE`varchar(15), IN`PRIMERAPELLIDO`varchar(15) ,IN`SEGUNDOAPELLIDO`varchar(15) ,IN`TELEFONOFIJO`varchar(10) ,IN`TELEFONOMOVIL`varchar(10) ,IN`CORREO`varchar(100))
BEGIN
	UPDATE paciente SET PA_PRIMER_NOMBRE=PRIMERNOMBRE, PA_SEGUNDO_NOMBRE=SEGUNDONOMBRE,
PA_PRIMER_APELLIDO=PRIMERAPELLIDO, PA_SEGUNDO_APELLIDO=SEGUNDOAPELLIDO,
PA_TELEFONO_FIJO=TELEFONOFIJO, PA_TELEFONO_MOVIL=TELEFONOMOVIL, PA_CORREO=CORREO
WHERE PA_CI=CEDULA; 
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarPago`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarPago`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarPago`(IN `ID` bigint,IN `MONTO` float,IN `NOMBRE` varchar(15),IN `PACIENTE` bigint)
BEGIN
	UPDATE pagos SET PA_MONTO=MONTO,PA_NOMBRE=NOMBRE,PA_PACIENTE_FK=PACIENTE
WHERE PA_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarPaqueteFinanciero`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarPaqueteFinanciero`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarPaqueteFinanciero`(IN`ID`bigint ,IN`FECHA_PAQUETE` date ,IN`FECHA_LIMITE` date,IN`CIRUJANO`bigint ,IN`PACIENTE` bigint)
BEGIN
	UPDATE paquete_financiero SET PF_FECHA_PAQUETE=FECHA_PAQUETE,PF_FECHA_LIMITE=FECHA_LIMITE,PF_CIRUJANO_FK=CIRUJANO,PF_PACIENTE_FK=PACIENTE 
WHERE PF_ID=ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarPersonalCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarPersonalCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarPersonalCirugia`(IN `ID` bigint,IN `CIRUGIA_PAQUETE` bigint,IN `PERSONAL` bigint,IN `ESPECIALIZACION` varchar(10))
BEGIN
	UPDATE personal_cirugia SET PC_CIRUGIA_PAQUETE_FK=CIRUGIA_PAQUETE,PC_PERSONAL_FK=PERSONAL,PC_ESPECIALIZACION=ESPECIALIZACION
WHERE PC_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarPersonalQuirurgico`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarPersonalQuirurgico`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarPersonalQuirurgico`(IN `CI` bigint,IN `PRIMERNOMBRE` varchar(30),IN `SEGUNDONOMBRE` varchar(30),IN `PRIMERAPELLIDO` varchar(30),IN `SEGUNDOAPELLIDO` varchar(30),IN `ESPECIALIZACION` varchar(10),IN `TELEFONO` varchar(10),IN `CORREO` varchar(30))
BEGIN
	UPDATE personal_quirurjico SET PQ_PRIMER_NOMBRE=PRIMERNOMBRE,PQ_SEGUNDO_NOMBRE=SEGUNDONOMBRE,PQ_PRIMER_APELLIDO=PRIMERAPELLIDO,PQ_SEGUNDO_APELLIDO=SEGUNDOAPELLIDO,PQ_ESPECIALIZACION=ESPECIALIZACION,PQ_TELEFONO_FIJO=TELEFONO,PQ_CORREO=CORREO
WHERE PQ_CI=CI;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ModificarTransferencia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ModificarTransferencia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarTransferencia`(IN `ID` bigint,IN `MONTO` float,IN `PACIENTE_OTORGA` bigint,IN `PACIENTE_RECIBE` bigint)
BEGIN
	UPDATE transferencia SET TR_MONTO=MONTO,TR_PACIENTE_OTORGA_FK=PACIENTE_OTORGA,TR_PACIENTE_RECIBE_FK=PACIENTE_RECIBE
WHERE TR_ID=ID;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirugiaCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirugiaCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirugiaCirujano`(IN `cedula` bigint)
BEGIN
	select c.CI_NOMBRE,cc.CC_HONORARIOS, cc.CC_FK_CIRUGIA, cc.CC_FK_CIRUJANO from cirugia_cirujano cc, cirugia c 
  where cc.CC_FK_CIRUJANO = cedula and cc.CC_STATUS = 1 and cc.CC_FK_CIRUGIA = c.CI_ID;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirugias`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirugias`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirugias`()
BEGIN
	Select ci_nombre,CI_ID from cirugia; 

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirugiasAgregarCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirugiasAgregarCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirugiasAgregarCirujano`(IN `cedula` bigint)
BEGIN
	
	select b.CI_ID,b.CI_NOMBRE
	from cirugia b
	left outer join (Select ci.CI_ID, ci.CI_NOMBRE
									from cirujano c, cirugia ci, cirugia_cirujano cc
									where c.AU_CI = cc.CC_FK_CIRUJANO and cc.CC_FK_CIRUGIA = ci.CI_ID
									and c.AU_CI = cedula) a
	on b.CI_ID = a.CI_ID
	where a.CI_ID is NULL;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirugiasPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirugiasPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirugiasPaciente`(IN `idPaciente` bigint)
BEGIN

select c.CP_ID, ci.CI_NOMBRE, cj.AU_PRIMER_NOMBRE as nombreCirujano,c.CP_FECHA_OPERACION,pa.PA_CI,c.CP_MONTO_CIRUJANO
from cirugia_paquete_f c, cirugia ci, cirujano cj, paquete_financiero pf, paciente pa
where c.CP_CIRUGIA_FK = ci.CI_ID and cj.AU_CI = c.PF_CIRUJANO_FK and pf.PF_ID = c.CP_PAQUETEF_FK and pa.PA_CI = pf.PF_PACIENTE_FK and pa.PA_CI = idPaciente and c.CP_Status != 0 ;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirugiasPaqueteFinanciero`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirugiasPaqueteFinanciero`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirugiasPaqueteFinanciero`(IN `idPaquete` bigint)
BEGIN

SELECT CI_NOMBRE, CONCAT(c.AU_PRIMER_NOMBRE,' ',c.AU_SEGUNDO_NOMBRE,' ',c.AU_PRIMER_APELLIDO) as nombre,CP_MONTO_PROTESIS, CP_MONTO_CIRUJANO, CP_DESCUENTO
from cirugia,cirugia_paquete_f,paquete_financiero, cirujano c
where CI_ID = CP_CIRUGIA_FK and CP_PAQUETEF_FK = PF_ID and PF_ID = idPaquete and c.AU_CI = PF_CIRUJANO_FK and CP_Status != 0 ;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirujanos`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirujanos`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirujanos`()
BEGIN
	select AU_CI, CONCAT(AU_PRIMER_NOMBRE,' ',AU_PRIMER_APELLIDO) as nombre
	from cirujano;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerCirujanosCirugia`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerCirujanosCirugia`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCirujanosCirugia`(IN `idCirugia` bigint(20))
BEGIN
	Select concat(c.AU_PRIMER_NOMBRE,' ',c.AU_PRIMER_APELLIDO) as nombre, c.AU_CI 
  from cirujano c,cirugia_cirujano cc  
	where cc.CC_FK_CIRUGIA = idCirugia and 
				cc.CC_FK_CIRUJANO = c.AU_CI GROUP BY nombre;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerFacturaPago`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerFacturaPago`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerFacturaPago`(IN `facturaId` bigint, IN `cedula` bigint)
BEGIN
	select p.PA_MONTO,p.PA_FECHA,p.PA_NOMBRE,p.PA_SEGURO,p.PA_TIPO_PAGO 
  from pagos p where p.PA_ID = facturaId and p.PA_PACIENTE_FK = cedula;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerHonorarioCirugiaCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerHonorarioCirugiaCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerHonorarioCirugiaCirujano`(IN `idCirugia` bigint(20),IN `idCirujano` bigint(20))
BEGIN
	SELECT cc.CC_ID , cc.CC_HONORARIOS from cirugia_cirujano cc where cc.CC_FK_CIRUGIA = idCirugia and cc.CC_FK_CIRUJANO = idCirujano and cc.CC_STATUS = 1;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerInformacionCirujano`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerInformacionCirujano`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerInformacionCirujano`(IN `cedula` bigint)
BEGIN
	select c.AU_PRIMER_NOMBRE,c.AU_SEGUNDO_NOMBRE,c.AU_PRIMER_APELLIDO,c.AU_SEGUNDO_APELLIDO,c.AU_TELEFONO_FIJO,c.AU_TELEFONO_MOVIL,c.AU_CORREO 
	from cirujano c where c.AU_CI = cedula;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerInformacionPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerInformacionPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerInformacionPaciente`(IN `Cedula` bigint)
BEGIN
	select p.PA_PRIMER_NOMBRE, p.PA_SEGUNDO_NOMBRE, p.PA_PRIMER_APELLIDO, p.PA_SEGUNDO_APELLIDO, p.PA_TELEFONO_FIJO, p.PA_TELEFONO_MOVIL, p.PA_CORREO 
  from paciente p where p.PA_CI = cedula;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerPagosPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerPagosPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPagosPaciente`(IN `IDPACIENTE` bigint)
BEGIN
	SELECT PA_ID,PA_MONTO,PA_FECHA FROM pagos WHERE PA_PACIENTE_FK = IDPACIENTE;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerPagosPaqueteFinanciero`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerPagosPaqueteFinanciero`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPagosPaqueteFinanciero`(IN `idPaquete` bigint)
BEGIN
	SELECT PA_MONTO,PA_NOMBRE,PA_FECHA,PA_SEGURO,PA_TIPO_PAGO
	FROM pagos, paquete_financiero
	where PA_PAQUETE_FK = PF_ID and PF_ID = idPaquete;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerPaqueteFPaciente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerPaqueteFPaciente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPaqueteFPaciente`(IN `CEDULA` bigint)
BEGIN
	select PF_ID, PF_FECHA_PAQUETE, PF_FECHA_OPERACION, PF_OBSERVACION
	from paquete_financiero
	where PF_PACIENTE_FK = cedula;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ObtenerPersonalQ`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ObtenerPersonalQ`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPersonalQ`()
BEGIN
		SELECT CONCAT(pq.PQ_PRIMER_NOMBRE," ",pq.PQ_PRIMER_APELLIDO),PQ_CI from personal_quirurjico pq;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ValidacionPacienteExistente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ValidacionPacienteExistente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ValidacionPacienteExistente`(IN `CEDULA` bigint,OUT `resultado` bigint)
BEGIN
	SELECT PA_CI into resultado from paciente WHERE PA_CI = cedula;
	IF (resultado=cedula) THEN
			set resultado = 1;
	ELSE	set resultado = 0;
	END if;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `ValidarPagoExistente`
-- ----------------------------
DROP PROCEDURE IF EXISTS `ValidarPagoExistente`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ValidarPagoExistente`(IN `IDPAGO` varchar(100),OUT `RESULTADO` bigint)
BEGIN
	SELECT PA_ID LIKE IDPAGO INTO resultado from pagos;
END
;;
DELIMITER ;
