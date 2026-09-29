using System;
using System.Collections.Generic;
using System.Text;

namespace AlunosApp.Entities
{
    public class Aluno
    {
        ///Id (UUID), 
        ///Nome(texto),
        ///Matricula(texto) , 
        ///Data de Nascimento(data e hora) , 
        ///Email(texto), 
        ///Data e hora de cadastro (data e hora),

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateOnly DataNascimento { get; set; } 


    }
}
