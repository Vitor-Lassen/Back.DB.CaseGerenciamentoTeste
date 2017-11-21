use case_TG

create procedure Back_DB_CGT_Create_Projeto
@nome_proj varchar(20),
@objetivo_proj varchar(200),
@cod_status_proj int,
@cod_proj int output
as begin 

INSERT INTO [dbo].[projeto]
           ([nome_proj]
           ,[objetivo_proj]
           ,[cod_status_proj])
     VALUES
           (@nome_proj, @objetivo_proj,@cod_status_proj )
		   set @cod_proj = SCOPE_IDENTITY()

end 




