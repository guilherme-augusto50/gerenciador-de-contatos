create database contatos;
use contatos;

create table if not exists usuarios(
	Id_usuario int auto_increment primary key,
	nome varchar(100) not null,
	email varchar(100) not null,
    senha varchar(100) not null
);

create table if not exists contatos (
	Id_contatos int auto_increment primary key,	
    nome varchar(100) not null,
    email varchar(100),
    telefone varchar(100) not null,
    Id_usuario int,
	foreign key (Id_usuario) references usuarios(Id_usuario)
);
DESCRIBE usuarios;
DESCRIBE contatos;