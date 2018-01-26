-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 23, 2018 at 03:01 PM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `the_athenaeum`
--

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

DROP TABLE IF EXISTS `author`;
CREATE TABLE IF NOT EXISTS `author` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`ID`, `Name`) VALUES
(1, 'Colleen Hoover'),
(2, 'Goerge R. R. Martin');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
CREATE TABLE IF NOT EXISTS `books` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `pub_date` date NOT NULL,
  `g_id` int(11) NOT NULL,
  `a_id` int(11) NOT NULL,
  `p_id` int(11) NOT NULL,
  `s_id` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `available` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `a_id` (`a_id`),
  UNIQUE KEY `g_id` (`g_id`),
  KEY `p_id` (`p_id`),
  KEY `s_id` (`s_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`ID`, `Name`, `pub_date`, `g_id`, `a_id`, `p_id`, `s_id`, `price`, `available`) VALUES
(1, 'It ends with us', '2016-08-02', 1, 1, 3, 2, 270, 5);

-- --------------------------------------------------------

--
-- Table structure for table `book_log`
--

DROP TABLE IF EXISTS `book_log`;
CREATE TABLE IF NOT EXISTS `book_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `u_id` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `u_id` (`u_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_log`
--

INSERT INTO `book_log` (`id`, `u_id`, `Name`) VALUES
(1, 1, '12');

-- --------------------------------------------------------

--
-- Table structure for table `borrows`
--

DROP TABLE IF EXISTS `borrows`;
CREATE TABLE IF NOT EXISTS `borrows` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `b_id` int(11) NOT NULL,
  `u_id` int(11) NOT NULL,
  `borrow_date` date NOT NULL,
  `return_date` date NOT NULL,
  `returned` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `b_id` (`b_id`),
  KEY `u_id` (`u_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `buys`
--

DROP TABLE IF EXISTS `buys`;
CREATE TABLE IF NOT EXISTS `buys` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `b_id` int(11) NOT NULL,
  `u_id` int(11) NOT NULL,
  `pay_method` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `b_id` (`b_id`),
  KEY `u_id` (`u_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `contains`
--

DROP TABLE IF EXISTS `contains`;
CREATE TABLE IF NOT EXISTS `contains` (
  `contain_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_id` int(11) NOT NULL,
  `bl_id` int(11) NOT NULL,
  `status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`contain_id`),
  KEY `b_id` (`b_id`),
  KEY `bl_id` (`bl_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contains`
--

INSERT INTO `contains` (`contain_id`, `b_id`, `bl_id`, `status`) VALUES
(3, 1, 1, 'Currently reading');

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
CREATE TABLE IF NOT EXISTS `genre` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `genre`
--

INSERT INTO `genre` (`ID`, `Type`) VALUES
(1, 'romance'),
(2, 'sci-fi');

-- --------------------------------------------------------

--
-- Table structure for table `grants`
--

DROP TABLE IF EXISTS `grants`;
CREATE TABLE IF NOT EXISTS `grants` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `L_id` int(11) NOT NULL,
  `U_id` int(11) NOT NULL,
  `B_id` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `B_id` (`B_id`),
  KEY `M_id` (`U_id`),
  KEY `L_id` (`L_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `librarian`
--

DROP TABLE IF EXISTS `librarian`;
CREATE TABLE IF NOT EXISTS `librarian` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `Contact` varchar(15) NOT NULL,
  `time_id` int(11) NOT NULL,
  `userName` varchar(20) NOT NULL,
  `security` varchar(50) NOT NULL,
  `answer` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `time_id` (`time_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `librarian`
--

INSERT INTO `librarian` (`ID`, `Name`, `password`, `Contact`, `time_id`, `userName`, `security`, `answer`) VALUES
(1, 'arefeen', 'rafee', '3242', 1, 'sultan', 'what is your nick name?', 'rafee');

-- --------------------------------------------------------

--
-- Table structure for table `membership`
--

DROP TABLE IF EXISTS `membership`;
CREATE TABLE IF NOT EXISTS `membership` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(20) NOT NULL,
  `validity` int(11) NOT NULL,
  `fee` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `membership`
--

INSERT INTO `membership` (`ID`, `Type`, `validity`, `fee`) VALUES
(1, 'Diamond', 12, 1000),
(2, 'Gold', 10, 800),
(3, 'Silver', 8, 600),
(4, 'Bronze', 6, 400);

-- --------------------------------------------------------

--
-- Table structure for table `publisher`
--

DROP TABLE IF EXISTS `publisher`;
CREATE TABLE IF NOT EXISTS `publisher` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `publisher`
--

INSERT INTO `publisher` (`ID`, `Name`) VALUES
(1, 'bloomsburry'),
(2, 'anondo'),
(3, 'Atria books');

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

DROP TABLE IF EXISTS `section`;
CREATE TABLE IF NOT EXISTS `section` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`ID`, `Type`) VALUES
(1, 'newspaper'),
(2, 'journal');

-- --------------------------------------------------------

--
-- Table structure for table `time_schedule`
--

DROP TABLE IF EXISTS `time_schedule`;
CREATE TABLE IF NOT EXISTS `time_schedule` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `week_day` varchar(9) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `time_schedule`
--

INSERT INTO `time_schedule` (`ID`, `start_time`, `end_time`, `week_day`) VALUES
(1, '10:00:00', '20:00:00', '1'),
(2, '10:00:00', '20:00:00', '2');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `Contact` varchar(15) NOT NULL,
  `M_id` int(11) NOT NULL,
  `bookLog` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `M_id` (`M_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `Name`, `password`, `Contact`, `M_id`, `bookLog`) VALUES
(1, 'labiba', 'kanij', '42341543', 1, 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`g_id`) REFERENCES `genre` (`ID`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`a_id`) REFERENCES `author` (`ID`),
  ADD CONSTRAINT `books_ibfk_3` FOREIGN KEY (`p_id`) REFERENCES `publisher` (`ID`),
  ADD CONSTRAINT `books_ibfk_4` FOREIGN KEY (`s_id`) REFERENCES `section` (`ID`);

--
-- Constraints for table `book_log`
--
ALTER TABLE `book_log`
  ADD CONSTRAINT `book_log_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `borrows`
--
ALTER TABLE `borrows`
  ADD CONSTRAINT `borrows_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`ID`),
  ADD CONSTRAINT `borrows_ibfk_2` FOREIGN KEY (`u_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `buys`
--
ALTER TABLE `buys`
  ADD CONSTRAINT `buys_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`ID`),
  ADD CONSTRAINT `buys_ibfk_2` FOREIGN KEY (`u_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `contains`
--
ALTER TABLE `contains`
  ADD CONSTRAINT `contains_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contains_ibfk_2` FOREIGN KEY (`bl_id`) REFERENCES `book_log` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `grants`
--
ALTER TABLE `grants`
  ADD CONSTRAINT `grants_ibfk_1` FOREIGN KEY (`L_id`) REFERENCES `librarian` (`ID`),
  ADD CONSTRAINT `grants_ibfk_2` FOREIGN KEY (`B_id`) REFERENCES `books` (`ID`),
  ADD CONSTRAINT `grants_ibfk_3` FOREIGN KEY (`U_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `librarian`
--
ALTER TABLE `librarian`
  ADD CONSTRAINT `librarian_ibfk_1` FOREIGN KEY (`time_id`) REFERENCES `time_schedule` (`ID`) ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_2` FOREIGN KEY (`M_id`) REFERENCES `membership` (`ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
