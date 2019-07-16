create database case_TG

use case_TG

create table tb_status_type(
cod_status int identity (1,1) primary key not null,
status_type varchar(15) not null 
-- check(status_type in ('', '', '', ''))
)
/*1 = Baixa, 2 = Média, 3 = Alta, 4 = Muito Alta*/

create table tb_sistema(
cod_sis int identity (1,1) primary key not null,
nome_sis varchar(20) not null,
sigla_sis varchar(5) unique not null,
cod_status_sis int foreign key references tb_status_type (cod_status) not null
)

create table tb_projeto(
cod_proj int identity (1,1) primary key not null,
nome_proj varchar(20) not null,
objetivo_proj varchar(200) not null,
cod_status_proj int foreign key references tb_status_type (cod_status) not null
)

create table tb_projeto_sistema(
cod_projxsis int identity (1,1) primary key not null,
cod_proj_projxsis int foreign key references tb_projeto (cod_proj) not null,
cod_sis_projxsis int foreign key references tb_sistema (cod_sis) not null
)

create table tb_cenario(
cod_cen int identity (1,1) primary key not null,
cod_proj_cen int foreign key references tb_projeto (cod_proj) not null,
nome_cen varchar(50) not null,
descri_cen varchar(100),
cod_status_cen int foreign key references tb_status_type (cod_status) not null
)

create table tb_tipo_permissao(
cod_tipo_permissao int identity primary key not null,
descricao_permissao varchar(10))

create table tb_usuario(
cod_usu int identity (1,1) primary key not null,
permissao_usu int foreign key references tb_tipo_permissao (cod_tipo_permissao) not null,
nome_usu varchar(30) not null,	
sobrenome_usu varchar(30) not null,
email_usu varchar(50),
login_usu varchar(20) not null unique,
senha_usu varchar(15) not null,
troca_senha bit, 
matricula varchar (10) unique
)

create table tb_caso(
cod_caso int identity (1,1) primary key not null,
nome_caso varchar(50) not null,
precond_caso varchar(200) not null, 
massadados_caso varchar(200) not null, 
resultesp_caso varchar(200) not null,
resultobt_caso varchar(200),
cod_cen_caso int foreign key references tb_cenario (cod_cen) not null,
cod_status_caso int foreign key references tb_status_type (cod_status) not null,
cod_usu_caso int foreign key references tb_usuario (cod_usu) not null,
motivo_bloq varchar(50)
)

create table tb_dependencia(
cod_caso int foreign key references tb_caso (cod_caso) not null,
cod_caso_dependencia int foreign key references tb_caso (cod_caso) not null
)

create table tb_execucao(
cod_exec int identity (1,1) primary key not null,
cod_usu_exec int foreign key references tb_usuario (cod_usu) not null,
cod_caso_exec int foreign key references tb_caso (cod_caso) not null,
cod_status_exec int foreign key references tb_status_type (cod_status) not null,
observacao_exec varchar(100),
anexo_exec varchar(30),
data_ini_exec datetime not null,
data_fim_exec datetime not null
)

create table tb_defeito(
cod_def int identity (1,1) primary key not null,
descri_def varchar(200),
titulo_def varchar(50) not null,
gravidade_def int foreign key references tb_status_type (cod_status),
cod_status_def int foreign key references tb_status_type (cod_status) not null,
cod_exec_def int foreign key references tb_execucao (cod_exec) not null
)


create table tb_usuario_projeto(
cod_usu_usuxproj int foreign key references tb_usuario (cod_usu) not null,
cod_proj_usuxproj int foreign key references tb_projeto (cod_proj) not null
)

create table tb_passo_ct(
cod_passo int identity (1,1) primary key not null,
cod_caso_passo int foreign key references tb_caso (cod_caso) not null, 
num_passo int not null,
acao_passo varchar(250),
result_esp_caso varchar(250)
)

create table log_execucao(
cod_log_exec int identity (1,1) primary key not null, 
cod_exec int foreign key references tb_execucao (cod_exec) not null,

)