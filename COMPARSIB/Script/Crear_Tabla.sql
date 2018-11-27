USE [CamComparar]
GO

/****** Object:  Table [dbo].[DE11Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE11Banke](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[codigo_facilidad] [varchar](27) NULL,
	[fecha_aprobacion] [datetime] NULL,
	[monto_aprobado] [decimal](12, 2) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[forma_pago_cap] [char](1) NULL,
	[forma_pago_Int] [char](1) NULL,
	[periodo_gracias] [int] NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[clasif_MExp] [char](1) NULL,
	[clasif_MCub] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[origen_recursos] [char](2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[garantia_adm] [decimal](12, 2) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[localidad] [varchar](6) NULL,
	[act_Deudor] [int] NULL,
	[dest_cred] [int] NULL,
	[no_Oficina] [char](5) NULL,
	[clasif_riesgo] [char](1) NULL,
	[cod_pais] [char](2) NULL,
	[fecha_IAdjudicacion] [datetime] NULL,
	[ident_DestinaConting] [varchar](15) NULL,
	[nombre_destinatario] [varchar](6) NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[prov_contingencia] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[cantidad_Plastic] [int] NULL,
	[cod_Subproducto] [int] NULL,
	[tip_cred] [char](1) NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE11CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE11CLI](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[codigo_facilidad] [varchar](27) NULL,
	[fecha_aprobacion] [datetime] NULL,
	[monto_aprobado] [decimal](12, 2) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[forma_pago_cap] [char](1) NULL,
	[forma_pago_Int] [char](1) NULL,
	[periodo_gracias] [int] NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[clasif_MExp] [char](1) NULL,
	[clasif_MCub] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[origen_recursos] [char](2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[garantia_adm] [decimal](12, 2) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[localidad] [varchar](6) NULL,
	[act_Deudor] [int] NULL,
	[dest_cred] [int] NULL,
	[no_Oficina] [char](5) NULL,
	[clasif_riesgo] [char](1) NULL,
	[cod_pais] [char](2) NULL,
	[fecha_IAdjudicacion] [datetime] NULL,
	[ident_DestinaConting] [varchar](15) NULL,
	[nombre_destinatario] [varchar](6) NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[prov_contingencia] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[cantidad_Plastic] [int] NULL,
	[cod_Subproducto] [int] NULL,
	[tip_cred] [char](1) NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE13Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE13Banke](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[localidad] [varchar](6) NULL,
	[no_Oficina] [char](5) NULL,
	[forma_pago_cap] [char](1) NULL,
	[forma_pago_Int] [char](1) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[fecha_aprobacion] [datetime] NULL,
	[monto_aprobado] [decimal](12, 2) NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[prov_contingencia] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[reestructurado] [char](2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE13CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE13CLI](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[localidad] [varchar](6) NULL,
	[no_Oficina] [char](5) NULL,
	[forma_pago_cap] [char](1) NULL,
	[forma_pago_Int] [char](1) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[fecha_aprobacion] [datetime] NULL,
	[monto_aprobado] [decimal](12, 2) NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[prov_contingencia] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[reestructurado] [char](2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE15Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE15Banke](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[localidad] [varchar](6) NULL,
	[no_Oficina] [char](5) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[reestructurado] [char](2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE15CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE15CLI](
	[numero_secuencial] [int] NULL,
	[ident_deu] [varchar](15) NULL,
	[tipo_per] [char](2) NULL,
	[nombre] [varchar](60) NULL,
	[apellido] [varchar](30) NULL,
	[codigo_Credito] [varchar](27) NULL,
	[fecha_Desembolso] [datetime] NULL,
	[monto_Desembolsado] [decimal](12, 2) NULL,
	[fecha_vencimiento] [datetime] NULL,
	[fecha_Ppago] [datetime] NULL,
	[monto_Cuota] [decimal](12, 2) NULL,
	[tasa_int] [decimal](12, 2) NULL,
	[tipo_Mon] [char](1) NULL,
	[cobran_judicial] [char](1) NULL,
	[clasif_Ini] [char](1) NULL,
	[prov_req] [decimal](12, 2) NULL,
	[tipo_Vinculo] [char](2) NULL,
	[localidad] [varchar](6) NULL,
	[no_Oficina] [char](5) NULL,
	[fecha_reestruc] [datetime] NULL,
	[fecha_renovac] [datetime] NULL,
	[opcion_pago] [char](2) NULL,
	[penal_pago] [decimal](12, 2) NULL,
	[provision_cap] [decimal](12, 2) NULL,
	[prov_rendimientos] [decimal](12, 2) NULL,
	[fecha_rev] [datetime] NULL,
	[fecha_CuotExtr] [datetime] NULL,
	[monto_CuoExt] [decimal](12, 2) NULL,
	[reestructurado] [char](2) NULL,
	[tipo_cliente] [int] NULL,
	[facilidad_credT78] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE21Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE21Banke](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[T_moneda] [char](1) NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE21CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE21CLI](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[T_moneda] [char](1) NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE23Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE23Banke](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE23CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE23CLI](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE25Banke]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE25Banke](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[DE25CLI]    Script Date: 04/08/2015 04:32:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DE25CLI](
	[No_sec] [int] NULL,
	[cod_cred] [varchar](27) NULL,
	[cuecta_cont] [varchar](80) NULL,
	[monto] [decimal](10, 2) NULL,
	[dia_atraso] [int] NULL,
	[Num_cuot] [int] NULL,
	[referencia] [varchar](20) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


