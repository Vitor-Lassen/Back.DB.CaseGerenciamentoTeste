use case_TG

create procedure Back_DB_CGT_Select_CasoForCenario
@cod_cen int

as begin 


select cod_caso as 'C�digo',nome_caso as 'Nome'
from case_TG.dbo.Caso where cod_cen_caso = @cod_cen 
for json auto 
end 



