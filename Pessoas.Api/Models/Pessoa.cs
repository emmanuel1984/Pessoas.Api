using System;

namespace Pessoas.Api.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool StatusPessoa { get; set; }
    }
}
