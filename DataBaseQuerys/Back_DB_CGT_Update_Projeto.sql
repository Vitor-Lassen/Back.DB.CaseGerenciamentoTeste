use case_TG

create procedure Back_DB_CGT_Update_Projeto
@nome_proj varchar(20),
@objetivo_proj varchar(200),
@cod_status_proj int,
@cod_proj int

as begin 

UPDATE [dbo].[projeto]
   SET [nome_proj] = @nome_proj
      ,[objetivo_proj] = @objetivo_proj
      ,[cod_status_proj] = @cod_status_proj
 WHERE cod_proj = @cod_proj
 end 

