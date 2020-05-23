-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 26, 2019 at 02:06 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `farm`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Eid` int(10) NOT NULL,
  `FullName` varchar(20) NOT NULL,
  `Address` varchar(20) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Position` varchar(20) NOT NULL,
  `Salary` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`Eid`, `FullName`, `Address`, `Phone`, `Position`, `Salary`) VALUES
(123, 'abid', 'kuril', '0186969696', 'farmer', '10000'),
(17001, 'Rahim Ahmed', 'Bashundhara', '01819271374', 'Farmer', '10000'),
(17002, 'Md.Salah', 'Badda', '01716327634', 'Driver', '7000'),
(17003, 'Messi Rahman', 'Kuril', '01619271374', 'Porter', '5000');

-- --------------------------------------------------------

--
-- Table structure for table `fertilizer`
--

CREATE TABLE `fertilizer` (
  `Frid` int(5) NOT NULL,
  `FrName` varchar(20) NOT NULL,
  `Rate` int(10) NOT NULL,
  `Quantity` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fertilizer`
--

INSERT INTO `fertilizer` (`Frid`, `FrName`, `Rate`, `Quantity`) VALUES
(1, 'Nitrogen', 100, 20),
(2, 'phosphorus', 120, 5),
(3, 'Potassium', 110, 4),
(4, 'Eurea', 130, 10);

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `Fid` int(5) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Quantity` double NOT NULL,
  `Type` varchar(10) NOT NULL,
  `PRate` int(10) NOT NULL,
  `SRate` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`Fid`, `Fname`, `Quantity`, `Type`, `PRate`, `SRate`) VALUES
(1, 'Rice', 30, 'Crops', 50, 60),
(2, 'Potato', 30, 'Vegetable', 20, 30),
(3, 'Mango', 40, 'Fruit', 60, 70),
(18, 'Rice', 10, 'Crops', 60, 70);

-- --------------------------------------------------------

--
-- Table structure for table `foodtype`
--

CREATE TABLE `foodtype` (
  `FTid` int(5) NOT NULL,
  `FTname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `foodtype`
--

INSERT INTO `foodtype` (`FTid`, `FTname`) VALUES
(1, 'Vegetable'),
(2, 'Crop'),
(3, 'Fruit');

-- --------------------------------------------------------

--
-- Table structure for table `pesticide`
--

CREATE TABLE `pesticide` (
  `Pid` int(5) NOT NULL,
  `Pname` varchar(20) NOT NULL,
  `Ptype` varchar(10) NOT NULL,
  `Rate` int(50) NOT NULL,
  `Quantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pesticide`
--

INSERT INTO `pesticide` (`Pid`, `Pname`, `Ptype`, `Rate`, `Quantity`) VALUES
(1, 'Herbicide', 'Liquid', 50, 30);

-- --------------------------------------------------------

--
-- Table structure for table `presticidetype`
--

CREATE TABLE `presticidetype` (
  `PTid` int(5) NOT NULL,
  `PTname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `presticidetype`
--

INSERT INTO `presticidetype` (`PTid`, `PTname`) VALUES
(1, 'Liquid'),
(2, 'Gas'),
(3, 'Solid');

-- --------------------------------------------------------

--
-- Table structure for table `seed`
--

CREATE TABLE `seed` (
  `Sid` int(5) NOT NULL,
  `Sname` varchar(20) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Rate` int(10) NOT NULL,
  `Quantity` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `seed`
--

INSERT INTO `seed` (`Sid`, `Sname`, `Type`, `Rate`, `Quantity`) VALUES
(1, 'Rice', 'Crops', 300, 70),
(2, 'Potato', 'Vegetable', 100, 30),
(3, 'Mango', 'Fruit', 90, 40);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `TRid` int(5) NOT NULL,
  `TRname` varchar(20) NOT NULL,
  `TRType` varchar(20) NOT NULL,
  `Price` int(10) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`TRid`, `TRname`, `TRType`, `Price`, `Description`, `Date`) VALUES
(1, 'salary', 'debit', 25000, 'Salary Expense', '0000-00-00'),
(2, 'Seeds', 'debit', 10000, 'Seeds Expense', '0000-00-00'),
(4, 'Fertilizer', 'debit', 10000, 'Fertilizer Expense', '0000-00-00'),
(33, 'Rice', 'credit', 600, 'Rice Sold', '2019-07-26'),
(34, 'Rice production', 'debit', 500, 'Production Expense', '2019-07-26'),
(35, 'Rice production', 'debit', 600, 'Production Expense', '2019-07-26'),
(36, 'Rice', 'credit', 600, 'Rice Sold', '2019-07-26');

-- --------------------------------------------------------

--
-- Table structure for table `treatment`
--

CREATE TABLE `treatment` (
  `Tid` int(10) NOT NULL,
  `Tname` varchar(20) NOT NULL,
  `Symptom` varchar(50) NOT NULL,
  `Pname` varchar(10) NOT NULL,
  `Frname` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `treatment`
--

INSERT INTO `treatment` (`Tid`, `Tname`, `Symptom`, `Pname`, `Frname`) VALUES
(1, 'Blight', 'fungus infection', 'Fungicide', 'Urea'),
(2, 'Black Knot', 'dying leaves', 'Hydroxide', 'Urea'),
(3, 'Hernia', 'dots', 'Phenyl', 'Nitrogen');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Uid` int(10) NOT NULL,
  `Uname` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Email` varchar(20) NOT NULL,
  `Address` varchar(20) NOT NULL,
  `Password` varchar(10) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `Position` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Uid`, `Uname`, `Phone`, `Email`, `Address`, `Password`, `Position`) VALUES
(1, 's', '01869302597', 'gamersajid777@gmail.', 'Kuril', 's', 'Owner'),
(2, 'm', '01845652165', 'manager@gmail.com', 'Bashundhara', 'm', 'Manager');

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE `warehouse` (
  `Wid` int(5) NOT NULL,
  `Wname` varchar(20) NOT NULL,
  `FoodName` varchar(20) NOT NULL,
  `Quantity` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`Wid`, `Wname`, `FoodName`, `Quantity`) VALUES
(1, 'Wellmart', 'Mango', 200),
(2, 'Foodcrate', 'Rice', 1049),
(3, 'Redix', 'Potato', 100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Eid`);

--
-- Indexes for table `fertilizer`
--
ALTER TABLE `fertilizer`
  ADD PRIMARY KEY (`Frid`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`Fid`);

--
-- Indexes for table `foodtype`
--
ALTER TABLE `foodtype`
  ADD PRIMARY KEY (`FTid`);

--
-- Indexes for table `pesticide`
--
ALTER TABLE `pesticide`
  ADD PRIMARY KEY (`Pid`);

--
-- Indexes for table `presticidetype`
--
ALTER TABLE `presticidetype`
  ADD PRIMARY KEY (`PTid`);

--
-- Indexes for table `seed`
--
ALTER TABLE `seed`
  ADD PRIMARY KEY (`Sid`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`TRid`);

--
-- Indexes for table `treatment`
--
ALTER TABLE `treatment`
  ADD PRIMARY KEY (`Tid`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Uid`);

--
-- Indexes for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`Wid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `Eid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17004;

--
-- AUTO_INCREMENT for table `fertilizer`
--
ALTER TABLE `fertilizer`
  MODIFY `Frid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `Fid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `foodtype`
--
ALTER TABLE `foodtype`
  MODIFY `FTid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pesticide`
--
ALTER TABLE `pesticide`
  MODIFY `Pid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `presticidetype`
--
ALTER TABLE `presticidetype`
  MODIFY `PTid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `seed`
--
ALTER TABLE `seed`
  MODIFY `Sid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `TRid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `treatment`
--
ALTER TABLE `treatment`
  MODIFY `Tid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Uid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `Wid` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
