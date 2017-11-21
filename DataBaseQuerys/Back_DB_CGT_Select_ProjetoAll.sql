use case_TG

create procedure Back_DB_CGT_Select_ProjetoAll
@cod_proj int

as begin 


select *
from case_TG.dbo.projeto where cod_proj = @cod_proj
for json auto 
end 

