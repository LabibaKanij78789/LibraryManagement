-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 02, 2018 at 07:11 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

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

CREATE TABLE `author` (
  `a_ID` int(11) NOT NULL,
  `a_Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`a_ID`, `a_Name`) VALUES
(1, 'Colleen Hoover'),
(2, 'Goerge R. R. Martin');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `b_ID` int(11) NOT NULL,
  `b_name` varchar(20) NOT NULL,
  `pub_date` date NOT NULL,
  `g_id` int(11) NOT NULL,
  `a_id` int(11) NOT NULL,
  `p_id` int(11) NOT NULL,
  `s_id` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`b_ID`, `b_name`, `pub_date`, `g_id`, `a_id`, `p_id`, `s_id`, `price`, `available`) VALUES
(1, 'It ends with us', '2016-08-02', 1, 1, 3, 2, 270, 5),
(2, 'game of thrones', '1995-07-12', 2, 2, 1, 2, 500, 5);

-- --------------------------------------------------------

--
-- Table structure for table `book_log`
--

CREATE TABLE `book_log` (
  `bl_id` int(11) NOT NULL,
  `u_id` int(11) NOT NULL,
  `bl_Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_log`
--

INSERT INTO `book_log` (`bl_id`, `u_id`, `bl_Name`) VALUES
(1, 1, '12');

-- --------------------------------------------------------

--
-- Table structure for table `borrows`
--

CREATE TABLE `borrows` (
  `bor_id` int(11) NOT NULL,
  `b_id` int(11) NOT NULL,
  `g_id` int(11) NOT NULL,
  `borrow_date` date NOT NULL,
  `return_date` date NOT NULL,
  `returned` tinyint(1) NOT NULL,
  `bor_avail` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `buys`
--

CREATE TABLE `buys` (
  `buy_ID` int(11) NOT NULL,
  `b_id` int(11) NOT NULL,
  `g_id` int(11) NOT NULL,
  `buy_avail` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `buys`
--

INSERT INTO `buys` (`buy_ID`, `b_id`, `g_id`, `buy_avail`) VALUES
(1, 1, 312, 0),
(2, 1, 113, 0);

-- --------------------------------------------------------

--
-- Table structure for table `contains`
--

CREATE TABLE `contains` (
  `contain_id` int(11) NOT NULL,
  `b_id` int(11) NOT NULL,
  `bl_id` int(11) NOT NULL,
  `status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contains`
--

INSERT INTO `contains` (`contain_id`, `b_id`, `bl_id`, `status`) VALUES
(10, 1, 1, 'Currently reading'),
(11, 1, 1, 'Currently reading'),
(12, 1, 1, 'Currently reading');

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

CREATE TABLE `genre` (
  `g_ID` int(11) NOT NULL,
  `g_Type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `genre`
--

INSERT INTO `genre` (`g_ID`, `g_Type`) VALUES
(1, 'romance'),
(2, 'sci-fi');

-- --------------------------------------------------------

--
-- Table structure for table `grants`
--

CREATE TABLE `grants` (
  `gr_ID` int(11) NOT NULL,
  `L_id` int(11) NOT NULL,
  `U_id` int(11) NOT NULL,
  `taskDoneOrNot` tinyint(1) NOT NULL,
  `total` int(11) DEFAULT NULL,
  `gr_Type` varchar(10) NOT NULL,
  `new` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grants`
--

INSERT INTO `grants` (`gr_ID`, `L_id`, `U_id`, `taskDoneOrNot`, `total`, `gr_Type`, `new`) VALUES
(113, 1, 1, 0, 0, 'w', 1),
(312, 1, 1, 0, 0, 'y', 0);

-- --------------------------------------------------------

--
-- Table structure for table `librarian`
--

CREATE TABLE `librarian` (
  `l_ID` int(11) NOT NULL,
  `l_Name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `Contact` varchar(15) NOT NULL,
  `time_id` int(11) NOT NULL,
  `userName` varchar(20) NOT NULL,
  `security` varchar(50) NOT NULL,
  `answer` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `librarian`
--

INSERT INTO `librarian` (`l_ID`, `l_Name`, `password`, `Contact`, `time_id`, `userName`, `security`, `answer`) VALUES
(1, 'arefeen', 'rafee', '3242', 1, 'sultan', 'what is your nick name?', 'rafee');

-- --------------------------------------------------------

--
-- Table structure for table `membership`
--

CREATE TABLE `membership` (
  `mem_ID` int(11) NOT NULL,
  `mem_Type` varchar(20) NOT NULL,
  `validity` int(11) NOT NULL,
  `fee` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `membership`
--

INSERT INTO `membership` (`mem_ID`, `mem_Type`, `validity`, `fee`) VALUES
(1, 'Diamond', 12, 1000),
(2, 'Gold', 10, 800),
(3, 'Silver', 8, 600),
(4, 'Bronze', 6, 400);

-- --------------------------------------------------------

--
-- Table structure for table `notifications`
--

CREATE TABLE `notifications` (
  `n_id` int(11) NOT NULL,
  `u_id` int(11) NOT NULL,
  `n_type` varchar(11) NOT NULL,
  `completed` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `notifications`
--

INSERT INTO `notifications` (`n_id`, `u_id`, `n_type`, `completed`) VALUES
(1, 1, 'w', 0),
(2, 1, 'y', 0),
(3, 2, 'w', 0),
(4, 2, 'y', 0),
(5, 2, 'r', 0),
(6, 2, 'd', 0);

-- --------------------------------------------------------

--
-- Table structure for table `publisher`
--

CREATE TABLE `publisher` (
  `p_ID` int(11) NOT NULL,
  `p_Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `publisher`
--

INSERT INTO `publisher` (`p_ID`, `p_Name`) VALUES
(1, 'bloomsburry'),
(2, 'anondo'),
(3, 'Atria books');

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `s_ID` int(11) NOT NULL,
  `s_Type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`s_ID`, `s_Type`) VALUES
(1, 'newspaper'),
(2, 'journal');

-- --------------------------------------------------------

--
-- Table structure for table `time_schedule`
--

CREATE TABLE `time_schedule` (
  `t_ID` int(5) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `week_day` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `time_schedule`
--

INSERT INTO `time_schedule` (`t_ID`, `start_time`, `end_time`, `week_day`) VALUES
(1, '10:00:00', '20:00:00', '1'),
(2, '10:00:00', '20:00:00', '2');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `u_ID` int(11) NOT NULL,
  `u_Name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `Contact` varchar(15) NOT NULL,
  `M_id` int(11) NOT NULL,
  `bookLog` tinyint(1) NOT NULL,
  `reqPending` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`u_ID`, `u_Name`, `password`, `Contact`, `M_id`, `bookLog`, `reqPending`) VALUES
(1, 'labiba', 'kanij', '42341543', 1, 1, 2),
(2, 'kanij', 'null', '344', 2, 0, 0),
(3, 'aru', 'null', '34', 4, 0, 0),
(4, 'sa', 'null', '668', 3, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author`
--
ALTER TABLE `author`
  ADD PRIMARY KEY (`a_ID`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`b_ID`),
  ADD UNIQUE KEY `a_id` (`a_id`),
  ADD UNIQUE KEY `g_id` (`g_id`),
  ADD KEY `p_id` (`p_id`),
  ADD KEY `s_id` (`s_id`);

--
-- Indexes for table `book_log`
--
ALTER TABLE `book_log`
  ADD PRIMARY KEY (`bl_id`),
  ADD KEY `u_id` (`u_id`);

--
-- Indexes for table `borrows`
--
ALTER TABLE `borrows`
  ADD PRIMARY KEY (`bor_id`),
  ADD KEY `b_id` (`b_id`),
  ADD KEY `g_id` (`g_id`);

--
-- Indexes for table `buys`
--
ALTER TABLE `buys`
  ADD PRIMARY KEY (`buy_ID`),
  ADD KEY `b_id` (`b_id`),
  ADD KEY `g_id` (`g_id`);

--
-- Indexes for table `contains`
--
ALTER TABLE `contains`
  ADD PRIMARY KEY (`contain_id`),
  ADD KEY `b_id` (`b_id`),
  ADD KEY `bl_id` (`bl_id`);

--
-- Indexes for table `genre`
--
ALTER TABLE `genre`
  ADD PRIMARY KEY (`g_ID`);

--
-- Indexes for table `grants`
--
ALTER TABLE `grants`
  ADD PRIMARY KEY (`gr_ID`),
  ADD KEY `B_id` (`taskDoneOrNot`),
  ADD KEY `M_id` (`U_id`),
  ADD KEY `L_id` (`L_id`);

--
-- Indexes for table `librarian`
--
ALTER TABLE `librarian`
  ADD PRIMARY KEY (`l_ID`),
  ADD KEY `time_id` (`time_id`);

--
-- Indexes for table `membership`
--
ALTER TABLE `membership`
  ADD PRIMARY KEY (`mem_ID`);

--
-- Indexes for table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`n_id`),
  ADD KEY `u_id` (`u_id`);

--
-- Indexes for table `publisher`
--
ALTER TABLE `publisher`
  ADD PRIMARY KEY (`p_ID`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`s_ID`);

--
-- Indexes for table `time_schedule`
--
ALTER TABLE `time_schedule`
  ADD PRIMARY KEY (`t_ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`u_ID`),
  ADD KEY `M_id` (`M_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `author`
--
ALTER TABLE `author`
  MODIFY `a_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `b_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `book_log`
--
ALTER TABLE `book_log`
  MODIFY `bl_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `borrows`
--
ALTER TABLE `borrows`
  MODIFY `bor_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `buys`
--
ALTER TABLE `buys`
  MODIFY `buy_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `contains`
--
ALTER TABLE `contains`
  MODIFY `contain_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `genre`
--
ALTER TABLE `genre`
  MODIFY `g_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `librarian`
--
ALTER TABLE `librarian`
  MODIFY `l_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `membership`
--
ALTER TABLE `membership`
  MODIFY `mem_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `n_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `publisher`
--
ALTER TABLE `publisher`
  MODIFY `p_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `s_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `time_schedule`
--
ALTER TABLE `time_schedule`
  MODIFY `t_ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `u_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`g_id`) REFERENCES `genre` (`g_ID`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`a_id`) REFERENCES `author` (`a_ID`),
  ADD CONSTRAINT `books_ibfk_3` FOREIGN KEY (`p_id`) REFERENCES `publisher` (`p_ID`),
  ADD CONSTRAINT `books_ibfk_4` FOREIGN KEY (`s_id`) REFERENCES `section` (`s_ID`);

--
-- Constraints for table `book_log`
--
ALTER TABLE `book_log`
  ADD CONSTRAINT `book_log_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`u_ID`);

--
-- Constraints for table `borrows`
--
ALTER TABLE `borrows`
  ADD CONSTRAINT `borrows_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`b_ID`),
  ADD CONSTRAINT `borrows_ibfk_2` FOREIGN KEY (`g_id`) REFERENCES `grants` (`gr_ID`);

--
-- Constraints for table `buys`
--
ALTER TABLE `buys`
  ADD CONSTRAINT `buys_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`b_ID`),
  ADD CONSTRAINT `buys_ibfk_2` FOREIGN KEY (`g_id`) REFERENCES `grants` (`gr_ID`);

--
-- Constraints for table `contains`
--
ALTER TABLE `contains`
  ADD CONSTRAINT `contains_ibfk_1` FOREIGN KEY (`b_id`) REFERENCES `books` (`b_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contains_ibfk_2` FOREIGN KEY (`bl_id`) REFERENCES `book_log` (`bl_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `grants`
--
ALTER TABLE `grants`
  ADD CONSTRAINT `grants_ibfk_1` FOREIGN KEY (`L_id`) REFERENCES `librarian` (`l_ID`),
  ADD CONSTRAINT `grants_ibfk_3` FOREIGN KEY (`U_id`) REFERENCES `user` (`u_ID`);

--
-- Constraints for table `librarian`
--
ALTER TABLE `librarian`
  ADD CONSTRAINT `librarian_ibfk_1` FOREIGN KEY (`time_id`) REFERENCES `time_schedule` (`t_ID`) ON UPDATE CASCADE;

--
-- Constraints for table `notifications`
--
ALTER TABLE `notifications`
  ADD CONSTRAINT `notifications_ibfk_1` FOREIGN KEY (`u_id`) REFERENCES `user` (`u_ID`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_2` FOREIGN KEY (`M_id`) REFERENCES `membership` (`mem_ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
