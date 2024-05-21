-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: May 22, 2024 at 01:21 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loginphp`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `ogrencibilgileri`
--

CREATE TABLE `ogrencibilgileri` (
  `kayıtNo` int(11) NOT NULL,
  `basari` varchar(255) DEFAULT NULL,
  `tc` bigint(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `ogrenciNo` int(11) NOT NULL,
  `sınıf` int(11) NOT NULL,
  `tel` int(11) NOT NULL,
  `ePosta` varchar(255) NOT NULL,
  `stajKodu` varchar(255) NOT NULL,
  `stajYeri` varchar(255) NOT NULL,
  `stajBasTarihi` date NOT NULL,
  `stajBitisTarihi` date NOT NULL,
  `personeleTeslim` tinyint(1) NOT NULL,
  `stajYazısı` varchar(255) NOT NULL,
  `endYazısı` int(5) NOT NULL,
  `dilekce` tinyint(1) NOT NULL,
  `kabulYazısı` tinyint(1) NOT NULL,
  `mustehaklık` tinyint(1) NOT NULL,
  `kimlikFoto` tinyint(1) NOT NULL,
  `stajDegerlendirme` tinyint(1) NOT NULL,
  `stajRaporu` tinyint(1) NOT NULL,
  `aciklama` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Dumping data for table `ogrencibilgileri`
--

INSERT INTO `ogrencibilgileri` (`kayıtNo`, `basari`, `tc`, `ad`, `soyad`, `ogrenciNo`, `sınıf`, `tel`, `ePosta`, `stajKodu`, `stajYeri`, `stajBasTarihi`, `stajBitisTarihi`, `personeleTeslim`, `stajYazısı`, `endYazısı`, `dilekce`, `kabulYazısı`, `mustehaklık`, `kimlikFoto`, `stajDegerlendirme`, `stajRaporu`, `aciklama`) VALUES
(7, 'BAŞARILI', 1231234564, 'Ahmet', 'Güngör', 908, 1, 2147483647, 'kale@gmail.com', 'END300', 'MAN TÜRKİYE A.Ş.', '2024-05-10', '2024-05-26', 1, 'B229', 12072, 1, 1, 1, 1, 1, 1, 'Bütün Belgeler Verildi'),
(8, 'Başarılı', 13726225626, 'Akif Giray', 'Pusat', 22297349, 2, 2147483647, 'akifgiraypusat@gmail.com', 'END300', 'MAN TÜRKİYE A.Ş.', '2024-05-01', '2024-06-02', 1, 'B229', 12072, 1, 1, 1, 1, 1, 1, 'Bütün Belgeler Verildi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ogrencibilgileri`
--
ALTER TABLE `ogrencibilgileri`
  ADD PRIMARY KEY (`kayıtNo`),
  ADD UNIQUE KEY `tc` (`tc`),
  ADD UNIQUE KEY `ogrenciNo` (`ogrenciNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ogrencibilgileri`
--
ALTER TABLE `ogrencibilgileri`
  MODIFY `kayıtNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
