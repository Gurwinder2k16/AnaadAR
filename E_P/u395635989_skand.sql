-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2017 at 12:00 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.0.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `u395635989_skand`
--

-- --------------------------------------------------------

--
-- Table structure for table `feed_back`
--

CREATE TABLE `feed_back` (
  `email` varchar(250) DEFAULT NULL,
  `feedback_mssg` varchar(250) DEFAULT NULL,
  `status` varchar(250) DEFAULT NULL,
  `reply_feed` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `feed_back`
--

INSERT INTO `feed_back` (`email`, `feedback_mssg`, `status`, `reply_feed`) VALUES
('ram@gmail.com', 'dhan guru nanak', 'none', 'false');

-- --------------------------------------------------------

--
-- Table structure for table `instruction`
--

CREATE TABLE `instruction` (
  `instr_field` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `instruction`
--

INSERT INTO `instruction` (`instr_field`) VALUES
('1) Registration is must for new user.\r\n2) Already Registered user login for playing game.\r\n3) Photography is not allowed.\r\n4) Entry of Field must be validate otherwise account is removed after verification.\r\n5) Any Compliant Regarding Application or content,Leave Message on Feedback.\r\n6) Please remove Head phones entering before Harimandir Sahib Parikarma.\r\n7) Use Head Phone in Heritage walk.\r\n8) Don\'t try to create crowd or indiscipline in Heritage walk and Harimandir Sahib.\r\n9) Make discipline and help to improve performance. ');

-- --------------------------------------------------------

--
-- Table structure for table `level_zone`
--

CREATE TABLE `level_zone` (
  `email` varchar(250) DEFAULT NULL,
  `compl_level` varchar(250) DEFAULT NULL,
  `point` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `level_zone`
--

INSERT INTO `level_zone` (`email`, `compl_level`, `point`) VALUES
('babananak@gmail.com', 'JALLIANWALABAGH', '1200'),
('pssahni@ymail.com', 'SACHKHAND HARIMANDIR SAHIB', '800'),
('demo@gmail.com', 'SANTOKH SAR SAHIB', '700'),
('harjeepannu@gmail.com', 'SANTOKH SAR SAHIB', '200');

-- --------------------------------------------------------

--
-- Table structure for table `user_login`
--

CREATE TABLE `user_login` (
  `email` varchar(250) NOT NULL,
  `user_name` varchar(250) DEFAULT NULL,
  `status` varchar(250) DEFAULT NULL,
  `block` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_login`
--

INSERT INTO `user_login` (`email`, `user_name`, `status`, `block`) VALUES
('babananak@gmail.com', 'babananak', 'none', 'false'),
('demo@gmail.com', 'demo', 'none', 'false'),
('hargobind@gmail.com', 'hargobind', 'none', 'false'),
('harjeepannu@gmail.com', 'nachatar', 'none', 'false'),
('mocgurwinder@gmail.com', 'Sumit Chawla', 'none', 'false'),
('pssahni@ymail.com', 'pssahni', 'none', 'false'),
('ram@gmail.com', 'ram', 'none', 'false'),
('singh@gmail.com', 'singh', 'none', 'false');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_login`
--
ALTER TABLE `user_login`
  ADD PRIMARY KEY (`email`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
