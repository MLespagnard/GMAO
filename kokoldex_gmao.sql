-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: mysql-kokoldex.alwaysdata.net
-- Generation Time: Jul 05, 2024 at 02:23 PM
-- Server version: 10.6.16-MariaDB
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kokoldex_gmao`
--

-- --------------------------------------------------------

--
-- Table structure for table `bt`
--

CREATE TABLE `bt` (
  `BT_ID` int(11) NOT NULL,
  `BT_NUMERO` varchar(15) NOT NULL,
  `BT_MOTIF` varchar(50) NOT NULL,
  `BT_INTITULE` varchar(50) NOT NULL,
  `BT_CREATEUR` varchar(50) NOT NULL,
  `BT_NOM_ECOLE` varchar(50) NOT NULL,
  `BT_EQUIPEMENT_CONCERNE` varchar(50) NOT NULL,
  `BT_PIECE_RECHANGE` varchar(200) NOT NULL,
  `BT_HEURE_EQUIPEMENT` int(6) NOT NULL,
  `BT_TRAVAIL_REALISER` varchar(200) NOT NULL COMMENT 'Ex: lubrifier le moteur	',
  `BT_COMMENTAIRE_INTERVENANT` varchar(200) NOT NULL,
  `BT_NOM_INTERVENANT` varchar(30) NOT NULL,
  `BT_TEMPS_TRAVAIL` int(11) NOT NULL,
  `STATUS` varchar(50) NOT NULL DEFAULT 'En attente',
  `BT_DATE_REALISATION` varchar(30) NOT NULL,
  `archiver` int(1) NOT NULL DEFAULT 0,
  `DATE_CREATION` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `bt`
--

INSERT INTO `bt` (`BT_ID`, `BT_NUMERO`, `BT_MOTIF`, `BT_INTITULE`, `BT_CREATEUR`, `BT_NOM_ECOLE`, `BT_EQUIPEMENT_CONCERNE`, `BT_PIECE_RECHANGE`, `BT_HEURE_EQUIPEMENT`, `BT_TRAVAIL_REALISER`, `BT_COMMENTAIRE_INTERVENANT`, `BT_NOM_INTERVENANT`, `BT_TEMPS_TRAVAIL`, `STATUS`, `BT_DATE_REALISATION`, `archiver`, `DATE_CREATION`) VALUES
(185, 'PR2024-0001', 'Préventif', 'Lubrification', 'Lespagnard Maximilien', '', 'Bande transporteuse', 'Vérin=1', 0, 'Lubrification sur le moteur', '', 'Goerge Daivd', 0, 'En attente', '', 0, '2024-06-18 08:11:55');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `name` varchar(15) NOT NULL,
  `age` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`name`, `age`) VALUES
('test', 17);

-- --------------------------------------------------------

--
-- Table structure for table `equipements`
--

CREATE TABLE `equipements` (
  `EQUIP_ID` int(11) NOT NULL,
  `EQUIP_NOM` varchar(60) NOT NULL,
  `EQUIP_CONSTRUCTEUR` varchar(60) NOT NULL,
  `EQUIP_MODEL` varchar(60) NOT NULL,
  `EQUIP_TEMPS_USURE` int(11) NOT NULL,
  `DATE_AJOUT` datetime NOT NULL DEFAULT current_timestamp(),
  `archiver` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `equipements`
--

INSERT INTO `equipements` (`EQUIP_ID`, `EQUIP_NOM`, `EQUIP_CONSTRUCTEUR`, `EQUIP_MODEL`, `EQUIP_TEMPS_USURE`, `DATE_AJOUT`, `archiver`) VALUES
(21, 'Test', 'test', 'Test', 4, '2024-05-27 10:52:53', 1),
(22, 'Bande transporteuse', '4QM 2023-2024', '4QM001', 2623, '2024-06-18 08:09:04', 1);

-- --------------------------------------------------------

--
-- Table structure for table `piece_de_rechange`
--

CREATE TABLE `piece_de_rechange` (
  `PR_ID` int(11) NOT NULL,
  `PR_NOM` varchar(50) NOT NULL,
  `PR_CONSTRUCTEUR` varchar(50) NOT NULL,
  `PR_REF_CONSTRUCTEUR` varchar(50) NOT NULL,
  `PR_FOURNISSEUR` varchar(50) NOT NULL,
  `PR_REF_FOURNISSEUR` int(15) NOT NULL,
  `PR_STOCK_MINI` int(5) NOT NULL,
  `PR_STOCK_MAX` int(5) NOT NULL,
  `PR_STOCK_ACTUEL` int(5) NOT NULL,
  `archiver` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `piece_de_rechange`
--

INSERT INTO `piece_de_rechange` (`PR_ID`, `PR_NOM`, `PR_CONSTRUCTEUR`, `PR_REF_CONSTRUCTEUR`, `PR_FOURNISSEUR`, `PR_REF_FOURNISSEUR`, `PR_STOCK_MINI`, `PR_STOCK_MAX`, `PR_STOCK_ACTUEL`, `archiver`) VALUES
(45, 'test', 'test', '1', 'test', 11, 1, 4, 0, 1),
(46, 'Vérin', 'Festo', 'ADNGF-20-50-P-A', 'Imes', 445227, 1, 5, 0, 0);

--
-- Triggers `piece_de_rechange`
--
DELIMITER $$
CREATE TRIGGER `before_update_stock` BEFORE UPDATE ON `piece_de_rechange` FOR EACH ROW BEGIN
    IF NEW.PR_STOCK_ACTUEL < 0 OR NEW.PR_STOCK_ACTUEL > NEW.PR_STOCK_MAX THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'La mise à jour est interdite : Le stock actuel doit être compris entre 0 et le stock maximum';
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `USER_ID` int(11) NOT NULL,
  `USER_TYPE` int(100) NOT NULL,
  `USER_LAST_NAME` varchar(255) NOT NULL,
  `USER_FIRST_NAME` varchar(50) NOT NULL,
  `USER_ID_CONNECTION` varchar(255) NOT NULL,
  `USER_PASSWORD` varchar(100) NOT NULL,
  `archiver` int(1) NOT NULL DEFAULT 0,
  `DATE_AJOUT` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`USER_ID`, `USER_TYPE`, `USER_LAST_NAME`, `USER_FIRST_NAME`, `USER_ID_CONNECTION`, `USER_PASSWORD`, `archiver`, `DATE_AJOUT`) VALUES
(54, 3, 'Maximilien', 'Lespagnard', 'm', 'm', 0, '2024-05-20'),
(55, 1, 'Arthur', 'Lea', 'aaaaaa', 'ZZZZZ', 1, '2024-06-17'),
(56, 1, 'Daivd', 'Goerge', 'daigoe', '111', 0, '2024-06-17'),
(57, 1, 'Jones', 'Harry', 'jonhar', '111', 0, '2024-06-17'),
(58, 1, 'Benoit', 'Laurent', 'benlau', 'cardijn', 0, '2024-06-18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bt`
--
ALTER TABLE `bt`
  ADD PRIMARY KEY (`BT_ID`);

--
-- Indexes for table `equipements`
--
ALTER TABLE `equipements`
  ADD PRIMARY KEY (`EQUIP_ID`);

--
-- Indexes for table `piece_de_rechange`
--
ALTER TABLE `piece_de_rechange`
  ADD PRIMARY KEY (`PR_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`USER_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bt`
--
ALTER TABLE `bt`
  MODIFY `BT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=186;

--
-- AUTO_INCREMENT for table `equipements`
--
ALTER TABLE `equipements`
  MODIFY `EQUIP_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `piece_de_rechange`
--
ALTER TABLE `piece_de_rechange`
  MODIFY `PR_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `USER_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
