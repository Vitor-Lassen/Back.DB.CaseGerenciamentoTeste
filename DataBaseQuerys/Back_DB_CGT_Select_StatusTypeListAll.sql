use case_TG

create procedure Back_DB_CGT_Select_StatusTypeListAll

as begin 

select cod_status, statustype
from case_TG.dbo.statustype 
for json auto

end 
