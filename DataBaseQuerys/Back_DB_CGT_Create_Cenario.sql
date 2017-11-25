use case_TG

create procedure Back_DB_CGT_Create_Cenario
@cod_proj_cen int,
@nome_cen varchar(50),
@descri_cen varchar(100),
@cod_status_cen int,
@cod_cen int output
as begin 

INSERT INTO [dbo].[cenario]
           ([cod_proj_cen]
           ,[nome_cen]
           ,[descri_cen]
           ,[cod_status_cen])
     VALUES
           (@cod_proj_cen,@nome_cen ,@descri_cen ,@cod_status_cen )



		   set @cod_cen = SCOPE_IDENTITY()

end 




