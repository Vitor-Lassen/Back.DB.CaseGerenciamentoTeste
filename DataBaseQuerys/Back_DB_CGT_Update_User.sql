use case_TG

alter procedure Back_DB_CGT_Update_User
@permissao_usu int,
@nome_usu varchar(30),
@sobrenome_usu varchar(30),
@email_usu varchar(50),
@senha_usu varchar(15),
@troca_senha bit,
@cod_usu int

as begin 

UPDATE [dbo].[usuario]
   SET [permissao_usu] = @permissao_usu
      ,[nome_usu] = @nome_usu
      ,[sobrenome_usu] = @sobrenome_usu
      ,[email_usu] = @email_usu
      ,[senha_usu] = @senha_usu
      ,[troca_senha] = @troca_senha
 WHERE cod_usu = @cod_usu

end 



