use case_TG

create procedure Back_DB_CGT_Select_UserForName
@nome_usu varchar(30)

as begin 


select cod_usu as 'Código', nome_usu as 'Nome', sobrenome_usu as 'Sobrenome', login_usu as 'Usuário', email_usu as 'E-mail'
from case_TG.dbo.usuario where nome_usu like '%'+@nome_usu+'%' 
for json auto 
end 



