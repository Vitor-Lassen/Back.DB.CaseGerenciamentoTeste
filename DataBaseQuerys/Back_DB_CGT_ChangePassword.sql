use case_TG

alter procedure Back_DB_CGT_ChangePassword
@login varchar(20),
@senha varchar (15),
@newSenha varchar(15),
@auth bit output

as begin 

set @auth = (select count(*) from case_TG.dbo.usuario	where login_usu = @login and senha_usu = @senha)

if (@auth = 1)
begin
	UPDATE [dbo].[usuario]
	   SET     
		  [senha_usu] = @newSenha,
		  [troca_senha] = 0
	 WHERE	[login_usu] = @login
end

end 