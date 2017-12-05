use case_TG

create procedure Back_DB_CGT_Select_DefeitoAllForCodCen
@cod_caso int

as begin 


select d.cod_def,d.assunto_def,d.descri_def,d.titulo_def,d.gravidade_def,d.cod_status_def
from case_TG.dbo.defeito d
inner join case_TG.dbo.caso c 
on c.cod_def_caso = d.cod_def
 where c.cod_caso= @cod_caso
for json auto 
end 
