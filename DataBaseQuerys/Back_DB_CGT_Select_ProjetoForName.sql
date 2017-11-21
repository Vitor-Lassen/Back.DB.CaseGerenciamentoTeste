use case_TG

create procedure Back_DB_CGT_Select_ProjetoForName
@nome_proj varchar(20)

as begin 


select cod_proj as 'Código', nome_proj as 'Nome'
from case_TG.dbo.proj where nome_proj like '%'+@nome_proj+'%' 
for json auto 
end 



