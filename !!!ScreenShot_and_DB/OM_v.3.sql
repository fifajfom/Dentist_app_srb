-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: om
-- ------------------------------------------------------
-- Server version	5.6.34-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `karton`
--

DROP TABLE IF EXISTS `karton`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `karton` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idp` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `ime` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `prezime` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `beleske` varchar(10000) COLLATE utf8_bin DEFAULT NULL,
  `gl1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl8` varchar(1000) COLLATE utf8_bin DEFAULT NULL,
  `gd1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `nn1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `nn2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `karton`
--

LOCK TABLES `karton` WRITE;
/*!40000 ALTER TABLE `karton` DISABLE KEYS */;
/*!40000 ALTER TABLE `karton` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacijent_beleske`
--

DROP TABLE IF EXISTS `pacijent_beleske`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacijent_beleske` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idp` varchar(100) DEFAULT NULL,
  `beleske` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijent_beleske`
--

LOCK TABLES `pacijent_beleske` WRITE;
/*!40000 ALTER TABLE `pacijent_beleske` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacijent_beleske` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacijenti`
--

DROP TABLE IF EXISTS `pacijenti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pacijenti` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ime` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `prezime` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `email` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `telefon` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `adresa` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `extra` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijenti`
--

LOCK TABLES `pacijenti` WRITE;
/*!40000 ALTER TABLE `pacijenti` DISABLE KEYS */;
/*!40000 ALTER TABLE `pacijenti` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER insert_karton
AFTER INSERT
ON pacijenti FOR EACH ROW
begin 
	insert into karton (idp , ime , prezime) values (new.id, new.ime, new.prezime);
	insert into zub (idp) values (new.id);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER update_karton
AFTER update 
ON pacijenti FOR EACH ROW
begin 
   update karton set ime = new.ime, prezime = new.prezime where idp = old.id	;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER delete_karton
AFTER delete 
ON pacijenti FOR EACH ROW
begin 
	delete from karton where idp=old.id;
	delete from zub where idp=old.id;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `tst`
--

DROP TABLE IF EXISTS `tst`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tst` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `prv` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tst`
--

LOCK TABLES `tst` WRITE;
/*!40000 ALTER TABLE `tst` DISABLE KEYS */;
INSERT INTO `tst` VALUES (1,'1');
/*!40000 ALTER TABLE `tst` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zfiles`
--

DROP TABLE IF EXISTS `zfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zfiles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imefajla` varchar(100) DEFAULT NULL,
  `beleske` varchar(1000) DEFAULT NULL,
  `putanja` varchar(1000) DEFAULT 'C:\\Users\\Miki\\Desktop\\BACKUP OM\\OrdinacijaMihajlovic - Karton\\bin\\Debug\\Pacijenti\\',
  `idp` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zfiles`
--

LOCK TABLES `zfiles` WRITE;
/*!40000 ALTER TABLE `zfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `zfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zub`
--

DROP TABLE IF EXISTS `zub`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zub` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idp` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gl8` varchar(1000) COLLATE utf8_bin DEFAULT NULL,
  `gd1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `gd8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dl8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd1` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd2` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd3` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd4` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd5` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd6` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd7` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `dd8` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zub`
--

LOCK TABLES `zub` WRITE;
/*!40000 ALTER TABLE `zub` DISABLE KEYS */;
/*!40000 ALTER TABLE `zub` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zub_beleske`
--

DROP TABLE IF EXISTS `zub_beleske`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zub_beleske` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idp` varchar(100) DEFAULT NULL,
  `datum` date DEFAULT NULL,
  `beleske` varchar(500) DEFAULT NULL,
  `idz` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zub_beleske`
--

LOCK TABLES `zub_beleske` WRITE;
/*!40000 ALTER TABLE `zub_beleske` DISABLE KEYS */;
/*!40000 ALTER TABLE `zub_beleske` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'om'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-26 17:07:10
