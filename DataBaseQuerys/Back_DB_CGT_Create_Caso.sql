use case_TG

create procedure Back_DB_CGT_Create_Caso
@nome_caso varchar(50),
@precond_caso varchar(200),
@massadados_caso varchar(200),
@resultesp_caso varchar(200),
@cod_cen_caso int,
@cod_status_caso int,
@cod_usu_caso int,
@cod_caso int output
as begin 

INSERT INTO [dbo].[caso]
           ([nome_caso]
           ,[precond_caso]
           ,[massadados_caso]
           ,[resultesp_caso]
           ,[cod_cen_caso]
           ,[cod_status_caso]
           ,[cod_usu_caso])
     VALUES
           (@nome_caso,@precond_caso,@massadados_caso,@resultesp_caso
		   ,@cod_cen_caso,@cod_status_caso,
			@cod_usu_caso)

		   set @cod_caso = SCOPE_IDENTITY()

end 




