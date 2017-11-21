use case_TG

create procedure Back_DB_CGT_Update_Sistema
@nome_sis varchar(20),
@sigla_sis varchar(5),
@cod_status_sis int,
@cod_sis int 
as begin 


UPDATE [dbo].[sistema]
   SET [nome_sis] = @nome_sis
      ,[sigla_sis] =@sigla_sis
      ,[cod_status_sis] = @cod_status_sis
 WHERE cod_sis = @cod_sis

end 



