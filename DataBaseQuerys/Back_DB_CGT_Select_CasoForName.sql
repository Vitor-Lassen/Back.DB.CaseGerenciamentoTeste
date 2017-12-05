use case_TG

create procedure Back_DB_CGT_Select_CasoForName
@nome_caso varchar(50)

as begin 


select cod_caso as 'Código',nome_caso as 'Nome'
from case_TG.dbo.Caso where nome_caso like '%'+@nome_caso+'%' 
for json auto 
end 



