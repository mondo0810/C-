-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1:3308
-- Thời gian đã tạo: Th2 20, 2024 lúc 07:18 AM
-- Phiên bản máy phục vụ: 10.4.24-MariaDB
-- Phiên bản PHP: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `slot6`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `attendance`
--

CREATE TABLE `attendance` (
  `id` int(11) NOT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `work_date` date NOT NULL,
  `hours_worked` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `attendance`
--

INSERT INTO `attendance` (`id`, `employee_id`, `work_date`, `hours_worked`) VALUES
(1, 1, '2022-01-05', 8),
(2, 1, '2022-01-06', 7),
(3, 2, '2022-02-18', 8),
(4, 2, '2022-02-20', 6),
(6, 3, '2022-03-26', 7),
(7, 1, '2022-01-06', 8),
(12, 3, '2022-03-30', 7),
(14, 1, '2022-01-08', 7),
(15, 2, '2022-02-18', 8),
(17, 3, '2022-03-25', 8),
(18, 3, '2022-03-26', 7),
(19, 1, '2022-01-06', 8),
(20, 3, '2022-03-30', 7),
(21, 1, '2022-01-05', 8),
(22, 1, '2022-01-06', 7),
(23, 2, '2022-02-18', 8),
(24, 2, '2022-02-20', 6),
(25, 3, '2022-03-26', 7),
(26, 1, '2022-01-06', 8),
(27, 3, '2022-03-30', 7),
(28, 1, '2022-01-06', 7),
(29, 2, '2022-02-18', 8),
(30, 3, '2022-03-25', 8),
(31, 3, '2022-03-19', 7),
(32, 1, '2022-01-06', 8),
(33, 3, '2022-03-30', 7);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `employees`
--

CREATE TABLE `employees` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `hire_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `employees`
--

INSERT INTO `employees` (`id`, `name`, `hire_date`) VALUES
(1, 'Nguyen Minh Tian', '2022-01-01'),
(2, 'Do Thi', '2022-02-15'),
(3, 'Tran Quan', '2022-03-20');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `leave_requests`
--

CREATE TABLE `leave_requests` (
  `id` int(11) NOT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `leave_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `leave_requests`
--

INSERT INTO `leave_requests` (`id`, `employee_id`, `leave_date`) VALUES
(2, 2, '2022-02-22'),
(3, 3, '2022-03-30'),
(5, 2, '2022-02-19'),
(6, 3, '2022-03-26'),
(7, 2, '2022-02-22'),
(8, 3, '2022-03-18'),
(9, 2, '2022-02-19'),
(10, 3, '2022-03-26');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2024_02_19_044450_create_attendance_table', 0),
(2, '2024_02_19_044450_create_employees_table', 0),
(3, '2024_02_19_044450_create_leave_requests_table', 0),
(4, '2024_02_19_044453_add_foreign_keys_to_attendance_table', 0),
(5, '2024_02_19_044453_add_foreign_keys_to_leave_requests_table', 0);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Chỉ mục cho bảng `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `leave_requests`
--
ALTER TABLE `leave_requests`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Chỉ mục cho bảng `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT cho bảng `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `leave_requests`
--
ALTER TABLE `leave_requests`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`);

--
-- Các ràng buộc cho bảng `leave_requests`
--
ALTER TABLE `leave_requests`
  ADD CONSTRAINT `leave_requests_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
