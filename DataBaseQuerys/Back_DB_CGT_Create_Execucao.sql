use case_TG

create procedure Back_DB_CGT_Create_Execucao
@cod_usu_exec int,
@cod_caso_exec int,
@cod_status_exec int,
@observacao_exec varchar(100),
@cod_exec int output
as begin 



INSERT INTO [dbo].[execucao]
           ([cod_usu_exec]
           ,[cod_caso_exec]
           ,[cod_status_exec]
           ,[observacao_exec])
     VALUES
           (@cod_usu_exec,@cod_caso_exec,@cod_status_exec,@observacao_exec )
		   set @cod_exec = SCOPE_IDENTITY()

end