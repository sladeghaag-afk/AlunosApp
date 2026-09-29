using AlunosApp.Entities;
using AlunosApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;



namespace AlunosApp.Services
{
     public class AlunoService
    {
        public void CadastrarAluno()
        {
            Console.WriteLine("\nSISTEMA DE CADASTRO DE ALUNOS\n");

            var aluno = new Aluno();

            Console.Write("DIGITE O NOME DO ALUNO......:  ");
            aluno.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("DIGITE A MATRICULA DO ALUNO......:  ");
            aluno.Matricula = Console.ReadLine() ?? string.Empty;

            Console.Write("DIGITE O EMAIL DO ALUNO......:  ");
            aluno.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("DIGITE A DATA DE NASCIMENTO DO ALUNO......:  ");
            aluno.DataNascimento = DateOnly.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("DIGITE A DATA DE MATRICULA DO ALUNO...:");
            aluno.DataCadastro = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            var alunoRepository = new AlunoRepository();
            alunoRepository.InserirDados(aluno);











        }





     }
}
