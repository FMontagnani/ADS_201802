DELIMITER $
CREATE PROCEDURE LancarSaidaEstoqueProducao
	@idProduct int, @idEstado int, @idCaixa int, @idLocal int, @qtd INT, @idmov int, @tpmov varchar(8)
	AS
	INSERT INTO tblStockMov VALUES
	(
		NOW(), @idProduct, @idEstado, @idCaixa, @idLocal, @qtd, @idmov, @tpmov
	);
END$
DELIMITER ;
/*-------------------------------------------------------------------------------------------------------*/
DELIMITER $
CREATE PROCEDURE insereOP
	AS
	INSERT INTO tblProduction VALUES (NOW(), 'PRODUCAO');
END$
DELIMITER;