using System;

namespace Xperiments.DesignPatterns.Adapter.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public DateTime DataDeNascimento { get; set; }
        public Cliente()
        {
        }
        public Cliente(string nome, string endereco, DateTime dataDeNascimento)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.DataDeNascimento = dataDeNascimento;
        }

       
    }
}