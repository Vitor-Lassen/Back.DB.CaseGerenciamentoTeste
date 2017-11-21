use case_TG

create procedure Back_DB_CGT_Select_SistemaListAll

as begin 

select cod_sis, nome_sis
from case_TG.dbo.sistema 
for json auto

end 
