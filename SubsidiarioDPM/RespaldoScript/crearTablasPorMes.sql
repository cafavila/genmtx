USE [CarteraDPM]
GO

/****** Object:  Table [dbo].[Enero]    Script Date: 24-01-2014 15:11:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Enero](
	[TipoRegistro] [varchar](1) NULL,
	[TipoCaptacion] [varchar](4) NULL,
	[RutCliente] [varchar](10) NULL,
	[RutCliente2] [varchar](10) NULL,
	[NumeroOperacion] [varchar](12) NULL,
	[Serial] [varchar](12) NULL,
	[Oficina] [varchar](3) NULL,
	[Moneda] [varchar](6) NULL,
	[Tasa] [varchar](9) NULL,
	[FechaEmision] [varchar](10) NULL,
	[FechaVencimiento] [varchar](10) NULL,
	[PlazoReal] [varchar](5) NULL,
	[CuentaContableCapital] [varchar](12) NULL,
	[MontoCaptacion] [varchar](17) NULL,
	[CuentaContableIntereses] [varchar](12) NULL,
	[Intereses] [varchar](17) NULL,
	[CuentaContableReajuste] [varchar](12) NULL,
	[Reajustes] [varchar](19) NULL,
	[MontoFinal] [varchar](17) NULL,
	[EstadoOperacion] [varchar](1) NULL,
	[SituacionContable] [varchar](3) NULL,
	[CodigPlazoContable] [varchar](2) NULL,
	[ClaseOperacion] [varchar](6) NULL,
	[SaldoInsolutoMonedaOrigen] [varchar](17) NULL,
	[SaldoInsolutoPesos] [varchar](19) NULL,
	[NumeroRecompras] [varchar](3) NULL,
	[FechaUltimaRecompra] [varchar](10) NULL,
	[MontoPagoCapital] [varchar](19) NULL,
	[MontoPagoIntereses] [varchar](19) NULL,
	[MontoPagoReajustes] [varchar](19) NULL,
	[CodigoTipoOperacion] [varchar](8) NULL,
	[PlazoOperacional] [varchar](4) NULL,
	[UnidadPlazoOperacional] [varchar](1) NULL,
	[FechaCaptacionOriginal] [varchar](10) NULL,
	[NumeroOperacionQueGeneroRenovacion] [varchar](12) NULL,
	[NumeroOperacionOriginal] [varchar](12) NULL,
	[FechaDevengo] [varchar](10) NULL,
	[CodigoTipoTasa] [varchar](12) NULL,
	[FechaVencimiento2] [varchar](10) NULL,
	[SaldoValorFinal] [varchar](19) NULL,
	[ValorCambioCaptacion] [varchar](16) NULL,
	[ValorCambioVencimiento] [varchar](16) NULL,
	[CompraPropiaUltimaEmision] [varchar](16) NULL,
	[CompraPropiaEmisionTotal] [varchar](16) NULL,
	[CuentaContableCapital2] [varchar](12) NULL,
	[Columna 45] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


