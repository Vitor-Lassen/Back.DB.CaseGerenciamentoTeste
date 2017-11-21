use case_TG

create procedure Back_DB_CGT_Select_SistemaForSigla
@sigla_sis varchar(5)

as begin 


select cod_sis as 'Código',nome_sis as 'Nome',sigla_sis as 'Sigla'
from case_TG.dbo.sistema where sigla_sis like '%'+@sigla_sis+'%' 
for json auto 
end 



