-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 02, 2016 at 08:15 AM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 7.0.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phpmyadmin`
--
CREATE DATABASE IF NOT EXISTS `phpmyadmin` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `phpmyadmin`;

-- --------------------------------------------------------

--
-- Table structure for table `pma__bookmark`
--

CREATE TABLE `pma__bookmark` (
  `id` int(11) NOT NULL,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks';

-- --------------------------------------------------------

--
-- Table structure for table `pma__central_columns`
--

CREATE TABLE `pma__central_columns` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_length` text COLLATE utf8_bin,
  `col_collation` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_isNull` tinyint(1) NOT NULL,
  `col_extra` varchar(255) COLLATE utf8_bin DEFAULT '',
  `col_default` text COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Central list of columns';

-- --------------------------------------------------------

--
-- Table structure for table `pma__column_info`
--

CREATE TABLE `pma__column_info` (
  `id` int(5) UNSIGNED NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__designer_settings`
--

CREATE TABLE `pma__designer_settings` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `settings_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Settings related to Designer';

--
-- Dumping data for table `pma__designer_settings`
--

INSERT INTO `pma__designer_settings` (`username`, `settings_data`) VALUES
('root', '{"angular_direct":"direct","snap_to_grid":"off","relation_lines":"true","full_screen":"on"}');

-- --------------------------------------------------------

--
-- Table structure for table `pma__export_templates`
--

CREATE TABLE `pma__export_templates` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `export_type` varchar(10) COLLATE utf8_bin NOT NULL,
  `template_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `template_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved export templates';

-- --------------------------------------------------------

--
-- Table structure for table `pma__favorite`
--

CREATE TABLE `pma__favorite` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Favorite tables';

-- --------------------------------------------------------

--
-- Table structure for table `pma__history`
--

CREATE TABLE `pma__history` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sqlquery` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__navigationhiding`
--

CREATE TABLE `pma__navigationhiding` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Hidden items of navigation tree';

-- --------------------------------------------------------

--
-- Table structure for table `pma__pdf_pages`
--

CREATE TABLE `pma__pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) UNSIGNED NOT NULL,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__recent`
--

CREATE TABLE `pma__recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Dumping data for table `pma__recent`
--

INSERT INTO `pma__recent` (`username`, `tables`) VALUES
('root', '[{"db":"projectdb","table":"ordetail"},{"db":"projectdb","table":"product"},{"db":"projectdb","table":"bill"},{"db":"projectdb","table":"billdetail"},{"db":"projectdb","table":"income"},{"db":"projectdb","table":"orders"},{"db":"projectdb","table":"employee"},{"db":"projectdb","table":"paydivem"},{"db":"projectdb","table":"paydivmem"},{"db":"projectdb","table":"recieve"}]');

-- --------------------------------------------------------

--
-- Table structure for table `pma__relation`
--

CREATE TABLE `pma__relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

--
-- Dumping data for table `pma__relation`
--

INSERT INTO `pma__relation` (`master_db`, `master_table`, `master_field`, `foreign_db`, `foreign_table`, `foreign_field`) VALUES
('projectdb', 'Bill', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'Expen', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'ProDetail', 'Pcode', 'projectdb', 'product', 'Pcode'),
('projectdb', 'ProDetail', 'TPcode', 'projectdb', 'product', 'TPcode'),
('projectdb', 'Supdetail', 'Pcode', 'projectdb', 'product', 'Pcode'),
('projectdb', 'Supdetail', 'SUPcode', 'projectdb', 'supplier', 'SUPcode'),
('projectdb', 'Supdetail', 'TPcode', 'projectdb', 'product', 'TPcode'),
('projectdb', 'adddiv', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'adddiv', 'Mid', 'projectdb', 'member', 'Mid'),
('projectdb', 'bill', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'bill', 'Mid', 'projectdb', 'member', 'Mid'),
('projectdb', 'billdetail', 'Bcode', 'projectdb', 'bill', 'Bcode'),
('projectdb', 'billdetail', 'Bdate', 'projectdb', 'bill', 'Bdate'),
('projectdb', 'billdetail', 'Pcode', 'projectdb', 'product', 'Pcode'),
('projectdb', 'billdetail', 'TPcode', 'projectdb', 'product', 'TPcode'),
('projectdb', 'expen', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'orders', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'ordetail', 'ORcode', 'projectdb', 'orders', 'ORcode'),
('projectdb', 'ordetail', 'ORdate', 'projectdb', 'orders', 'ORdate'),
('projectdb', 'ordetail', 'Pcode', 'projectdb', 'supdetail', 'Pcode'),
('projectdb', 'ordetail', 'SUPcode', 'projectdb', 'supdetail', 'SUPcode'),
('projectdb', 'ordetail', 'TPcode', 'projectdb', 'supdetail', 'TPcode'),
('projectdb', 'paydivem', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'paydivmem', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'paydivmem', 'Mid', 'projectdb', 'member', 'Mid'),
('projectdb', 'product', 'TPcode', 'projectdb', 'typepro', 'TPcode'),
('projectdb', 'proexpen', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'recieve', 'PEcode', 'projectdb', 'proexpen', 'PEcode'),
('projectdb', 'recieve', 'PEdate', 'projectdb', 'proexpen', 'PEdate'),
('projectdb', 'recieve', 'Pcode', 'projectdb', 'supdetail', 'Pcode'),
('projectdb', 'recieve', 'SUPcode', 'projectdb', 'supdetail', 'SUPcode'),
('projectdb', 'recieve', 'TPcode', 'projectdb', 'supdetail', 'TPcode'),
('projectdb', 'subdiv', 'EMid', 'projectdb', 'employee', 'EMid'),
('projectdb', 'subdiv', 'Mid', 'projectdb', 'member', 'Mid'),
('projectdb', 'supdetail', 'Pcode', 'projectdb', 'product', 'Pcode'),
('projectdb', 'supdetail', 'SUPcode', 'projectdb', 'supplier', 'SUPcode'),
('projectdb', 'supdetail', 'TPcode', 'projectdb', 'product', 'TPcode');

-- --------------------------------------------------------

--
-- Table structure for table `pma__savedsearches`
--

CREATE TABLE `pma__savedsearches` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved searches';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_coords`
--

CREATE TABLE `pma__table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT '0',
  `x` float UNSIGNED NOT NULL DEFAULT '0',
  `y` float UNSIGNED NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_info`
--

CREATE TABLE `pma__table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_uiprefs`
--

CREATE TABLE `pma__table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

--
-- Dumping data for table `pma__table_uiprefs`
--

INSERT INTO `pma__table_uiprefs` (`username`, `db_name`, `table_name`, `prefs`, `last_update`) VALUES
('root', 'projectdb', 'employee', '{"sorted_col":"`EMid` ASC"}', '2016-05-02 20:50:45'),
('root', 'projectdb', 'ordetail', '{"sorted_col":"`ordetail`.`TPcode`  DESC"}', '2016-06-02 06:12:40'),
('root', 'projectdb', 'product', '[]', '2016-04-26 14:51:35'),
('root', 'projectdb', 'supdetail', '[]', '2016-04-22 20:26:30');

-- --------------------------------------------------------

--
-- Table structure for table `pma__tracking`
--

CREATE TABLE `pma__tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) UNSIGNED NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin,
  `data_sql` longtext COLLATE utf8_bin,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) UNSIGNED NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__userconfig`
--

CREATE TABLE `pma__userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `config_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Dumping data for table `pma__userconfig`
--

INSERT INTO `pma__userconfig` (`username`, `timevalue`, `config_data`) VALUES
('root', '2016-04-04 15:18:00', '{"collation_connection":"utf8mb4_unicode_ci"}');

-- --------------------------------------------------------

--
-- Table structure for table `pma__usergroups`
--

CREATE TABLE `pma__usergroups` (
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL,
  `tab` varchar(64) COLLATE utf8_bin NOT NULL,
  `allowed` enum('Y','N') COLLATE utf8_bin NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User groups with configured menu items';

-- --------------------------------------------------------

--
-- Table structure for table `pma__users`
--

CREATE TABLE `pma__users` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Users and their assignments to user groups';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pma__central_columns`
--
ALTER TABLE `pma__central_columns`
  ADD PRIMARY KEY (`db_name`,`col_name`);

--
-- Indexes for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`);

--
-- Indexes for table `pma__designer_settings`
--
ALTER TABLE `pma__designer_settings`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_user_type_template` (`username`,`export_type`,`template_name`);

--
-- Indexes for table `pma__favorite`
--
ALTER TABLE `pma__favorite`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__history`
--
ALTER TABLE `pma__history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`,`db`,`table`,`timevalue`);

--
-- Indexes for table `pma__navigationhiding`
--
ALTER TABLE `pma__navigationhiding`
  ADD PRIMARY KEY (`username`,`item_name`,`item_type`,`db_name`,`table_name`);

--
-- Indexes for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  ADD PRIMARY KEY (`page_nr`),
  ADD KEY `db_name` (`db_name`);

--
-- Indexes for table `pma__recent`
--
ALTER TABLE `pma__recent`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__relation`
--
ALTER TABLE `pma__relation`
  ADD PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  ADD KEY `foreign_field` (`foreign_db`,`foreign_table`);

--
-- Indexes for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_savedsearches_username_dbname` (`username`,`db_name`,`search_name`);

--
-- Indexes for table `pma__table_coords`
--
ALTER TABLE `pma__table_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`);

--
-- Indexes for table `pma__table_info`
--
ALTER TABLE `pma__table_info`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma__table_uiprefs`
--
ALTER TABLE `pma__table_uiprefs`
  ADD PRIMARY KEY (`username`,`db_name`,`table_name`);

--
-- Indexes for table `pma__tracking`
--
ALTER TABLE `pma__tracking`
  ADD PRIMARY KEY (`db_name`,`table_name`,`version`);

--
-- Indexes for table `pma__userconfig`
--
ALTER TABLE `pma__userconfig`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__usergroups`
--
ALTER TABLE `pma__usergroups`
  ADD PRIMARY KEY (`usergroup`,`tab`,`allowed`);

--
-- Indexes for table `pma__users`
--
ALTER TABLE `pma__users`
  ADD PRIMARY KEY (`username`,`usergroup`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__history`
--
ALTER TABLE `pma__history`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  MODIFY `page_nr` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;--
-- Database: `projectdb`
--
CREATE DATABASE IF NOT EXISTS `projectdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `projectdb`;

-- --------------------------------------------------------

--
-- Table structure for table `adddiv`
--

CREATE TABLE `adddiv` (
  `ADcode` bigint(50) NOT NULL,
  `ADdate` date NOT NULL,
  `ADamount` int(2) NOT NULL,
  `ADvalue` double NOT NULL,
  `Mid` bigint(50) NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `adddiv`
--

INSERT INTO `adddiv` (`ADcode`, `ADdate`, `ADamount`, `ADvalue`, `Mid`, `EMid`) VALUES
(1, '2016-05-02', 12, 230, 1, 2),
(2, '2016-05-02', 3, 300, 1, 1),
(3, '2016-05-02', 1, 100, 1, 1),
(4, '2016-05-02', 1, 100, 1, 1),
(5, '2016-05-02', 1, 100, 1, 1),
(6, '2016-05-03', 1, 100, 9, 1),
(8, '2016-05-03', 1, 100, 8, 1),
(9, '2016-05-03', 4, 400, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `Bcode` bigint(50) NOT NULL,
  `Bdate` date NOT NULL,
  `Ball` int(5) NOT NULL,
  `Bpay` float NOT NULL,
  `EMid` bigint(50) NOT NULL,
  `Mid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`Bcode`, `Bdate`, `Ball`, `Bpay`, `EMid`, `Mid`) VALUES
(1, '2016-05-03', 20, 100, 1, 11),
(1, '2016-05-31', 11, 1222, 1, 2),
(2, '2016-05-02', 2, 10, 1, 1),
(3, '2016-05-02', 1, 5, 1, 1),
(4, '2016-05-02', 1, 5, 1, 1),
(5, '2016-05-02', 2, 10, 1, 1),
(6, '2016-04-06', 100, 1200, 1, 2),
(7, '2016-04-08', 23, 1234, 1, 2),
(8, '2016-04-08', 12, 1234, 2, 3),
(9, '2016-04-19', 21, 2500, 2, 3),
(10, '2016-04-04', 21, 1209, 1, 4),
(11, '2016-04-05', 10, 1200, 2, 4),
(12, '2016-04-15', 3, 212, 1, 5),
(13, '2016-04-18', 12, 300, 1, 5),
(14, '2016-04-19', 21, 200, 1, 6),
(15, '2016-05-17', 10, 1000, 1, 6),
(16, '2016-04-20', 23, 200, 1, 7),
(17, '2016-04-20', 21, 200, 1, 7),
(18, '2016-04-02', 2, 200, 1, 8),
(19, '2016-04-06', 34, 211, 2, 8),
(20, '2016-03-23', 3, 300, 1, 9),
(21, '2016-04-19', 21, 300, 1, 9),
(22, '2016-04-13', 21, 4000, 2, 10),
(23, '2016-04-29', 13, 300, 1, 10),
(24, '2016-04-14', 23, 3400, 1, 11),
(25, '2016-05-02', 21, 2300, 2, 12),
(26, '2016-04-21', 12, 100, 1, 11),
(27, '2016-04-20', 12, 2000, 3, 13),
(28, '2016-04-21', 12, 321, 2, 13),
(29, '2016-04-21', 12, 2000, 2, 14),
(30, '2016-04-14', 20, 235, 1, 14),
(31, '2016-04-28', 43, 2345, 1, 15),
(32, '2016-04-14', 2, 300, 2, 16),
(33, '2016-04-27', 4, 100, 1, 17),
(34, '2016-04-02', 12, 200, 2, 16),
(35, '2016-04-15', 23, 300, 2, 17),
(36, '2016-04-21', 3, 320, 1, 17),
(37, '2016-04-28', 20, 320, 1, 18),
(38, '2016-04-14', 20, 1200, 1, 18),
(39, '2016-04-15', 3, 300, 2, 19),
(40, '2016-04-08', 12, 132, 2, 20),
(41, '2016-04-27', 2, 200, 2, 21),
(42, '2016-04-21', 12, 230, 2, 22),
(43, '2016-05-01', 2, 450, 1, 23),
(44, '2016-04-15', 5, 200, 2, 24),
(45, '2016-04-21', 4, 230, 1, 25),
(46, '2016-05-01', 2, 190, 2, 26),
(47, '2016-04-27', 13, 230, 2, 27),
(48, '2016-04-28', 12, 123, 2, 28),
(49, '2016-05-01', 10, 120, 1, 29),
(50, '2016-05-01', 2, 120, 1, 2),
(51, '2016-04-28', 2, 213, 1, 30),
(52, '2016-05-02', 2, 67, 1, 1),
(53, '2016-05-02', 2, 44, 1, 1),
(54, '2016-05-02', 1, 5, 1, 1),
(55, '2016-05-02', 2, 47, 2, 1),
(56, '2016-05-02', 1, 43, 1, 2),
(57, '2016-05-02', 2, 39, 1, 3),
(58, '2016-05-02', 1, 40, 1, 2),
(59, '2016-05-02', 2, 91, 1, 4),
(60, '2016-05-02', 2, 195, 1, 6),
(61, '2016-05-02', 2, 108, 1, 3),
(62, '2016-05-02', 2, 65, 1, 1),
(63, '2016-05-02', 2, 162, 1, 4),
(64, '2016-05-02', 2, 25, 2, 2),
(65, '2016-05-02', 2, 165, 1, 6),
(66, '2016-05-02', 2, 36, 2, 2),
(67, '2016-05-02', 2, 40, 2, 6),
(68, '2016-05-02', 2, 91, 2, 3),
(69, '2016-05-02', 2, 205, 1, 1),
(70, '2016-05-02', 2, 55, 1, 3),
(71, '2016-05-02', 2, 149, 2, 3),
(72, '2016-05-02', 2, 149, 1, 2),
(73, '2016-05-03', 4, 144, 1, 4),
(74, '2016-05-03', 2, 57.75, 1, 1),
(75, '2016-05-03', 2, 30, 1, 1),
(76, '2016-05-03', 2, 175, 1, 7),
(77, '2016-05-25', 12, 123333, 1, 17),
(78, '2016-05-26', 11, 12333, 1, 15),
(79, '2016-06-01', 1, 200, 1, 6),
(80, '2016-05-30', 12, 12333, 1, 1),
(81, '2016-05-31', 1, 1234, 1, 1),
(82, '2016-06-01', 12, 1234, 1, 1),
(83, '2016-06-02', 12, 456, 1, 1),
(84, '2016-05-29', 12, 12333, 1, 2),
(85, '2016-05-30', 12, 10000, 1, 2),
(86, '2016-06-01', 11, 111111, 1, 2),
(88, '2016-05-30', 12, 12222, 1, 3),
(89, '2016-05-31', 11, 11111, 1, 3),
(90, '2016-06-01', 12, 12333, 1, 3),
(91, '2016-06-02', 1, 1111, 2, 3),
(92, '2016-06-01', 12, 1111, 1, 4),
(93, '2016-06-02', 1, 111, 1, 4),
(94, '2016-06-01', 22, 1111, 1, 5),
(95, '2016-06-02', 1, 111, 1, 5);

-- --------------------------------------------------------

--
-- Table structure for table `billdetail`
--

CREATE TABLE `billdetail` (
  `Bcode` bigint(50) NOT NULL,
  `Bdate` date NOT NULL,
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `Pcode` bigint(50) NOT NULL,
  `BDamount` int(5) NOT NULL,
  `BDpay` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `billdetail`
--

INSERT INTO `billdetail` (`Bcode`, `Bdate`, `TPcode`, `Pcode`, `BDamount`, `BDpay`) VALUES
(1, '2016-05-03', 'A', 1, 20, 2000),
(2, '2016-05-02', 'A', 1, 1, 5),
(3, '2016-05-02', 'A', 1, 1, 5),
(4, '2016-05-02', 'A', 1, 1, 5),
(52, '2016-05-02', 'C', 29, 1, 27),
(53, '2016-05-02', 'D', 44, 1, 34),
(54, '2016-05-02', 'A', 2, 1, 5),
(55, '2016-05-02', 'C', 29, 1, 27),
(56, '2016-05-02', 'B', 18, 1, 43),
(57, '2016-05-02', 'D', 45, 1, 27),
(58, '2016-05-02', 'C', 29, 2, 40),
(59, '2016-05-02', 'C', 40, 3, 81),
(60, '2016-05-02', 'F', 75, 1, 15),
(61, '2016-05-02', 'C', 28, 2, 40),
(64, '2016-05-02', 'A', 4, 1, 20),
(65, '2016-05-02', 'E', 62, 3, 15),
(66, '2016-05-02', 'C', 30, 1, 12),
(66, '2016-05-02', 'D', 45, 2, 24),
(67, '2016-05-02', 'C', 40, 3, 15),
(68, '2016-05-02', 'B', 18, 2, 86),
(68, '2016-05-02', 'C', 41, 1, 5),
(69, '2016-05-02', 'D', 55, 1, 25),
(69, '2016-05-02', 'F', 75, 4, 180),
(70, '2016-05-02', 'C', 42, 2, 12),
(70, '2016-05-02', 'H', 91, 1, 43),
(71, '2016-05-02', 'B', 18, 3, 129),
(71, '2016-05-02', 'D', 58, 1, 20),
(72, '2016-05-02', 'B', 18, 3, 129),
(72, '2016-05-02', 'C', 29, 1, 20),
(73, '2016-05-03', 'A', 3, 3, 15),
(73, '2016-05-03', 'B', 26, 1, 30),
(73, '2016-05-03', 'E', 63, 1, 54),
(73, '2016-05-03', 'F', 75, 1, 45),
(74, '2016-05-03', 'A', 1, 1, 3.75),
(74, '2016-05-03', 'B', 17, 2, 54),
(75, '2016-05-03', 'A', 2, 2, 10),
(75, '2016-05-03', 'C', 29, 1, 20),
(76, '2016-05-03', 'A', 2, 1, 5),
(76, '2016-05-03', 'B', 16, 5, 170),
(79, '2016-06-01', 'A', 10, 40, 200);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EMid` bigint(50) NOT NULL,
  `EMtype` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `EMname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `EMgen` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `EMcontact` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `EMpay` double NOT NULL,
  `EMsalary` int(5) NOT NULL,
  `EMuser` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `EMpass` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `EMstatus` char(1) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EMid`, `EMtype`, `EMname`, `EMgen`, `EMcontact`, `EMpay`, `EMsalary`, `EMuser`, `EMpass`, `EMstatus`) VALUES
(1, 'Em', 'นางลำไย เพชรนอก', 'หญิง', 'บ้านเลขที่ 1 ม.12 ต.ด้านคล้า อ.โนนสูง จ.นครราชสีมา', 0.2, 9000, 'thehug', '555', '1'),
(2, 'Em', 'นางละมุน มั่นกลาง', 'หญิง', 'บ้านเลขที่ 23 ม.12 ต.ด่านคล้า อ.โนนสูง จ.นครราชสีมา', 0.2, 9000, 'catwoman', 'catwoman', '1'),
(3, 'Sn', 'นางแจ่ม ปลั่งกลาง', 'หญิง', 'บ้านเลขที่ 2 ม.12 ต.ด้านคล้า อ.โนนสูง จ.นครราชสีมา', 0.2, 0, 'batman', '1234', '1'),
(4, 'SP', 'กมลพรรณ สวิทอิน', 'หญิง', '53/1 หมู่12 ต.ด่านคล้า อ.โนนสูง \nจ.นครราชสีมา', 0.5, 9000, 'superman', '12345678', '');

-- --------------------------------------------------------

--
-- Table structure for table `expen`
--

CREATE TABLE `expen` (
  `EXcode` bigint(50) NOT NULL,
  `EXname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `EXdate` date NOT NULL,
  `EXpay` float NOT NULL,
  `EXdetail` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `expen`
--

INSERT INTO `expen` (`EXcode`, `EXname`, `EXdate`, `EXpay`, `EXdetail`, `EMid`) VALUES
(1, 'ค่าน้ำ', '2016-05-01', 200, 'จ่ายให้น้า', 1);

-- --------------------------------------------------------

--
-- Table structure for table `income`
--

CREATE TABLE `income` (
  `INcode` bigint(20) NOT NULL,
  `INdate` date NOT NULL,
  `INvalue` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `income`
--

INSERT INTO `income` (`INcode`, `INdate`, `INvalue`) VALUES
(1, '2016-06-02', 174423);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `Mid` bigint(50) NOT NULL,
  `Mname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Mgen` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `Mpay` double NOT NULL,
  `Mstatus` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `MshAmount` int(2) NOT NULL,
  `MshValue` int(3) NOT NULL,
  `Mcontact` varchar(200) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`Mid`, `Mname`, `Mgen`, `Mpay`, `Mstatus`, `MshAmount`, `MshValue`, `Mcontact`) VALUES
(1, 'นายพงษ์แก้ว รักกลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 110 ม.12 ต.ด่านคล้า อ.โนนสูง จ.นครราชสีมา'),
(2, 'นางสมศรี มีโพธิ์', 'หญิง', 0.05, '1', 3, 300, 'บ้านเลขที่ 150 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(3, 'นายอยู่ หรภูมิ', 'ชาย', 0.05, '1', 4, 400, 'บ้านเลขที่ 160 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(4, 'นายวัน ยี่จอหอ', 'ชาย', 0.05, '1', 4, 400, 'บ้านเลขที่ 0170 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(5, 'นางวันเพ็ญ เจนด่านกลาง', 'หญิง', 0.05, '1', 2, 200, 'บ้านเลขที่ 120 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(6, 'นายปั่น เสริงกลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 130 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(7, 'นายเกิด นกกลาง', 'ชาย', 0.5, '1', 1, 100, 'บ้านเลขที่ 140 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(8, 'นายถนอม รักกลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 180 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(9, 'นางแสงจันทร์ วงศ์กลาง', 'หญิง', 0.05, '1', 1, 100, 'บ้านเลขที่ 190 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(10, 'นายเย็น หวังปักกลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 0200 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(11, 'นางเฉลียว รัตนศฤงค์', 'หญิง', 0.05, '1', 4, 400, 'บ้านเลขที่ 210 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(12, 'นางฟ้อง บิลด่านกลาง', 'หญิง', 0.05, '1', 3, 300, 'บ้านเลขที่ 220 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(13, 'นายลาด สำราญกลาง', 'ชาย', 0.05, '1', 2, 200, 'บ้านเลขที่ 0230 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(14, 'นายเลื่อน ไม้กลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 250 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(15, 'นางพอง กมลกลาง', 'หญิง', 0.05, '1', 5, 500, 'บ้านเลขที่ 260 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(16, 'นายจำรัส เยี่ยงกลาง', 'ชาย', 0.05, '1', 3, 300, 'บ้านเลขที่ 270 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(17, 'นายฉลวย ไม้กลาง', 'ชาย', 0.05, '1', 1, 100, 'บ้านเลขที่ 0280 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(18, 'นางอินไชย จัดกลาง', 'หญิง', 0.05, '1', 2, 200, 'บ้านเลขที่ 290 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(19, 'นางแฉล้ม ปิ่นวิเศษ', 'หญิง', 0.05, '1', 4, 400, 'บ้านเลขที่ 301 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(20, 'นางถวิล เกตุกลาง', 'หญิง', 0.05, '1', 5, 500, 'บ้านเลขที่ 302 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(21, 'นางทองอยู่ ชูใจ', 'หญิง', 0.05, '1', 2, 200, 'บ้านเลขที่ 303 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(22, 'นายสมทรัพย์ ยศกลาง', 'ชาย', 0.05, '1', 4, 400, 'บ้านเลขที่ 304 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(23, 'นางประสิทธิ์ ชาวไธสง', 'หญิง', 0.05, '1', 2, 200, 'บ้านเลขที่ 305 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(24, 'นางแช่ม สำราญกลาง', 'หญิง', 0.05, '1', 3, 300, 'บ้านเลขที่ 306 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(25, 'นางยวง ชัยกลาง', 'หญิง', 0.05, '1', 4, 400, 'บ้านเลขที่ 4 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(26, 'นายอาคาร เพ็งกลาง', 'ชาย', 0.05, '1', 2, 200, 'บ้านเลขที่ 308 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(27, 'นายสันติพงษ์ สำราญกลาง', 'ชาย', 0.05, '1', 2, 200, 'บ้านเลขที่ 310 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(28, 'นางเครือวรรณ ซึมกลาง', 'หญิง', 0.05, '1', 1, 100, 'บ้านเลขที่ 311 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(29, 'นางคูณ ปลั่งกลาง', 'หญิง', 0.05, '1', 2, 200, 'บ้านเลขที่ 312 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(30, 'นายเฮม ยันพิมาย', 'ชาย', 0.05, '1', 5, 500, 'บ้านเลขที่ 313 ม.12 ต.ด่านคลัง อ.โนนสูง จ.นครราชสีมา'),
(31, 'rff', 'หญิง', 0, '1', 0, 0, 'sss'),
(32, 'rr', 'ชาย', 0, '1', 0, 0, 'www');

-- --------------------------------------------------------

--
-- Table structure for table `memdiv`
--

CREATE TABLE `memdiv` (
  `Mid` bigint(50) NOT NULL,
  `Bcode` bigint(50) NOT NULL,
  `Bdate` date NOT NULL,
  `MDcode` bigint(50) NOT NULL,
  `MDdate` date NOT NULL,
  `MDpay` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `memdiv`
--

INSERT INTO `memdiv` (`Mid`, `Bcode`, `Bdate`, `MDcode`, `MDdate`, `MDpay`) VALUES
(2, 1, '2016-05-03', 1, '2016-05-04', 0.2);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `ORcode` bigint(50) NOT NULL,
  `ORdate` date NOT NULL,
  `ORorder` int(5) NOT NULL,
  `ORpay` float NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`ORcode`, `ORdate`, `ORorder`, `ORpay`, `EMid`) VALUES
(80, '2016-05-03', 1, 12, 1),
(81, '2016-05-03', 2, 115, 1),
(82, '2016-05-03', 2, 60, 1),
(83, '2016-05-03', 2, 30, 1),
(84, '2016-05-03', 2, 18, 1),
(85, '2016-05-03', 2, 40, 1),
(86, '2016-05-03', 1, 23, 2),
(87, '2016-05-16', 4, 2000, 1),
(88, '2016-05-15', 5, 2000, 2),
(89, '2016-05-09', 5, 100000, 1),
(91, '2016-05-19', 1, 120000, 3);

-- --------------------------------------------------------

--
-- Table structure for table `ordetail`
--

CREATE TABLE `ordetail` (
  `ORcode` bigint(50) NOT NULL,
  `ORdate` date NOT NULL,
  `SUPcode` bigint(50) NOT NULL,
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `Pcode` bigint(50) NOT NULL,
  `ORDamount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `ordetail`
--

INSERT INTO `ordetail` (`ORcode`, `ORdate`, `SUPcode`, `TPcode`, `Pcode`, `ORDamount`) VALUES
(80, '2016-05-03', 1, 'A', 2, 1),
(81, '2016-05-03', 1, 'B', 17, 1),
(82, '2016-05-03', 1, 'A', 2, 2),
(83, '2016-05-03', 1, 'A', 1, 1),
(84, '2016-05-03', 1, 'C', 29, 1),
(85, '2016-05-03', 1, 'B', 17, 1),
(86, '2016-05-03', 2, 'B', 16, 1);

-- --------------------------------------------------------

--
-- Table structure for table `paydivem`
--

CREATE TABLE `paydivem` (
  `PDEcode` bigint(50) NOT NULL,
  `PDEdate` date NOT NULL,
  `PDEstart` date NOT NULL,
  `PDEend` date NOT NULL,
  `PDEprofit` double NOT NULL,
  `PDEpay` double NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `paydivem`
--

INSERT INTO `paydivem` (`PDEcode`, `PDEdate`, `PDEstart`, `PDEend`, `PDEprofit`, `PDEpay`, `EMid`) VALUES
(1, '2016-04-30', '2016-04-30', '2016-04-30', 222, 12, 1),
(6, '2016-05-03', '2016-03-30', '2016-05-03', 15021.75, 3004.35, 4),
(7, '2016-05-03', '2016-03-30', '2016-05-03', 15021.75, 3004.35, 4),
(8, '2016-05-03', '2016-03-30', '2016-05-03', 15021.75, 3004.35, 4),
(9, '2016-05-03', '2016-03-30', '2016-05-03', 15021.75, 7510.875, 4),
(10, '2016-05-26', '2016-05-11', '2016-05-26', 1000, 200, 4),
(11, '2016-05-26', '2016-05-11', '2016-05-26', 1000, 200, 4),
(12, '2016-05-26', '2016-05-11', '2016-05-26', 1000, 200, 4),
(13, '2016-05-26', '2016-05-11', '2016-05-26', 1000, 500, 4),
(14, '2016-05-26', '2016-05-12', '2016-05-26', 1000, 200, 4),
(15, '2016-05-26', '2016-05-12', '2016-05-26', 1000, 200, 4),
(16, '2016-05-26', '2016-05-12', '2016-05-26', 1000, 200, 4),
(17, '2016-05-26', '2016-05-12', '2016-05-26', 1000, 500, 4),
(18, '2016-05-26', '2016-05-23', '2016-05-26', 123333, 24666.6, 4),
(19, '2016-05-26', '2016-05-23', '2016-05-26', 123333, 24666.6, 4),
(20, '2016-05-26', '2016-05-23', '2016-05-26', 123333, 24666.6, 4),
(21, '2016-05-26', '2016-05-23', '2016-05-26', 123333, 61666.5, 4),
(22, '2016-05-26', '2016-05-26', '2016-05-26', 12333, 2466.6, 4),
(23, '2016-05-26', '2016-05-26', '2016-05-26', 12333, 2466.6, 4),
(24, '2016-05-26', '2016-05-26', '2016-05-26', 12333, 2466.6, 4),
(25, '2016-05-26', '2016-05-26', '2016-05-26', 12333, 6166.5, 4);

-- --------------------------------------------------------

--
-- Table structure for table `paydivmem`
--

CREATE TABLE `paydivmem` (
  `PDMcode` bigint(50) NOT NULL,
  `PDMdate` date NOT NULL,
  `PDMstart` date NOT NULL,
  `PDMend` date NOT NULL,
  `PDMbill` double NOT NULL,
  `PDMpay` double NOT NULL,
  `EMid` bigint(50) NOT NULL,
  `Mid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `paydivmem`
--

INSERT INTO `paydivmem` (`PDMcode`, `PDMdate`, `PDMstart`, `PDMend`, `PDMbill`, `PDMpay`, `EMid`, `Mid`) VALUES
(10, '2016-04-30', '2016-04-02', '2016-04-30', 170, 8.5, 1, 1),
(11, '2016-04-30', '2016-04-30', '2016-04-30', 70, 3.5, 1, 1),
(12, '2016-04-30', '2016-04-08', '2016-04-30', 70, 3.5, 1, 1),
(13, '2016-05-03', '2016-04-07', '2016-05-03', 397, 198.5, 1, 4),
(14, '2016-05-03', '2016-03-31', '2016-05-03', 512, 256, 1, 5),
(15, '2016-05-03', '2016-04-15', '2016-05-03', 600, 300, 1, 6),
(16, '2016-05-03', '2016-04-13', '2016-05-03', 512, 25.6, 1, 5),
(17, '2016-05-03', '2016-04-06', '2016-05-03', 512, 25.6, 1, 5),
(18, '2016-06-02', '2016-05-31', '2016-06-02', 2924, 146.2, 1, 1),
(19, '2016-06-02', '2016-06-01', '2016-06-02', 111111, 5555.55, 1, 2),
(20, '2016-06-02', '2016-06-01', '2016-06-02', 13444, 672.2, 1, 3),
(21, '2016-06-02', '2016-06-01', '2016-06-02', 1222, 61.1, 1, 4);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Pcode` bigint(50) NOT NULL,
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `Pname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `Pprice` double NOT NULL,
  `Pamount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Pcode`, `TPcode`, `Pname`, `Pprice`, `Pamount`) VALUES
(1, 'A', 'เลย์ ขนาด 75 กรัม', 3.75, 18),
(2, 'A', 'ขนม แคมปัส', 5, 29),
(3, 'A', 'ขนม โปเต้', 5, 30),
(4, 'A', 'ขนม ตะวัน', 5, 40),
(5, 'A', 'ขนม ฮานามิ', 6, 50),
(6, 'A', 'ขนมโดนัท', 7, 50),
(7, 'A', 'ขนม ไก่ย่าง', 5, 50),
(8, 'A', 'ขนม ถั่วเจดีย์คู่', 5, 50),
(9, 'A', 'ขนม โรลเลอร์โคสเตอร์ แดง', 5, 50),
(10, 'A', 'ขนม โรลเลอร์โคสเตอร์ น้ำเงิน', 5, 10),
(11, 'A', 'ขนม สแน็คแจ็ค', 5, 50),
(12, 'A', 'ขนม ปาปีกา', 5, 50),
(13, 'A', 'ขนม ฟันโอ รสช็อกโคแลต', 6, 50),
(14, 'A', 'ขนม หมึกเบนโตะ', 5, 50),
(15, 'A', 'ขนม ปลาเส้นทาโร่', 5, 50),
(16, 'B', 'น้ำมันพืช มรกต 250มล.', 34, 49),
(17, 'B', 'ซีอิ้วขาว', 27, 49),
(18, 'B', 'ซอสหอยนางรม', 43, 47),
(19, 'B', 'น้ำปลา ทิพรส 330มล.', 32, 50),
(20, 'B', 'น้ำส้มสายชู', 20, 50),
(21, 'B', 'น้ำจิ้มไก้', 15, 50),
(22, 'B', 'พริกไทย', 30, 50),
(23, 'B', 'ซอสมะเขือเทศโรซ่า', 22, 50),
(24, 'B', 'กะทิกล่อง ชาวเกาะ 250 มล', 15, 50),
(25, 'B', 'ไข่ไก่', 4, 300),
(26, 'B', 'น้ำตาลทราย', 30, 200),
(27, 'B', 'เกลือ', 10, 100),
(28, 'C', 'ปลาราดพริก กระป๋อง', 17, 300),
(29, 'C', 'หอยลาย กระป๋อง', 20, 16),
(30, 'C', 'ผักกาด กระป๋อง', 12, 50),
(31, 'B', 'ผงชูรส ตราถ้วยแดง ', 7, 50),
(32, 'B', 'ซุปก้อน คนอร์ หมู', 12, 100),
(33, 'B', 'ซุปก้อน คนอร์ ไก่', 53, 100),
(34, 'B', 'ผงปรุงรส รสดีหมู', 12, 100),
(35, 'B', 'ซุปก้อน คนอร์ ต้มยำ', 10, 200),
(36, 'B', 'แป้งทอดกรอบ', 20, 100),
(37, 'C', 'มาม่า ต้มยำกุ้ง 90กรัม', 6, 300),
(38, 'C', 'มาม่า หมูสับ 90กรัม', 5, 500),
(39, 'C', 'มาม่า ต้มยำกุ้ง 55กรัม', 6, 300),
(40, 'C', 'ไวไว หมูสับต้มยำ', 5, 97),
(41, 'C', 'ไวไว ควิก ต้มโคล้ง', 5, 200),
(42, 'C', 'ยำยำจัมโบ้ ต้มยำกุ้งน้ำข้น 67กรัม', 6, 300),
(43, 'C', 'คนอร์ คัพโจ๊ก ถ้วย รสหมู', 17, 200),
(44, 'D', 'นม โฟร์โมสต์ หวาน225มล.', 10, 200),
(45, 'D', 'นม โฟร์โมสต์ จืด225มล.', 12, 99),
(46, 'D', 'นม โฟร์โมสต์ ช็อค225มล.', 12, 300),
(47, 'D', 'นม ไวตามิ้ลค์ 250มล.', 12, 300),
(48, 'D', 'นม แลตตาซอย 300มล', 13, 200),
(49, 'D', 'โออิชิ ชาเขียว', 25, 200),
(50, 'D', 'โออิชิ น้ำผึ้งผสมมะนาว', 25, 300),
(51, 'D', 'นมสด หมี', 14, 200),
(52, 'D', 'นมเปรี้ยว ดัฃมิลล์ รสผลไม้รวม', 12, 200),
(53, 'D', 'นมเปรี้ยว ดัฃมิลล์ รสสตอเบอรี่', 13, 300),
(54, 'D', 'น้ำดื่ม คริสตัล 600 มล', 7, 300),
(55, 'D', 'เป๊ปซี่ 1.25ลิตร', 25, 196),
(56, 'D', 'โค้ก 1.5ลิตร ', 20, 300),
(57, 'D', 'แฟนต้าน้ำแดง1.5ลิตร', 25, 100),
(58, 'D', 'แฟนต้าน้ำเขียว1.5ลิตร', 20, 197),
(59, 'D', 'น้ำดื่ม น้ำทิพย์ 550 มล', 14, 300),
(60, 'D', 'นมข้นหวาน มะลิ380ก.', 24, 200),
(61, 'E', 'สุราผสมเสือดำ 330มล.', 30, 300),
(62, 'E', 'สุราแสงโสมแบน 300มล.', 150, 100),
(63, 'E', 'เบียร์ลีโอใหญ่ 630มล.', 54, 200),
(64, 'E', 'เบียร์ช้างใหญ่ 640มล.', 55, 100),
(65, 'E', 'เบียร์สิงห์ใหญ่ 630มล.', 54, 400),
(66, 'E', 'เบียร์อาชาใหญ่ 640มล.', 54, 300),
(67, 'E', 'บุหรี่ กรองทิพย์', 32, 300),
(68, 'E', 'บุหรี่ สายฝน', 34, 200),
(69, 'E', 'บุหรี่ แอล เอ็ม แดง', 42, 300),
(70, 'E', 'บุหรี่ แอล เอ็ม เขียว', 45, 200),
(71, 'E', 'บุหรี่ แอล เอ็ม เขียว', 37, 300),
(72, 'E', 'กระดาษสูบยา', 32, 200),
(73, 'F', ' ยาเม็ดลดไข้ พาราเซตามอลขนาด 500 มก', 35, 100),
(74, 'F', 'ยาเม็ดแก้แพ้ลดน้ำมูก คลอร์เฟนิรามีน', 34, 200),
(75, 'F', 'ยาแก้ไอน้ำดำ', 45, 296),
(76, 'F', ' ยารักษาลิ้นเป็นฝ้า เยนเชี่ยนไวโอเลต', 30, 100),
(77, 'F', ' ยาทาแก้ท้องอืด ท้องเฟ้อ ทิงเจอร์มหาหิงค์', 37, 200),
(78, 'F', 'ยาธาตุน้ำแดง', 32, 60),
(79, 'F', ' ยาระบายมะขามแขก', 40, 100),
(80, 'F', ' ยาหยอดตา ซัลฟาเซตาไมด์', 20, 100),
(81, 'F', 'ยาถ่ายพยาธิตัวกลม มีเบนดาโซล', 20, 300),
(82, 'G', 'ปากกาสีน้ำเงิน', 100, 300),
(83, 'G', ' ปากกาสีแดง', 10, 100),
(84, 'G', ' ดินสอไม้', 10, 100),
(85, 'G', ' สีไม้', 10, 100),
(86, 'G', 'สมุดวาดเขียน', 20, 300),
(87, 'G', 'ยางลบ', 12, 100),
(88, 'G', 'ไม้บรรทัด', 20, 200),
(89, 'G', ' น้ำยาลบคำผิด', 40, 500),
(90, 'H', ' ยาสีฟัน คอลเกต50ก.', 34, 500),
(91, 'H', 'ยาสีฟัน ใกล้ชิด30ก.', 43, 498),
(92, 'H', 'สบู่ลักส์พิเศษ ขาว', 12, 100),
(93, 'H', 'สบู่ลักส์พิเศษ ชมพู', 20, 100),
(94, 'H', 'แป้งเบบี้มาย', 30, 100),
(95, 'H', 'แชมพู ซันซิล', 34, 100),
(96, 'H', 'ครีมนวดผม ซันซิล', 38, 100),
(97, 'H', 'แชมพู รีจอย', 34, 200),
(98, 'H', 'แชมพู เคลีย', 45, 100),
(99, 'H', 'ผงซักฟอก บรีส', 45, 100),
(100, 'H', 'น้ำยาซักผ้าขาว', 32, 200),
(109, 'H', 'ผ้าอนามัย ลอริเอะ', 22, 100),
(110, 'H', 'ผ้าอนามัย ลอริเอะ มีปีก', 16, 200),
(111, 'H', 'ไม้ขีดไฟ', 6, 90),
(112, 'H', 'ถ่านไฟฉาย ใหญ่', 20, 100),
(113, 'H', 'ถ่านไฟฉาย เล็ก AAA', 32, 100),
(114, 'H', 'เทียนไข', 45, 100),
(115, 'H', 'ธูป', 20, 100),
(116, 'B', 'ปลาราดพริก', 0, 0),
(117, 'A', 'ดาว', 0, 0),
(118, 'B', 'ตตต', 0, 0),
(118, 'C', 'กกกก', 0, 0),
(119, 'A', 'xcv', 0, 0),
(120, 'B', 'กัญชา', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `proexpen`
--

CREATE TABLE `proexpen` (
  `PEcode` bigint(50) NOT NULL,
  `PEdate` date NOT NULL,
  `PEpay` float NOT NULL,
  `PEorder` int(5) NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `proexpen`
--

INSERT INTO `proexpen` (`PEcode`, `PEdate`, `PEpay`, `PEorder`, `EMid`) VALUES
(1, '2016-05-01', 20000, 20, 1),
(73, '2016-05-03', 15, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `recieve`
--

CREATE TABLE `recieve` (
  `PEcode` bigint(50) NOT NULL,
  `PEdate` date NOT NULL,
  `SUPcode` bigint(50) NOT NULL,
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `Pcode` bigint(50) NOT NULL,
  `REamount` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `recieve`
--

INSERT INTO `recieve` (`PEcode`, `PEdate`, `SUPcode`, `TPcode`, `Pcode`, `REamount`) VALUES
(1, '2016-05-01', 1, 'A', 2, 20);

-- --------------------------------------------------------

--
-- Table structure for table `subdiv`
--

CREATE TABLE `subdiv` (
  `SDcode` bigint(50) NOT NULL,
  `SDdate` date NOT NULL,
  `SDamount` int(2) NOT NULL,
  `SDvalue` double NOT NULL,
  `Mid` bigint(50) NOT NULL,
  `EMid` bigint(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `subdiv`
--

INSERT INTO `subdiv` (`SDcode`, `SDdate`, `SDamount`, `SDvalue`, `Mid`, `EMid`) VALUES
(1, '2016-05-01', 11, 1200, 16, 1),
(2, '2016-05-02', 1, 100, 1, 1),
(3, '2016-05-02', 1, 100, 1, 1),
(4, '2016-05-03', 1, 100, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `supdetail`
--

CREATE TABLE `supdetail` (
  `SUPcode` bigint(50) NOT NULL,
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `Pcode` bigint(50) NOT NULL,
  `SUPcost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `supdetail`
--

INSERT INTO `supdetail` (`SUPcode`, `TPcode`, `Pcode`, `SUPcost`) VALUES
(1, 'A', 1, 15),
(1, 'A', 2, 12),
(1, 'A', 3, 13),
(1, 'A', 4, 5),
(1, 'A', 5, 5),
(1, 'A', 6, 5.5),
(1, 'A', 7, 5),
(1, 'A', 8, 6),
(1, 'A', 9, 5),
(1, 'A', 10, 4.5),
(1, 'A', 11, 4.5),
(1, 'A', 13, 5),
(1, 'A', 14, 5.5),
(1, 'A', 15, 4),
(1, 'B', 17, 25),
(1, 'B', 18, 24),
(1, 'B', 19, 25),
(1, 'B', 21, 34),
(1, 'B', 23, 32),
(1, 'B', 27, 5),
(1, 'B', 32, 27),
(1, 'B', 34, 21),
(1, 'B', 35, 21),
(1, 'B', 36, 22),
(1, 'C', 29, 13),
(1, 'C', 30, 31),
(1, 'C', 37, 23),
(1, 'C', 39, 32),
(1, 'C', 41, 45),
(1, 'C', 42, 32),
(1, 'C', 43, 31),
(1, 'D', 46, 13),
(1, 'D', 48, 34),
(1, 'D', 49, 32),
(2, 'A', 6, 5),
(2, 'A', 9, 5.5),
(2, 'A', 10, 5),
(2, 'A', 11, 5.5),
(2, 'A', 12, 4),
(2, 'A', 14, 5),
(2, 'B', 16, 23),
(2, 'B', 18, 25),
(2, 'B', 20, 26),
(2, 'B', 21, 32),
(2, 'B', 22, 32),
(2, 'B', 24, 34),
(2, 'B', 25, 35),
(2, 'B', 26, 30),
(2, 'B', 31, 30),
(2, 'B', 32, 21),
(2, 'B', 33, 23),
(2, 'C', 38, 43),
(2, 'C', 39, 30),
(2, 'C', 40, 21),
(2, 'D', 44, 10),
(2, 'D', 45, 7),
(2, 'D', 46, 12),
(2, 'D', 47, 21),
(2, 'D', 50, 35);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `SUPcode` bigint(50) NOT NULL,
  `SUPname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `SUPcontact` varchar(200) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SUPcode`, `SUPname`, `SUPcontact`) VALUES
(1, 'บริษัทวงศ์มังกร ซุปเปอร์สโตร์ จำกัด', '111 ถนนไชยณรงค์ ตำบลในเมือง อำเภอเมืองนครราชสีมา จังหวัด นครราชสีมา 30000\r\n0-4425-1528'),
(2, 'Toffee Wholesale', '637 ถ.มุขมนตรี ตำบลในเมือง อำเภอเมืองนครราชสีมา จังหวัด นครราชสีมา 30000\r\n'),
(3, 'มิตรราชสีมาเทรดดิ้ง บจก.', '999 หมู่ 6 ตำบลหนองระเวียง อำเภอเมืองนครราชสีมา จังหวัดนครราชสีมา 30000\r\n044-334-291-2'),
(4, 'somo', '1234\nfdd'),
(5, 'ewq', 'tyyu'),
(6, 'dgdg', 'fsgges'),
(7, 'ww', 'wqr'),
(8, 'SV', 'DVS'),
(9, 'a', 'a'),
(10, 'gdg', 'fdgd'),
(11, 'ghgmj', 'gjh,km'),
(12, 'sdac', 'sfs');

-- --------------------------------------------------------

--
-- Table structure for table `typepro`
--

CREATE TABLE `typepro` (
  `TPcode` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `TPname` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `TPprofit` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `typepro`
--

INSERT INTO `typepro` (`TPcode`, `TPname`, `TPprofit`) VALUES
('A', 'ขนมขบเคี้ยวและของหวาน', 0.25),
('B', 'สินค้าในครัวเรือน', 0.1),
('C', 'อาหารสำเร็จรูป', 0.2),
('D', 'เครื่องดื่ม', 0.1),
('E', 'เครื่องดื่มแอลกอฮอลล์เเละบุหรี่', 0.4),
('F', 'ยาสามัญประจำบ้าน', 0.1),
('G', 'เครื่องเขียน', 0.3),
('H', 'สินค้าอื่นๆ', 0.2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adddiv`
--
ALTER TABLE `adddiv`
  ADD PRIMARY KEY (`ADcode`,`ADdate`),
  ADD KEY `ad_fk` (`Mid`),
  ADD KEY `ad_fk1` (`EMid`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`Bcode`,`Bdate`),
  ADD KEY `bill_fk` (`EMid`),
  ADD KEY `bill_fk1` (`Mid`);

--
-- Indexes for table `billdetail`
--
ALTER TABLE `billdetail`
  ADD PRIMARY KEY (`Bcode`,`Bdate`,`TPcode`,`Pcode`),
  ADD UNIQUE KEY `Bcode` (`Bcode`,`Bdate`,`TPcode`,`Pcode`),
  ADD KEY `bd_fk1` (`TPcode`,`Pcode`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EMid`),
  ADD UNIQUE KEY `EMuser` (`EMuser`),
  ADD UNIQUE KEY `EMpass` (`EMpass`);

--
-- Indexes for table `expen`
--
ALTER TABLE `expen`
  ADD PRIMARY KEY (`EXcode`),
  ADD KEY `ex_fk` (`EMid`);

--
-- Indexes for table `income`
--
ALTER TABLE `income`
  ADD PRIMARY KEY (`INcode`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`Mid`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`ORcode`,`ORdate`),
  ADD KEY `or_fk` (`EMid`),
  ADD KEY `ORcode` (`ORcode`);

--
-- Indexes for table `ordetail`
--
ALTER TABLE `ordetail`
  ADD PRIMARY KEY (`ORcode`,`Pcode`),
  ADD KEY `ordt_fk2` (`SUPcode`,`TPcode`,`Pcode`),
  ADD KEY `ORcode` (`ORcode`,`ORdate`);

--
-- Indexes for table `paydivem`
--
ALTER TABLE `paydivem`
  ADD PRIMARY KEY (`PDEcode`,`PDEdate`,`PDEstart`,`EMid`),
  ADD KEY `pdmem_fk` (`EMid`);

--
-- Indexes for table `paydivmem`
--
ALTER TABLE `paydivmem`
  ADD PRIMARY KEY (`PDMcode`,`PDMdate`,`PDMstart`,`Mid`),
  ADD KEY `paydivmem_fk` (`EMid`),
  ADD KEY `pdmem_fk1` (`Mid`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Pcode`,`TPcode`),
  ADD KEY `TPcode` (`TPcode`),
  ADD KEY `TPcode_2` (`TPcode`),
  ADD KEY `TPcode_3` (`TPcode`),
  ADD KEY `TPcode_4` (`TPcode`);

--
-- Indexes for table `proexpen`
--
ALTER TABLE `proexpen`
  ADD PRIMARY KEY (`PEcode`,`PEdate`),
  ADD KEY `proex_fk` (`EMid`);

--
-- Indexes for table `recieve`
--
ALTER TABLE `recieve`
  ADD PRIMARY KEY (`PEcode`,`PEdate`,`SUPcode`,`TPcode`,`Pcode`),
  ADD KEY `PEcode` (`PEcode`),
  ADD KEY `PEdate` (`PEdate`),
  ADD KEY `re_fk` (`SUPcode`,`TPcode`,`Pcode`);

--
-- Indexes for table `subdiv`
--
ALTER TABLE `subdiv`
  ADD PRIMARY KEY (`SDcode`,`SDdate`),
  ADD KEY `sd_fk` (`Mid`),
  ADD KEY `sd_fk1` (`EMid`);

--
-- Indexes for table `supdetail`
--
ALTER TABLE `supdetail`
  ADD PRIMARY KEY (`SUPcode`,`TPcode`,`Pcode`),
  ADD KEY `supd_fk2` (`TPcode`,`Pcode`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`SUPcode`);

--
-- Indexes for table `typepro`
--
ALTER TABLE `typepro`
  ADD PRIMARY KEY (`TPcode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adddiv`
--
ALTER TABLE `adddiv`
  MODIFY `ADcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `bill`
--
ALTER TABLE `bill`
  MODIFY `Bcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EMid` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `expen`
--
ALTER TABLE `expen`
  MODIFY `EXcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `income`
--
ALTER TABLE `income`
  MODIFY `INcode` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `Mid` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `ORcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=92;
--
-- AUTO_INCREMENT for table `paydivem`
--
ALTER TABLE `paydivem`
  MODIFY `PDEcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `paydivmem`
--
ALTER TABLE `paydivmem`
  MODIFY `PDMcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `Pcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=121;
--
-- AUTO_INCREMENT for table `proexpen`
--
ALTER TABLE `proexpen`
  MODIFY `PEcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;
--
-- AUTO_INCREMENT for table `subdiv`
--
ALTER TABLE `subdiv`
  MODIFY `SDcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `SUPcode` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `adddiv`
--
ALTER TABLE `adddiv`
  ADD CONSTRAINT `ad_fk` FOREIGN KEY (`Mid`) REFERENCES `member` (`Mid`),
  ADD CONSTRAINT `ad_fk1` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `bill`
--
ALTER TABLE `bill`
  ADD CONSTRAINT `bill_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`),
  ADD CONSTRAINT `bill_fk1` FOREIGN KEY (`Mid`) REFERENCES `member` (`Mid`);

--
-- Constraints for table `billdetail`
--
ALTER TABLE `billdetail`
  ADD CONSTRAINT `bd_fk` FOREIGN KEY (`Bcode`,`Bdate`) REFERENCES `bill` (`Bcode`, `Bdate`),
  ADD CONSTRAINT `bd_fk1` FOREIGN KEY (`TPcode`,`Pcode`) REFERENCES `product` (`TPcode`, `Pcode`);

--
-- Constraints for table `expen`
--
ALTER TABLE `expen`
  ADD CONSTRAINT `ex_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `or_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `ordetail`
--
ALTER TABLE `ordetail`
  ADD CONSTRAINT `ordt_fk1` FOREIGN KEY (`ORcode`,`ORdate`) REFERENCES `orders` (`ORcode`, `ORdate`),
  ADD CONSTRAINT `ordt_fk2` FOREIGN KEY (`SUPcode`,`TPcode`,`Pcode`) REFERENCES `supdetail` (`SUPcode`, `TPcode`, `Pcode`);

--
-- Constraints for table `paydivem`
--
ALTER TABLE `paydivem`
  ADD CONSTRAINT `pdmem_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `paydivmem`
--
ALTER TABLE `paydivmem`
  ADD CONSTRAINT `paydivmem_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`),
  ADD CONSTRAINT `pdmem_fk1` FOREIGN KEY (`Mid`) REFERENCES `member` (`Mid`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `p_fk` FOREIGN KEY (`TPcode`) REFERENCES `typepro` (`TPcode`);

--
-- Constraints for table `proexpen`
--
ALTER TABLE `proexpen`
  ADD CONSTRAINT `proex_fk` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `recieve`
--
ALTER TABLE `recieve`
  ADD CONSTRAINT `re_fk` FOREIGN KEY (`SUPcode`,`TPcode`,`Pcode`) REFERENCES `supdetail` (`SUPcode`, `TPcode`, `Pcode`),
  ADD CONSTRAINT `re_fk1` FOREIGN KEY (`PEcode`,`PEdate`) REFERENCES `proexpen` (`PEcode`, `PEdate`);

--
-- Constraints for table `subdiv`
--
ALTER TABLE `subdiv`
  ADD CONSTRAINT `sd_fk` FOREIGN KEY (`Mid`) REFERENCES `member` (`Mid`),
  ADD CONSTRAINT `sd_fk1` FOREIGN KEY (`EMid`) REFERENCES `employee` (`EMid`);

--
-- Constraints for table `supdetail`
--
ALTER TABLE `supdetail`
  ADD CONSTRAINT `supd_fk2` FOREIGN KEY (`TPcode`,`Pcode`) REFERENCES `product` (`TPcode`, `Pcode`);
--
-- Database: `student`
--
CREATE DATABASE IF NOT EXISTS `student` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `student`;
--
-- Database: `test`
--
CREATE DATABASE IF NOT EXISTS `test` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `test`;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
