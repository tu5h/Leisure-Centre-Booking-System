-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bookingsystem
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `bookings`
--

DROP TABLE IF EXISTS `bookings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bookings` (
  `BookingID` int NOT NULL AUTO_INCREMENT,
  `UserID` int DEFAULT NULL,
  `ActivityID` int DEFAULT NULL,
  `Date` date NOT NULL,
  `StartTime` time NOT NULL,
  `EndTime` time NOT NULL,
  `TotalCost` decimal(10,0) DEFAULT '0',
  `CentreID` int NOT NULL,
  PRIMARY KEY (`BookingID`),
  KEY `ActivityID` (`ActivityID`),
  KEY `centreID_idx` (`CentreID`),
  KEY `bookings_1` (`UserID`),
  CONSTRAINT `bookings_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `bookings_ibfk_3` FOREIGN KEY (`ActivityID`) REFERENCES `activity` (`ActivityID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=158 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci KEY_BLOCK_SIZE=1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookings`
--

LOCK TABLES `bookings` WRITE;
/*!40000 ALTER TABLE `bookings` DISABLE KEYS */;
INSERT INTO `bookings` VALUES (1,NULL,2,'2024-02-04','14:00:00','15:00:00',NULL,1),(2,NULL,1,'2024-01-09','15:00:00','16:00:00',NULL,0),(7,9,2,'2024-02-04','14:00:00','15:00:00',0,1),(8,9,2,'2024-02-04','15:00:00','16:00:00',0,1),(9,1,2,'2024-02-04','16:00:00','17:00:00',0,1),(10,1,2,'2024-02-04','18:00:00','19:00:00',0,1),(11,1,1,'2024-02-07','15:00:00','16:00:00',0,1),(12,1,1,'2024-02-08','12:00:00','13:00:00',0,1),(13,1,2,'2024-02-09','09:00:00','10:00:00',0,1),(14,1,2,'2024-02-09','09:00:00','10:00:00',0,1),(15,1,2,'2024-02-09','09:00:00','10:00:00',0,1),(16,1,1,'2024-02-16','11:00:00','12:00:00',0,1),(17,1,1,'2024-02-16','11:00:00','12:00:00',0,1),(18,1,1,'2024-02-16','11:00:00','12:00:00',0,1),(19,1,1,'2024-02-16','12:00:00','13:00:00',0,1),(20,1,1,'2024-02-16','12:00:00','13:00:00',0,1),(21,1,4,'2024-02-17','19:00:00','21:00:00',0,1),(22,1,5,'2024-02-18','19:00:00','21:00:00',0,1),(24,1,4,'2024-02-18','13:00:00','15:00:00',0,1),(27,1,1,'2024-02-18','20:00:00','21:00:00',0,1),(28,1,1,'2024-02-18','09:00:00','10:00:00',0,1),(33,1,4,'2024-02-18','15:00:00','17:00:00',0,1),(42,1,1,'2024-02-23','11:00:00','12:00:00',0,-1),(43,1,2,'2024-02-15','10:00:00','11:00:00',0,1),(44,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(45,1,1,'2024-02-18','09:00:00','10:00:00',0,1),(46,1,1,'2024-02-18','09:00:00','10:00:00',0,1),(47,1,1,'2024-02-18','09:00:00','10:00:00',0,1),(48,1,1,'2024-03-01','11:00:00','12:00:00',0,1),(49,1,1,'2024-03-08','11:00:00','12:00:00',0,1),(50,1,1,'2024-02-01','11:00:00','12:00:00',0,1),(51,1,1,'2024-02-08','11:00:00','12:00:00',0,1),(52,1,5,'2024-02-18','19:00:00','21:00:00',0,2),(53,1,6,'2024-02-19','09:00:00','10:00:00',0,1),(54,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(55,1,1,'2024-02-25','10:00:00','11:00:00',0,1),(56,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(57,1,1,'2024-02-25','10:00:00','11:00:00',0,1),(58,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(59,1,1,'2024-02-25','10:00:00','11:00:00',0,1),(60,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(61,1,1,'2024-02-25','10:00:00','11:00:00',0,1),(62,1,1,'2024-02-18','10:00:00','11:00:00',0,1),(63,1,1,'2024-02-25','10:00:00','11:00:00',0,1),(64,1,1,'2024-01-18','10:00:00','11:00:00',0,1),(65,1,1,'2024-01-25','10:00:00','11:00:00',0,1),(66,1,1,'2024-01-03','10:00:00','11:00:00',0,1),(67,1,1,'2024-01-10','10:00:00','11:00:00',0,1),(68,1,1,'2024-02-18','15:00:00','16:00:00',0,1),(69,1,1,'2024-02-18','14:00:00','15:00:00',0,1),(70,1,1,'2024-02-18','13:00:00','14:00:00',0,1),(71,1,1,'2024-02-18','12:00:00','13:00:00',0,1),(72,1,1,'2024-02-18','11:00:00','12:00:00',0,1),(73,1,1,'2024-02-18','16:00:00','17:00:00',0,1),(74,1,1,'2024-02-18','18:00:00','19:00:00',0,1),(75,1,2,'2024-02-18','14:00:00','15:00:00',0,2),(77,1,1,'2024-02-19','14:00:00','15:00:00',0,1),(78,1,2,'2024-02-18','14:00:00','15:00:00',0,2),(79,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(80,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(81,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(84,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(85,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(86,11,1,'2024-02-19','14:00:00','15:00:00',0,2),(87,1,6,'2024-02-19','14:00:00','15:00:00',0,1),(88,11,2,'2024-02-19','10:00:00','11:00:00',0,1),(89,11,2,'2024-02-26','10:00:00','11:00:00',0,1),(90,11,2,'2024-02-19','10:00:00','11:00:00',0,1),(91,11,2,'2024-02-26','10:00:00','11:00:00',0,1),(92,1,1,'2024-02-19','16:00:00','17:00:00',0,1),(93,1,1,'2024-02-26','16:00:00','17:00:00',0,1),(94,1,1,'2024-03-04','16:00:00','17:00:00',0,1),(95,1,1,'2024-03-11','16:00:00','17:00:00',0,1),(96,1,1,'2024-02-19','16:00:00','17:00:00',0,1),(97,1,1,'2024-02-26','16:00:00','17:00:00',0,1),(98,1,1,'2024-03-04','16:00:00','17:00:00',0,1),(99,1,1,'2024-03-11','16:00:00','17:00:00',0,1),(100,1,1,'2024-02-12','12:00:00','13:00:00',0,1),(101,1,1,'2024-02-19','12:00:00','13:00:00',0,1),(102,1,1,'2024-02-20','13:00:00','14:00:00',0,1),(103,1,1,'2024-02-20','14:00:00','15:00:00',0,1),(104,13,1,'2024-02-22','16:00:00','17:00:00',0,1),(105,13,4,'2024-02-21','09:00:00','11:00:00',0,1),(108,13,6,'2024-02-21','09:00:00','10:00:00',0,1),(109,13,1,'2024-03-02','10:00:00','11:00:00',0,1),(110,13,1,'2024-03-09','10:00:00','11:00:00',0,1),(111,13,1,'2024-03-02','10:00:00','11:00:00',0,1),(112,13,1,'2024-03-09','10:00:00','11:00:00',0,1),(113,1,1,'2024-02-21','14:00:00','15:00:00',0,1),(114,1,1,'2024-02-21','16:00:00','17:00:00',0,1),(115,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(116,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(117,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(118,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(119,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(120,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(121,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(122,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(123,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(124,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(125,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(126,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(127,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(128,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(129,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(130,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(131,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(132,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(133,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(134,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(135,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(136,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(137,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(138,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(139,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(140,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(141,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(142,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(143,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(144,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(145,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(146,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(147,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(148,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(149,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(150,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(151,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(152,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(153,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(154,1,3,'2024-02-23','13:00:00','14:00:00',0,1),(155,1,3,'2024-03-01','13:00:00','14:00:00',0,1),(156,1,3,'2024-03-08','13:00:00','14:00:00',0,1),(157,1,2,'2024-02-23','16:00:00','17:00:00',0,1);
/*!40000 ALTER TABLE `bookings` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-08 21:40:28
