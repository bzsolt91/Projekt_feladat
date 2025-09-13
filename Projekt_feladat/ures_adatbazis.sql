-- MySQL dump 10.13  Distrib 9.1.0, for Win64 (x86_64)
--
-- Host: localhost    Database: utazast_kezelo
-- ------------------------------------------------------
-- Server version	9.1.0

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
-- Table structure for table `cim`
--

DROP TABLE IF EXISTS `cim`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cim` (
  `cim_id` int NOT NULL AUTO_INCREMENT,
  `utas_id` int NOT NULL,
  `email_cim` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  `lakcim` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`cim_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cim`
--

LOCK TABLES `cim` WRITE;
/*!40000 ALTER TABLE `cim` DISABLE KEYS */;
/*!40000 ALTER TABLE `cim` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `elofoglalas`
--

DROP TABLE IF EXISTS `elofoglalas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `elofoglalas` (
  `elofoglalas_id` int NOT NULL AUTO_INCREMENT,
  `teljes_nev` varchar(100) COLLATE utf16_hungarian_ci NOT NULL,
  `telefon` varchar(20) COLLATE utf16_hungarian_ci NOT NULL,
  `email` varchar(100) COLLATE utf16_hungarian_ci NOT NULL,
  `lakcim` varchar(255) COLLATE utf16_hungarian_ci NOT NULL,
  `regisztracio_idopont` datetime NOT NULL,
  `utazas_id` int NOT NULL,
  `allapot` enum('érdeklődik','foglalva','lemondva') COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`elofoglalas_id`),
  KEY `utazas_id` (`utazas_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `elofoglalas`
--

LOCK TABLES `elofoglalas` WRITE;
/*!40000 ALTER TABLE `elofoglalas` DISABLE KEYS */;
/*!40000 ALTER TABLE `elofoglalas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `felhasznalok`
--

DROP TABLE IF EXISTS `felhasznalok`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `felhasznalok` (
  `id` int NOT NULL AUTO_INCREMENT,
  `felhasznalonev` varchar(50) COLLATE utf8mb3_hungarian_ci NOT NULL,
  `jelszo` varchar(64) COLLATE utf8mb3_hungarian_ci NOT NULL,
  `jogosultsag` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `felhasznalok`
--

LOCK TABLES `felhasznalok` WRITE;
/*!40000 ALTER TABLE `felhasznalok` DISABLE KEYS */;
INSERT INTO `felhasznalok` VALUES (1,'operator','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',0),(2,'admin','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',1);
/*!40000 ALTER TABLE `felhasznalok` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fizetes`
--

DROP TABLE IF EXISTS `fizetes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fizetes` (
  `fizetes_id` int NOT NULL AUTO_INCREMENT,
  `utas_id` int NOT NULL,
  `befizetett_osszeg` int NOT NULL,
  `biztositas` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`fizetes_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fizetes`
--

LOCK TABLES `fizetes` WRITE;
/*!40000 ALTER TABLE `fizetes` DISABLE KEYS */;
/*!40000 ALTER TABLE `fizetes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lejarati_ertesitesek`
--

DROP TABLE IF EXISTS `lejarati_ertesitesek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lejarati_ertesitesek` (
  `utas_id` int DEFAULT NULL,
  `utas_nev` varchar(255) COLLATE utf8mb3_hungarian_ci DEFAULT NULL,
  `okmany_tipus` varchar(255) COLLATE utf8mb3_hungarian_ci DEFAULT NULL,
  `okmany_lejarat` date DEFAULT NULL,
  `ertesites_datuma` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lejarati_ertesitesek`
--

LOCK TABLES `lejarati_ertesitesek` WRITE;
/*!40000 ALTER TABLE `lejarati_ertesitesek` DISABLE KEYS */;
/*!40000 ALTER TABLE `lejarati_ertesitesek` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `lejaro_okmanyok`
--

DROP VIEW IF EXISTS lejaro_okmanyok;

CREATE ALGORITHM=UNDEFINED
SQL SECURITY INVOKER
VIEW lejaro_okmanyok AS
SELECT 
  u.titulus       AS `Titulus`,
  u.vezeteknev    AS `Vezetéknév`,
  u.keresztnev1   AS `Keresztnév`,
  s.szemelyi_vagy_utlevel AS `Okmány szám`,
  s.okmany_lejarat        AS `Okmány lejárat`
FROM utas u
JOIN szemelyi s ON s.utas_id = u.utas_id
WHERE s.okmany_lejarat IS NOT NULL
  AND s.okmany_lejarat <= DATE_ADD(CURDATE(), INTERVAL 3 MONTH)
ORDER BY s.okmany_lejarat;

--
-- Table structure for table `megjegyzes`
--

DROP TABLE IF EXISTS `megjegyzes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `megjegyzes` (
  `megjegyzes_id` int NOT NULL AUTO_INCREMENT,
  `utas_id` int NOT NULL,
  `megjegyzes` varchar(255) COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`megjegyzes_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `megjegyzes`
--

LOCK TABLES `megjegyzes` WRITE;
/*!40000 ALTER TABLE `megjegyzes` DISABLE KEYS */;
/*!40000 ALTER TABLE `megjegyzes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `szemelyi`
--

DROP TABLE IF EXISTS `szemelyi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `szemelyi` (
  `szemelyi_id` int NOT NULL AUTO_INCREMENT,
  `utas_id` int NOT NULL,
  `szemelyi_vagy_utlevel` varchar(50) COLLATE utf16_hungarian_ci NOT NULL,
  `okmany_lejarat` date NOT NULL,
  `allampolgarsag` varchar(50) COLLATE utf16_hungarian_ci NOT NULL DEFAULT 'magyar',
  PRIMARY KEY (`szemelyi_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `szemelyi`
--

LOCK TABLES `szemelyi` WRITE;
/*!40000 ALTER TABLE `szemelyi` DISABLE KEYS */;
/*!40000 ALTER TABLE `szemelyi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefon`
--

DROP TABLE IF EXISTS `telefon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefon` (
  `telefon_id` int NOT NULL AUTO_INCREMENT,
  `utas_id` int NOT NULL,
  `telefon` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`telefon_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefon`
--

LOCK TABLES `telefon` WRITE;
/*!40000 ALTER TABLE `telefon` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utas`
--

DROP TABLE IF EXISTS `utas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utas` (
  `utas_id` int NOT NULL AUTO_INCREMENT,
  `titulus` varchar(50) COLLATE utf16_hungarian_ci NOT NULL,
  `vezeteknev` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  `keresztnev1` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  `keresztnev2` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  `szuletesi_datum` date NOT NULL,
  PRIMARY KEY (`utas_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utas`
--

LOCK TABLES `utas` WRITE;
/*!40000 ALTER TABLE `utas` DISABLE KEYS */;
/*!40000 ALTER TABLE `utas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utas_utazasai`
--

DROP TABLE IF EXISTS `utas_utazasai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utas_utazasai` (
  `utas_id` int NOT NULL,
  `utazas_id` int NOT NULL,
  PRIMARY KEY (`utas_id`,`utazas_id`),
  KEY `utazas_id` (`utazas_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utas_utazasai`
--

LOCK TABLES `utas_utazasai` WRITE;
/*!40000 ALTER TABLE `utas_utazasai` DISABLE KEYS */;
/*!40000 ALTER TABLE `utas_utazasai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utazas`
--

DROP TABLE IF EXISTS `utazas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utazas` (
  `utazas_id` int NOT NULL AUTO_INCREMENT,
  `utazas_modja` enum('busz','repulő','hajó','egyéni') CHARACTER SET utf16 COLLATE utf16_hungarian_ci NOT NULL,
  `utazas_elnevezese` varchar(60) COLLATE utf16_hungarian_ci NOT NULL,
  `utazas_ideje` date NOT NULL,
  `desztinacio` varchar(50) COLLATE utf16_hungarian_ci NOT NULL,
  PRIMARY KEY (`utazas_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utazas`
--

LOCK TABLES `utazas` WRITE;
/*!40000 ALTER TABLE `utazas` DISABLE KEYS */;
/*!40000 ALTER TABLE `utazas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utazas_reszletek`
--

DROP TABLE IF EXISTS `utazas_reszletek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utazas_reszletek` (
  `utazas_id` int NOT NULL,
  `leiras` text COLLATE utf16_hungarian_ci NOT NULL,
  `indulasi_datum` date NOT NULL,
  `visszaindulas_datum` date NOT NULL,
  `ar` int NOT NULL,
  `indulasi_helyszin` varchar(100) COLLATE utf16_hungarian_ci NOT NULL,
  `boritokep` varchar(255) COLLATE utf16_hungarian_ci DEFAULT NULL,
  PRIMARY KEY (`utazas_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utazas_reszletek`
--

LOCK TABLES `utazas_reszletek` WRITE;
/*!40000 ALTER TABLE `utazas_reszletek` DISABLE KEYS */;
/*!40000 ALTER TABLE `utazas_reszletek` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `lejaro_okmanyok`
--

/*!50001 DROP VIEW IF EXISTS `lejaro_okmanyok`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `lejaro_okmanyok` AS select `u`.`titulus` AS `Titulus`,`u`.`vezeteknev` AS `Vezetéknév`,`u`.`keresztnev1` AS `Keresztnév`,`s`.`szemelyi_vagy_utlevel` AS `Okmány szám`,`s`.`okmany_lejarat` AS `Okmány lejárat` from (`utas` `u` join `szemelyi` `s` on((`u`.`utas_id` = `s`.`utas_id`))) where ((`s`.`okmany_lejarat` < curdate()) or (`s`.`okmany_lejarat` <= (curdate() + interval 3 month))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-09 14:02:45
