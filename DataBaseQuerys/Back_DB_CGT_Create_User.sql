use case_TG

create procedure Back_DB_CGT_Create_User
@permissao_usu int,
@nome_usu varchar(30),
@sobrenome_usu varchar(30),
@email_usu varchar(50),
@login_usu varchar(20),
@senha_usu varchar(15),
@troca_senha bit,
@codUser int output
as begin 
INSERT INTO [dbo].[usuario]
           ([permissao_usu]
           ,[nome_usu]
           ,[sobrenome_usu]
           ,[email_usu]
           ,[login_usu]
           ,[senha_usu]
           ,[troca_senha])
     VALUES(@permissao_usu ,
@nome_usu ,
@sobrenome_usu,
@email_usu ,
@login_usu ,
@senha_usu ,
@troca_senha)
set @codUser = SCOPE_IDENTITY()

end 




