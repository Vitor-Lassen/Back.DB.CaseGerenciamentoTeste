use case_TG

create procedure Back_DB_CGT_Select_SistemaAll
@cod_sis int

as begin 


select *
from case_TG.dbo.sistema where cod_sis = @cod_sis
for json auto 
end 

