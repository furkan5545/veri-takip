-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 01 Ara 2016, 12:28:15
-- Sunucu sürümü: 10.1.16-MariaDB
-- PHP Sürümü: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `veritakip`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `id` int(11) NOT NULL,
  `urunAd` varchar(100) NOT NULL,
  `urunAdedi` varchar(100) NOT NULL,
  `girisTarihi` varchar(100) NOT NULL,
  `cikisTarihi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`id`, `urunAd`, `urunAdedi`, `girisTarihi`, `cikisTarihi`) VALUES
(2, 'yusuf', '10', '10.12.2016', '16.12.2016'),
(3, 'dsadsa', 'dasdsa', '11.12.2016', '11.12.2016'),
(6, 'furkan', '10', '8.12.2016', '31.12.2016'),
(9, 'Mehmet Can Yilmaz', '1', '2.12.2016', '17.12.2016'),
(10, 'Harun ', '1', '17.12.2016', '7.12.2016'),
(11, 'TextBox', 'TextBox', '', ''),
(12, 'TextBox', 'TextBox', '', '');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `urunler`
--
ALTER TABLE `urunler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `urunler`
--
ALTER TABLE `urunler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
