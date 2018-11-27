USE [CamComparar]
GO

/****** Object:  StoredProcedure [dbo].[BorraDE]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[BorraDE](@DE int)
   as 
begin
 if @DE = 11 
  begin
			if exists(select 1 from sys.objects where name = 'DE11Banke')
		 begin 
			   Delete DE11Banke
		   end 
    end
if @DE = 16 
  begin
			if exists(select 1 from sys.objects where name = 'DE11CLI')
		 begin 
			   Delete DE11CLI
		   end 
    end
 if @DE = 13 
  begin
			if exists(select 1 from sys.objects where name = 'DE13Banke')
		 begin 
			   Delete DE13Banke
		   end 
    end
 if @DE = 17 
  begin
			if exists(select 1 from sys.objects where name = 'DE13CLI')
		 begin 
			   Delete DE13CLI
		   end 
    end
if @DE = 15 
  begin
			if exists(select 1 from sys.objects where name = 'DE15Banke')
		 begin 
			   Delete DE15Banke
		   end 
    end
if @DE = 18 
  begin
			if exists(select 1 from sys.objects where name = 'DE15CLI')
		 begin 
			   Delete DE15CLI
		   end 
    end
     if @DE = 21 
  begin
			if exists(select 1 from sys.objects where name = 'DE21Banke')
		 begin 
			   Delete DE21Banke
		   end 
    end
   
     if @DE = 23 
  begin
			if exists(select 1 from sys.objects where name = 'DE23Banke')
		 begin 
			   Delete DE23Banke
		   end 
    end
     if @DE = 25 
  begin
			if exists(select 1 from sys.objects where name = 'DE25Banke')
		 begin 
			   Delete DE25Banke
		   end 
    end

	 if @DE = 26 
  begin
			if exists(select 1 from sys.objects where name = 'DE21CLI')
		 begin 
			   Delete DE21CLI
		   end 
    end

	 if @DE = 27
  begin
			if exists(select 1 from sys.objects where name = 'DE23CLI')
		 begin 
			   Delete DE23CLI
		   end 
    end

	 if @DE = 28 
  begin
			if exists(select 1 from sys.objects where name = 'DE25CLI')
		 begin 
			   Delete DE25CLI
		   end 
    end
  end

  


GO


/****** Object:  StoredProcedure [dbo].[GuardaDE11]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[GuardaDE11]( @numero_secuencial int,
									 @ident_deu varchar(15),
									 @tipo_per char(2) ,
									 @nombre varchar(60),
									 @apellido varchar(30),
									 @codigo_Credito varchar(27),
									 @codigo_facilidad varchar(27),
									 @fecha_aprobacion DateTime ,
									 @monto_aprobado decimal(12,2),
									 @fecha_Desembolso DateTime,
									 @monto_Desembolsado decimal(12,2),
									 @fecha_vencimiento DateTime,
									 @fecha_Ppago DateTime,
									 @monto_Cuota decimal(12,2),
									 @forma_pago_cap char(1),
									 @forma_pago_Int char(1),
									 @periodo_gracias int, 
									 @tasa_int decimal(12,2),
									 @tipo_Mon char(1),
									 @cobran_judicial  char(1),
									 @clasif_Ini char(1),
									 @clasif_MExp char(1),
									 @clasif_MCub char(1),
									 @prov_req decimal(12,2),
									 @origen_recursos char(2),
									 @tipo_Vinculo char(2),
									 @garantia_adm decimal(12,2),
									 @fecha_reestruc DateTime,
									 @fecha_renovac DateTime,
									 @localidad varchar(6),
									 @act_Deudor int ,
									 @dest_cred int ,
									 @no_Oficina char(5),
									 @clasif_riesgo char(1),
									 @cod_pais char(2),
									 @fecha_IAdjudicacion DateTime,
									 @ident_DestinaConting varchar(15),
									 @nombre_destinatario varchar(15),
									 @opcion_pago char(2),
									 @penal_pago decimal(12,2),
									 @provision_cap decimal(12,2),
									 @prov_rendimientos decimal(12,2),
									 @prov_contingencia decimal(12,2),
									 @fecha_rev DateTime,
									 @fecha_CuotExtr DateTime,
									 @monto_CuoExt decimal(12,2),
									 @tipo_cliente int,
									 @facilidad_credT78 int,
									 @cantidad_Plastic int,
									 @cod_Subproducto int,
									 @tip_cred char(1) )
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE11Banke')
		 begin 
			   create table DE11Banke (	numero_secuencial int,
									 ident_deu varchar(15),
									 tipo_per char(2) ,
									 nombre varchar(60),
									 apellido varchar(30),
									 codigo_Credito varchar(27),
									 codigo_facilidad varchar(27),
									 fecha_aprobacion DateTime ,
									 monto_aprobado decimal(12,2),
									 fecha_Desembolso DateTime,
									 monto_Desembolsado decimal(12,2),
									 fecha_vencimiento DateTime,
									 fecha_Ppago DateTime,
									 monto_Cuota decimal(12,2),
									 forma_pago_cap char(1),
									 forma_pago_Int char(1),
									 periodo_gracias int, 
									 tasa_int decimal(12,2),
									 tipo_Mon char(1),
									 cobran_judicial  char(1),
									 clasif_Ini char(1),
									 clasif_MExp char(1),
									 clasif_MCub char(1),
									 prov_req decimal(12,2),
									 origen_recursos char(2),
									 tipo_Vinculo char(2),
									 garantia_adm decimal(12,2),
									 fecha_reestruc DateTime,
									 fecha_renovac DateTime,
									 localidad varchar(6),
									 act_Deudor int ,
									 dest_cred int ,
									 no_Oficina char(5),
									 clasif_riesgo char(1),
									 cod_pais char(2),
									 fecha_IAdjudicacion DateTime,
									 ident_DestinaConting varchar(15),
									 nombre_destinatario varchar(6),
									 opcion_pago char(2),
									 penal_pago decimal(12,2),
									 provision_cap decimal(12,2),
									 prov_rendimientos decimal(12,2),
									 prov_contingencia decimal(12,2),
									 fecha_rev DateTime,
									 fecha_CuotExtr DateTime,
									 monto_CuoExt decimal(12,2),
									 tipo_cliente int,
									 facilidad_credT78 int,
									 cantidad_Plastic int,
									 cod_Subproducto int,
									 tip_cred char(1),
									 referencia varchar(20) NULL
									)
		   end 
   insert into DE11Banke(numero_secuencial  ,
									 ident_deu ,
									 tipo_per   ,
									 nombre ,
									 apellido ,
									 codigo_Credito ,
									 codigo_facilidad ,
									 fecha_aprobacion   ,
									 monto_aprobado  ,
									 fecha_Desembolso  ,
									 monto_Desembolsado  ,
									 fecha_vencimiento  ,
									 fecha_Ppago  ,
									 monto_Cuota  ,
									 forma_pago_cap  ,
									 forma_pago_int   ,
									 periodo_gracias  , 
									 tasa_int   ,
									 tipo_Mon  ,
									 cobran_judicial   ,
									 clasif_Ini  ,
									 clasif_MExp  ,
									 clasif_MCub  ,
									 prov_req  ,
									 origen_recursos  ,
									 tipo_Vinculo  ,
									 garantia_adm  ,
									 fecha_reestruc  ,
									 fecha_renovac  ,
									 localidad ,
									 act_Deudor   ,
									 dest_cred   ,
									 no_Oficina ,
									 clasif_riesgo  ,
									 cod_pais  ,
									 fecha_IAdjudicacion  ,
									 ident_DestinaConting  ,
									 nombre_destinatario  ,
									 opcion_pago  ,
									 penal_pago  ,
									 provision_cap  ,
									 prov_rendimientos  ,
									 prov_contingencia  ,
									 fecha_rev  ,
									 fecha_CuotExtr  ,
									 monto_CuoExt  ,
									 tipo_cliente  ,
									 facilidad_credT78  ,
									 cantidad_Plastic  ,
									 cod_Subproducto  ,
									 tip_cred  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @codigo_facilidad ,
									 @fecha_aprobacion   ,
									 @monto_aprobado  ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @forma_pago_cap  ,
									 @forma_pago_Int   ,
									 @periodo_gracias  , 
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @clasif_MExp  ,
									 @clasif_MCub  ,
									 @prov_req  ,
									 @origen_recursos  ,
									 @tipo_Vinculo  ,
									 @garantia_adm  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @act_Deudor   ,
									 @dest_cred   ,
									 @no_Oficina  ,
									 @clasif_riesgo  ,
									 @cod_pais  ,
									 @fecha_IAdjudicacion  ,
									 @ident_DestinaConting  ,
									 @nombre_destinatario  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @prov_contingencia  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  ,
									 @cantidad_Plastic  ,
									 @cod_Subproducto  ,
									 @tip_cred   )
  end






GO

/****** Object:  StoredProcedure [dbo].[GuardaDE11CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[GuardaDE11CLI]( @numero_secuencial int,
									 @ident_deu varchar(15),
									 @tipo_per char(2) ,
									 @nombre varchar(60),
									 @apellido varchar(30),
									 @codigo_Credito varchar(27),
									 @codigo_facilidad varchar(27),
									 @fecha_aprobacion DateTime ,
									 @monto_aprobado decimal(12,2),
									 @fecha_Desembolso DateTime,
									 @monto_Desembolsado decimal(12,2),
									 @fecha_vencimiento DateTime,
									 @fecha_Ppago DateTime,
									 @monto_Cuota decimal(12,2),
									 @forma_pago_cap char(1),
									 @forma_pago_Int char(1),
									 @periodo_gracias int, 
									 @tasa_int decimal(12,2),
									 @tipo_Mon char(1),
									 @cobran_judicial  char(1),
									 @clasif_Ini char(1),
									 @clasif_MExp char(1),
									 @clasif_MCub char(1),
									 @prov_req decimal(12,2),
									 @origen_recursos char(2),
									 @tipo_Vinculo char(2),
									 @garantia_adm decimal(12,2),
									 @fecha_reestruc DateTime,
									 @fecha_renovac DateTime,
									 @localidad varchar(6),
									 @act_Deudor int ,
									 @dest_cred int ,
									 @no_Oficina char(5),
									 @clasif_riesgo char(1),
									 @cod_pais char(2),
									 @fecha_IAdjudicacion DateTime,
									 @ident_DestinaConting varchar(15),
									 @nombre_destinatario varchar(15),
									 @opcion_pago char(2),
									 @penal_pago decimal(12,2),
									 @provision_cap decimal(12,2),
									 @prov_rendimientos decimal(12,2),
									 @prov_contingencia decimal(12,2),
									 @fecha_rev DateTime,
									 @fecha_CuotExtr DateTime,
									 @monto_CuoExt decimal(12,2),
									 @tipo_cliente int,
									 @facilidad_credT78 int,
									 @cantidad_Plastic int,
									 @cod_Subproducto int,
									 @tip_cred char(1) )
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE11CLI')
		 begin 
			   create table DE11CLI (	numero_secuencial int,
									 ident_deu varchar(15),
									 tipo_per char(2) ,
									 nombre varchar(60),
									 apellido varchar(30),
									 codigo_Credito varchar(27),
									 codigo_facilidad varchar(27),
									 fecha_aprobacion DateTime ,
									 monto_aprobado decimal(12,2),
									 fecha_Desembolso DateTime,
									 monto_Desembolsado decimal(12,2),
									 fecha_vencimiento DateTime,
									 fecha_Ppago DateTime,
									 monto_Cuota decimal(12,2),
									 forma_pago_cap char(1),
									 forma_pago_Int char(1),
									 periodo_gracias int, 
									 tasa_int decimal(12,2),
									 tipo_Mon char(1),
									 cobran_judicial  char(1),
									 clasif_Ini char(1),
									 clasif_MExp char(1),
									 clasif_MCub char(1),
									 prov_req decimal(12,2),
									 origen_recursos char(2),
									 tipo_Vinculo char(2),
									 garantia_adm decimal(12,2),
									 fecha_reestruc DateTime,
									 fecha_renovac DateTime,
									 localidad varchar(6),
									 act_Deudor int ,
									 dest_cred int ,
									 no_Oficina char(5),
									 clasif_riesgo char(1),
									 cod_pais char(2),
									 fecha_IAdjudicacion DateTime,
									 ident_DestinaConting varchar(15),
									 nombre_destinatario varchar(6),
									 opcion_pago char(2),
									 penal_pago decimal(12,2),
									 provision_cap decimal(12,2),
									 prov_rendimientos decimal(12,2),
									 prov_contingencia decimal(12,2),
									 fecha_rev DateTime,
									 fecha_CuotExtr DateTime,
									 monto_CuoExt decimal(12,2),
									 tipo_cliente int,
									 facilidad_credT78 int,
									 cantidad_Plastic int,
									 cod_Subproducto int,
									 tip_cred char(1),
									 referencia varchar(20) NULL
									)
		   end 
   insert into DE11CLI(numero_secuencial  ,
									 ident_deu ,
									 tipo_per   ,
									 nombre ,
									 apellido ,
									 codigo_Credito ,
									 codigo_facilidad ,
									 fecha_aprobacion   ,
									 monto_aprobado  ,
									 fecha_Desembolso  ,
									 monto_Desembolsado  ,
									 fecha_vencimiento  ,
									 fecha_Ppago  ,
									 monto_Cuota  ,
									 forma_pago_cap  ,
									 forma_pago_int   ,
									 periodo_gracias  , 
									 tasa_int   ,
									 tipo_Mon  ,
									 cobran_judicial   ,
									 clasif_Ini  ,
									 clasif_MExp  ,
									 clasif_MCub  ,
									 prov_req  ,
									 origen_recursos  ,
									 tipo_Vinculo  ,
									 garantia_adm  ,
									 fecha_reestruc  ,
									 fecha_renovac  ,
									 localidad ,
									 act_Deudor   ,
									 dest_cred   ,
									 no_Oficina ,
									 clasif_riesgo  ,
									 cod_pais  ,
									 fecha_IAdjudicacion  ,
									 ident_DestinaConting  ,
									 nombre_destinatario  ,
									 opcion_pago  ,
									 penal_pago  ,
									 provision_cap  ,
									 prov_rendimientos  ,
									 prov_contingencia  ,
									 fecha_rev  ,
									 fecha_CuotExtr  ,
									 monto_CuoExt  ,
									 tipo_cliente  ,
									 facilidad_credT78  ,
									 cantidad_Plastic  ,
									 cod_Subproducto  ,
									 tip_cred  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @codigo_facilidad ,
									 @fecha_aprobacion   ,
									 @monto_aprobado  ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @forma_pago_cap  ,
									 @forma_pago_Int   ,
									 @periodo_gracias  , 
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @clasif_MExp  ,
									 @clasif_MCub  ,
									 @prov_req  ,
									 @origen_recursos  ,
									 @tipo_Vinculo  ,
									 @garantia_adm  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @act_Deudor   ,
									 @dest_cred   ,
									 @no_Oficina  ,
									 @clasif_riesgo  ,
									 @cod_pais  ,
									 @fecha_IAdjudicacion  ,
									 @ident_DestinaConting  ,
									 @nombre_destinatario  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @prov_contingencia  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  ,
									 @cantidad_Plastic  ,
									 @cod_Subproducto  ,
									 @tip_cred   )
  end







GO

/****** Object:  StoredProcedure [dbo].[GuardaDE13]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[GuardaDE13]( @numero_secuencial int,
										 @ident_deu varchar(15),
										 @tipo_per char(2) ,
										 @nombre varchar(60),
										 @apellido varchar(30),
										 @codigo_Credito varchar(27),
										 @fecha_Desembolso DateTime,
										 @monto_Desembolsado decimal(12,2),
										 @fecha_vencimiento DateTime,
										 @fecha_Ppago DateTime,
										 @monto_Cuota decimal(12,2),
										 @tasa_int decimal(12,2),
										 @tipo_Mon char(1),
										 @cobran_judicial  char(1),
										 @clasif_Ini char(1),
										 @prov_req decimal(12,2),
										 @tipo_Vinculo char(2),
										 @localidad varchar(6),
										 @no_Oficina char(5),
										 @forma_pago_cap char(1),
										 @forma_pago_Int char(1),
										 @fecha_reestruc DateTime,
										 @fecha_renovac DateTime,
										 @fecha_aprobacion DateTime ,
										 @monto_aprobado decimal(12,2),
										 @opcion_pago char(2),
										 @penal_pago decimal(12,2),
										 @provision_cap decimal(12,2),
										 @prov_rendimientos decimal(12,2),
										 @prov_contingencia decimal(12,2),
										 @fecha_rev DateTime,
										 @fecha_CuotExtr DateTime,
										 @monto_CuoExt decimal(12,2),
										 @reestructurado char(2),
										 @tipo_cliente int,
										 @facilidad_credT78 int
									 )

   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE13Banke')
		 begin 
			   create table DE13Banke (	numero_secuencial int,
									 ident_deu varchar(15),
									 tipo_per char(2) ,
									 nombre varchar(60),
									 apellido varchar(30),
									 codigo_Credito varchar(27),
									 fecha_Desembolso DateTime,
									 monto_Desembolsado decimal(12,2),
									 fecha_vencimiento DateTime,
									 fecha_Ppago DateTime,
									 monto_Cuota decimal(12,2),
									 tasa_int decimal(12,2),
									 tipo_Mon char(1),
									 cobran_judicial  char(1),
									 clasif_Ini char(1),
									 prov_req decimal(12,2),
									 tipo_Vinculo char(2),
									 localidad varchar(6),
									 no_Oficina char(5),
									 forma_pago_cap char(1),
									 forma_pago_Int char(1),
									 fecha_reestruc DateTime,
									 fecha_renovac DateTime,
									 fecha_aprobacion DateTime ,
									 monto_aprobado decimal(12,2),
									 opcion_pago char(2),
									 penal_pago decimal(12,2),
									 provision_cap decimal(12,2),
									 prov_rendimientos decimal(12,2),
									 prov_contingencia decimal(12,2),
									 fecha_rev DateTime,
									 fecha_CuotExtr DateTime,
									 monto_CuoExt decimal(12,2),
									 reestructurado char(2),
									 tipo_cliente int,
									 facilidad_credT78 int,
									 referencia varchar(20) NULL
									)
		   end 
   insert into DE13Banke(   numero_secuencial  ,
							ident_deu ,
							tipo_per   ,
							nombre ,
							apellido ,
							codigo_Credito ,
							fecha_aprobacion   ,
							monto_aprobado  ,
							fecha_Desembolso  ,
							monto_Desembolsado  ,
							fecha_vencimiento  ,
							fecha_Ppago  ,
							monto_Cuota  ,
							forma_pago_cap  ,
							forma_pago_int   ,
							tasa_int   ,
							tipo_Mon  ,
							cobran_judicial   ,
							clasif_Ini  ,
							prov_req  ,
							tipo_Vinculo  ,
							fecha_reestruc  ,
							fecha_renovac  ,
							localidad ,
							no_Oficina ,
							opcion_pago  ,
							penal_pago  ,
							provision_cap  ,
							prov_rendimientos  ,
							prov_contingencia  ,
							fecha_rev  ,
							fecha_CuotExtr  ,
							monto_CuoExt  ,
							tipo_cliente  ,
							facilidad_credT78  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @fecha_aprobacion   ,
									 @monto_aprobado  ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @forma_pago_cap  ,
									 @forma_pago_Int   , 
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @prov_req  ,
									 @tipo_Vinculo  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @no_Oficina  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @prov_contingencia  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  )
  end







GO

/****** Object:  StoredProcedure [dbo].[GuardaDE13CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[GuardaDE13CLI]( @numero_secuencial int,
										 @ident_deu varchar(15),
										 @tipo_per char(2) ,
										 @nombre varchar(60),
										 @apellido varchar(30),
										 @codigo_Credito varchar(27),
										 @fecha_Desembolso DateTime,
										 @monto_Desembolsado decimal(12,2),
										 @fecha_vencimiento DateTime,
										 @fecha_Ppago DateTime,
										 @monto_Cuota decimal(12,2),
										 @tasa_int decimal(12,2),
										 @tipo_Mon char(1),
										 @cobran_judicial  char(1),
										 @clasif_Ini char(1),
										 @prov_req decimal(12,2),
										 @tipo_Vinculo char(2),
										 @localidad varchar(6),
										 @no_Oficina char(5),
										 @forma_pago_cap char(1),
										 @forma_pago_Int char(1),
										 @fecha_reestruc DateTime,
										 @fecha_renovac DateTime,
										 @fecha_aprobacion DateTime ,
										 @monto_aprobado decimal(12,2),
										 @opcion_pago char(2),
										 @penal_pago decimal(12,2),
										 @provision_cap decimal(12,2),
										 @prov_rendimientos decimal(12,2),
										 @prov_contingencia decimal(12,2),
										 @fecha_rev DateTime,
										 @fecha_CuotExtr DateTime,
										 @monto_CuoExt decimal(12,2),
										 @reestructurado char(2),
										 @tipo_cliente int,
										 @facilidad_credT78 int
									 )

   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE13CLI')
		 begin 
			   create table DE13CLI (	numero_secuencial int,
									 ident_deu varchar(15),
									 tipo_per char(2) ,
									 nombre varchar(60),
									 apellido varchar(30),
									 codigo_Credito varchar(27),
									 fecha_Desembolso DateTime,
									 monto_Desembolsado decimal(12,2),
									 fecha_vencimiento DateTime,
									 fecha_Ppago DateTime,
									 monto_Cuota decimal(12,2),
									 tasa_int decimal(12,2),
									 tipo_Mon char(1),
									 cobran_judicial  char(1),
									 clasif_Ini char(1),
									 prov_req decimal(12,2),
									 tipo_Vinculo char(2),
									 localidad varchar(6),
									 no_Oficina char(5),
									 forma_pago_cap char(1),
									 forma_pago_Int char(1),
									 fecha_reestruc DateTime,
									 fecha_renovac DateTime,
									 fecha_aprobacion DateTime ,
									 monto_aprobado decimal(12,2),
									 opcion_pago char(2),
									 penal_pago decimal(12,2),
									 provision_cap decimal(12,2),
									 prov_rendimientos decimal(12,2),
									 prov_contingencia decimal(12,2),
									 fecha_rev DateTime,
									 fecha_CuotExtr DateTime,
									 monto_CuoExt decimal(12,2),
									 reestructurado char(2),
									 tipo_cliente int,
									 facilidad_credT78 int,
									 referencia varchar(20) NULL
									)
		   end 
   insert into DE13CLI(   numero_secuencial  ,
							ident_deu ,
							tipo_per   ,
							nombre ,
							apellido ,
							codigo_Credito ,
							fecha_aprobacion   ,
							monto_aprobado  ,
							fecha_Desembolso  ,
							monto_Desembolsado  ,
							fecha_vencimiento  ,
							fecha_Ppago  ,
							monto_Cuota  ,
							forma_pago_cap  ,
							forma_pago_int   ,
							tasa_int   ,
							tipo_Mon  ,
							cobran_judicial   ,
							clasif_Ini  ,
							prov_req  ,
							tipo_Vinculo  ,
							fecha_reestruc  ,
							fecha_renovac  ,
							localidad ,
							no_Oficina ,
							opcion_pago  ,
							penal_pago  ,
							provision_cap  ,
							prov_rendimientos  ,
							prov_contingencia  ,
							fecha_rev  ,
							fecha_CuotExtr  ,
							monto_CuoExt  ,
							tipo_cliente  ,
							facilidad_credT78  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @fecha_aprobacion   ,
									 @monto_aprobado  ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @forma_pago_cap  ,
									 @forma_pago_Int   , 
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @prov_req  ,
									 @tipo_Vinculo  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @no_Oficina  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @prov_contingencia  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  )
  end








GO

/****** Object:  StoredProcedure [dbo].[GuardaDE15]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[GuardaDE15]( @numero_secuencial int,
										 @ident_deu varchar(15),
										 @tipo_per char(2) ,
										 @nombre varchar(60),
										 @apellido varchar(30),
										 @codigo_Credito varchar(27),
										 @fecha_Desembolso DateTime,
										 @monto_Desembolsado decimal(12,2),
										 @fecha_vencimiento DateTime,
										 @fecha_Ppago DateTime,
										 @monto_Cuota decimal(12,2),
										 @tasa_int decimal(12,2),
										 @tipo_Mon char(1),
										 @cobran_judicial  char(1),
										 @clasif_Ini char(1),
										 @prov_req decimal(12,2),
										 @tipo_Vinculo char(2),
										 @localidad varchar(6),
										 @no_Oficina char(5),
										 @fecha_reestruc DateTime,
										 @fecha_renovac DateTime,
										 @opcion_pago char(2),
										 @penal_pago decimal(12,2),
										 @provision_cap decimal(12,2),
										 @prov_rendimientos decimal(12,2),
										 @fecha_rev DateTime,
										 @fecha_CuotExtr DateTime,
										 @monto_CuoExt decimal(12,2),
										 @reestructurado char(2),
										 @tipo_cliente int,
										 @facilidad_credT78 int
									 )

   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE15Banke')
		 begin 
			   create table DE15Banke (	 numero_secuencial int,
										 ident_deu varchar(15),
										 tipo_per char(2) ,
										 nombre varchar(60),
										 apellido varchar(30),
										 codigo_Credito varchar(27),
										 fecha_Desembolso DateTime,
										 monto_Desembolsado decimal(12,2),
										 fecha_vencimiento DateTime,
										 fecha_Ppago DateTime,
										 monto_Cuota decimal(12,2),
										 tasa_int decimal(12,2),
										 tipo_Mon char(1),
										 cobran_judicial  char(1),
										 clasif_Ini char(1),
										 prov_req decimal(12,2),
										 tipo_Vinculo char(2),
										 localidad varchar(6),
										 no_Oficina char(5),
										 fecha_reestruc DateTime,
										 fecha_renovac DateTime,
										 opcion_pago char(2),
										 penal_pago decimal(12,2),
										 provision_cap decimal(12,2),
										 prov_rendimientos decimal(12,2),
										 fecha_rev DateTime,
										 fecha_CuotExtr DateTime,
										 monto_CuoExt decimal(12,2),
										 reestructurado char(2),
										 tipo_cliente int,
										 facilidad_credT78 int,
										 referencia varchar(20) NULL
									)
		   end 
   insert into DE15Banke(   numero_secuencial  ,
							ident_deu ,
							tipo_per   ,
							nombre ,
							apellido ,
							codigo_Credito ,
							fecha_Desembolso  ,
							monto_Desembolsado  ,
							fecha_vencimiento  ,
							fecha_Ppago  ,
							monto_Cuota  ,
							tasa_int   ,
							tipo_Mon  ,
							cobran_judicial   ,
							clasif_Ini  ,
							prov_req  ,
							tipo_Vinculo  ,
							fecha_reestruc  ,
							fecha_renovac  ,
							localidad ,
							no_Oficina ,
							opcion_pago  ,
							penal_pago  ,
							provision_cap  ,
							prov_rendimientos  ,
							fecha_rev  ,
							fecha_CuotExtr  ,
							monto_CuoExt  ,
							tipo_cliente  ,
							facilidad_credT78  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @prov_req  ,
									 @tipo_Vinculo  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @no_Oficina  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  )
  end







GO

/****** Object:  StoredProcedure [dbo].[GuardaDE15CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[GuardaDE15CLI]( @numero_secuencial int,
										 @ident_deu varchar(15),
										 @tipo_per char(2) ,
										 @nombre varchar(60),
										 @apellido varchar(30),
										 @codigo_Credito varchar(27),
										 @fecha_Desembolso DateTime,
										 @monto_Desembolsado decimal(12,2),
										 @fecha_vencimiento DateTime,
										 @fecha_Ppago DateTime,
										 @monto_Cuota decimal(12,2),
										 @tasa_int decimal(12,2),
										 @tipo_Mon char(1),
										 @cobran_judicial  char(1),
										 @clasif_Ini char(1),
										 @prov_req decimal(12,2),
										 @tipo_Vinculo char(2),
										 @localidad varchar(6),
										 @no_Oficina char(5),
										 @fecha_reestruc DateTime,
										 @fecha_renovac DateTime,
										 @opcion_pago char(2),
										 @penal_pago decimal(12,2),
										 @provision_cap decimal(12,2),
										 @prov_rendimientos decimal(12,2),
										 @fecha_rev DateTime,
										 @fecha_CuotExtr DateTime,
										 @monto_CuoExt decimal(12,2),
										 @reestructurado char(2),
										 @tipo_cliente int,
										 @facilidad_credT78 int
									 )

   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE15CLI')
		 begin 
			   create table DE15CLI (	 numero_secuencial int,
										 ident_deu varchar(15),
										 tipo_per char(2) ,
										 nombre varchar(60),
										 apellido varchar(30),
										 codigo_Credito varchar(27),
										 fecha_Desembolso DateTime,
										 monto_Desembolsado decimal(12,2),
										 fecha_vencimiento DateTime,
										 fecha_Ppago DateTime,
										 monto_Cuota decimal(12,2),
										 tasa_int decimal(12,2),
										 tipo_Mon char(1),
										 cobran_judicial  char(1),
										 clasif_Ini char(1),
										 prov_req decimal(12,2),
										 tipo_Vinculo char(2),
										 localidad varchar(6),
										 no_Oficina char(5),
										 fecha_reestruc DateTime,
										 fecha_renovac DateTime,
										 opcion_pago char(2),
										 penal_pago decimal(12,2),
										 provision_cap decimal(12,2),
										 prov_rendimientos decimal(12,2),
										 fecha_rev DateTime,
										 fecha_CuotExtr DateTime,
										 monto_CuoExt decimal(12,2),
										 reestructurado char(2),
										 tipo_cliente int,
										 facilidad_credT78 int,
										 referencia varchar(20) NULL
									)
		   end 
   insert into DE15CLI(   numero_secuencial  ,
							ident_deu ,
							tipo_per   ,
							nombre ,
							apellido ,
							codigo_Credito ,
							fecha_Desembolso  ,
							monto_Desembolsado  ,
							fecha_vencimiento  ,
							fecha_Ppago  ,
							monto_Cuota  ,
							tasa_int   ,
							tipo_Mon  ,
							cobran_judicial   ,
							clasif_Ini  ,
							prov_req  ,
							tipo_Vinculo  ,
							fecha_reestruc  ,
							fecha_renovac  ,
							localidad ,
							no_Oficina ,
							opcion_pago  ,
							penal_pago  ,
							provision_cap  ,
							prov_rendimientos  ,
							fecha_rev  ,
							fecha_CuotExtr  ,
							monto_CuoExt  ,
							tipo_cliente  ,
							facilidad_credT78  )
        values (@numero_secuencial  ,
									 @ident_deu ,
									 @tipo_per   ,
									 @nombre ,
									 @apellido ,
									 @codigo_Credito ,
									 @fecha_Desembolso  ,
									 @monto_Desembolsado  ,
									 @fecha_vencimiento  ,
									 @fecha_Ppago  ,
									 @monto_Cuota  ,
									 @tasa_int   ,
									 @tipo_Mon  ,
									 @cobran_judicial   ,
									 @clasif_Ini  ,
									 @prov_req  ,
									 @tipo_Vinculo  ,
									 @fecha_reestruc  ,
									 @fecha_renovac  ,
									 @localidad  ,
									 @no_Oficina  ,
									 @opcion_pago  ,
									 @penal_pago  ,
									 @provision_cap  ,
									 @prov_rendimientos  ,
									 @fecha_rev  ,
									 @fecha_CuotExtr  ,
									 @monto_CuoExt  ,
									 @tipo_cliente  ,
									 @facilidad_credT78  )
  end








GO

/****** Object:  StoredProcedure [dbo].[GuardaDE21]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GuardaDE21](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int,
							@T_moneda char(1))
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE21Banke')
		 begin 
			   create table DE21Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE21Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,T_moneda,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,@T_moneda,NULL)
  end


GO

/****** Object:  StoredProcedure [dbo].[GuardaDE21CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GuardaDE21CLI](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int,
							@T_moneda char(1))
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE21CLI')
		 begin 
			   create table DE21CLI (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE21CLI(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,T_moneda,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,@T_moneda,NULL)
  end



GO

/****** Object:  StoredProcedure [dbo].[GuardaDE23]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GuardaDE23](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE23Banke')
		 begin 
			   create table DE23Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE23Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end


GO

/****** Object:  StoredProcedure [dbo].[GuardaDE23CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GuardaDE23CLI](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE23CLI')
		 begin 
			   create table DE23CLI (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE23CLI(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end



GO

/****** Object:  StoredProcedure [dbo].[GuardaDE25]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GuardaDE25](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE25Banke')
		 begin 
			   create table DE25Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE25Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end


GO

/****** Object:  StoredProcedure [dbo].[GuardaDE25CLI]    Script Date: 04/08/2015 04:29:02 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GuardaDE25CLI](@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE25CLI')
		 begin 
			   create table DE25CLI (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE25CLI(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end



GO