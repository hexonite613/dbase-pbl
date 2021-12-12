SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE `actorrating` (
  `actorrating_id` int(11) NOT NULL,
  `id` char(20) NOT NULL,
  `actor_number` int(11) UNSIGNED NOT NULL,
  `score` int(11) NOT NULL,
  `comment` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `booking` (
  `book_num` int(11) UNSIGNED NOT NULL,
  `id` char(20) DEFAULT NULL,
  `sche_id` int(5) NOT NULL,
  `seat_id` int(5) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `pay_price` int(11) NOT NULL,
  `book_type` enum('normal','youth','disable','elder') NOT NULL DEFAULT 'normal',
  `pay_method` char(20) NOT NULL,
  `cus_phonenum` int(11) NOT NULL,
  `book_id` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `coupon_list` (
  `coupon_id` int(11) UNSIGNED NOT NULL,
  `id` char(20) CHARACTER SET utf8mb4 NOT NULL,
  `coupon_type` int(11) UNSIGNED NOT NULL,
  `issue_date` datetime NOT NULL,
  `expire_date` datetime NOT NULL,
  `isused` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `coupon_type` (
  `coupon_type` int(11) UNSIGNED NOT NULL,
  `coupon_name` varchar(20) NOT NULL,
  `coupon_desc` varchar(50) DEFAULT NULL,
  `discount_price` int(15) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `department` (
  `division_id` char(20) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `division_name` char(20) NOT NULL,
  `division_phonenum` varchar(20) NOT NULL,
  `division_manager_ID` varchar(100) NOT NULL,
  `employee_tasks` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `equipment` (
  `equip_id` varchar(8) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `equip_name` char(30) NOT NULL,
  `amount` int(11) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `filmography` (
  `actor_number` int(11) UNSIGNED NOT NULL,
  `movie_id` int(11) NOT NULL,
  `role` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `genre` (
  `genre_id` int(8) NOT NULL,
  `genre_name` varchar(100) NOT NULL,
  `genre_name_eng` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `movie` (
  `movie_id` int(11) NOT NULL,
  `genre_id` int(8) NOT NULL,
  `name` char(40) NOT NULL,
  `name_eng` varchar(50) NOT NULL,
  `movie_time` smallint(2) NOT NULL,
  `description` mediumtext,
  `release_date` date NOT NULL,
  `country` varchar(10) NOT NULL,
  `rating` enum('ALL','12','15','18','R18') NOT NULL,
  `poster` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `movierating` (
  `movie_id` int(11) NOT NULL,
  `book_num` int(11) UNSIGNED NOT NULL,
  `score` int(11) DEFAULT NULL,
  `comment` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `movie_person` (
  `actor_number` int(11) UNSIGNED NOT NULL,
  `actor_name` char(40) DEFAULT NULL,
  `english_name` char(10) DEFAULT NULL,
  `nationality` varchar(30) DEFAULT NULL,
  `actor_image` mediumtext,
  `birth_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `movie_photo` (
  `photo_num` int(11) NOT NULL,
  `movie_id` int(11) NOT NULL,
  `photo_image` mediumtext NOT NULL,
  `title` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `preferred_genre` (
  `id` char(20) NOT NULL,
  `gerne_id` int(8) NOT NULL,
  `prefer_score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `purchase_list` (
  `purchase_ordernum` int(11) NOT NULL,
  `sales_id` int(11) UNSIGNED NOT NULL,
  `menu_id` int(10) NOT NULL,
  `theater_id` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `payment` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `schedule` (
  `sche_id` int(5) NOT NULL,
  `movie_id` int(11) NOT NULL,
  `screen_id` int(8) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `start_time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `screen` (
  `screen_id` int(8) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `screen_name` varchar(20) NOT NULL,
  `screen_type` enum('2D','3D','IMAX','4DX') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `screen_seat` (
  `seat_id` int(11) NOT NULL,
  `seat_row` enum('A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z') NOT NULL,
  `seat_col` int(5) NOT NULL,
  `screen_id` int(8) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `available` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `staff` (
  `id` char(20) NOT NULL,
  `division_id` char(20) DEFAULT NULL,
  `theater_id` varchar(8) NOT NULL,
  `name` varchar(50) NOT NULL,
  `addr` varchar(255) DEFAULT NULL,
  `pwd` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phonenum` varchar(20) DEFAULT NULL,
  `staff_type` varchar(30) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `stafftask` (
  `task_id` char(20) NOT NULL,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `task_type` varchar(100) NOT NULL,
  `done` enum('Y','N') NOT NULL,
  `on_halfholiday` tinyint(1) NOT NULL,
  `on_office` tinyint(1) NOT NULL,
  `part_time` char(5) NOT NULL,
  `reason` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `staff_auth` (
  `staff_type` varchar(30) NOT NULL,
  `auth_key` text NOT NULL,
  `theater_id` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `valid_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `store_menu` (
  `menu_id` int(10) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `menu_name` varchar(20) NOT NULL,
  `price` int(11) NOT NULL,
  `salescount` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `theater` (
  `theater_id` varchar(8) NOT NULL,
  `theater_name` varchar(50) DEFAULT NULL,
  `phonenum` varchar(20) DEFAULT NULL,
  `assets` bigint(13) UNSIGNED DEFAULT NULL,
  `area` char(10) DEFAULT NULL,
  `theater_addr` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `theater_finance` (
  `year_quarter` varchar(8) NOT NULL,
  `theater_id` varchar(8) NOT NULL,
  `salary_expense` bigint(13) NOT NULL,
  `store_revenue` bigint(13) NOT NULL,
  `ticket_revenue` bigint(13) NOT NULL,
  `expend_supply` bigint(13) NOT NULL,
  `expend_admin` bigint(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `user` (
  `id` char(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `name` char(40) NOT NULL,
  `addr` varchar(255) NOT NULL,
  `birthday` date NOT NULL,
  `email` varchar(100) NOT NULL,
  `phonenum` varchar(20) NOT NULL,
  `push` enum('Y','N') NOT NULL DEFAULT 'Y',
  `type` enum('normal','staff','admin') NOT NULL DEFAULT 'normal'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


ALTER TABLE `actorrating`
  ADD PRIMARY KEY (`actorrating_id`),
  ADD KEY `id` (`id`);

ALTER TABLE `booking`
  ADD PRIMARY KEY (`book_num`),
  ADD KEY `id` (`id`),
  ADD KEY `seat_id` (`seat_id`),
  ADD KEY `sche_id` (`sche_id`);

ALTER TABLE `coupon_list`
  ADD PRIMARY KEY (`coupon_id`),
  ADD KEY `id` (`id`),
  ADD KEY `coupon_type` (`coupon_type`);

ALTER TABLE `coupon_type`
  ADD PRIMARY KEY (`coupon_type`);

ALTER TABLE `department`
  ADD PRIMARY KEY (`division_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `equipment`
  ADD PRIMARY KEY (`equip_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `filmography`
  ADD PRIMARY KEY (`actor_number`,`movie_id`),
  ADD KEY `movie_id` (`movie_id`);

ALTER TABLE `genre`
  ADD PRIMARY KEY (`genre_id`);

ALTER TABLE `movie`
  ADD PRIMARY KEY (`movie_id`),
  ADD KEY `gerne_id` (`genre_id`);

ALTER TABLE `movierating`
  ADD PRIMARY KEY (`movie_id`,`book_num`),
  ADD KEY `book_num` (`book_num`);

ALTER TABLE `movie_person`
  ADD PRIMARY KEY (`actor_number`);

ALTER TABLE `movie_photo`
  ADD PRIMARY KEY (`photo_num`),
  ADD KEY `movie_id` (`movie_id`);

ALTER TABLE `preferred_genre`
  ADD PRIMARY KEY (`id`,`gerne_id`),
  ADD KEY `gerne_id` (`gerne_id`);

ALTER TABLE `purchase_list`
  ADD PRIMARY KEY (`purchase_ordernum`),
  ADD KEY `menu_id` (`menu_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `schedule`
  ADD PRIMARY KEY (`sche_id`),
  ADD KEY `movie_id` (`movie_id`),
  ADD KEY `screen_id` (`screen_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `screen`
  ADD PRIMARY KEY (`screen_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `screen_seat`
  ADD PRIMARY KEY (`seat_id`,`seat_row`,`seat_col`,`screen_id`,`theater_id`),
  ADD KEY `screen_id` (`screen_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`),
  ADD KEY `staff_type` (`staff_type`),
  ADD KEY `theater_id` (`theater_id`),
  ADD KEY `division_id` (`division_id`);

ALTER TABLE `stafftask`
  ADD PRIMARY KEY (`task_id`);

ALTER TABLE `staff_auth`
  ADD PRIMARY KEY (`staff_type`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `store_menu`
  ADD PRIMARY KEY (`menu_id`,`theater_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `theater`
  ADD PRIMARY KEY (`theater_id`);

ALTER TABLE `theater_finance`
  ADD PRIMARY KEY (`year_quarter`,`theater_id`),
  ADD KEY `theater_id` (`theater_id`);

ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `actorrating`
  MODIFY `actorrating_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
ALTER TABLE `booking`
  MODIFY `book_num` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123272;
ALTER TABLE `schedule`
  MODIFY `sche_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;
ALTER TABLE `screen_seat`
  MODIFY `seat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=467;

ALTER TABLE `actorrating`
  ADD CONSTRAINT `actorrating_ibfk_1` FOREIGN KEY (`id`) REFERENCES `user` (`id`);

ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`id`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `booking_ibfk_2` FOREIGN KEY (`seat_id`) REFERENCES `screen_seat` (`seat_id`),
  ADD CONSTRAINT `booking_ibfk_3` FOREIGN KEY (`sche_id`) REFERENCES `schedule` (`sche_id`);

ALTER TABLE `coupon_list`
  ADD CONSTRAINT `coupon_list_ibfk_1` FOREIGN KEY (`id`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `coupon_list_ibfk_2` FOREIGN KEY (`coupon_type`) REFERENCES `coupon_type` (`coupon_type`);

ALTER TABLE `department`
  ADD CONSTRAINT `department_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `equipment`
  ADD CONSTRAINT `equipment_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `filmography`
  ADD CONSTRAINT `filmography_ibfk_1` FOREIGN KEY (`actor_number`) REFERENCES `movie_person` (`actor_number`),
  ADD CONSTRAINT `filmography_ibfk_2` FOREIGN KEY (`movie_id`) REFERENCES `movie` (`movie_id`);

ALTER TABLE `movie`
  ADD CONSTRAINT `movie_ibfk_1` FOREIGN KEY (`genre_id`) REFERENCES `genre` (`genre_id`);

ALTER TABLE `movierating`
  ADD CONSTRAINT `movierating_ibfk_1` FOREIGN KEY (`movie_id`) REFERENCES `movie` (`movie_id`),
  ADD CONSTRAINT `movierating_ibfk_2` FOREIGN KEY (`book_num`) REFERENCES `booking` (`book_num`);

ALTER TABLE `movie_photo`
  ADD CONSTRAINT `movie_photo_ibfk_1` FOREIGN KEY (`movie_id`) REFERENCES `movie` (`movie_id`);

ALTER TABLE `preferred_genre`
  ADD CONSTRAINT `preferred_genre_ibfk_1` FOREIGN KEY (`gerne_id`) REFERENCES `genre` (`genre_id`),
  ADD CONSTRAINT `preferred_genre_ibfk_2` FOREIGN KEY (`id`) REFERENCES `user` (`id`);

ALTER TABLE `purchase_list`
  ADD CONSTRAINT `purchase_list_ibfk_1` FOREIGN KEY (`menu_id`) REFERENCES `store_menu` (`menu_id`),
  ADD CONSTRAINT `purchase_list_ibfk_2` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`movie_id`) REFERENCES `movie` (`movie_id`),
  ADD CONSTRAINT `schedule_ibfk_2` FOREIGN KEY (`screen_id`) REFERENCES `screen` (`screen_id`),
  ADD CONSTRAINT `schedule_ibfk_3` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `screen`
  ADD CONSTRAINT `screen_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `screen_seat`
  ADD CONSTRAINT `screen_seat_ibfk_1` FOREIGN KEY (`screen_id`) REFERENCES `screen` (`screen_id`),
  ADD CONSTRAINT `screen_seat_ibfk_2` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`staff_type`) REFERENCES `staff_auth` (`staff_type`),
  ADD CONSTRAINT `staff_ibfk_2` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`),
  ADD CONSTRAINT `staff_ibfk_3` FOREIGN KEY (`division_id`) REFERENCES `department` (`division_id`);

ALTER TABLE `staff_auth`
  ADD CONSTRAINT `staff_auth_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `store_menu`
  ADD CONSTRAINT `store_menu_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);

ALTER TABLE `theater_finance`
  ADD CONSTRAINT `theater_finance_ibfk_1` FOREIGN KEY (`theater_id`) REFERENCES `theater` (`theater_id`);
