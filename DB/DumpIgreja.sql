CREATE DATABASE  IF NOT EXISTS `db_igreja` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_igreja`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: db_igreja
-- ------------------------------------------------------
-- Server version	5.7.14

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
-- Table structure for table `atos`
--

DROP TABLE IF EXISTS `atos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `atos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_tipo_ato` int(11) DEFAULT NULL,
  `descricao` longtext,
  `id_user` int(11) DEFAULT NULL,
  `data_atual` date DEFAULT NULL,
  `data_marcada` date DEFAULT NULL,
  `estado` enum('pendente','realizada') DEFAULT 'pendente',
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`),
  KEY `id_tipo_ato` (`id_tipo_ato`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `caixa`
--

DROP TABLE IF EXISTS `caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caixa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_dados_culto` int(11) DEFAULT NULL,
  `valor` decimal(11,2) DEFAULT '0.00',
  PRIMARY KEY (`id`),
  KEY `id_dados_culto` (`id_dados_culto`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cargos`
--

DROP TABLE IF EXISTS `cargos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cargos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nome` (`nome`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cargos_membros`
--

DROP TABLE IF EXISTS `cargos_membros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cargos_membros` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_membro` int(11) DEFAULT NULL,
  `id_cargo` int(11) DEFAULT NULL,
  `data_inicio` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_membro` (`id_membro`),
  KEY `id_cargo` (`id_cargo`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contactos`
--

DROP TABLE IF EXISTS `contactos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contactos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_membro` int(11) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_membro` (`id_membro`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cultos`
--

DROP TABLE IF EXISTS `cultos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cultos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_membro` int(11) DEFAULT NULL,
  `tema` varchar(50) NOT NULL,
  `livro` varchar(50) DEFAULT NULL,
  `capitulo` varchar(50) DEFAULT NULL,
  `data_c` date DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_membro` (`id_membro`),
  KEY `id_user` (`id_user`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger tg_add_dados_culto after insert on cultos for each row 
begin
call sp_dados_culto (0, new.id, 0, 0, 0, 0, 0, 0);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `dados_culto`
--

DROP TABLE IF EXISTS `dados_culto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dados_culto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_culto` int(11) DEFAULT NULL,
  `num_homens` int(11) DEFAULT '0',
  `num_mulheres` int(11) DEFAULT '0',
  `num_adolescentes` int(11) DEFAULT '0',
  `num_criancas` int(11) DEFAULT '0',
  `oferta` decimal(11,2) DEFAULT '0.00',
  `dizimo` decimal(11,2) DEFAULT '0.00',
  PRIMARY KEY (`id`),
  KEY `id_culto` (`id_culto`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger tg_insert_caixa after insert on dados_culto for each row 
begin
declare total int default (select (oferta+dizimo) from dados_culto where id=new.id);
insert into caixa values (default,new.id,total);
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 trigger tg_update_caixa after update on dados_culto for each row 
begin
-- declare total int default (select (oferta+dizimo) from dados_culto where id=old.id);
update caixa set valor=(select (oferta+dizimo) from dados_culto where id=old.id) where caixa.id_dados_culto=old.id;
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `membros`
--

DROP TABLE IF EXISTS `membros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `membros` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bi` varchar(50) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `apelido` varchar(50) DEFAULT NULL,
  `pai` varchar(100) DEFAULT NULL,
  `mae` varchar(100) DEFAULT NULL,
  `sexo` enum('M','F') NOT NULL,
  `data_n` date DEFAULT NULL,
  `estado_civil` varchar(50) NOT NULL,
  `residencia` varchar(100) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `imagem` longblob,
  `nome_usuario` varchar(50) DEFAULT NULL,
  `senha` varchar(20) DEFAULT NULL,
  `acesso` enum('nenhum','admin','normal') DEFAULT NULL,
  `batizado` enum('sim','não') DEFAULT 'não',
  `estado` enum('associado','desassociado') DEFAULT 'associado',
  PRIMARY KEY (`id`),
  UNIQUE KEY `bi` (`bi`),
  KEY `membros_nome` (`nome`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `saidas`
--

DROP TABLE IF EXISTS `saidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saidas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` longtext,
  `valor` decimal(11,2) DEFAULT '0.00',
  `data_atual` date DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tipo_atos`
--

DROP TABLE IF EXISTS `tipo_atos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_atos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nome` (`nome`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Temporary view structure for view `vw_actividades`
--

DROP TABLE IF EXISTS `vw_actividades`;
/*!50001 DROP VIEW IF EXISTS `vw_actividades`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_actividades` AS SELECT 
 1 AS `Id`,
 1 AS `Tipo`,
 1 AS `descricao`,
 1 AS `data_atual`,
 1 AS `data_marcada`,
 1 AS `estado`,
 1 AS `usuario`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_cultos`
--

DROP TABLE IF EXISTS `vw_cultos`;
/*!50001 DROP VIEW IF EXISTS `vw_cultos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_cultos` AS SELECT 
 1 AS `Id`,
 1 AS `Pregador`,
 1 AS `Tema`,
 1 AS `Livro`,
 1 AS `capitulo`,
 1 AS `Membros`,
 1 AS `Data`,
 1 AS `usuario`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_entradas`
--

DROP TABLE IF EXISTS `vw_entradas`;
/*!50001 DROP VIEW IF EXISTS `vw_entradas`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_entradas` AS SELECT 
 1 AS `Id`,
 1 AS `Oferta`,
 1 AS `Dizimo`,
 1 AS `Total`,
 1 AS `data_c`,
 1 AS `Registado_por`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_estatistica_entradas_mes`
--

DROP TABLE IF EXISTS `vw_estatistica_entradas_mes`;
/*!50001 DROP VIEW IF EXISTS `vw_estatistica_entradas_mes`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_estatistica_entradas_mes` AS SELECT 
 1 AS `id`,
 1 AS `Ofertas`,
 1 AS `Dizimo`,
 1 AS `Total`,
 1 AS `mes`,
 1 AS `Ano`,
 1 AS `tot_ofertas`,
 1 AS `tot_dizimo`,
 1 AS `Tot_geral`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_estatistica_entradas_saidas`
--

DROP TABLE IF EXISTS `vw_estatistica_entradas_saidas`;
/*!50001 DROP VIEW IF EXISTS `vw_estatistica_entradas_saidas`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_estatistica_entradas_saidas` AS SELECT 
 1 AS `id`,
 1 AS `Tot_Entradas`,
 1 AS `Tot_Saidas`,
 1 AS `Total`,
 1 AS `mes`,
 1 AS `Ano`,
 1 AS `total_entrada`,
 1 AS `total_saida`,
 1 AS `caixa`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_estatistica_membros`
--

DROP TABLE IF EXISTS `vw_estatistica_membros`;
/*!50001 DROP VIEW IF EXISTS `vw_estatistica_membros`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_estatistica_membros` AS SELECT 
 1 AS `Tot_mebros`,
 1 AS `Tot_criancas`,
 1 AS `Tot_adolscentes`,
 1 AS `Tot_adultos`,
 1 AS `Tot_masculinos`,
 1 AS `Tot_femininos`,
 1 AS `Tot_associado`,
 1 AS `Tot_desassociado`,
 1 AS `Tot_batizados`,
 1 AS `Tot_nh_batizados`,
 1 AS `Tot_casados`,
 1 AS `Tot_solteiros`,
 1 AS `Tot_viuvos`,
 1 AS `Tot_usuarios`,
 1 AS `first`,
 1 AS `second`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_membros`
--

DROP TABLE IF EXISTS `vw_membros`;
/*!50001 DROP VIEW IF EXISTS `vw_membros`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_membros` AS SELECT 
 1 AS `ID`,
 1 AS `BI`,
 1 AS `Nome`,
 1 AS `Apelido`,
 1 AS `Pai`,
 1 AS `Mae`,
 1 AS `Sexo`,
 1 AS `Idade`,
 1 AS `data_n`,
 1 AS `Aniversario`,
 1 AS `estado_civil`,
 1 AS `Residencia`,
 1 AS `Email`,
 1 AS `Acesso`,
 1 AS `Tel1`,
 1 AS `Tel2`,
 1 AS `Estado`,
 1 AS `batizado`,
 1 AS `nome_usuario`,
 1 AS `imagem`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_saidas`
--

DROP TABLE IF EXISTS `vw_saidas`;
/*!50001 DROP VIEW IF EXISTS `vw_saidas`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_saidas` AS SELECT 
 1 AS `Id`,
 1 AS `id_user`,
 1 AS `descricao`,
 1 AS `Valor`,
 1 AS `data_atual`,
 1 AS `registado_por`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'db_igreja'
--

--
-- Final view structure for view `vw_actividades`
--

/*!50001 DROP VIEW IF EXISTS `vw_actividades`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_actividades` AS select `a`.`id` AS `Id`,`ta`.`nome` AS `Tipo`,`a`.`descricao` AS `descricao`,`a`.`data_atual` AS `data_atual`,`a`.`data_marcada` AS `data_marcada`,`a`.`estado` AS `estado`,`m`.`nome` AS `usuario` from ((`atos` `a` join `tipo_atos` `ta` on((`ta`.`id` = `a`.`id_tipo_ato`))) join `membros` `m` on((`m`.`id` = `a`.`id_user`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_cultos`
--

/*!50001 DROP VIEW IF EXISTS `vw_cultos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_cultos` AS select `c`.`id` AS `Id`,`m1`.`nome` AS `Pregador`,`c`.`tema` AS `Tema`,`c`.`livro` AS `Livro`,`c`.`capitulo` AS `capitulo`,(((`dc`.`num_homens` + `dc`.`num_mulheres`) + `dc`.`num_criancas`) + `dc`.`num_adolescentes`) AS `Membros`,`c`.`data_c` AS `Data`,`m2`.`nome` AS `usuario` from (((`cultos` `c` join `membros` `m1` on((`m1`.`id` = `c`.`id_membro`))) join `membros` `m2` on((`m2`.`id` = `c`.`id_user`))) join `dados_culto` `dc` on((`c`.`id` = `dc`.`id_culto`))) order by `c`.`id` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_entradas`
--

/*!50001 DROP VIEW IF EXISTS `vw_entradas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_entradas` AS select `c`.`id` AS `Id`,`dc`.`oferta` AS `Oferta`,`dc`.`dizimo` AS `Dizimo`,(`dc`.`oferta` + `dc`.`dizimo`) AS `Total`,`c`.`data_c` AS `data_c`,`m`.`nome` AS `Registado_por` from ((`dados_culto` `dc` join `cultos` `c` on((`c`.`id` = `dc`.`id_culto`))) join `membros` `m` on((`m`.`id` = `c`.`id_user`))) where ((`dc`.`oferta` <> 0) or (`dc`.`dizimo` <> 0)) order by `dc`.`id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_estatistica_entradas_mes`
--

/*!50001 DROP VIEW IF EXISTS `vw_estatistica_entradas_mes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_estatistica_entradas_mes` AS select `vw1`.`Id` AS `id`,(select sum(`e1`.`Oferta`) from `vw_entradas` `e1` where ((year(`e1`.`data_c`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_c`) = month(`vw1`.`data_c`)))) AS `Ofertas`,(select sum(`e1`.`Dizimo`) from `vw_entradas` `e1` where ((year(`e1`.`data_c`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_c`) = month(`vw1`.`data_c`)))) AS `Dizimo`,(select sum(`e1`.`Total`) from `vw_entradas` `e1` where ((year(`e1`.`data_c`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_c`) = month(`vw1`.`data_c`)))) AS `Total`,`fn_say_month`(month(`vw1`.`data_c`)) AS `mes`,year(`vw1`.`data_c`) AS `Ano`,(select sum(`vw_entradas`.`Oferta`) from `vw_entradas`) AS `tot_ofertas`,(select sum(`vw_entradas`.`Dizimo`) from `vw_entradas`) AS `tot_dizimo`,(select sum((`vw_entradas`.`Dizimo` + `vw_entradas`.`Oferta`)) from `vw_entradas`) AS `Tot_geral` from `vw_entradas` `vw1` order by month(`vw1`.`data_c`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_estatistica_entradas_saidas`
--

/*!50001 DROP VIEW IF EXISTS `vw_estatistica_entradas_saidas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_estatistica_entradas_saidas` AS select `vw1`.`Id` AS `id`,(select sum(`e1`.`Total`) from `vw_entradas` `e1` where ((year(`e1`.`data_c`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_c`) = month(`vw1`.`data_c`)))) AS `Tot_Entradas`,(case when isnull((select sum(`e1`.`Valor`) from `vw_saidas` `e1` where ((year(`e1`.`data_atual`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_atual`) = month(`vw1`.`data_c`))))) then 0 else (select sum(`e1`.`Valor`) from `vw_saidas` `e1` where ((year(`e1`.`data_atual`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_atual`) = month(`vw1`.`data_c`)))) end) AS `Tot_Saidas`,((select sum(`e1`.`Total`) from `vw_entradas` `e1` where ((year(`e1`.`data_c`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_c`) = month(`vw1`.`data_c`)))) + (case when isnull((select sum(`e1`.`Valor`) from `vw_saidas` `e1` where ((year(`e1`.`data_atual`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_atual`) = month(`vw1`.`data_c`))))) then 0 else (select sum(`e1`.`Valor`) from `vw_saidas` `e1` where ((year(`e1`.`data_atual`) = year(`vw1`.`data_c`)) and (month(`e1`.`data_atual`) = month(`vw1`.`data_c`)))) end)) AS `Total`,`fn_say_month`(month(`vw1`.`data_c`)) AS `mes`,year(`vw1`.`data_c`) AS `Ano`,(select sum(`caixa`.`valor`) from `caixa`) AS `total_entrada`,(select sum(`vw_saidas`.`Valor`) from `vw_saidas`) AS `total_saida`,(select ((select sum(`vw_entradas`.`Total`) from `vw_entradas`) - (select sum(`vw_saidas`.`Valor`) from `vw_saidas`))) AS `caixa` from `vw_entradas` `vw1` order by month(`vw1`.`data_c`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_estatistica_membros`
--

/*!50001 DROP VIEW IF EXISTS `vw_estatistica_membros`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_estatistica_membros` AS select (select count(0) from `vw_membros`) AS `Tot_mebros`,(select count(0) from `vw_membros` where (`vw_membros`.`Idade` <= 12)) AS `Tot_criancas`,(select count(0) from `vw_membros` where ((`vw_membros`.`Idade` >= 13) and (`vw_membros`.`Idade` <= 18))) AS `Tot_adolscentes`,(select count(0) from `vw_membros` where (`vw_membros`.`Idade` >= 19)) AS `Tot_adultos`,(select count(0) from `vw_membros` where (`vw_membros`.`Sexo` = 'M')) AS `Tot_masculinos`,(select count(0) from `vw_membros` where (`vw_membros`.`Sexo` = 'F')) AS `Tot_femininos`,(select count(0) from `vw_membros` where (`vw_membros`.`Estado` = 'associado')) AS `Tot_associado`,(select count(0) from `vw_membros` where (`vw_membros`.`Estado` = 'desassociado')) AS `Tot_desassociado`,(select count(0) from `vw_membros` where (`vw_membros`.`batizado` = 'sim')) AS `Tot_batizados`,(select count(0) from `vw_membros` where (`vw_membros`.`batizado` = 'não')) AS `Tot_nh_batizados`,(select count(0) from `vw_membros` where (`vw_membros`.`estado_civil` = 'casado')) AS `Tot_casados`,(select count(0) from `vw_membros` where (`vw_membros`.`estado_civil` = 'solteiro')) AS `Tot_solteiros`,(select count(0) from `vw_membros` where (`vw_membros`.`estado_civil` = 'Viúvo')) AS `Tot_viuvos`,(select count(0) from `vw_membros` where (`vw_membros`.`nome_usuario` is not null)) AS `Tot_usuarios`,'first' AS `first`,'second' AS `second` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_membros`
--

/*!50001 DROP VIEW IF EXISTS `vw_membros`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_membros` AS select `membros`.`id` AS `ID`,`membros`.`bi` AS `BI`,`membros`.`nome` AS `Nome`,`membros`.`apelido` AS `Apelido`,`membros`.`pai` AS `Pai`,`membros`.`mae` AS `Mae`,`membros`.`sexo` AS `Sexo`,((year(curdate()) - year(`membros`.`data_n`)) - (right(curdate(),5) < right(`membros`.`data_n`,5))) AS `Idade`,`membros`.`data_n` AS `data_n`,right(`membros`.`data_n`,5) AS `Aniversario`,`membros`.`estado_civil` AS `estado_civil`,`membros`.`residencia` AS `Residencia`,`membros`.`email` AS `Email`,`membros`.`acesso` AS `Acesso`,(select `contactos`.`numero` from `contactos` where (`contactos`.`id_membro` = `membros`.`id`) limit 1) AS `Tel1`,(select `contactos`.`numero` from `contactos` where (`contactos`.`id_membro` = `membros`.`id`) order by `contactos`.`id` desc limit 1) AS `Tel2`,`membros`.`estado` AS `Estado`,`membros`.`batizado` AS `batizado`,`membros`.`nome_usuario` AS `nome_usuario`,`membros`.`imagem` AS `imagem` from `membros` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_saidas`
--

/*!50001 DROP VIEW IF EXISTS `vw_saidas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_saidas` AS select `s`.`id` AS `Id`,`s`.`id_user` AS `id_user`,`s`.`descricao` AS `descricao`,`s`.`valor` AS `Valor`,`s`.`data_atual` AS `data_atual`,`m`.`nome` AS `registado_por` from (`saidas` `s` join `membros` `m` on((`m`.`id` = `s`.`id_user`))) */;
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

-- Dump completed on 2020-11-03 22:20:54
