use case_TG

create procedure Back_DB_CGT_Select_SistemaForName
@nome_sis varchar(20)

as begin 


select cod_sis as 'Código',nome_sis as 'Nome',sigla_sis as 'Sigla'
from case_TG.dbo.sistema where nome_sis like '%'+@nome_sis+'%' 
for json auto 
end 



