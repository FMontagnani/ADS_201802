/* QUERY PRA GERAR O RELATÓRIO DA ORDEM DE PRODUÇÃO (ITENS A SER PRODUZIDOS) ------------------------------*/

SELECT DISTINCT c.aliasClient Cliente, CONCAT(p.descProduct, ' - ', p.sizeProduct) AS Produto, pc.descPackage AS Caixa, pp.quantityItem AS Quantidade
	FROM ((((tblOrders AS b
		INNER JOIN tblClients AS c
			ON c.idClient=b.id_Client)
		INNER JOIN tblProductionItens AS pp
			ON b.IdOrder=pp.id_Order)
		 INNER JOIN tblProducts AS p
			ON pp.id_Product=p.idProduct)
		INNER JOIN tblPackage AS pc
			ON pp.id_Package=pc.idPackage)
		/*A DATA NA SUBQUERY SERÁ UM PARAMÊTRO PASSADO*/
		WHERE pp.id_Production IN (SELECT idProduction FROM tblProduction WHERE dateProduction='2018-11-16')
    ORDER BY
		Cliente ASC;
		
/* QUERY PARA SOMAR A QUANTIDADE DE CAIXAS PRODUZIDAS ----------------------------------------------------*/

SELECT pc.descPackage AS Caixa, SUM(pp.quantityItem) AS Quantidade 
	FROM (tblProductionItens AS pp
		INNER JOIN tblPackage AS pc
			ON pc.idPackage=pp.id_Package)
	/*A DATA NA SUBQUERY SERÁ UM PARAMÊTRO PASSADO*/
	WHERE pp.id_Production IN (SELECT idProduction FROM tblProduction WHERE dateProduction='2018-11-16')
																						 /*BETWEEN*/
    GROUP BY Caixa
	ORDER BY Caixa ASC;
	
