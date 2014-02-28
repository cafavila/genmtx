USE [Subsidiario]
GO

/****** Object:  StoredProcedure [dbo].[TotalizaMensual]    Script Date: 24-01-2014 16:21:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TotalizaMensual] @MesOperacion as nvarchar(20)
AS

IF @MesOperacion = 'Enero'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Enero2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Febrero'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Febrero2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Marzo'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Marzo2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Abril'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Abril2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Mayo'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Mayo2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Junio'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Junio2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Julio'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Julio2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Agosto'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Agosto2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Septiembre'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Septiembre2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Octubre'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Octubre2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Noviembre'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Noviembre2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;
ELSE
IF @MesOperacion = 'Diciembre'
Select Mes.Operacion As Operacion, Mes.CuentaContable As Cuenta, CAST(SUM(Mes.Debe) AS varchar(18)) As Debe, CAST(SUM(Mes.Haber) AS varchar(18)) As Haber 
FROM Diciembre2013 AS Mes 
GROUP BY Mes.Operacion, Mes.CuentaContable ORDER BY Mes.Operacion ASC;




GO


