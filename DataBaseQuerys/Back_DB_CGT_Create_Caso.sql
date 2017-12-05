use case_TG

create procedure Back_DB_CGT_Create_Caso
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
@cod_caso int output
as begin 

INSERT INTO [dbo].[caso]
           ([nome_caso]
           ,[precond_caso]
           ,[massadados_caso]
           ,[resultesp_caso]
           ,[resultobt_caso]
           ,[cod_cen_caso]
           ,[cod_def_caso]
           ,[cod_status_caso]
           ,[cod_usu_caso]
           ,[motivo_bloq])
     VALUES
           (@nome_caso,@precond_caso,@massadados_caso,@resultesp_caso,
			@resultobt_caso,@cod_cen_caso,@cod_def_caso,@cod_status_caso,
			@cod_usu_caso,@motivo_bloq)

		   set @cod_caso = SCOPE_IDENTITY()

end 




