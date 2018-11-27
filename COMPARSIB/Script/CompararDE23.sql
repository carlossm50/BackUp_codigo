use CamComparar

select * 
--update b set b.referencia=c.cuecta_refer
from DE23banke b inner join Easybank_bct20..ecuectam c on b.cod_cred=c.cuecta_formateado

-- Para sumar el monto total y compararlo con el total en el archivo DE
create view vw_TotalDE23 as 
	select 'EasyBank'[Reporte DE],SUM(monto) Total from DE23banke
union all
	select 'Pesoa'[Reporte DE],SUM(monto) Total from DE23cli


	create view vw_TotalCapDE23 as
---para mostrar el monto total de capital 
	select 'Pesoa'[Reporte DE],sum(monto) CAPITAL--1474
	  from DE23cli 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	 union all
	select 'EasyBank'[Reporte DE],sum(monto) CAPITAL  --2133
	  from DE23banke 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	

	create view vw_TotalIntDE23 as
-- para mostrar el monto total de intereses 
	select 'PESOA'[Reporte DE] ,SUM(monto) INTERESES
	  from DE23cli 
	 where cuecta_cont like '128.%' 

      union all 
	select 'EASYBANK' ,SUM(monto) INTERESES
	  from DE23banke 
	 where cuecta_cont like '128.%' 


--Para insertar el interes en la temporal Banke
    create view Int_Banke23 as
    select referencia,SUM(monto) INTERESE_BANKE 
	  from DE23banke 
	 where cuecta_cont like '128.%' 
  group by referencia
    
  
      create view   cap_Banke23 as 
--Para insertar el capital en la temporal Banke

    select referencia,SUM(monto) CAPITAL_BANKE 
	  from DE23banke 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by referencia
  
  
  


  --BCT-------------------------
   create view Int_BCT23 as 
  --Para insertar el interes en la temporal BCT
    
    select cod_cred,SUM(monto) INTERESE_BCT 
	  from DE23cli 
	 where cuecta_cont like '128.%' 
  group by cod_cred
 
  
    create view cap_BCT23 as
--Para insertar el capital en la temporal BCT
  
  select cod_cred,SUM(monto) CAPITAL_BCT 
	  from DE23cli 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by cod_cred



  create view Diff_cap23 as
--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en el capital 
select a.* ,b.*,(isnull(a.CAPITAL_BCT,0)-isnull(b.CAPITAL_BANKE,0)) Diferencia
  from cap_BCT23 a inner join cap_Banke23 b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where isnull(a.CAPITAL_BCT,0)<>isnull(b.CAPITAL_BANKE,0)


 create view Diff_int23 as
--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en los intereses 
select a.* ,b.INTERESE_BANKE,(a.INTERESE_BCT-b.INTERESE_BANKE) Diferencia
  from Int_BCT23 a inner join Int_Banke23 b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where a.INTERESE_BCT<>b.INTERESE_BANKE


 create view cap_BCTnoBanke23 as
--para saber cuales cuentas esta en una tabla de capital de Cotui que no esta en Banke
  select * 
    from cap_BCT23 a 
   where not exists (select *
                       from cap_Banke23 b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0))




   create view cap_BankenoBCT23 as                
--para saber cuales cuentas esta en una tabla de capital de Banke que no esta en Cotui
  select * 
    from cap_Banke23 a 
   where not exists (select *
                       from cap_BCT23 b
                       where  cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) = isnull(a.referencia,0))

create view CtaBankeNoRef23 as
--Para identificar cuales cuentas no tienen referencia.
select cod_cred,monto from DE23banke where referencia is null and (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )


create view IntClinoBk23 as
--Para saber cuales cuentas esta en la tabla de intereses de Cotui que no esta en banke
  select * 
    from Int_BCT23 a 
   where not exists (select *
                       from Int_Banke23 b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) = isnull(b.referencia,0))
                       
    create view IntBknoCli23 as                   
--Para saber cuales cuentas esta en la tabla de intereses de banke que no esta en Cotui

  select * 
    from Int_Banke23 a 
   where not exists (select *
                       from int_BCT23 b
                       where cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) =a.referencia)



create view CtaCNTMontoBk23 as
--Para compara los monto por cuenta

	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Easybank 
	  FROM dbo.DE23banke 
      GROUP BY cuecta_cont 
	  --order by Cuenta 
	create view CtaCNTMontoCli23 as  
	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Bancotuí
	  FROM dbo.DE23cli 
      GROUP BY cuecta_cont 
	  --order by Cuenta


      create view Diff_int23_02 as
	  	  select Referencia ,isnull(INTERESE_BANKE,0)INTERESE_BANKE , isnull(INTERESE_BCT,0)INTERESE_BCT,(isnull(INTERESE_BANKE,0) - isnull(INTERESE_BCT,0))Diferencia
	    from Int_Banke23 
		full join Int_BCT23 on isnull(referencia,0) = cast(isnull(cast(cod_cred as int),0) as varchar(27))
		where isnull(INTERESE_BANKE,0) <> isnull(INTERESE_BCT,0)


		 select Cod_cred,monto from DE23banke where referencia is null and ( cuecta_cont like '128.%')
		 select * from #Int_Banke where referencia is null