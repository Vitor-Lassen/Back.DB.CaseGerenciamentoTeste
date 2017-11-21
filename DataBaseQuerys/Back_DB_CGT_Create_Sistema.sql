use case_TG

create procedure Back_DB_CGT_Create_Sistema
@nome_sis varchar(20),
@sigla_sis varchar(5),
@cod_status_sis int,
@cod_sis int output
as begin 


INSERT INTO [dbo].[sistema]
           ([nome_sis]
           ,[sigla_sis]
           ,[cod_status_sis])
     VALUES
           (@nome_sis ,@sigla_sis ,@cod_status_sis )
		   set @cod_sis = SCOPE_IDENTITY()


end