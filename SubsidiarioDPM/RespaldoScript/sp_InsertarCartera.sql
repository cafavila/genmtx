USE [CarteraDPM]
GO

/****** Object:  StoredProcedure [dbo].[InsertarCartera]    Script Date: 24-01-2014 15:09:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertarCartera](@TipoRegistro As varchar(1),
                                 @TipoCaptacion As varchar(4),
                                 @RutCliente As varchar(10),
                                 @RutCliente2 As varchar(10),
                                 @NumeroOperacion As varchar(12),
                                 @Serial As varchar(12),
                                 @Oficina As varchar(3),
                                 @Moneda As varchar(6),
                                 @Tasa As varchar(9),
                                 @FechaEmision As varchar(10),
                                 @FechaVencimiento As varchar(10),
                                 @PlazoReal As varchar(5),
                                 @CuentaContableCapital As varchar(12),
                                 @MontoCaptacion As varchar(17),
                                 @CuentaContableIntereses As varchar(12),
                                 @Intereses As varchar(17),
                                 @CuentaContableReajuste As varchar(12),
                                 @Reajustes As varchar(19),
                                 @MontoFinal As varchar(17),
                                 @EstadoOperacion As varchar(1),
                                 @SituacionContable As varchar(3),
                                 @CodigPlazoContable As varchar(2),
                                 @ClaseOperacion As varchar(6),
                                 @SaldoInsolutoMonedaOrigen As varchar(17),
                                 @SaldoInsolutoPesos As varchar(19),
                                 @NumeroRecompras As varchar(3),
                                 @FechaUltimaRecompra As varchar(10),
                                 @MontoPagoCapital As varchar(19),
                                 @MontoPagoIntereses As varchar(19),
                                 @MontoPagoReajustes As varchar(19),
                                 @CodigoTipoOperacion As varchar(8),
                                 @PlazoOperacional As varchar(4),
                                 @UnidadPlazoOperacional As varchar(1),
                                 @FechaCaptacionOriginal As varchar(10),
                                 @NumeroOperacionQueGeneroRenovacion As varchar(12),
                                 @NumeroOperacionOriginal As varchar(12),
                                 @FechaDevengo As varchar(10),
                                 @CodigoTipoTasa As varchar(12),
                                 @FechaVencimiento2 As varchar(10),
                                 @SaldoValorFinal As varchar(19),
                                 @ValorCambioCaptacion As varchar(16),
                                 @ValorCambioVencimiento As varchar(16),
                                 @CompraPropiaUltimaEmision As varchar(16),
                                 @CompraPropiaEmisionTotal As varchar(16),
                                 @CuentaContableCapital2 As varchar(12),
								 @Disponible As varchar(50),
								 @MesProceso As varchar(12))
AS
SET NOCOUNT ON;

IF @MesProceso = 'Enero' 
	INSERT INTO Enero VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Febrero' 
	INSERT INTO Febrero VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Marzo' 
	INSERT INTO Marzo VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Abril' 
	INSERT INTO Abril VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Mayo'
	INSERT INTO Mayo VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Junio'
	INSERT INTO Junio VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Julio' 
	INSERT INTO Julio VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Agosto' 
	INSERT INTO Agosto VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Septiembre' 
	INSERT INTO Septiembre VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Octubre' 
	INSERT INTO Octubre VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Noviembre'
	INSERT INTO Noviembre VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)
ELSE
IF @MesProceso = 'Diciembre' 
	INSERT INTO Diciembre VALUES(@TipoRegistro, @TipoCaptacion, @RutCliente, @RutCliente2, @NumeroOperacion, @Serial, @Oficina, @Moneda, @Tasa, @FechaEmision, @FechaVencimiento, @PlazoReal, @CuentaContableCapital, @MontoCaptacion, @CuentaContableIntereses, @Intereses, @CuentaContableReajuste, @Reajustes, @MontoFinal, @EstadoOperacion, @SituacionContable, @CodigPlazoContable, @ClaseOperacion, @SaldoInsolutoMonedaOrigen, @SaldoInsolutoPesos, @NumeroRecompras, @FechaUltimaRecompra, @MontoPagoCapital, @MontoPagoIntereses, @MontoPagoReajustes, @CodigoTipoOperacion, @PlazoOperacional, @UnidadPlazoOperacional, @FechaCaptacionOriginal, @NumeroOperacionQueGeneroRenovacion, @NumeroOperacionOriginal, @FechaDevengo, @CodigoTipoTasa, @FechaVencimiento2, @SaldoValorFinal, @ValorCambioCaptacion, @ValorCambioVencimiento, @CompraPropiaUltimaEmision, @CompraPropiaEmisionTotal, @CuentaContableCapital2, @Disponible)


GO


