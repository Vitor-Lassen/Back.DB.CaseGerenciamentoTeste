use case_TG

create procedure Back_DB_CGT_Delete_ProjetoXSistema

@cod_projxsis int output
as begin 


DELETE FROM [dbo].[projetoxsistema]
      WHERE cod_proj_projxsis = @cod_projxsis
end