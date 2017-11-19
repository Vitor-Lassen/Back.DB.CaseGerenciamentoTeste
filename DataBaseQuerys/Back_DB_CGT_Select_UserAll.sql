use case_TG

create procedure Back_DB_CGT_Select_UserAll
@cod_usu int

as begin 


select *
from case_TG.dbo.usuario where cod_usu = @cod_usu
for json auto 
end 

