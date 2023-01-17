DROP SCHEMA IF EXISTS `LMS` ;
CREATE SCHEMA IF NOT EXISTS `LMS` ;

USE `LMS` ;

CREATE TABLE IF NOT EXISTS `trainings` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `topic` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `faculty` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
  `location` VARCHAR(200) CHARACTER SET 'utf8mb3' NOT NULL,
  PRIMARY KEY (`id`));
insert into trainings (id,topic,description,faculty,location) values (1,'COP','Concept of programming','Vaishali Chikhalkar','Pune');
insert into trainings (id,topic,description,faculty,location) values (2,'OS','Operating system','Nisarg Acharya','Pune');

show databases;
USE `LMS` ;
show tables;
select * from trainings;

