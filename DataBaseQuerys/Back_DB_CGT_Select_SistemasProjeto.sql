use case_TG

create procedure Back_DB_CGT_Select_SistemasProjeto
@cod_proj int 

as begin 


select s.cod_sis,s.nome_sis,s.sigla_sis
from case_TG.dbo.sistema s
inner join case_TG.dbo.projetoxsistema x on 
x.cod_sis_projxsis = s.cod_sis
where x.cod_projxsis = @cod_proj
for json auto 
end 



