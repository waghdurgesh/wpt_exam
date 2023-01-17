CREATE SCHEMA IF NOT EXISTS `transflower_mis` ;
USE `transflower_mis` ;

DROP TABLE IF EXISTS `transflower_mis`.`qualifications` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`qualifications` (
  `q_id` INT NOT NULL,
  `q_degree` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`q_id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `qid_UNIQUE` ON `transflower_mis`.`qualifications` (`q_id` ASC) VISIBLE;

insert into qualifications (q_id, q_degree) values (1, 'Ph.D./D.Phil');
insert into qualifications (q_id, q_degree) values (2, 'B.E');
insert into qualifications (q_id, q_degree) values (3, 'M.E');
insert into qualifications (q_id, q_degree) values (4, 'B.C.S');
insert into qualifications (q_id, q_degree) values (5, 'M.C.S');
insert into qualifications (q_id, q_degree) values (6, 'M.C.A');
insert into qualifications (q_id, q_degree) values (7, 'L.L.M');
insert into qualifications (q_id, q_degree) values (8, 'B.C.A');
insert into qualifications (q_id, q_degree) values (9, 'B.Tech');
insert into qualifications (q_id, q_degree) values (10, 'L.L.B');
insert into qualifications (q_id, q_degree) values (11, 'M.Tech');

DROP TABLE IF EXISTS `transflower_mis`.`modules` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`modules` (
  `module_id` INT NOT NULL,
  `module_name` VARCHAR(45) COLLATE 'utf8mb3_bin' NOT NULL,
  PRIMARY KEY (`module_id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `sub_name_UNIQUE` ON `transflower_mis`.`modules` (`module_name` ASC) VISIBLE;

insert into modules (module_id, module_name) values (1, 'concept of programming');
insert into modules (module_id, module_name) values (2, 'operating system');
insert into modules (module_id, module_name) values (3, 'database technologies');
insert into modules (module_id, module_name) values (4, 'object oriented programming with java');
insert into modules (module_id, module_name) values (5, 'algorithms & data structures using java');
insert into modules (module_id, module_name) values (6, 'web programming technology');
insert into modules (module_id, module_name) values (7, 'software development methodologies');
insert into modules (module_id, module_name) values (8, 'microsoft .net technologies');
insert into modules (module_id, module_name) values (9, 'web-based java programming');

DROP TABLE IF EXISTS `transflower_mis`.`trainers` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`trainers` (
  `tr_id` INT NOT NULL,
  `tr_first_name` VARCHAR(45) NOT NULL,
  `tr_last_name` VARCHAR(45) COLLATE 'utf8mb3_bin' NOT NULL,
  `tr_email` VARCHAR(45) COLLATE 'utf8mb3_bin' NOT NULL,
  `tr_phone` DECIMAL(10,0) NOT NULL,
  `tr_address` VARCHAR(200) COLLATE 'utf8mb3_bin' NOT NULL,
  `tr_qualification` INT NOT NULL,
  PRIMARY KEY (`tr_id`, `tr_qualification`),
  CONSTRAINT `q_id`
    FOREIGN KEY (`tr_qualification`)
    REFERENCES `transflower_mis`.`qualifications` (`q_id`))
ENGINE = InnoDB;

CREATE UNIQUE INDEX `phone_UNIQUE` ON `transflower_mis`.`trainers` (`tr_phone` ASC) VISIBLE;

CREATE UNIQUE INDEX `email_UNIQUE` ON `transflower_mis`.`trainers` (`tr_email` ASC) VISIBLE;

CREATE INDEX `qid_idx` ON `transflower_mis`.`trainers` (`tr_qualification` ASC) VISIBLE;

insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (1, 'vaishali', 'chikhalkar', 'vaishali.chikhalkar@gmail.com', '9028437934', 'Pune', 2);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (2, 'nisarg', 'acharya', 'nisarg.acharya@gmail.com', '9022960035', 'Pune', 7);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (3, 'kishori', 'khadilkar', 'kishori.khadilkar@gmail.com', '9109749373', 'Pune', 2);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (4, 'madhura', 'anturkar', 'madhura.anturkar@gmail.com', '9009910231', 'Pune', 2);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (5, 'vishal', 'jagtap', 'vishal.jagtap@gmail.com', '9133945903', 'Pune', 2);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (6, 'ravi', 'tambade', 'ravi.tambade@gmail.com', '9178200994', 'Pune', 2);
insert into trainers (tr_id, tr_first_name, tr_last_name, tr_email, tr_phone, tr_address, tr_qualification) values (7, 'shantanu', 'pathak', 'shantanu.pathak@gmail.com', '9862228563', 'Pune', 1);

DROP TABLE IF EXISTS `transflower_mis`.`modules_has_trainers` ;

CREATE TABLE IF NOT EXISTS `transflower_mis`.`modules_has_trainers` (
  `modules_module_id` INT NOT NULL,
  `trainers_tr_id` INT NOT NULL,
  PRIMARY KEY (`modules_module_id`, `trainers_tr_id`),
  CONSTRAINT `fk_modules_has_trainers_modules1`
    FOREIGN KEY (`modules_module_id`)
    REFERENCES `transflower_mis`.`modules` (`module_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_modules_has_trainers_trainers1`
    FOREIGN KEY (`trainers_tr_id`)
    REFERENCES `transflower_mis`.`trainers` (`tr_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_modules_has_trainers_trainers1_idx` ON `transflower_mis`.`modules_has_trainers` (`trainers_tr_id` ASC) VISIBLE;

CREATE INDEX `fk_modules_has_trainers_modules1_idx` ON `transflower_mis`.`modules_has_trainers` (`modules_module_id` ASC) VISIBLE;

insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (1, 1);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (2, 2);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (3, 3);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (4, 4);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (5, 5);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (6, 3);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (7, 6);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (8, 6);
insert into modules_has_trainers (modules_module_id, trainers_tr_id) values (9, 4);
