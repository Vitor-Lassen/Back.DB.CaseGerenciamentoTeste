use case_TG

create procedure Back_DB_CGT_Update_Defeito
@assunto_def varchar(50),
@descri_def varchar(200),
@titulo_def varchar(50),
@gravidade_def int,
@cod_status_def int,
@cod_def int 
as begin 


UPDATE [dbo].[defeito]
   SET [assunto_def] = @assunto_def
      ,[descri_def] = @descri_def
      ,[titulo_def] = @titulo_def
      ,[gravidade_def] = @gravidade_def
      ,[cod_status_def] = @cod_status_def
 WHERE cod_def = @cod_def

 end 
