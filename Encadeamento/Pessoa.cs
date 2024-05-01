using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encadeamento
{
    internal class Pessoa
    {
        string nome;
        int idade;
        Endereco endereco;

        public Pessoa(string nome, int idade, Endereco endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }

        public override string? ToString()
        {
            string valor = "Dados da Pessoa\nNome: " + nome + "\nIdade: " + idade;
            valor += endereco.ToString();
            return valor;
        }
    }


}

