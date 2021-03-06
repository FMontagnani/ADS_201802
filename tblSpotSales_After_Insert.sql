DELIMITER $
CREATE DEFINER = CURRENT_USER TRIGGER `mydb`.`tblSpotSales_AFTER_INSERT` AFTER INSERT ON `tblSpotSales` FOR EACH ROW
BEGIN
	INSERT INTO tblStockMov VALUES(now(), NEW.id_Product, 1, NEW.id_Package, 1, NEW.quantity, NULL, NEW.idSpotSales, 'SPOT');
    /*PARAMETROS PASSADOS: DATA DA VENDA, ID PRODUTO, ESTADO DO PRODUTO = 1 (MADURO),
	  ID DA CAIXA, LOCAL DE ARMAZENAMENTO = 1 (PÁTIO), QUANTIDADE VENDIDA, Codigo Lote = NULL,
      ID DO MOVIMENTO = ID DA VENDA, E TIPO DO REGISTRO = 'SPOT'*/
END$
DELIMITER ;