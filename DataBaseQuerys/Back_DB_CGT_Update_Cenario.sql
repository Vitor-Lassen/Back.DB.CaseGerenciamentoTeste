use case_TG

create procedure Back_DB_CGT_Update_Cenario
@cod_proj_cen int,
@nome_cen varchar(50),
@descri_cen varchar(100),
@cod_status_cen int,
@cod_cen int 
as begin 


UPDATE [dbo].[cenario]
   SET [cod_proj_cen] = @cod_proj_cen
      ,[nome_cen] = @nome_cen
      ,[descri_cen] = @descri_cen
      ,[cod_status_cen] = @cod_status_cen
 WHERE cod_cen = @cod_cen



end 



