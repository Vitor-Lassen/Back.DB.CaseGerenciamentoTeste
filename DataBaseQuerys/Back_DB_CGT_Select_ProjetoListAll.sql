use case_TG

create procedure Back_DB_CGT_Select_ProjetoListAll

as begin 

select cod_proj, nome_proj
from case_TG.dbo.projeto 
for json auto

end 
