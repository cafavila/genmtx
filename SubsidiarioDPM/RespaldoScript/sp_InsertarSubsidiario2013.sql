USE [Subsidiario]
GO

/****** Object:  StoredProcedure [dbo].[InsertarSubsidiario]    Script Date: 24-01-2014 16:19:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarSubsidiario](@Fecha as varchar(10),
									 @Oficina as varchar(20),
									 @CtaCtbl as varchar(10),
									 @Nombre as varchar(23),
									 @Rut as varchar(12),
									 @Operacion as varchar(12),
									 @Serial as varchar(12),
									 @Tasa as varchar(6),
									 @Debe as nvarchar(18),
									 @Haber as nvarchar(18),
									 @Algoritmo as varchar(1),
									 @Saldo as nvarchar(18),
									 @MesProceso as varchar(12))
AS
SET NOCOUNT ON;

DECLARE @mDebe as money, @mHaber as money, @mSaldo as money;
SET @mDebe = PARSE(@Debe as money using 'es-cl') /* CONVERT(money, @Debe) */
SET @mHaber = PARSE(@Haber as money using 'es-cl') /* CONVERT(money, @Haber); */
SET @mSaldo = PARSE(@Saldo as money using 'es-cl') /* CONVERT(money, @Saldo); */

IF @MesProceso = 'Enero' 
	INSERT INTO Enero2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Febrero' 
	INSERT INTO Febrero2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Marzo' 
	INSERT INTO Marzo2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Abril' 
	INSERT INTO Abril2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Mayo'
	INSERT INTO Mayo2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Junio'
	INSERT INTO Junio2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Julio' 
	INSERT INTO Julio2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Agosto' 
	INSERT INTO Agosto2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Septiembre' 
	INSERT INTO Septiembre2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Octubre' 
	INSERT INTO Octubre2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Noviembre'
	INSERT INTO Noviembre2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)
ELSE
IF @MesProceso = 'Diciembre' 
	INSERT INTO Diciembre2013 VALUES(@Fecha, @Oficina, @CtaCtbl, @Nombre, @Rut, @Operacion, @Serial, @Tasa, @mDebe, @mHaber, @Algoritmo, @mSaldo)


GO


