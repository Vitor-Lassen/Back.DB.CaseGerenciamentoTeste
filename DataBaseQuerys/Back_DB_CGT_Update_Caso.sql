use case_TG

create procedure Back_DB_CGT_Update_Caso
@nome_caso varchar(50),
@precond_caso varchar(200),
@massadados_caso varchar(200),
@resultesp_caso varchar(200),
@resultobt_caso varchar(200),
@cod_cen_caso int,
@cod_def_caso int,
@cod_status_caso int,
@cod_usu_caso int,
@motivo_bloq varchar(50),
@cod_caso int 

as begin 

UPDATE [dbo].[caso]
   SET [nome_caso] = @nome_caso
      ,[precond_caso] = @precond_caso
      ,[massadados_caso] = @massadados_caso
      ,[resultesp_caso] = @resultesp_caso
      ,[resultobt_caso] = @resultobt_caso
      ,[cod_cen_caso] = @cod_cen_caso
      ,[cod_def_caso] = @cod_def_caso
      ,[cod_status_caso] = @cod_status_caso
      ,[cod_usu_caso] = @cod_usu_caso
      ,[motivo_bloq] = @motivo_bloq
 WHERE cod_caso = @cod_caso
 end 

