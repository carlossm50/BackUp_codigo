use CamComparar

select * 
--update b set b.referencia=c.cuecta_refer
from DE25banke b inner join Easybank_bct20..ecuectam c on b.cod_cred=c.cuecta_formateado

-- Para sumar el monto total y compararlo con el total en el archivo DE

	select 'EasyBank'[Reporte DE],SUM(monto) Total from DE25banke
union all
	select 'Pesoa'[Reporte DE],SUM(monto) Total from DE25cli



---para mostrar el monto total de capital 
	select 'Pesoa'[Reporte DE],sum(monto) CAPITAL--1474
	  from DE25cli 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	 union all
	select 'EasyBank'[Reporte DE],sum(monto) CAPITAL  --2133
	  from DE25banke 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	


-- para mostrar el monto total de intereses 
	select 'PESOA' ,SUM(monto) INTERESES
	  from DE25cli 
	 where cuecta_cont like '128.%' 

      union all 
	select 'EASYBANK' ,SUM(monto) INTERESES
	  from DE25banke 
	 where cuecta_cont like '128.%' 


--Para insertar el interes en la temporal Banke
    
    select referencia,SUM(monto) INTERESE_BANKE into #Int_Banke
	  from DE25banke 
	 where cuecta_cont like '128.%' 
  group by referencia
    
  

--Para insertar el capital en la temporal Banke

    select referencia,SUM(monto) CAPITAL_BANKE into  #cap_Banke
	  from DE25banke 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by referencia
  
  
  


  --BCT-------------------------

  --Para insertar el interes en la temporal BCT
    
    select cod_cred,SUM(monto) INTERESE_BCT into #Int_BCT
	  from DE25cli 
	 where cuecta_cont like '128.%' 
  group by cod_cred
 
  

--Para insertar el capital en la temporal BCT
  
  select cod_cred,SUM(monto) CAPITAL_BCT into #cap_BCT
	  from DE25cli 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by cod_cred




--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en el capital 
select a.* ,b.*,(isnull(a.CAPITAL_BCT,0)-isnull(b.CAPITAL_BANKE,0)) Diferencia
  from #cap_BCT a inner join #cap_Banke b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where isnull(a.CAPITAL_BCT,0)<>isnull(b.CAPITAL_BANKE,0)



--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en los intereses 
select a.* ,b.INTERESE_BANKE,(a.INTERESE_BCT-b.INTERESE_BANKE) Diferencia
  from #Int_BCT a inner join #Int_Banke b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where isnull(a.INTERESE_BCT,0)<>isnull(b.INTERESE_BANKE,0)



--para saber cuales cuentas esta en una tabla de capital de Cotui que no esta en Banke


  select * 
    from #cap_BCT a 
   where not exists (select *
                       from #cap_Banke b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0))




                   
--para saber cuales cuentas esta en una tabla de capital de Banke que no esta en Cotui
  select * 
    from #cap_Banke a 
   where not exists (select *
                       from #cap_BCT b
                       where  cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) = isnull(a.referencia,0))

--Para identificar cuales cuentas no tienen referencia.
select cod_cred,monto from DE25banke where referencia is null and (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
--Para saber cuales cuentas esta en la tabla de intereses de Cotui que no esta en banke

  select * 
    from #Int_BCT a 
   where not exists (select *
                       from #Int_Banke b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) = isnull(b.referencia,0))
                       
                       
--Para saber cuales cuentas esta en la tabla de intereses de banke que no esta en Cotui

  select * 
    from #Int_Banke a 
   where not exists (select *
                       from #int_BCT b
                       where cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) = a.referencia)


 --select Cod_cred,monto from DE25banke where referencia is null and ( cuecta_cont like '128.%')

--Para compara los monto por cuenta

	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Easybank_07 
	  FROM dbo.DE25banke 
      GROUP BY cuecta_cont order by Cuenta 
	  
	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Bancotuí
	  FROM dbo.DE25cli 
      GROUP BY cuecta_cont order by Cuenta


      select sum(INTERESE_BCT) from #Int_BCT
	  select * from #Int_BCT

	  select Referencia ,isnull(INTERESE_BANKE,0)INTERESE_BANKE , isnull(INTERESE_BCT,0)INTERESE_BCT,(isnull(INTERESE_BANKE,0) - isnull(INTERESE_BCT,0))Diferencia
	    from #Int_Banke 
		full join #Int_BCT on isnull(referencia,0) = cast(isnull(cast(cod_cred as int),0) as varchar(27))
		where isnull(INTERESE_BANKE,0) <> isnull(INTERESE_BCT,0)
	  

      select cod_cred,monto from DE25banke where referencia is null and (cuecta_cont like '128.%' )
	  select * from #Int_Banke where referencia is null



