-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema fiskalnisistem
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema fiskalnisistem
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `fiskalnisistem` DEFAULT CHARACTER SET utf8 ;
USE `fiskalnisistem` ;

-- -----------------------------------------------------
-- Table `fiskalnisistem`.`komitent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fiskalnisistem`.`komitent` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nazivKomitenta` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `telefon` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `adresa` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,  
  `jib` VARCHAR(14) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `pib` VARCHAR(13) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `napomena` VARCHAR(350) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;


-- -----------------------------------------------------
-- Table `fiskalnisistem`.`model`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fiskalnisistem`.`model` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nazivModela` VARCHAR(15) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `opis` VARCHAR(255) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;


-- -----------------------------------------------------
-- Table `fiskalnisistem`.`kasa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fiskalnisistem`.`kasa` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `brojKase` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `komitentId` INT(11) NULL DEFAULT '0',
  `brojModula` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `brojTerminala` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `simKartica` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `pin` INT(5) NULL DEFAULT '0',
  `telefon` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `adresaInstaliranja` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `modelId` INT(5) NULL DEFAULT '0',
  `defiskalizacija` TINYINT(1) NULL DEFAULT '0',
  `datumDefiskalizacije` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `dokumentacijaPoslata` TINYINT(1) NULL DEFAULT '0',
  `datumSlanjaDokumentacije` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `datumFiskalizacije` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `fiskalnaPlomba` VARCHAR(30) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `programskaPlomba` VARCHAR(30) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `brojUgovora` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `fLink` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `ibsa` VARCHAR(45) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `napomena` VARCHAR(255) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_kasa_komitent_idx` (`komitentId` ASC),
  INDEX `fk_kasa_model1_idx` (`modelId` ASC),
  CONSTRAINT `fk_kasa_komitent`
    FOREIGN KEY (`komitentId`)
    REFERENCES `fiskalnisistem`.`komitent` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_kasa_model1`
    FOREIGN KEY (`modelId`)
    REFERENCES `fiskalnisistem`.`model` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;


-- -----------------------------------------------------
-- Table `fiskalnisistem`.`servis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `fiskalnisistem`.`servis` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `kasaId` INT(11) NULL DEFAULT '0',
  `datumServisa` VARCHAR(20) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `opis` VARCHAR(255) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_servis_kasa1_idx` (`kasaId` ASC),
  CONSTRAINT `fk_servis_kasa1`
    FOREIGN KEY (`kasaId`)
    REFERENCES `fiskalnisistem`.`kasa` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
