use case_TG

create procedure Back_DB_CGT_Select_CasoAll
@cod_caso int

as begin 


select *
from case_TG.dbo.caso where cod_caso = @cod_caso
for json auto 
end 

