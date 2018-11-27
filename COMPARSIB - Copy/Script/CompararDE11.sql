




use CamComparar


SELECT  'BANKE' Sistema, 
		SUM(a.monto_aprobado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq		
  FROM DE11banke a 
union all
SELECT  'BANCOTUI' Sistema,
		SUM(a.monto_aprobado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq
  FROM DE11cli a 
  
  
  select isnull(DE11CLI.codigo_Credito,0)cuenta_pesoa		,
         isnull(DE11Banke.codigo_Credito,0) Cuenta_EasyBank,
		 isnull(DE11CLI.Nombre,DE11Banke.Nombre)Nombre ,
		 isnull(DE11Banke.clasif_Ini,'')	Clasificacion_Easybank,
		 isnull(DE11CLI.clasif_Ini,'')	Clasificacion_Bancotuí,
		 isnull(DE11CLI.monto_aprobado,0)monto_apro_Pesoa,
		 isnull(DE11Banke.monto_aprobado,0)monto_apro_EasyBank,
		 isnull(DE11CLI.monto_aprobado,0) - isnull(DE11Banke.monto_aprobado,0) Diferencia,
		 isnull(DE11CLI.prov_req,0)	ProvCapReq_Bancotuí,		 
		 isnull(DE11Banke.prov_req,0)		ProvCapReq_Easybank,
		 isnull(DE11CLI.prov_req,0) - isnull(DE11Banke.prov_req,0) Diferencia
    from DE11Banke 
		 full join DE11CLI on isnull(DE11Banke.referencia,0) = isnull(DE11CLI.codigo_Credito,0)
		 order by 11



/*
SE USARON LOS SCRIPT DE ARRIBA PARA LA COMPARACION 
DE AQUI EN ADELANTE HAY QUE REVISAR */

--Cuentas que estan en Easybank_14 y no en Bancotuí
select cuenta CUENTA_Easybank_14,
		referencia CUENTA_BANCOTUI,
		MONTO_APRO MONTOAPRO_BANKE, 
		Nombre +' '+Apellido NOMBRE,
		ProvCapReq,
		ProvCapContit 
  from cuentas_bankede11 a 
 where a.referencia not in (select b.cuenta from cuentas_Compararde11 b) 
 
 
 --Cuentas que estan en Bancotuí y no en Easybank
 select cuenta CUENTA,
		MONTO_APRO MONTOAPRO_BANCOTUI, 
		ProvCapReq,
		ProvCapContit
   from cuentas_Compararde11 a 
  where a.cuenta not in (select b.referencia from cuentas_bankeDE11 b)


      

select * 
  from cuentas_bankeDE11 a 
 where (isnull(a.referencia,0) not in (select isnull(b.cuenta,0) from cuentas_CompararDE11 b)) or 
		a.referencia is null )
       
 
 
 select a.* from cuentas_bankeDE11 a  where isnull(a.referencia,0) not in (select isnull(b.cuenta,0) from cuentas_CompararDE11 b) 

 select b.* from cuentas_CompararDE11 b where isnull(b.cuenta,0) not in (  select isnull(a.referencia,0)   from cuentas_bankeDE11 a )



 select cuenta CUENTA,
		MONTO_APRO MONTOAPRO_BANCOTUI, 
		ProvCapReq ProvCapReq,
		ProvCapContit ProvCapContit
   from cuentas_CompararDE11 a 
  where a.cuenta not in (select b.referencia from cuentas_bankeDE11 b)

 

   select * 
     from cuentas_CompararDE11 
	where cuenta not in (select cuentas_compararDE11.cuenta 
						   from cuentas_compararDE11 
					 inner join cuentas_BankeDE11 on referencia = cuentas_compararDE11.cuenta)




select * from cuentas_CompararDE11 where monto_apro =100000
select * from cuentas_BankeDE11 where monto_apro =100000



  
  
  
  --------------------------------------------------------------
  --PARA REVISAR CUALES PRESTAMOS TIENEN GARANTIA 
  
    
--select 'Certificado',* from BCT_garCertificado where referencia in ('20121509','20130081','20111159','20121983')

--select 'Hipotecaria',* from dbo.BCT_garHipotecaria where referencia in ('20121509','20130081','20111159','20121983')

--select 'Solidaria',* from dbo.BCT_garSolidaria where referencia in ('20121509','20130081','20111159','20121983')


--------------------------------------------------------------------------
--Amaury: -- Garantia Hipotecaria
SELECT * FROM DSPR..MAGHI

-- Garantia Solidaria
SELECT * FROM DSPR..MAGSO

-- Garantia de Certificados
SELECT * FROM DSPR..MAGCF 

--------------------------------------------------------------------------
--PARA CONSTRUIR SELECT A TABLA DE GARANTIA DE COTUI

--Garantia Hipotecaria
select 'SELECT * FROM DSPR..MAGHI WHERE NUMPRE ='''+a.cuenta+''' UNION ALL'
  from cuentas_pesoa2 a
  
-- Garantia Solidaria  
select 'SELECT * FROM DSPR..MAGSO WHERE NUMPRE ='''+a.cuenta+''' UNION ALL'
  from cuentas_pesoa2 a
  
-- Garantia de Certificados  
select 'SELECT * FROM DSPR..MAGCF WHERE NUMPRE ='''+a.cuenta+''' UNION ALL'
  from cuentas_pesoa2 a
  

  
 
SELECT admgar_monto,
	   admgar_tasacion,
	   sibgar_indadm 
  FROM esibgard 
 WHERE admgar_numero in (1834)
 
 
 SELECT sibcat_codigo,sibcde_porcact,sibcde_provcapreq,sibcde_provcap,sibcde_garantia 
  FROM esibcded 
 WHERE cuecta_numid = 30583 



 select * from cuentas_BankeDE11 where referencia='20140607'