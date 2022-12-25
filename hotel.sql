-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2019 at 02:38 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel management`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `room_no` int(2) NOT NULL,
  `customer_name` varchar(20) NOT NULL,
  `address` varchar(20) NOT NULL,
  `contact` int(20) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`room_no`, `customer_name`, `address`, `contact`, `status`) VALUES
(11, 'amin', 'dhaka', 1954328967, 'booked'),
(12, '', '', 0, 'vacant'),
(13, 'saif', 'dhaka', 1434543422, 'booked'),
(14, 'foisal', 'sylhet', 1534231256, 'booked'),
(15, '', '', 0, 'vacant'),
(16, '', '', 0, 'vacant');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(2) NOT NULL,
  `emp_name` varchar(20) NOT NULL,
  `position` varchar(20) NOT NULL,
  `salary` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `emp_name`, `position`, `salary`) VALUES
(12, 'rahim', 'reciptionist', 20000),
(13, 'karim', 'cleaner', 4000),
(14, 'fahim', 'driver', 10000),
(15, 'samim', 'gard', 6000),
(16, 'jamil', 'gard', 6000);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(1) NOT NULL,
  `user name` varchar(20) NOT NULL,
  `passward` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `user name`, `passward`) VALUES
(1, 'manager', '2234'),
(2, 'reciptionist', '2245');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD UNIQUE KEY `room_no` (`room_no`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD UNIQUE KEY `id` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
