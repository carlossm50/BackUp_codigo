use CamComparar

select * 
--update b set b.referencia=c.cuecta_refer
from DE21banke b inner join Easybank_bct20..ecuectam c on b.cod_cred=c.cuecta_formateado

-- Para sumar el monto total y compararlo con el total en el archivo DE
go
create view vw_TotalDE21 as 
select 'EasyBank'[Reporte DE],SUM(monto) Total from DE21banke
union all
select 'Pesoa'[Reporte DE],SUM(monto) Total from DE21cli


---para mostrar el monto total de capital 

create view vw_TotalCapDE21 as
	select 'Pesoa'[Reporte DE],sum(monto) CAPITAL--1474
	  from DE21cli 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	 union all
	select 'EasyBank'[Reporte DE],sum(monto) CAPITAL  --2133
	  from DE21banke 
	 where (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )
	


-- para mostrar el monto total de intereses 

create view vw_TotalIntDE21 as
	select 'PESOA'[Reporte DE] ,SUM(monto) INTERESES
	  from DE21cli 
	 where cuecta_cont like '128.%' 

      union all 
	select 'EASYBANK' ,SUM(monto) INTERESES
	  from DE21banke 
	 where cuecta_cont like '128.%' 


--Para insertar el interes en la temporal Banke
    create view Int_Banke21 as
    select referencia,SUM(monto) INTERESE_BANKE 
	  from DE21banke 
	 where cuecta_cont like '128.%' 
  group by referencia
    
  

--Para insertar el capital en la temporal Banke

    create view   cap_Banke21 as 
	select referencia,SUM(monto) CAPITAL_BANKE 
	  from DE21banke 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by referencia
  
  
  


  --BCT-------------------------

  --Para insertar el interes en la temporal BCT
    
    create view Int_BCT21 as 
	select cod_cred,SUM(monto) INTERESE_BCT 
	  from DE21cli 
	 where cuecta_cont like '128.%' 
  group by cod_cred
 
  

--Para insertar el capital en la temporal BCT
  
  create view cap_BCT21 as
  select cod_cred,SUM(monto) CAPITAL_BCT 
	  from DE21cli 
	 where (cuecta_cont like '121.%'  
	    or cuecta_cont like '122.%' 
	    or cuecta_cont like '123.%'
	    or cuecta_cont like '124.%'
	    or cuecta_cont like '125.%')
	   --and referencia=20110942
  group by cod_cred


  

--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en el capital 
create view Diff_cap21 as
select a.* ,b.*,(isnull(a.CAPITAL_BCT,0)-isnull(b.CAPITAL_BANKE,0)) Diferencia
  from cap_BCT21 a inner join cap_Banke21 b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where isnull(a.CAPITAL_BCT,0)<>isnull(b.CAPITAL_BANKE,0)



--Para mostrar los cuentas que estan el las dos table temporales y tienen diferencia en los intereses 
create view Diff_int21 as
select a.* ,b.INTERESE_BANKE,(a.INTERESE_BCT-b.INTERESE_BANKE) Diferencia
  from Int_BCT21 a inner join Int_Banke21 b on cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0)
 where a.INTERESE_BCT<>b.INTERESE_BANKE

 

--para saber cuales cuentas esta en una tabla de capital de Cotui que no esta en Banke

create view cap_BCTnoBanke21 as
  select * 
    from cap_BCT21 a 
   where not exists (select *
                       from cap_Banke21 b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) =isnull(b.referencia,0))




                   
--para saber cuales cuentas esta en una tabla de capital de Banke que no esta en Cotui
create view cap_BankenoBCT21 as
  select * 
    from cap_Banke21 a 
   where not exists (select *
                       from cap_BCT21 b
                       where  cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) = isnull(a.referencia,0))

--Para identificar cuales cuentas no tienen referencia.
create view CtaBankeNoRef21 as
select cod_cred,monto 
  from DE21banke 
 where referencia is null 
   and (cuecta_cont like '121.%' 
		or cuecta_cont like '122.%' 
		or cuecta_cont like '123.%' 
		or cuecta_cont like '124.%' 
		or cuecta_cont like '125.%' )

create view IntClinoBk21 as
--Para saber cuales cuentas esta en la tabla de intereses de Cotui que no esta en banke

  select * 
    from Int_BCT21 a 
   where not exists (select *
                       from Int_Banke21 b
                       where  cast(isnull(cast(a.cod_cred as int),0) as varchar(27)) = isnull(b.referencia,0))
                       
                       
create view IntBknoCli21 as
--Para saber cuales cuentas esta en la tabla de intereses de banke que no esta en Cotui
  select * 
    from Int_Banke21 a 
   where not exists (select *
                       from int_BCT21 b
                       where cast(isnull(cast(b.cod_cred as int),0) as varchar(27)) = isnull(a.referencia,0))


 --select Cod_cred,monto from DE21banke where referencia is null and ( cuecta_cont like '128.%')

--Para compara los monto por cuenta

create view CtaCNTMontoBk21 as
	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Easybank
	  FROM dbo.DE21banke 
      GROUP BY cuecta_cont 
	  --order by Cuenta 
	  
create view CtaCNTMontoCli21 as
	SELECT cuecta_cont Cuenta,SUM(MONTO) Monto_Bancotuí
	  FROM dbo.DE21cli 
      GROUP BY cuecta_cont 
	  --order by Cuenta


create view Diff_int21_02 as
        select Referencia ,isnull(INTERESE_BANKE,0)INTERESE_BANKE , isnull(INTERESE_BCT,0)INTERESE_BCT,(isnull(INTERESE_BANKE,0) - isnull(INTERESE_BCT,0))Diferencia
	    from Int_Banke21 
		full join Int_BCT21 on isnull(referencia,0) = cast(isnull(cast(cod_cred as int),0) as varchar(27))
		where isnull(INTERESE_BANKE,0) <> isnull(INTERESE_BCT,0)

		 select Cod_cred,monto from DE21banke where referencia is null and ( cuecta_cont like '128.%')
		 select * from #Int_Banke where referencia is null