using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Pessoa
    {
        private string Nome;
        protected int Idade;
        public string Endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

        public void saudacao(){
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}