use case_TG

create procedure Back_DB_CGT_Select_CenarioForName
@nome_cen varchar(50),
@cod_proj_cen int

as begin 


select c.cod_cen as 'Código' ,c.nome_cen as 'Nome Cenário',st.statustype as 'Status'
from case_TG.dbo.cenario c 
inner join case_TG.dbo.statustype st
on c.cod_status_cen = st.cod_status
 where c.nome_cen like '%'+@nome_cen+'%'  and c.cod_proj_cen = @cod_proj_cen
for json auto 
end 

