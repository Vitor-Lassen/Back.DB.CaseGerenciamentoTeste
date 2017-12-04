use case_TG

create procedure Back_DB_CGT_Select_StatusTypeForCod
@cod_status int
as begin 

select statustype
from case_TG.dbo.statustype 
where cod_status = @cod_status
for json auto

end 
