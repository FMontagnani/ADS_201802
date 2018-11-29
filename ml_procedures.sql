/*--------- PROCEDURE PARA ATUALIZAR A MOVIMENTAÇÃO DE ESTOQUE DOS ITENS PRODUZIDOS ------------------*/

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `LancarSaidaEstoqueProducao`(IN idProduct int, idEstado int, idCaixa int, idLocal int, qtd INT, idmov int, tpmov varchar(8))
BEGIN
	INSERT INTO tblStockMov (dateStockMov, id_Product, id_StateProduct, id_Package, id_StockLocal, qtdStockMov, id_mov, tpmov) 
    VALUES
	(
		NOW(), idProduct, idEstado, idCaixa, idLocal, qtd, idmov, tpmov
	);
END$$
DELIMITER ;

/*-------------------------------------------------------------------------------------------------------*/
DELIMITER $
CREATE PROCEDURE insereOP
	AS
	INSERT INTO tblProduction VALUES (NOW(), 'Producao');
END$
DELIMITER;

/*--------PROCEDURE PARA ATUALIZAR A TABELA DE PEDIDOS-----------------------------------------------------------------------------*/
DELIMITER $
CREATE DEFINER=`root`@`localhost` PROCEDURE `AtualizarStatusPedidosParaEntregue` (IN idProd)

BEGIN

	UPDATE `milani`.`tblOrders` 
		SET statusOrder = 'Entregue'
		WHERE idOrder IN (SELECT id_Order 
							FROM `milani`.`tblProductionItens` 
							WHERE id_Production = idProd);

END$
DELIMITER;