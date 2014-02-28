USE [CarteraDPM]
GO

/****** Object:  StoredProcedure [dbo].[SaldosPromedio]    Script Date: 24-01-2014 15:10:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SaldosPromedio] @MesOperacion as nvarchar(20)
AS

IF @MesOperacion = 'Enero'
Select c.NumeroOperacion, SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)) / COUNT(c.NumeroOperacion) AS SaldoPromedio 
FROM Enero as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Febrero'
Select c.NumeroOperacion, SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)) / COUNT(c.NumeroOperacion) AS SaldoPromedio 
FROM Febrero as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Marzo'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Marzo as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Abril'
Select c.NumeroOperacion, SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)) / COUNT(c.NumeroOperacion) AS SaldoPromedio 
FROM Abril as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Mayo'
Select c.NumeroOperacion, SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)) / COUNT(c.NumeroOperacion) AS SaldoPromedio 
FROM Mayo as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Junio'
Select c.NumeroOperacion, SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)) / COUNT(c.NumeroOperacion) AS SaldoPromedio 
FROM Junio as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Julio'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Julio as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Agosto'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Agosto as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Septiembre'
Select c.NumeroOperacion, (SUM(PARSE(c.SaldoInsolutoMonedaOrigen as money using 'es-cl')) / COUNT(c.NumeroOperacion)) AS SaldoPromedio 
FROM Septiembre as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Octubre'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Octubre as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Noviembre'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Noviembre as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;
ELSE
IF @MesOperacion = 'Diciembre'
Select c.NumeroOperacion, ((SUM(CAST(c.SaldoInsolutoMonedaOrigen as money)/10) / COUNT(c.NumeroOperacion)) * 10) AS SaldoPromedio 
FROM Diciembre as C
GROUP BY c.NumeroOperacion ORDER BY c.NumeroOperacion ASC;

GO


