-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: santoyo
-- ------------------------------------------------------
-- Server version	9.0.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cliente` varchar(45) DEFAULT NULL,
  `descripcion` varchar(64) DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `fechaventa` datetime DEFAULT NULL,
  `cambio` float DEFAULT '0',
  `divisa` tinyint DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=130 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (45,'1','',112,'2024-11-28 11:52:28',0,0),(46,'1','',112,'2024-11-28 11:52:41',0,0),(47,'0','o',700,'2024-11-28 13:00:38',0,0),(48,'44587114','',3,'2024-11-28 13:09:21',0,0),(49,'458872326','rep',86,'2024-12-01 11:00:28',0,0),(50,'44587114','rep',41,'2024-12-01 11:02:04',0,0),(51,'44587114','',67,'2024-12-01 11:04:28',0,0),(52,'458872326','rep aire',88,'2024-12-01 11:06:00',0,0),(53,'44587114','repracion aires',74,'2024-12-01 11:07:15',0,0),(54,'44587114','rep- aire',50,'2024-12-01 11:08:19',0,0),(55,'44587114','rep. aire',32,'2024-12-01 11:12:10',0,0),(56,'458872326','r',7,'2024-12-01 11:15:14',0,0),(57,'458872326','rep',5,'2024-12-01 11:20:23',0,0),(58,'458872326','r',16,'2024-12-01 11:21:21',0,0),(59,'458872326','r',76,'2024-12-01 11:24:10',0,0),(60,'458872326','rep',4,'2024-12-01 11:25:05',0,0),(61,'458872326','rep',4,'2024-12-01 11:38:10',0,0),(62,'458872326','rep',4,'2024-12-01 11:44:16',0,0),(63,'458872326','r',55,'2024-12-01 12:27:34',0,0),(64,'458872326','rep. aire',88,'2024-12-01 12:29:00',0,0),(65,'44587114','',0,'2024-12-01 12:38:17',0,0),(66,'458872326','rep',40,'2024-12-01 12:38:58',0,0),(67,'458872326','rep',46,'2024-12-01 12:41:30',0,0),(68,'458872326','k',22,'2024-12-01 12:43:03',0,0),(69,'458872326','rep',120,'2024-12-01 12:44:55',0,0),(70,'44587114','rep ar',69,'2024-12-01 12:46:20',0,0),(71,'44587114','des',67,'2024-12-01 16:18:56',0,0),(72,'44587114','repp.',33,'2024-12-01 16:22:35',0,0),(73,'44587114','repp.',33,'2024-12-01 16:31:56',0,0),(74,'458872326','rep. aire',567,'2024-12-01 16:32:53',0,0),(75,'44587114','rep, aire',178,'2024-12-01 16:35:33',0,0),(76,'44587114','rep. aretg',92,'2024-12-01 16:38:37',0,0),(77,'458872326','rep',475,'2024-12-01 16:50:48',0,0),(78,'458872326','www',70,'2024-12-01 16:52:33',0,0),(79,'458872326','www',70,'2024-12-01 17:01:31',0,0),(80,'458872326','www',70,'2024-12-01 19:38:37',0,0),(81,'458872326','rep',0,'2024-12-01 19:47:52',0,0),(82,'458872326','rep',65,'2024-12-01 19:48:48',0,0),(83,'44587114','e',45,'2024-12-01 19:52:25',0,0),(84,'44587114','rep',53,'2024-12-01 19:54:21',0,0),(85,'44587114','fdsfas',24,'2024-12-01 20:00:24',0,0),(86,'458872326','rep',53,'2024-12-01 20:03:26',0,0),(87,'458872326','rep aire',84,'2024-12-01 20:04:11',0,0),(88,'458872326','rep. aire',364,'2024-12-03 16:16:20',0,0),(89,'44587114','gkh',124,'2024-12-03 16:21:10',0,0),(90,'458872326','rep. arie 20btu',750,'2024-12-03 16:39:25',0,0),(91,'458872326','instalacion de 40 comps polar',402000,'2024-12-05 13:49:30',0,0),(92,'458872326','rep aire',422,'2024-12-05 18:43:51',0,0),(93,'44587114','rep. aire',205,'2024-12-05 18:45:42',0,0),(94,'31265030','rep aire',2772,'2024-12-05 19:07:26',0,0),(95,'44587114','rep. aire',104,'2024-12-05 19:08:54',0,0),(96,'45874125','rep. aire ',436,'2024-12-05 19:14:05',0,0),(97,'441555566','rep aire',998,'2024-12-05 19:14:56',0,0),(98,'31265030','rep aire',234,'2024-12-05 19:19:53',0,0),(99,'441555566','rep aire',480,'2024-12-05 19:22:23',0,0),(100,'45874125','rep aire',492,'2024-12-05 19:26:08',0,0),(101,'45874125','rep aire',644,'2024-12-05 19:27:26',0,0),(102,'31265030','',144,'2024-12-05 19:28:04',0,0),(103,'45874125','rep aire',933,'2024-12-05 19:32:58',0,0),(104,'45874125','rep aire. 12btu',45,'2024-12-05 22:26:14',0,0),(105,'45874125','rep aire. 12btu',45,'2024-12-05 22:28:01',0,0),(106,'45874125','rep aire',750,'2024-12-05 22:38:02',0,0),(107,'45874125','rep aire',750,'2024-12-05 22:38:12',0,0),(108,'45874125','rep aire',750,'2024-12-05 22:38:19',0,0),(109,'458872326','rep aire ',2900,'2024-12-05 22:39:34',0,0),(110,'458872326','rep aire ',2900,'2024-12-05 22:39:46',0,0),(111,'458872326','rep aire ',2900,'2024-12-05 22:39:54',0,0),(112,'458872326','rep aire ',2900,'2024-12-05 22:40:00',0,0),(113,'458872326','rep aire ',2900,'2024-12-05 22:40:07',0,0),(114,'441555566','Evaluación del rendimiento del sistema.',1460,'2024-12-06 11:31:35',0,0),(115,'441555566','Evaluación del rendimiento del sistema.',600,'2024-12-06 11:49:13',0,0),(116,'441555566','Evaluación del rendimiento del sistema.',520,'2024-12-06 12:04:57',0,0),(117,'441555566','Evaluación del rendimiento del sistema.',3850,'2024-12-06 13:14:27',0,0),(118,'44587114','Evaluación del rendimiento del sistema.',500,'2024-12-06 13:55:17',0,0),(119,'44587114','Evaluación del rendimiento del sistema.',500,'2024-12-06 13:55:29',0,0),(120,'44587114','Evaluación del rendimiento del sistema.',1184,'2024-12-06 13:58:21',0,0),(121,'45874125','Identificación de fugas en el sistema',208,'2024-12-06 18:07:53',0,0),(122,'441555566','Identificación de fugas en el sistema',496,'2024-12-06 18:19:31',0,0),(123,'45874125','Evaluación del rendimiento del sistema.',748,'2024-12-06 20:43:51',0,0),(124,'45874125','Evaluación del rendimiento del sistema.',2750,'2024-12-06 21:15:08',0,0),(125,'44587114','Identificación de fugas en el sistema',840,'2024-12-06 21:18:30',0,0),(126,'441555566','Identificación de fugas en el sistema',840,'2024-12-06 21:18:50',0,0),(127,'458872326','Evaluación del rendimiento del sistema.',1040,'2024-12-06 21:20:25',0,0),(128,'441555566','Evaluación del rendimiento del sistema.',700,'2024-12-07 07:21:28',0,0),(129,'44587114','Identificación de fugas en el sistema',60,'2024-12-11 17:49:35',0,0);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-12 15:01:04
