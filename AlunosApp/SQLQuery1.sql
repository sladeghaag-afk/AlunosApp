CREATE TABLE ALUNOS (

ID                 UNIQUEIDENTIFIER                 PRIMARY KEY,
NOME               VARCHAR (150)                     NOT NULL, 
MATRICULA          VARCHAR (10)                      NOT NULL, 
DATANASCIMENTO     DATE                              NOT NULL, 
EMAIL              VARCHAR(100)                      NOT NULL, 
DATACADASTRO       DATE                                  NOT NULL );