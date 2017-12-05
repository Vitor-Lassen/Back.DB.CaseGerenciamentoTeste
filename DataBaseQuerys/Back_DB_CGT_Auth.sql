use case_TG

create procedure Back_DB_CGT_Auth
@login varchar(20),
@senha varchar(15)

as begin 
	select permissao_usu, troca_senha,nome_usu,sobrenome_usu,cod_usu
	from case_TG.dbo.usuario
	where login_usu = @login and senha_usu = @senha
end 