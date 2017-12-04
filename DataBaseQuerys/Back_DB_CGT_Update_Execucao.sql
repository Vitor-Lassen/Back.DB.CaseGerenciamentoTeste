use case_TG

create procedure Back_DB_CGT_Update_Execucao
@cod_usu_exec int,
@cod_caso_exec int,
@cod_status_exec int,
@observacao_exec varchar(100),
@cod_exec int 
as begin 

UPDATE [dbo].[execucao]
   SET [cod_usu_exec] = @cod_usu_exec 
      ,[cod_caso_exec] = @cod_caso_exec
      ,[cod_status_exec] = @cod_status_exec
      ,[observacao_exec] = @observacao_exec
 WHERE cod_exec = @cod_exec

end 



