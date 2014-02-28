USE [Subsidiario]
GO

/****** Object:  Table [dbo].[SubsidiarioMensual]    Script Date: 24-01-2014 16:17:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SubsidiarioMensual](
	[Fecha] [varchar](10) NOT NULL,
	[Oficina] [varchar](20) NOT NULL,
	[CuentaContable] [varchar](10) NOT NULL,
	[Nombre] [varchar](23) NULL,
	[Rut] [varchar](12) NULL,
	[Operacion] [varchar](12) NULL,
	[Serial] [varchar](12) NULL,
	[Tasa] [varchar](6) NULL,
	[Debe] [money] NULL,
	[Haber] [money] NULL,
	[Algoritmo] [varchar](1) NULL,
	[Saldo] [money] NULL,
  PRIMARY KEY ([Fecha], [Oficina], [CuentaContable])
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


