use case_TG

alter procedure Back_DB_CGT_Select_SistemasProjeto 1
@cod_proj int 

as begin 


select s.cod_sis,s.nome_sis,s.sigla_sis,x.cod_projxsis
from case_TG.dbo.sistema s
inner join case_TG.dbo.projetoxsistema x on 
x.cod_sis_projxsis = s.cod_sis
where x.cod_proj_projxsis = @cod_proj

end 



