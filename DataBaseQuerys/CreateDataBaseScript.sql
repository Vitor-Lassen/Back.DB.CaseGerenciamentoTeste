create database case_TG

use case_TG


create table statustype(
cod_status int identity (1,1) primary key not null,
statustype varchar(20) not null
)


create table sistema(
cod_sis int identity (1,1) primary key not null,
nome_sis varchar(20) not null, 
--funcao_sis varchar(200) not null,
sigla_sis varchar(5) unique not null,
cod_status_sis int foreign key references statustype (cod_status) not null
)

create table projeto(
cod_proj int identity (1,1) primary key not null,
nome_proj varchar(20) not null,
objetivo_proj varchar(200) not null,
cod_status_proj int foreign key references statustype (cod_status) not null
)

create table projetoxsistema(
cod_projxsis int identity (1,1) primary key not null,
cod_proj_projxsis int foreign key references projeto (cod_proj) not null,
cod_sis_projxsis int foreign key references sistema (cod_sis) not null
)

create table cenario(
cod_cen int identity (1,1) primary key not null,
cod_proj_cen int foreign key references projeto (cod_proj) not null,
nome_cen varchar(50) not null,
descri_cen varchar(100),
cod_status_cen int foreign key references statustype (cod_status) not null
)

create table defeito(
cod_def int identity (1,1) primary key not null,
assunto_def varchar(50) not null,
descri_def varchar(200),
titulo_def varchar(50) not null,
/*1 = Baixa, 2 = Média, 3 = Alta, 4 = Muito Alta*/
gravidade_def int not null,
cod_status_def int foreign key references statustype (cod_status) not null
)

create table usuario(
cod_usu int identity (1,1) primary key not null,
--1 adm, 2 coordenação, 3 analista, 4 operador
permissao_usu int not null,
nome_usu varchar(30) not null,	
sobrenome_usu varchar(30) not null,
email_usu varchar(50),
login_usu varchar(20) not null unique,
senha_usu varchar(15) not null,
troca_senha bit 
)


create table caso(
cod_caso int identity (1,1) primary key not null,
nome_caso varchar(50) not null,
precond_caso varchar(200) not null, 
massadados_caso varchar(200) not null, 
resultesp_caso varchar(200) not null,
resultobt_caso varchar(200),
cod_cen_caso int foreign key references cenario (cod_cen) not null,
cod_def_caso int foreign key references defeito (cod_def),
cod_status_caso int foreign key references statustype (cod_status) not null,
cod_usu_caso int foreign key references usuario (cod_usu) not null,
motivo_bloq varchar(50)
)




create table execucao(
cod_exec int identity (1,1) primary key not null,
cod_usu_exec int foreign key references usuario (cod_usu) not null,
cod_caso_exec int foreign key references caso (cod_caso) not null,
cod_status_exec int foreign key references statustype (cod_status) not null,
observacao_exec varchar(100)
)


create table usuarioxprojeto(
cod_usu_usuxproj int foreign key references usuario (cod_usu) not null,
cod_proj_usuxproj int foreign key references projeto (cod_proj) not null
)
