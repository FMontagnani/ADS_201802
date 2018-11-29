DELIMITER $
CREATE DEFINER = CURRENT_USER TRIGGER `milani`.`tblProduction_AFTER_UPDATE` AFTER UPDATE ON `tblProduction` FOR EACH ROW

BEGIN
	DECLARE done INT DEFAULT FALSE;
    DECLARE idpd INT;
    DECLARE idcx INT;
    DECLARE idst INT;
    DECLARE qt INT;
    DECLARE id INT DEFAULT OLD.idProduction;
    
    DECLARE cur CURSOR FOR (SELECT id_Product, id_Package, id_StateProduct, quantityItem 
							FROM `milani`.`tblProductionItens` 
                            WHERE id_Production = 1);
	
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
    
    OPEN cur;
    REPEAT
		FETCH cur INTO idpd, idcx, idst, qt;
        IF NOT done THEN
			CALL LancarSaidaEstoqueProducao (idpd, idst, idcx, 1, qt, OLD.idProduction, 'Producao');
		END IF;
	UNTIL done END REPEAT;
   CLOSE cur;
END$
DELIMITER ;