use case_TG

create procedure Back_DB_CGT_Select_CenarioAll
@cod_cen int

as begin 


select *
from case_TG.dbo.cenario where cod_cen = @cod_cen
for json auto 
end 

