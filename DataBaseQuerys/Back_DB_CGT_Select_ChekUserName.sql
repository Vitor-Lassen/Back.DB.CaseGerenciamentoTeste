use case_TG

alter procedure Back_DB_CGT_Select_ChekUserName
@login_usu varchar(20)


as begin 

Select count(*) from case_TG.dbo.usuario where login_usu = @login_usu

end 



