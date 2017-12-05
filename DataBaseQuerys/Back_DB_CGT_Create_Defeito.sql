use case_TG

create procedure Back_DB_CGT_Create_Defeito
@assunto_def varchar(50),
@descri_def varchar(200),
@titulo_def varchar(50),
@gravidade_def int,
@cod_status_def int,
@cod_def int output
as begin 


INSERT INTO [dbo].[defeito]
           ([assunto_def]
           ,[descri_def]
           ,[titulo_def]
           ,[gravidade_def]
           ,[cod_status_def])
     VALUES
           (@assunto_def,@descri_def,@titulo_def,@gravidade_def,@cod_status_def)
		   set @cod_def = SCOPE_IDENTITY()

end 




