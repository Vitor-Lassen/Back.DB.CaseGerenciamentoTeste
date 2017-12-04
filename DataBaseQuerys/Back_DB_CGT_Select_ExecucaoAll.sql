use case_TG

create procedure Back_DB_CGT_Select_ExecucaoAll
@cod_exec int

as begin 


select *
from case_TG.dbo.execucao where cod_exec = @cod_exec
for json auto 
end 

