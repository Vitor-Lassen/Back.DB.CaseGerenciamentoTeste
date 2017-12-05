use case_TG

create procedure Back_DB_CGT_Select_DefeitoAll
@cod_def int

as begin 


select *
from case_TG.dbo.defeito where cod_def = @cod_def
for json auto 
end 

