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
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventa` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idproducto` varchar(45) DEFAULT NULL,
  `idventa` int DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
INSERT INTO `detalleventa` VALUES (9,'H1',45,1),(10,'H1',46,1),(11,'H1',47,50),(12,'H1',48,1),(13,'H1',49,3),(14,'H1',50,3),(15,'H1',51,5),(16,'H1',52,4),(17,'H1',53,2),(18,'H1',54,3),(19,'H1',55,1),(20,'H1',56,9),(21,'H1',57,1),(22,'H1',58,1),(23,'H1',59,6),(24,'H1',60,5),(25,'H1',61,5),(26,'H1',62,5),(27,'H1',62,4),(28,'H1',63,4),(29,'H1',64,4),(30,'H1',66,3),(31,'H1',67,3),(32,'H1',68,1),(33,'H1',69,5),(34,'H1',70,3),(35,'H1',71,1),(36,'H1',71,4),(37,'H1',72,3),(38,'H1',73,3),(39,'H1',74,1),(40,'H1',75,6),(41,'H1',75,5),(42,'H1',75,2),(43,'H1',76,4),(44,'H1',77,33),(45,'H1',78,2),(46,'H1',78,1),(47,'H1',78,1),(48,'H1',79,2),(49,'H1',79,1),(50,'H1',79,1),(51,'H1',80,2),(52,'H1',80,1),(53,'H1',80,1),(54,'H1',82,2),(55,'H1',83,1),(56,'H1',84,1),(57,'H1',85,1),(58,'H1',86,4),(59,'H1',87,2),(60,'Rp1',88,1),(61,'H1',88,2),(62,'Rp1',88,5),(63,'H1',89,3),(64,'Rp1',90,7),(65,'Rp1',91,40),(66,'Rp1',92,4),(67,'Rp1',93,3),(68,'Rp1',94,55),(69,'H1',95,2),(70,'H1',96,3),(71,'H1',97,5),(72,'H1',98,1),(73,'H1',99,3),(74,'H1',100,4),(75,'Rp1',101,4),(76,'H1',102,7),(77,'H1',103,50),(78,'H1',104,3),(79,'Rp1',104,3),(80,'H1',105,3),(81,'Rp1',105,3),(82,'Rp1',106,5),(83,'Rp1',107,5),(84,'Rp1',108,5),(85,'Rp1',109,56),(86,'Rp1',110,56),(87,'Rp1',111,56),(88,'Rp1',112,56),(89,'Rp1',113,56),(90,'H1',114,80),(91,'Ac1',115,5),(92,'Ac1',116,1),(93,'Rp1',117,7),(94,'Rp1',117,60),(95,'H1',120,45),(96,'H1',120,12),(97,'H1',121,4),(98,'Ac1',121,5),(99,'H1',122,8),(100,'Rp1',122,6),(101,'Ac1',122,2),(102,'H1',123,4),(103,'Rp1',123,4),(104,'Rp1',124,45),(105,'H1',125,65),(106,'H1',127,45),(107,'Rp1',128,4);
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-12 15:01:03
