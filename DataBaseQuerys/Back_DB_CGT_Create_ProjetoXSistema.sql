USE [case_TG]
GO
/****** Object:  StoredProcedure [dbo].[Back_DB_CGT_Create_ProjetoXSistema]    Script Date: 11/25/2017 7:14:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Back_DB_CGT_Create_ProjetoXSistema]
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