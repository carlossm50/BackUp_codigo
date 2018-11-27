
use CamComparar


SELECT  'BANKE' Sistema, 
		SUM(a.monto_Desembolsado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq		
  FROM DE15banke a 
union all
SELECT  'BANCOTUI' Sistema,
		SUM(a.monto_Desembolsado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq
  FROM DE15cli a 
  
  
  select isnull(DE15CLI.codigo_Credito,0)cuenta_pesoa		,
         isnull(DE15Banke.codigo_Credito,0) Cuenta_EasyBank,
		 isnull(DE15CLI.Nombre,DE15Banke.Nombre)Nombre ,
		 isnull(DE15Banke.clasif_Ini,'')	Clasificacion_Easybank,
		 isnull(DE15CLI.clasif_Ini,'')	Clasificacion_Bancotuí,
		 isnull(DE15CLI.monto_Desembolsado,0)monto_apro_Pesoa,
		 isnull(DE15Banke.monto_Desembolsado,0)monto_apro_EasyBank,
		 isnull(DE15CLI.monto_Desembolsado,0) - isnull(DE15Banke.monto_Desembolsado,0) Diferencia,
		 isnull(DE15CLI.prov_req,0)	ProvCapReq_Bancotuí,		 
		 isnull(DE15Banke.prov_req,0)		ProvCapReq_Easybank,
		 isnull(DE15CLI.prov_req,0) - isnull(DE15Banke.prov_req,0) Diferencia
    from DE15Banke 
		 full join DE15CLI on isnull(DE15Banke.referencia,0) = isnull(DE15CLI.codigo_Credito,0)
		 order by 11