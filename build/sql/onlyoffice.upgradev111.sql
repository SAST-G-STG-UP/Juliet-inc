DELIMITER DLM00

DROP PROCEDURE IF EXISTS upgrade111 DLM00

CREATE PROCEDURE upgrade111()
BEGIN

    IF NOT EXISTS(SELECT * FROM information_schema.`COLUMNS` WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'files_file' AND COLUMN_NAME = 'thumb') THEN
        ALTER TABLE `files_file` ADD COLUMN `thumb` INT(1) NOT NULL DEFAULT '0' AFTER `forcesave`;
    END IF;

    ALTER TABLE `files_thirdparty_account` CHANGE COLUMN `password` `password` VARCHAR(512) NOT NULL AFTER `user_name`;


END DLM00

CALL upgrade111() DLM00

DELIMITER ;
