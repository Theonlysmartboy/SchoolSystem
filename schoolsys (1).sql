-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 24, 2018 at 04:05 PM
-- Server version: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `schoolsys`
--
Create database schoolsys;
use schoolsys;
-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
CREATE TABLE IF NOT EXISTS `classes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  `stream` int(11) NOT NULL,
  `symbol` int(2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `classes_ibfk_1` (`stream`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`id`, `name`, `stream`, `symbol`) VALUES
(7, '1', 10, 1),
(8, '2', 8, 2),
(9, '3', 8, 3),
(10, '4', 9, 4);

-- --------------------------------------------------------

--
-- Table structure for table `feeamt`
--

DROP TABLE IF EXISTS `feeamt`;
CREATE TABLE IF NOT EXISTS `feeamt` (
  `code` varchar(50) NOT NULL,
  `class` int(2) NOT NULL,
  `term` int(2) NOT NULL,
  `year` varchar(4) NOT NULL,
  `amt` decimal(10,2) NOT NULL,
  `createdon` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updatedon` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `feeamt`
--

INSERT INTO `feeamt` (`code`, `class`, `term`, `year`, `amt`, `createdon`, `updatedon`) VALUES
('F1/2018', 1, 1, '2018', '50000.00', '2018-10-24 08:32:11', '2018-10-24 08:32:11'),
('F2/2018', 1, 1, '2018', '30000.00', '2018-10-24 08:32:45', '2018-10-24 08:32:45'),
('F3/2018', 1, 1, '2018', '60000.00', '2018-10-24 08:33:23', '2018-10-24 08:33:23'),
('F4/2018', 2, 2, '2018', '50000.00', '2018-10-24 08:41:57', '2018-10-24 08:41:57');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
CREATE TABLE IF NOT EXISTS `payments` (
  `admno` varchar(50) NOT NULL,
  `receiptno` int(11) NOT NULL,
  `datepaid` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `amtpaid` decimal(10,2) NOT NULL,
  `type` varchar(50) NOT NULL,
  `documentno` varchar(50) NOT NULL,
  `paidby` varchar(50) NOT NULL,
  `receivedby` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`admno`, `receiptno`, `datepaid`, `amtpaid`, `type`, `documentno`, `paidby`, `receivedby`) VALUES
('abel', 4000, '2018-09-30 11:02:56', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'dg', 'jg'),
('tim', 4001, '2018-09-30 12:59:14', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'th', 'th'),
('tim', 4001, '2018-09-30 12:53:14', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'jd', 'hg'),
('jean', 4001, '2018-10-07 07:36:23', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'jean', 'joseph'),
('jean', 4002, '2018-10-07 07:52:54', '1000.00', 'SchoolSys.TypeofPaymentItem', 'bursar/092/233', 'joel', 'joseph'),
('jean', 4003, '2018-10-07 07:58:03', '1000.00', 'SchoolSys.TypeofPaymentItem', '6256679111', 'jean', 'joseph'),
('jean', 4001, '2018-10-07 08:08:13', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'hsdj', 'sdjk'),
('tim', 4001, '2018-10-07 08:59:38', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'kld', 'lkd'),
('tim', 4001, '2018-10-07 09:04:23', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'sd', 'sd'),
('tim', 4001, '2018-10-07 09:34:30', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'kkl', 'kll'),
('tim', 4001, '2018-10-07 09:44:02', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'klds', 'jkw'),
('tim', 4001, '2018-10-07 09:53:32', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'lkk', 'jf'),
('tim', 4001, '2018-10-07 09:55:35', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'kl', 'kl'),
('tim', 4001, '2018-10-17 07:14:08', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'n,snfxk', 'kljdk'),
('tim', 4001, '2018-10-17 07:21:17', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'klk', 'jkl'),
('tim', 4001, '2018-10-17 07:33:02', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'dsf', 'dfds'),
('tim', 4001, '2018-10-17 08:04:50', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'klsd', 'lsk'),
('ken', 4001, '2018-10-17 08:23:04', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'lk', 'kds'),
('ken', 4000, '2018-10-17 08:30:27', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'jlfd', 'ljflld'),
('ken', 4000, '2018-10-17 09:39:38', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'fdf', 'dgf'),
('ken', 4001, '2018-10-17 09:41:01', '0.00', 'SchoolSys.TypeofPaymentItem', 'Cancelled Receipt', 'nsba', 'jsajk'),
('ken', 4002, '2018-10-17 09:45:10', '500.00', 'SchoolSys.TypeofPaymentItem', 'sdf', 'jkhj', 'nmnm'),
('tim', 4003, '2018-10-17 10:18:42', '3000.00', 'SchoolSys.TypeofPaymentItem', 'uhhd', 'jkdfh', 'jk'),
('tim', 4004, '2018-10-17 10:25:40', '1000.00', 'SchoolSys.TypeofPaymentItem', 'ksdjl', 'kjdf', 'kjsd'),
('50002', 4005, '2018-10-22 07:46:15', '5000.00', 'SchoolSys.TypeofPaymentItem', '78348', 'jklwe', 'jkffff'),
('50007', 4006, '2018-10-23 06:38:30', '5000.00', 'SchoolSys.TypeofPaymentItem', '16763687377388', 'Joseph', 'Michael chieng'),
('50008', 4007, '2018-10-23 08:45:13', '10000.00', 'SchoolSys.TypeofPaymentItem', '7652346898574979', 'Esther', 'Paul'),
('50004', 4007, '2018-10-23 13:21:38', '4000.00', 'SchoolSys.TypeofPaymentItem', '2wqwrqwwerewrer', 'wererwerwer', 'ewrerew'),
('50006', 4008, '2018-10-23 13:23:52', '3000.00', 'SchoolSys.TypeofPaymentItem', 'wertwrtrt', 'ret', 'trtttre');

-- --------------------------------------------------------

--
-- Table structure for table `pg`
--

DROP TABLE IF EXISTS `pg`;
CREATE TABLE IF NOT EXISTS `pg` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `admno` varchar(50) NOT NULL,
  `pgname` varchar(50) NOT NULL,
  `pgrelationship` varchar(50) NOT NULL,
  `pgphone` varchar(15) NOT NULL,
  `pgemail` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `admno` (`admno`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pg`
--

INSERT INTO `pg` (`id`, `admno`, `pgname`, `pgrelationship`, `pgphone`, `pgemail`) VALUES
(3, 'tim', 'samuel', 'father', '9898398989', 'sam@sam'),
(7, 'tim', 'djj', 'ahh', '99393', 'kjks'),
(8, 'jean', 'michael', 'father', '0789353637', 'michael@gmail.com'),
(10, 'job', 'moses', 'father', '0725787377', 'moses@gmail.com'),
(11, 'mildred', 'James Belingtom', 'Father', '0978858588', 'james@belington.com'),
(12, 'ken', 'Samuel Okumu', 'Father', '0725242556', 'sam@gmail.com'),
(13, 'ken', 'Angela Okumu', 'Mother', '0724353636', 'ang@gmail.com'),
(14, 'joe', 'jkasj', 'ksjl', 'klkasd', 'lkasd'),
(15, 'joe', 'jsdj;l', 'ok;\'lsd', 'oipfos', 'kjklsa'),
(16, 'tom', 'Mildred Otieno', 'Mother', '0723449493', 'amil@yahoo.com'),
(17, 'elvis', 'collins makena', 'father', '0728282929', 'colinso@gmail.com'),
(18, '50000', 'Manase Ochieng', 'Father', '0789282828', 'manase@gmail.com'),
(19, '50000', 'Phanice Oyier', 'Mother', '0723701234', 'phanice@gmail.com'),
(20, '50001', 'masbjk', 'kjash', '23059347', 'hsdjf'),
(21, '50002', 'jkhs', 'kl;se', '04839473', 'jkfhdsjk'),
(22, '50003', 'hiuh', 'ihi', '23434', 'ksajdk'),
(23, '50004', 'jolius oching', 'joyce maa', 'klj', 'klj'),
(24, '50005', 'simon Chege', 'Father', '0725703816', 'chege@gmail.com'),
(25, '50005', 'monicah chege', 'mother', '0788338835', 'monicah@yahoo.com'),
(26, '50006', 'Naomi Mireri', 'Mother', '0723383838', 'naomi@gmail.com'),
(27, '50006', 'Japheth Ochieng', 'Father', '0728882882', 'japheth @yahoo.com'),
(28, '50007', 'thuita', 'Father', '0706785858', 'thuita@gmail.com'),
(29, '50007', 'wanjiru', 'mother', '0726262666', 'wanjiru@gmail.com'),
(30, '50008', 'Haris Ochieng', 'Father', '0723424422', 'haris@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `stream`
--

DROP TABLE IF EXISTS `stream`;
CREATE TABLE IF NOT EXISTS `stream` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stream`
--

INSERT INTO `stream` (`id`, `name`) VALUES
(7, 'Blue'),
(8, 'Yellow'),
(9, 'Red'),
(10, 'Green');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `admno` varchar(20) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `othernames` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `doa` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `dob` varchar(50) NOT NULL,
  `kcpemarks` int(10) NOT NULL,
  `kcpeschool` varchar(50) NOT NULL,
  `class` varchar(30) NOT NULL,
  `stream` varchar(30) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Ongoing',
  PRIMARY KEY (`admno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`admno`, `firstname`, `lastname`, `othernames`, `gender`, `doa`, `dob`, `kcpemarks`, `kcpeschool`, `class`, `stream`, `status`) VALUES
('50000', 'miliband', 'sophie ', 'malanie', 'Female', '2018-10-21 11:03:09', '12/12/1990', 370, 'SOri Primary School', '7', '8', 'Ongoing'),
('50001', 'jlkj', 'kajl', 'jlkj', 'Female', '2018-10-21 11:16:24', '1/1/2008', 450, 'kyhak', '7', '7', 'Ongoing'),
('50002', 'kljlas', 'hkshk', 'lks', 'Female', '2018-10-21 11:17:55', '3/3/1992', 456, 'hklasf', '7', '9', 'Ongoing'),
('50003', 'og', 'mike', 'oh', 'Male', '2018-10-21 11:20:30', '12/3/2013', 300, 'asbjm', '7', '10', 'Ongoing'),
('50004', 'jha', 'uyhfs', 'kljal', 'Male', '2018-10-22 06:45:11', '2/2/1994', 400, 'kasl', '7', '7', 'Ongoing'),
('50005', 'duke ', 'chege', 'thuita', 'Male', '2018-10-22 06:57:09', '2/2/1991', 400, 'moranga primary school', '7', '10', 'Ongoing'),
('50006', 'Mireri ', 'Dicken', 'Mogeni', 'Male', '2018-10-22 07:42:41', '12/1/2000', 322, 'Kisii Primary School', '', '', 'Ongoing'),
('50007', 'Joseph', 'Chege', 'Thuita', 'Male', '2018-10-23 06:33:16', '12/1/1997', 400, 'Muranga Primary', '7', '8', 'Ongoing'),
('50008', 'Achieng', 'Esther', 'Gift', 'Female', '2018-10-23 08:40:55', '1/1/1989', 450, 'migosi pri school', '8', '8', 'Ongoing'),
('abel', 'clement', 'abel', 'okumu', 'Male', '2018-09-16 07:54:11', '2018-09-16 00:00:00', 420, 'mini school', '7', '7', ''),
('d', 'h', 'h', 'n', 'Male', '2018-09-23 13:38:49', '2018-09-23 00:00:00', 667, 'jkj', '9', '7', ''),
('elvis', 'omondi', 'elvis', 'ochieng', 'Male', '2018-10-21 09:45:49', '12/5/2018', 390, 'migori primary', '', 'Green', 'Ongoing'),
('gh', 'jh', 'jh', 'nm', 'Male', '2018-09-23 13:45:35', '2018-09-23 00:00:00', 655, 'hj', '8', '7', ''),
('hdj', 'ada', 'ad', 'asda', 'Female', '2018-09-23 13:50:40', '2018-09-23 00:00:00', 433, 'hgg', '7', '7', ''),
('jean', 'Jean', 'Ayako', 'Audry', 'Female', '2018-10-07 07:33:59', '2000-10-07 00:00:00', 450, 'Migori Primary School', '', 'Red', ''),
('jess', 'ochieng', 'jesse', 'omondi', 'Male', '2018-09-30 08:57:53', '2018-09-30 00:00:00', 400, 'kks', '9', '9', ''),
('job', 'Dennis', 'Okari', 'Okudo', 'Male', '2018-10-16 18:28:38', '1993-06-16 00:00:00', 340, 'Nyamasaria Primary School', '', 'Green', ''),
('joe', 'jkjlk', 'nkk', 'jlkjk', 'Male', '2018-10-17 06:38:12', '2018-10-17 00:00:00', 395, 'jask', '8', '9', ''),
('ken', 'Kenneth', 'Obonyo', 'Okumu', 'Female', '2018-10-17 06:02:09', '1993-10-10 00:00:00', 395, 'Sony Primary School', '', 'Blue', ''),
('mildred', 'MIldred', 'Ochieng', 'Akinyi', 'Female', '2018-10-17 05:57:05', '1990-02-17 00:00:00', 380, 'kaduda primary', '8', '8', ''),
('sam', 'SAM', 'samSAM', 'SAM', 'Male', '2018-09-23 12:26:59', '2018-09-23 00:00:00', 395, 'DNS', '8', '7', ''),
('tim', 'Timothy', 'Okumu', 'Odhiambo', 'Male', '2018-09-30 08:31:53', '2018-09-30 00:00:00', 465, 'sony', '', 'Red', ''),
('tom', 'ochieng', 'tom', 'jalango', 'Male', '2018-10-21 09:01:56', '2018-10-21 12:00:04', 350, 'kamtudi', '8', '8', 'Ongoing'),
('ttr', 'k', 'hkj', 'kj', 'Male', '2018-09-23 13:49:22', '2018-09-23 00:00:00', 565, 'jkhk', '8', '8', '');

-- --------------------------------------------------------

--
-- Table structure for table `tempadmno`
--

DROP TABLE IF EXISTS `tempadmno`;
CREATE TABLE IF NOT EXISTS `tempadmno` (
  `id` int(11) NOT NULL,
  `temp` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tempadmno`
--

INSERT INTO `tempadmno` (`id`, `temp`) VALUES
(0, 50009);

-- --------------------------------------------------------

--
-- Table structure for table `tempreceiptno`
--

DROP TABLE IF EXISTS `tempreceiptno`;
CREATE TABLE IF NOT EXISTS `tempreceiptno` (
  `id` int(11) NOT NULL,
  `tempno` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tempreceiptno`
--

INSERT INTO `tempreceiptno` (`id`, `tempno`) VALUES
(0, 4009);

-- --------------------------------------------------------

--
-- Table structure for table `term`
--

DROP TABLE IF EXISTS `term`;
CREATE TABLE IF NOT EXISTS `term` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `term`
--

INSERT INTO `term` (`id`, `name`) VALUES
(1, '1'),
(2, '2'),
(3, '3');

-- --------------------------------------------------------

--
-- Table structure for table `typeofpayment`
--

DROP TABLE IF EXISTS `typeofpayment`;
CREATE TABLE IF NOT EXISTS `typeofpayment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `types` varchar(100) NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1 COMMENT='typeofpayment';

--
-- Dumping data for table `typeofpayment`
--

INSERT INTO `typeofpayment` (`id`, `types`) VALUES
(5, 'Bank Slip'),
(6, 'Cash'),
(7, 'Mpesa'),
(8, 'EFT');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `uname` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` int(2) NOT NULL DEFAULT '0',
  `created_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`uname`, `password`, `role`, `created_on`, `updated_on`) VALUES
('okumutim', 'okumutim', 0, '2018-09-03 14:30:33', '2018-09-03 14:30:33'),
('tosby', 'tosby', 0, '2018-09-03 14:30:33', '2018-09-03 14:30:33'),
('tim', 'tim', 0, '2018-09-04 12:49:32', '2018-09-04 12:49:32');

-- --------------------------------------------------------

--
-- Table structure for table `voteheads`
--

DROP TABLE IF EXISTS `voteheads`;
CREATE TABLE IF NOT EXISTS `voteheads` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `receiptno` int(11) NOT NULL,
  `vhname` varchar(50) NOT NULL,
  `vhamt` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `receipt` (`receiptno`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `voteheads`
--

INSERT INTO `voteheads` (`id`, `receiptno`, `vhname`, `vhamt`) VALUES
(3, 4000, 'Exams', '1000.00'),
(4, 4001, 'Boarding', '20000.00'),
(5, 4001, 'Boarding', '67888.00'),
(6, 4001, 'Exams', '20000.00'),
(7, 4002, 'Exams', '2000.00'),
(8, 4001, 'Boarding', '500.00'),
(9, 4001, 'Causion', '500.00'),
(10, 4001, 'Tuition ', '2000.00'),
(11, 4001, 'Exams', '10000.00'),
(12, 4001, 'Boarding', '1000.00'),
(13, 4001, 'Exams', '20200.00'),
(14, 4001, 'Tuition ', '10000.00'),
(15, 4001, 'Boarding', '10000.00'),
(16, 4002, 'Causion', '1000.00'),
(17, 4003, 'Medical', '1000.00'),
(18, 4001, 'Boarding', '2000.00'),
(19, 4001, 'Exams', '1000.00'),
(20, 4001, 'Actvity ', '1000.00'),
(21, 4001, 'Exams', '4000.00'),
(22, 4001, 'Causion', '1000.00'),
(23, 4001, 'Tuition ', '1000.00'),
(24, 4001, 'Boarding', '10000.00'),
(25, 4001, 'Tuition ', '10000.00'),
(26, 4000, 'Tuition ', '4000.00'),
(27, 4000, 'Causion', '4200.00'),
(28, 4001, 'Tuition ', '1000.00'),
(29, 4001, 'Boarding', '1000.00'),
(30, 4002, 'Causion', '500.00'),
(31, 4002, 'Actvity ', '100.00'),
(32, 4002, 'Actvity ', '3000.00'),
(33, 4002, 'Actvity ', '3663.00'),
(34, 4003, 'Actvity ', '3000.00'),
(35, 4004, 'Causion', '100.00'),
(36, 4004, 'Actvity ', '200.00'),
(37, 4004, 'Boarding', '300.00'),
(38, 4004, 'Medical', '400.00'),
(39, 4005, 'Tuition ', '5000.00'),
(40, 4005, 'Causion', '0.00'),
(43, 4007, 'Tuition ', '5000.00'),
(44, 4007, 'Boarding', '5000.00'),
(45, 4006, 'Tuition ', '5000.00'),
(46, 4007, 'Boarding', '4000.00'),
(47, 4008, 'Medical', '3000.00');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classes`
--
ALTER TABLE `classes`
  ADD CONSTRAINT `classes_ibfk_1` FOREIGN KEY (`stream`) REFERENCES `stream` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pg`
--
ALTER TABLE `pg`
  ADD CONSTRAINT `pg_ibfk_1` FOREIGN KEY (`admno`) REFERENCES `student` (`admno`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
