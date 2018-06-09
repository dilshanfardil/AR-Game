-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 04, 2018 at 09:26 AM
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
-- Database: `leave_db_v2`
--

-- --------------------------------------------------------

--
-- Table structure for table `april_leave_schedule`
--

DROP TABLE IF EXISTS `april_leave_schedule`;
CREATE TABLE IF NOT EXISTS `april_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `april_leave_schedule`
--

INSERT INTO `april_leave_schedule` (`dates`, `leave_status`) VALUES
(1, 'Sunday'),
(7, 'Saturday'),
(8, 'Sunday'),
(13, 'Sinhala and Tamil New Year Eve'),
(14, 'Sinhala and Tamil New Year'),
(15, 'Sunday'),
(21, 'Saturday'),
(22, 'Sunday'),
(28, 'Saturday'),
(29, 'Vesak Full Moon Paya Day'),
(30, 'Day After Vesak Full Moon Poya Day');

-- --------------------------------------------------------

--
-- Table structure for table `august_leave_dates`
--

DROP TABLE IF EXISTS `august_leave_dates`;
CREATE TABLE IF NOT EXISTS `august_leave_dates` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `august_leave_dates`
--

INSERT INTO `august_leave_dates` (`dates`, `leave_status`) VALUES
(4, 'Saturday'),
(5, 'Sunday'),
(11, 'Saturday'),
(12, 'Sunday'),
(18, 'Saturday'),
(19, 'Sunday'),
(22, 'Hajjhi Festival Day'),
(25, '\'Nikini\' Full Moon Poya Day'),
(26, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `branch_details`
--

DROP TABLE IF EXISTS `branch_details`;
CREATE TABLE IF NOT EXISTS `branch_details` (
  `branch_no` int(11) NOT NULL AUTO_INCREMENT,
  `branch_name` varchar(100) NOT NULL,
  `officer_name` varchar(100) NOT NULL,
  `officer_emp_no` int(4) NOT NULL,
  PRIMARY KEY (`branch_no`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch_details`
--

INSERT INTO `branch_details` (`branch_no`, `branch_name`, `officer_name`, `officer_emp_no`) VALUES
(1, 'Establishment', 'S.H.Sanjeewa Senawirathne', 35),
(2, 'Addministration', 'E.Patuwathawithana', 25),
(3, 'Information and Technology', 'E.Patuwathawithana', 25),
(4, 'Supply', 'Wasantha Ranawaka', 10),
(5, 'Finance', 'Wasantha Ranawaka', 10),
(6, 'Hasara', 'E.Patuwathawithana', 25),
(7, 'Abc', 'E.Patuwathawithana', 25);

-- --------------------------------------------------------

--
-- Table structure for table `december_leave_dates`
--

DROP TABLE IF EXISTS `december_leave_dates`;
CREATE TABLE IF NOT EXISTS `december_leave_dates` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `december_leave_dates`
--

INSERT INTO `december_leave_dates` (`dates`, `leave_status`) VALUES
(1, 'Saturday'),
(2, 'Sunday'),
(8, 'Saturday'),
(9, 'Sunday'),
(15, 'Saturday'),
(16, 'Sunday'),
(22, '\'Unduvap\' Full Moon Poya Day'),
(23, 'Sunday'),
(25, 'Cristmas Day'),
(29, 'Saturday'),
(30, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `february_leave_schedule`
--

DROP TABLE IF EXISTS `february_leave_schedule`;
CREATE TABLE IF NOT EXISTS `february_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `february_leave_schedule`
--

INSERT INTO `february_leave_schedule` (`dates`, `leave_status`) VALUES
(13, 'Maha ShiwaRathri  Day'),
(10, 'Saturday'),
(4, 'Independence Day'),
(11, 'Sunday'),
(3, 'Saturday'),
(17, 'Saturday'),
(18, 'Sunday'),
(24, 'Saturday'),
(25, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `government_leave_dates`
--

DROP TABLE IF EXISTS `government_leave_dates`;
CREATE TABLE IF NOT EXISTS `government_leave_dates` (
  `government_leave_date` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `government_leave_dates`
--

INSERT INTO `government_leave_dates` (`government_leave_date`) VALUES
('2018-01-06'),
('2018-01-07'),
('2018-01-01'),
('2018-01-13'),
('2018-01-14'),
('2018-01-20'),
('2018-01-21'),
('2018-01-27'),
('2018-01-28'),
('2018-01-31'),
('2018-02-03'),
('2018-02-04'),
('2018-02-10'),
('2018-02-11'),
('2018-02-13'),
('2018-02-17'),
('2018-02-18'),
('2018-02-24'),
('2018-02-25'),
('2018-03-01'),
('2018-03-03'),
('2018-03-04'),
('2018-03-10'),
('2018-03-11'),
('2018-03-17'),
('2018-03-18'),
('2018-03-24'),
('2018-03-25'),
('2018-03-30'),
('2018-03-31'),
('2018-04-01'),
('2018-04-07'),
('2018-04-08'),
('2018-04-13'),
('2018-04-14'),
('2018-04-15'),
('2018-04-21'),
('2018-04-22'),
('2018-04-28'),
('2018-04-29'),
('2018-04-30'),
('2018-05-05'),
('2018-05-06'),
('2018-05-07'),
('2018-05-12'),
('2018-05-13'),
('2018-05-19'),
('2018-05-20'),
('2018-05-26'),
('2018-05-27'),
('2018-05-29'),
('2018-06-02'),
('2018-06-03'),
('2018-06-09'),
('2018-06-10'),
('2018-06-15'),
('2018-06-16'),
('2018-06-17'),
('2018-06-23'),
('2018-06-24'),
('2018-06-27'),
('2018-06-30'),
('2018-07-01'),
('2018-07-07'),
('2018-07-08'),
('2018-07-14'),
('2018-07-15'),
('2018-07-21'),
('2018-07-22'),
('2018-07-27'),
('2018-07-28'),
('2018-07-29'),
('2018-08-04'),
('2018-08-05'),
('2018-08-11'),
('2018-08-12'),
('2018-08-18'),
('2018-08-19'),
('2018-08-22'),
('2018-08-25'),
('2018-08-26'),
('2018-09-01'),
('2018-09-02'),
('2018-09-08'),
('2018-09-09'),
('2018-09-15'),
('2018-09-16'),
('2018-09-22'),
('2018-09-23'),
('2018-09-24'),
('2018-09-29'),
('2018-09-30'),
('2018-10-06'),
('2018-10-07'),
('2018-10-13'),
('2018-10-14'),
('2018-10-20'),
('2018-10-21'),
('2018-10-24'),
('2018-10-27'),
('2018-10-28'),
('2018-11-03'),
('2018-11-04'),
('2018-11-06'),
('2018-11-10'),
('2018-11-11'),
('2018-11-17'),
('2018-11-18'),
('2018-11-20'),
('2018-11-22'),
('2018-11-24'),
('2018-11-25'),
('2018-12-01'),
('2018-12-02'),
('2018-12-08'),
('2018-12-09'),
('2018-12-15'),
('2018-12-16'),
('2018-12-22'),
('2018-12-23'),
('2018-12-25'),
('2018-12-29'),
('2018-12-30');

-- --------------------------------------------------------

--
-- Table structure for table `january_leave_dates`
--

DROP TABLE IF EXISTS `january_leave_dates`;
CREATE TABLE IF NOT EXISTS `january_leave_dates` (
  `date` int(11) NOT NULL,
  `status` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `january_leave_dates`
--

INSERT INTO `january_leave_dates` (`date`, `status`) VALUES
(1, ''),
(6, ''),
(7, ''),
(13, ''),
(14, ''),
(20, ''),
(21, ''),
(27, ''),
(28, ''),
(31, '');

-- --------------------------------------------------------

--
-- Table structure for table `january_leave_schedule`
--

DROP TABLE IF EXISTS `january_leave_schedule`;
CREATE TABLE IF NOT EXISTS `january_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `january_leave_schedule`
--

INSERT INTO `january_leave_schedule` (`dates`, `leave_status`) VALUES
(1, '\'Duruthu\' Full Moon Poya Day'),
(6, 'Saturday'),
(7, 'Sunday'),
(13, 'Saturday'),
(14, 'Tamil \'Thaipongal\' Day'),
(20, 'Saturday'),
(21, 'Sunday'),
(27, 'Saturday'),
(28, 'Sunday'),
(31, '\'Nawam\' Full Moon Poya Day');

-- --------------------------------------------------------

--
-- Table structure for table `july_leave_schedule`
--

DROP TABLE IF EXISTS `july_leave_schedule`;
CREATE TABLE IF NOT EXISTS `july_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `july_leave_schedule`
--

INSERT INTO `july_leave_schedule` (`dates`, `leave_status`) VALUES
(1, 'Sunday'),
(7, 'Saturday'),
(8, 'Sunday'),
(14, 'Saturday'),
(15, 'Sunday'),
(21, 'Saturday'),
(22, 'Sunday'),
(27, '\'Esala\' Full Moon Poya Day'),
(28, 'Saturday'),
(29, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `june_leave_schedule`
--

DROP TABLE IF EXISTS `june_leave_schedule`;
CREATE TABLE IF NOT EXISTS `june_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `june_leave_schedule`
--

INSERT INTO `june_leave_schedule` (`dates`, `leave_status`) VALUES
(2, 'Saturday'),
(3, 'Sunday'),
(9, 'Saturday'),
(10, 'Sunday'),
(15, 'Idul Fitr'),
(16, 'Saturday'),
(17, 'Sunday'),
(23, 'Saturday'),
(24, 'Sunday'),
(27, 'Poson Full Moon Poya Day'),
(30, 'Saturday');

-- --------------------------------------------------------

--
-- Table structure for table `leave_details`
--

DROP TABLE IF EXISTS `leave_details`;
CREATE TABLE IF NOT EXISTS `leave_details` (
  `row_id` int(5) NOT NULL,
  `emp_no` int(5) NOT NULL,
  `leave_type` varchar(100) NOT NULL,
  `no_of_days` double NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `resuming_date` date NOT NULL,
  `leave_details` varchar(100) NOT NULL,
  `acting_name` varchar(100) NOT NULL,
  `accepted` varchar(20) NOT NULL DEFAULT 'not-accepted',
  `checked` varchar(10) NOT NULL DEFAULT 'unchecked',
  PRIMARY KEY (`row_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `leave_details`
--

INSERT INTO `leave_details` (`row_id`, `emp_no`, `leave_type`, `no_of_days`, `start_date`, `end_date`, `resuming_date`, `leave_details`, `acting_name`, `accepted`, `checked`) VALUES
(1, 320, 'Casual', 1, '2018-03-02', '2018-03-02', '2018-03-05', 'Apply a personal leave', '', 'not-accepted', 'unchecked'),
(2, 320, 'Duty ', 0.5, '2018-02-28', '2018-02-28', '2018-03-02', 'To Meet Programmer to get details about Vehicle Permit software(HalfDay)', '', 'not-accepted', 'unchecked'),
(3, 275, 'Casual', 1, '2018-03-01', '2018-03-01', '2018-03-02', 'For Annual Trip ', 'Kathaluwa Liyana Kankanamge Jeewan Lakmal', 'not-accepted', 'checked'),
(4, 275, 'Casual', 1, '2018-03-13', '2018-03-13', '2018-03-14', 'rain', 'Kathaluwa Liyana Kankanamge Jeewan Lakmal', 'not-accepted', 'checked'),
(5, 275, 'Medical', 2, '2018-03-22', '2018-03-26', '2018-03-27', 'sick leave', 'Kathaluwa Liyana Kankanamge Jeewan Lakmal', 'not-accepted', 'checked'),
(6, 275, 'Casual', 1, '2018-03-30', '2018-04-02', '2018-04-03', 'sick leave', 'Kathaluwa Liyana Kankanamge Jeewan Lakmal', 'accepted', 'checked'),
(7, 275, 'Casual', 0.5, '2018-04-12', '2018-04-12', '2018-04-16', 'Personal', 'Jeewan Lakmal', 'not-accepted', 'checked');

-- --------------------------------------------------------

--
-- Table structure for table `login_details`
--

DROP TABLE IF EXISTS `login_details`;
CREATE TABLE IF NOT EXISTS `login_details` (
  `emp_no` int(5) NOT NULL,
  `user_name` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL,
  PRIMARY KEY (`emp_no`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login_details`
--

INSERT INTO `login_details` (`emp_no`, `user_name`, `password`) VALUES
(193, 'ach193', 'ach193'),
(275, 'rashini', '1234'),
(25, 'erangika', '1234'),
(35, 'sanjeewa', '1234'),
(10, 'wasantha', '1234'),
(440, 'aru440', 'aru440'),
(191, 'kat191', 'kat191'),
(320, 'kal320', 'kal320'),
(0, 'Admin', 'cso*LH18'),
(123, 'kal123', 'kal123');

-- --------------------------------------------------------

--
-- Table structure for table `march_leave_schedule`
--

DROP TABLE IF EXISTS `march_leave_schedule`;
CREATE TABLE IF NOT EXISTS `march_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `march_leave_schedule`
--

INSERT INTO `march_leave_schedule` (`dates`, `leave_status`) VALUES
(1, '\'Medin\' Full Moon Poya Day'),
(3, 'Saturday'),
(4, 'Sunday'),
(10, 'Saturday'),
(11, 'Sunday'),
(17, 'Saturday'),
(18, 'Sunday'),
(24, 'Saturday'),
(25, 'Sunday'),
(30, 'Good Friday'),
(31, '\'Bak\' Full Moon Poya Day');

-- --------------------------------------------------------

--
-- Table structure for table `may_leave_schedule`
--

DROP TABLE IF EXISTS `may_leave_schedule`;
CREATE TABLE IF NOT EXISTS `may_leave_schedule` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `may_leave_schedule`
--

INSERT INTO `may_leave_schedule` (`dates`, `leave_status`) VALUES
(5, 'Saturday'),
(6, 'Sunday'),
(7, 'May Day(Changed by government)'),
(12, 'Saturday'),
(13, 'Sunday'),
(19, 'Saturday'),
(20, 'Sunday'),
(26, 'Saturday'),
(27, 'Sunday'),
(29, '\'Adi-Poson\' Full Moon Poya Day');

-- --------------------------------------------------------

--
-- Table structure for table `november_leave_dates`
--

DROP TABLE IF EXISTS `november_leave_dates`;
CREATE TABLE IF NOT EXISTS `november_leave_dates` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `november_leave_dates`
--

INSERT INTO `november_leave_dates` (`dates`, `leave_status`) VALUES
(3, 'Saturday'),
(4, 'Sunday'),
(6, 'Deepavali Day'),
(10, 'Saturday'),
(11, 'Sunday'),
(17, 'Saturday'),
(18, 'Sunday'),
(20, 'Milad-Un-Nabi Day'),
(22, '\'Ill\' Full Moon Poya Day'),
(24, 'Saturday'),
(25, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `october_leave_dates`
--

DROP TABLE IF EXISTS `october_leave_dates`;
CREATE TABLE IF NOT EXISTS `october_leave_dates` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `october_leave_dates`
--

INSERT INTO `october_leave_dates` (`dates`, `leave_status`) VALUES
(6, 'Saturday'),
(7, 'Sunday'),
(13, 'Saturday'),
(14, 'Sunday'),
(20, 'Saturday'),
(21, 'Sunday'),
(24, '\'Vap\' Full Moon Poya Day'),
(27, 'Saturday'),
(28, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `personal_details`
--

DROP TABLE IF EXISTS `personal_details`;
CREATE TABLE IF NOT EXISTS `personal_details` (
  `emp_no` int(5) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone_no` int(10) NOT NULL,
  `post` varchar(100) NOT NULL,
  `branch_name` varchar(100) NOT NULL,
  PRIMARY KEY (`emp_no`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `personal_details`
--

INSERT INTO `personal_details` (`emp_no`, `full_name`, `phone_no`, `post`, `branch_name`) VALUES
(320, 'Kalu Arachchige Hasara Semini', 715123729, 'ICT Assistant', 'Information And Technology'),
(275, 'Thuiya Hannadige Rashini Madumanthi', 775803594, 'Management Assistant 111', 'Establishment'),
(35, 'S.H.Sanjeewa Senawirathne', 715123729, 'Assistant Chief Secretary(Establishment)', 'Establishment'),
(25, 'E.Patuwathawithana', 715123729, 'Assistant Chief Secretary(Administration)', 'Administration'),
(10, 'Wasantha Ranawaka', 715123729, 'Accountant(Supply)', 'Supply'),
(440, 'Arumapperuma Kankanamgei Dileep', 778149932, 'Office Employment Service', 'Establishment'),
(191, 'Kathaluwa Liyana Kankanamge Jeewan Lakmal', 716258807, 'Management Assistant', 'Establishment'),
(193, 'Achini Yuwantha De Silva', 715123729, 'Management Assistant', 'Establishment'),
(123, 'Kalu Arachchige Susith Kanchana', 715123729, 'IO', 'Addministration');

-- --------------------------------------------------------

--
-- Table structure for table `september_leave_dates`
--

DROP TABLE IF EXISTS `september_leave_dates`;
CREATE TABLE IF NOT EXISTS `september_leave_dates` (
  `dates` int(11) NOT NULL,
  `leave_status` varchar(50) NOT NULL,
  PRIMARY KEY (`dates`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `september_leave_dates`
--

INSERT INTO `september_leave_dates` (`dates`, `leave_status`) VALUES
(1, 'Saturday'),
(2, 'Sunday'),
(8, 'Saturday'),
(9, 'Sunday'),
(15, 'Saturday'),
(16, 'Sunday'),
(22, 'Saturday'),
(23, 'Sunday'),
(24, '\'Binara\' Full Moon Poya Day'),
(29, 'Saturday'),
(30, 'Sunday');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
