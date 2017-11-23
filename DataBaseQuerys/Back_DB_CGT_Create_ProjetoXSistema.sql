use case_TG

create procedure Back_DB_CGT_Create_ProjetoXSistema
@cod_proj_projxsis int,
@cod_sis_projxsis int,
@cod_projxsis int output
as begin 


INSERT INTO [dbo].[projetoxsistema]
           ([cod_proj_projxsis]
           ,[cod_sis_projxsis])
     VALUES
           (@cod_proj_projxsis ,@cod_sis_projxsis)


		   set @cod_projxsis = SCOPE_IDENTITY()


end