-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 21, 2023 at 01:48 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

DROP DATABASE IF EXISTS thaitanic_db;
CREATE DATABASE thaitanic_db;

USE thaitanic_db;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `thaitanic_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing_address`
--

CREATE TABLE `billing_address` (
  `id` int(11) NOT NULL,
  `user_fid` int(11) NOT NULL,
  `full_name` varchar(64) NOT NULL,
  `phone_number` varchar(64) NOT NULL,
  `region` varchar(64) NOT NULL,
  `province` varchar(64) NOT NULL,
  `city` varchar(64) NOT NULL,
  `barangay` varchar(64) NOT NULL,
  `postal_code` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `billing_address`
--

INSERT INTO `billing_address` (`id`, `user_fid`, `full_name`, `phone_number`, `region`, `province`, `city`, `barangay`, `postal_code`) VALUES
(1, 1, 'Work', '09448710999', 'Region 6', 'Capiz', 'Roxas', 'Culasi', '5800'),
(3, 5, 'Home', '234234', 'Region Welew', 'Mangrove', 'Mangjov', 'Culahaw', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `name` varchar(64) NOT NULL,
  `description` varchar(255) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `category` enum('Breakfast','Burgers','Dessert','Drinks','Alcohol','Main Course','Pasta') NOT NULL,
  `available` tinyint(1) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `name`, `description`, `price`, `category`, `available`, `created_at`, `updated_at`) VALUES
(1, 'Eggs Benedict', 'Classic breakfast dish with poached eggs, ham, and hollandaise sauce.', '12.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(2, 'Pancakes with Maple Syrup', 'Fluffy pancakes served with sweet maple syrup.', '9.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(3, 'French Toast', 'Thick slices of bread dipped in a mixture of eggs and milk, then fried until golden.', '8.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(4, 'Breakfast Burrito', 'Tortilla filled with scrambled eggs, cheese, bacon, and veggies.', '10.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(5, 'Fruit Parfait', 'Layers of yogurt, granola, and fresh fruits.', '6.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(6, 'Omelette', 'Fluffy omelette filled with your choice of veggies, cheese, and meat.', '11.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(7, 'Avocado Toast', 'Toasted bread topped with mashed avocado, olive oil, and seasonings.', '7.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(8, 'Breakfast Wrap', 'Wrap filled with scrambled eggs, sausage, cheese, and veggies.', '9.49', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(9, 'Bagel with Cream Cheese', 'Freshly baked bagel served with creamy cream cheese.', '5.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(10, 'Cereal with Milk', 'Assorted cereal flakes served with cold milk.', '4.99', 'Breakfast', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(11, 'Chocolate Brownie', 'Rich and fudgy chocolate brownie topped with walnuts.', '6.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(12, 'New York Cheesecake', 'Creamy and velvety cheesecake with a graham cracker crust.', '8.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(13, 'Strawberry Shortcake', 'Layers of fluffy cake, fresh strawberries, and whipped cream.', '7.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(14, 'Crème Brûlée', 'Smooth vanilla custard with a caramelized sugar crust.', '9.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(15, 'Apple Pie', 'Classic pie with sweet apple filling and a flaky pastry crust.', '10.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(16, 'Molten Lava Cake', 'Warm chocolate cake with a gooey molten chocolate center.', '7.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(17, 'Tiramisu', 'Italian dessert with layers of coffee-soaked ladyfingers and mascarpone cream.', '8.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(18, 'Fruit Tart', 'Buttery tart shell filled with pastry cream and topped with fresh fruits.', '9.49', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(19, 'Ice Cream Sundae', 'Scoops of ice cream topped with whipped cream, chocolate sauce, and a cherry.', '6.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(20, 'Panna Cotta', 'Silky and smooth Italian dessert made with sweetened cream and served with fruit sauce.', '8.99', 'Dessert', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(21, 'Classic Cheeseburger', 'Juicy beef patty topped with melted cheese, lettuce, tomato, and pickles.', '9.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(22, 'Bacon BBQ Burger', 'Beef patty topped with crispy bacon, tangy BBQ sauce, and onion rings.', '11.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(23, 'Mushroom Swiss Burger', 'Beef patty smothered with sautéed mushrooms and melted Swiss cheese.', '10.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(24, 'Spicy Jalapeno Burger', 'Beef patty topped with fiery jalapenos, pepper jack cheese, and chipotle mayo.', '10.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(25, 'Veggie Burger', 'Plant-based patty made with assorted vegetables and served with lettuce and tomato.', '8.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(26, 'Hawaiian Teriyaki Burger', 'Beef patty glazed with teriyaki sauce and topped with grilled pineapple.', '11.49', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(27, 'Blue Cheese Burger', 'Beef patty topped with tangy blue cheese, caramelized onions, and arugula.', '10.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(28, 'Guacamole Bacon Burger', 'Beef patty topped with guacamole, crispy bacon, and chipotle mayo.', '11.49', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(29, 'BBQ Ranch Chicken Burger', 'Grilled chicken breast topped with BBQ sauce, ranch dressing, and lettuce.', '9.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(30, 'Portobello Mushroom Burger', 'Grilled portobello mushroom cap topped with melted cheese, roasted red peppers, and basil mayo.', '9.99', 'Burgers', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(31, 'Iced Coffee', 'Chilled coffee served over ice.', '3.99', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(32, 'Lemonade', 'Refreshing drink made with freshly squeezed lemons and sweetened with sugar.', '2.99', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(33, 'Mango Smoothie', 'Creamy and fruity smoothie made with fresh mangoes and yogurt.', '4.99', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(34, 'Iced Tea', 'Chilled black tea served over ice, sweetened to taste.', '2.99', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(35, 'Strawberry Lemonade', 'Tangy lemonade infused with sweet strawberry flavor.', '3.99', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(36, 'Pineapple Juice', 'Freshly squeezed pineapple juice.', '3.49', 'Drinks', 1, '2023-05-19 02:02:16', '2023-06-11 11:57:49'),
(37, 'Buko Pie', 'Delicious creamed pie', '12.99', 'Dessert', 0, '2023-06-12 10:13:13', '2023-06-12 10:52:40'),
(38, 'Bulalo', 'Slow-cooked beef stew with vegetables and herbs', '15.75', 'Main Course', 1, '2023-06-12 10:50:48', '2023-06-12 10:50:48');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `date_ordered` datetime NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `user_fid` int(11) NOT NULL,
  `billing_address_fid` int(11) NOT NULL,
  `status` enum('To Pay','To Ship','To Recieve','Completed','Cancelled') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `date_ordered`, `total_price`, `user_fid`, `billing_address_fid`, `status`) VALUES
(5, '2023-06-11 21:32:42', '37.46', 1, 1, 'To Pay'),
(6, '2023-06-11 21:33:07', '10.97', 1, 1, 'To Recieve'),
(7, '2023-06-11 21:49:14', '61.44', 1, 1, 'Completed'),
(8, '2023-06-11 21:52:53', '170.83', 1, 1, 'Completed'),
(9, '2023-06-12 08:42:02', '86.91', 1, 1, 'Cancelled'),
(10, '2023-06-12 09:48:30', '48.45', 1, 1, 'To Pay'),
(11, '2023-06-12 12:01:44', '40.46', 1, 1, 'Cancelled'),
(12, '2023-06-12 12:02:04', '107.88', 1, 1, 'To Pay'),
(13, '2023-06-12 12:03:09', '35.97', 1, 1, 'To Ship'),
(14, '2023-06-12 12:08:40', '22.44', 1, 1, 'To Pay'),
(15, '2023-06-12 12:23:50', '29.47', 1, 1, 'To Pay'),
(16, '2023-06-12 18:51:33', '40.74', 1, 1, 'Completed'),
(17, '2023-06-15 16:22:54', '59.44', 5, 3, 'Completed');

-- --------------------------------------------------------

--
-- Table structure for table `order_batch`
--

CREATE TABLE `order_batch` (
  `id` int(11) NOT NULL,
  `item_fid` int(11) NOT NULL,
  `order_fid` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order_batch`
--

INSERT INTO `order_batch` (`id`, `item_fid`, `order_fid`, `quantity`) VALUES
(18, 2, 5, 2),
(19, 7, 5, 1),
(20, 8, 5, 1),
(21, 33, 6, 1),
(22, 34, 6, 1),
(23, 32, 6, 1),
(24, 2, 7, 3),
(25, 8, 7, 1),
(26, 3, 7, 1),
(27, 1, 7, 1),
(28, 2, 8, 4),
(29, 8, 8, 2),
(30, 3, 8, 2),
(31, 1, 8, 1),
(32, 26, 8, 1),
(33, 27, 8, 1),
(34, 28, 8, 1),
(35, 25, 8, 1),
(36, 4, 8, 1),
(37, 7, 8, 1),
(38, 6, 8, 1),
(39, 5, 8, 1),
(40, 1, 9, 1),
(41, 2, 9, 2),
(42, 3, 9, 2),
(43, 4, 9, 1),
(44, 5, 9, 1),
(45, 13, 9, 1),
(46, 14, 9, 1),
(47, 3, 10, 1),
(48, 4, 10, 2),
(49, 7, 10, 1),
(50, 8, 10, 1),
(51, 3, 11, 1),
(52, 4, 11, 2),
(53, 8, 11, 1),
(54, 3, 12, 12),
(55, 6, 13, 3),
(56, 31, 14, 1),
(57, 32, 14, 1),
(58, 33, 14, 1),
(59, 34, 14, 1),
(60, 36, 14, 1),
(61, 35, 14, 1),
(62, 4, 15, 1),
(63, 3, 15, 1),
(64, 8, 15, 1),
(65, 37, 16, 1),
(66, 38, 16, 1),
(67, 2, 17, 1),
(68, 4, 17, 1),
(69, 3, 17, 1),
(70, 7, 17, 1),
(71, 8, 17, 1),
(72, 6, 17, 1);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL,
  `first_name` varchar(64) NOT NULL,
  `last_name` varchar(64) NOT NULL,
  `middle_name` varchar(64) DEFAULT NULL,
  `birthday` datetime NOT NULL,
  `email` varchar(64) NOT NULL,
  `phone_number` varchar(64) NOT NULL,
  `role_enum` enum('admin','user') NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `first_name`, `last_name`, `middle_name`, `birthday`, `email`, `phone_number`, `role_enum`, `created_at`, `updated_at`) VALUES
(1, 'user', 'ee11cbb19052e40b07aac0ca060c23ee', 'Chris Dominic', 'Chan', 'Panaguiton', '2002-03-05 13:33:12', 'chanchrisdominic@gmail.com', '09123456723', 'user', '2023-06-06 14:53:13', '2023-06-21 11:36:52'),
(2, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'Administrator', 'Distrator', 'Blender', '2002-06-05 13:33:12', 'hello@gmail.com', 'adsfsadfa', 'admin', '2023-06-12 04:18:57', '2023-06-12 04:19:32'),
(5, 'user2', 'ee11cbb19052e40b07aac0ca060c23ee', 'user', 'user', '', '2023-05-15 13:33:12', 'sdfdsf', 'user', 'user', '2023-06-15 08:08:16', '2023-06-15 08:08:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing_address`
--
ALTER TABLE `billing_address`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_fid` (`user_fid`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_fid` (`user_fid`),
  ADD KEY `billing_address_fid` (`billing_address_fid`);

--
-- Indexes for table `order_batch`
--
ALTER TABLE `order_batch`
  ADD PRIMARY KEY (`id`),
  ADD KEY `order_fid` (`order_fid`),
  ADD KEY `item_fid` (`item_fid`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `billing_address`
--
ALTER TABLE `billing_address`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `order_batch`
--
ALTER TABLE `order_batch`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `billing_address`
--
ALTER TABLE `billing_address`
  ADD CONSTRAINT `billing_address_ibfk_1` FOREIGN KEY (`user_fid`) REFERENCES `user` (`id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`user_fid`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`billing_address_fid`) REFERENCES `billing_address` (`id`);

--
-- Constraints for table `order_batch`
--
ALTER TABLE `order_batch`
  ADD CONSTRAINT `order_batch_ibfk_1` FOREIGN KEY (`order_fid`) REFERENCES `orders` (`id`),
  ADD CONSTRAINT `order_batch_ibfk_2` FOREIGN KEY (`item_fid`) REFERENCES `items` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
