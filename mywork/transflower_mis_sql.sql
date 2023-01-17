-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema transflower_mis
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `transflower_mis` ;

-- -----------------------------------------------------
-- Schema transflower_mis
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `transflower_mis` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `transflower_mis` ;

-- -----------------------------------------------------
-- Table `transflower_mis`.`modules`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transflower_mis`.`modules` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`modules` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE UNIQUE INDEX `sub_name_UNIQUE` ON `transflower_mis`.`modules` (`name` ASC) VISIBLE;

insert into modules (id, name) values (1, 'concept of programming');
insert into modules (id, name) values (2, 'operating system');
insert into modules (id, name) values (3, 'database technologies');
insert into modules (id, name) values (4, 'object oriented programming with java');
insert into modules (id, name) values (5, 'algorithms & data structures using java');
insert into modules (id, name) values (6, 'web programming technology');
insert into modules (id, name) values (7, 'software development methodologies');
insert into modules (id, name) values (8, 'microsoft .net technologies');
insert into modules (id, name) values (9, 'web-based java programming');

-- -----------------------------------------------------
-- Table `transflower_mis`.`qualifications`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transflower_mis`.`qualifications` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`qualifications` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `degree` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE UNIQUE INDEX `qid_UNIQUE` ON `transflower_mis`.`qualifications` (`id` ASC) VISIBLE;

insert into qualifications (id, degree) values (1, 'Ph.D./D.Phil');
insert into qualifications (id, degree) values (2, 'B.E');
insert into qualifications (id, degree) values (3, 'M.E');
insert into qualifications (id, degree) values (4, 'B.C.S');
insert into qualifications (id, degree) values (5, 'M.C.S');
insert into qualifications (id, degree) values (6, 'M.C.A');
insert into qualifications (id, degree) values (7, 'L.L.M');
insert into qualifications (id, degree) values (8, 'B.C.A');
insert into qualifications (id, degree) values (9, 'B.Tech');
insert into qualifications (id, degree) values (10, 'L.L.B');
insert into qualifications (id, degree) values (11, 'M.Tech');

-- -----------------------------------------------------
-- Table `transflower_mis`.`trainers`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transflower_mis`.`trainers` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`trainers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(45) NOT NULL,
  `last_name` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `email` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `phone` DOUBLE NOT NULL,
  `address` VARCHAR(200) CHARACTER SET 'utf8mb3' NOT NULL,
  `qualification` INT NOT NULL,
  PRIMARY KEY (`id`, `qualification`),
  CONSTRAINT `q_id`
    FOREIGN KEY (`qualification`)
    REFERENCES `transflower_mis`.`qualifications` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE UNIQUE INDEX `phone_UNIQUE` ON `transflower_mis`.`trainers` (`phone` ASC) VISIBLE;

CREATE UNIQUE INDEX `email_UNIQUE` ON `transflower_mis`.`trainers` (`email` ASC) VISIBLE;

CREATE INDEX `qid_idx` ON `transflower_mis`.`trainers` (`qualification` ASC) VISIBLE;

CREATE UNIQUE INDEX `id_UNIQUE` ON `transflower_mis`.`trainers` (`id` ASC) VISIBLE;

insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (1, 'vaishali', 'chikhalkar', 'vaishali.chikhalkar@gmail.com', '9028437934', 'Pune', 2);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (2, 'nisarg', 'acharya', 'nisarg.acharya@gmail.com', '9022960035', 'Pune', 7);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (3, 'kishori', 'khadilkar', 'kishori.khadilkar@gmail.com', '9109749373', 'Pune', 2);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (4, 'madhura', 'anturkar', 'madhura.anturkar@gmail.com', '9009910231', 'Pune', 2);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (5, 'vishal', 'jagtap', 'vishal.jagtap@gmail.com', '9133945903', 'Pune', 2);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (6, 'ravi', 'tambade', 'ravi.tambade@gmail.com', '9178200994', 'Pune', 2);
insert into trainers (id,first_name,last_name,email,phone,address,qualification) values (7, 'shantanu', 'pathak', 'shantanu.pathak@gmail.com', '9862228563', 'Pune', 1);


-- -----------------------------------------------------
-- Table `transflower_mis`.`modules_has_trainers`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transflower_mis`.`modules_has_trainers` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`modules_has_trainers` (
  `module_id` INT NOT NULL,
  `trainer_id` INT NOT NULL,
  PRIMARY KEY (`module_id`, `trainer_id`),
  CONSTRAINT `fk_modules_has_trainers_modules1`
    FOREIGN KEY (`module_id`)
    REFERENCES `transflower_mis`.`modules` (`id`),
  CONSTRAINT `fk_modules_has_trainers_trainers1`
    FOREIGN KEY (`trainer_id`)
    REFERENCES `transflower_mis`.`trainers` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE INDEX `fk_modules_has_trainers_trainers1_idx` ON `transflower_mis`.`modules_has_trainers` (`trainer_id` ASC) VISIBLE;

CREATE INDEX `fk_modules_has_trainers_modules1_idx` ON `transflower_mis`.`modules_has_trainers` (`module_id` ASC) VISIBLE;


insert into modules_has_trainers (module_id, trainer_id) values (1, 1);
insert into modules_has_trainers (module_id, trainer_id) values (2, 2);
insert into modules_has_trainers (module_id, trainer_id) values (3, 3);
insert into modules_has_trainers (module_id, trainer_id) values (4, 4);
insert into modules_has_trainers (module_id, trainer_id) values (5, 5);
insert into modules_has_trainers (module_id, trainer_id) values (6, 3);
insert into modules_has_trainers (module_id, trainer_id) values (7, 6);
insert into modules_has_trainers (module_id, trainer_id) values (8, 6);
insert into modules_has_trainers (module_id, trainer_id) values (9, 4);

-- -----------------------------------------------------
-- VIEW ALL TABLES
-- -----------------------------------------------------

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

SELECT `modules`.`id`,
    `modules`.`name`
FROM `transflower_mis`.`modules`;

SELECT `modules_has_trainers`.`module_id`,
    `modules_has_trainers`.`trainer_id`
FROM `transflower_mis`.`modules_has_trainers`;

SELECT `qualifications`.`id`,
    `qualifications`.`degree`
FROM `transflower_mis`.`qualifications`;

SELECT `trainers`.`id`,
    `trainers`.`first_name`,
    `trainers`.`last_name`,
    `trainers`.`email`,
    `trainers`.`phone`,
    `trainers`.`address`,
    `trainers`.`qualification`
FROM `transflower_mis`.`trainers`;



