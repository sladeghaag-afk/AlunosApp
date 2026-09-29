using System;
using System.Collections.Generic;
using System.Text;
using AlunosApp.Entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AlunosApp.Repository
{
    public class AlunoRepository
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = BDAlunos; Integrated Security = True; TrustServerCertificate=True;";
        
        
        public void InserirDados(Aluno aluno)
        {
           

            using (var connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                var transaction = connection.BeginTransaction();



              try
              {



                    connection.Execute("""

                 INSERT INTO ALUNOS (ID, NOME , MATRICULA, DATANASCIMENTO, EMAIL, DATACADASTRO)
                 VALUES(@ID, @NOME, @MATRICULA, @DATANASCIMENTO, @EMAIL, @DATACADASTRO)
               """, new
                    {
                        ID = aluno.Id,
                        NOME = aluno.Nome,
                        MATRICULA = aluno.Matricula,
                        DATANASCIMENTO = aluno.DataNascimento,
                        EMAIL = aluno.Email,
                        DATACADASTRO = aluno.DataCadastro




                    }, transaction);


                    transaction.Commit();

                    Console.WriteLine($"\nDADOS CADASTRADOS COM SUCESSO\n");
               }
               catch (Exception e)
                
               {
                    transaction.Rollback();
                    Console.WriteLine(" \nNÃO FOI POSSÍVEL REALIZAR A OPERAÇÃO!\n" ) ;
                    Console.WriteLine("ERRO: " + e.Message);




               }






            }




        }
    }
}