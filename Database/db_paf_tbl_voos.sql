-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_paf
-- ------------------------------------------------------
-- Server version	8.0.42

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
-- Table structure for table `tbl_voos`
--

DROP TABLE IF EXISTS `tbl_voos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_voos` (
  `voo_id` int NOT NULL AUTO_INCREMENT,
  `numero_voo` varchar(5) DEFAULT NULL,
  `cidade_destino` varchar(50) DEFAULT NULL,
  `aeroporto_partida` int DEFAULT NULL,
  `aeroporto_destino` int DEFAULT NULL,
  `data_partida` date DEFAULT NULL,
  `data_chegada` date DEFAULT NULL,
  `preco_voo` int DEFAULT NULL,
  `aeronave_fk` int DEFAULT NULL,
  PRIMARY KEY (`voo_id`),
  KEY `aeroporto_partida` (`aeroporto_partida`),
  KEY `aeroporto_destino` (`aeroporto_destino`),
  KEY `aeronave_fk` (`aeronave_fk`),
  CONSTRAINT `tbl_voos_ibfk_1` FOREIGN KEY (`aeroporto_partida`) REFERENCES `tbl_aeroportos` (`aeroporto_id`),
  CONSTRAINT `tbl_voos_ibfk_2` FOREIGN KEY (`aeroporto_destino`) REFERENCES `tbl_aeroportos` (`aeroporto_id`),
  CONSTRAINT `tbl_voos_ibfk_3` FOREIGN KEY (`aeronave_fk`) REFERENCES `tbl_aeronaves` (`aeronave_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-15 17:54:52
