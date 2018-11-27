
use CamComparar


SELECT  'BANKE' Sistema, 
		SUM(a.monto_aprobado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq		
  FROM DE13banke a 
union all
SELECT  'BANCOTUI' Sistema,
		SUM(a.monto_aprobado) MONTO_APRO,
		SUM(a.prov_req)   ProvCapReq
  FROM DE13cli a 
  
  
  select isnull(DE13CLI.codigo_Credito,0)cuenta_pesoa		,
         isnull(DE13Banke.codigo_Credito,0) Cuenta_EasyBank,
		 isnull(DE13CLI.Nombre,DE13Banke.Nombre)Nombre ,
		 isnull(DE13Banke.clasif_Ini,'')	Clasificacion_Easybank,
		 isnull(DE13CLI.clasif_Ini,'')	Clasificacion_Bancotuí,
		 isnull(DE13CLI.monto_aprobado,0)monto_apro_Pesoa,
		 isnull(DE13Banke.monto_aprobado,0)monto_apro_EasyBank,
		 isnull(DE13CLI.monto_aprobado,0) - isnull(DE13Banke.monto_aprobado,0) Diferencia,
		 isnull(DE13CLI.prov_req,0)	ProvCapReq_Bancotuí,		 
		 isnull(DE13Banke.prov_req,0)		ProvCapReq_Easybank,
		 isnull(DE13CLI.prov_req,0) - isnull(DE13Banke.prov_req,0) Diferencia
    from DE13Banke 
		 full join DE13CLI on isnull(DE13Banke.referencia,0) = isnull(DE13CLI.codigo_Credito,0)
		 order by 11