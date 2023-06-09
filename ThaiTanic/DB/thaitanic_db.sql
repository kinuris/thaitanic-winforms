﻿DROP DATABASE IF EXISTS thaitanic_db;
CREATE DATABASE thaitanic_db;

USE thaitanic_db;

CREATE TABLE `ITEMS` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(64) NOT NULL,
  `description` VARCHAR(255) NOT NULL,
  `price` DECIMAL(10, 2) NOT NULL,
  `category` ENUM('Breakfast', 'Burgers', 'Dessert' , 'Drinks', 'Alcohol', 'Main Course', 'Pasta') NOT NULL,
  `available` BOOLEAN NOT NULL,
  `created_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
);

CREATE TABLE `USER` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(64) NOT NULL,
  `password` VARCHAR(64) NOT NULL,
  `first_name` VARCHAR(64) NOT NULL,
  `last_name` VARCHAR(64) NOT NULL,
  `middle_name` VARCHAR(64) DEFAULT NULL,
  `birthday` DATETIME NOT NULL,
  `email` VARCHAR(64) NOT NULL,
  `phone_number` VARCHAR(64) NOT NULL,
  `role_enum` ENUM ('admin' , 'user') NOT NULL,
  `created_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
);

CREATE TABLE `BILLING_ADDRESS` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `user_fid` INT NOT NULL,
    `full_name` VARCHAR(64) NOT NULL,
    `phone_number` VARCHAR(64) NOT NULL,
    `region` VARCHAR(64) NOT NULL,
    `province` VARCHAR(64) NOT NULL,
    `city` VARCHAR(64) NOT NULL,
    `barangay` VARCHAR(64) NOT NULL,
    `postal_code` VARCHAR(12) NOT NULL,
    PRIMARY KEY (`id`),
    FOREIGN KEY (`user_fid`) REFERENCES `USER` (`id`)
);

CREATE TABLE `ORDERS` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `date_ordered` DATETIME NOT NULL,
  `total_price` DECIMAL(10, 2) NOT NULL,
  `user_fid` INT NOT NULL,
  `billing_address_fid` INT NOT NULL,
  `status` ENUM ('To Pay', 'To Ship', 'To Recieve', 'Completed', 'Cancelled') NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`user_fid`) REFERENCES `USER`(`id`),
  FOREIGN KEY (`billing_address_fid`) REFERENCES `BILLING_ADDRESS` (`id`)
);

CREATE TABLE `ORDER_BATCH` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `item_fid` INT NOT NULL,
  `order_fid` INT NOT NULL,
  `quantity` INT NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`order_fid`) REFERENCES `ORDERS`(`id`),
  FOREIGN KEY (`item_fid`) REFERENCES `ITEMS`(`id`)
);