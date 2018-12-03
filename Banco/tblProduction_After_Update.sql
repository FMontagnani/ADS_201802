DELIMITER $
CREATE DEFINER = CURRENT_USER TRIGGER `milani`.`tblProduction_AFTER_UPDATE` AFTER UPDATE ON `tblProduction` FOR EACH ROW

BEGIN
	DECLARE done INT DEFAULT FALSE;
    DECLARE idpd INT;
    DECLARE idcx INT;
    DECLARE idst INT;
    DECLARE qt INT;
    
    DECLARE cur CURSOR FOR SELECT (id_Product, id_Package, id_StateProduct, quantityItem)
						   FROM tblProductionItens
                           WHERE idProductionItens = OLD.idProduction;
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
    
    OPEN cur;
	read_loop: LOOP
		FETCH cur INTO idpd, idcx, idst, qt;
		IF done THEN
			LEAVE read_loop;
		END IF;
		CALL LancarSaidaEstoqueProducao idProduct = idpd, idEstado = idst, idCaixa = idcx, idLocal = 1, qtd = qt, idmov = OLD.idProduction, tpmov = 'PRODUCAO';
   END LOOP read_loop; 
   CLOSE cur;
END$
DELIMITER ;
