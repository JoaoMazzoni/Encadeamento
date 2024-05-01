using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encadeamento
{
    internal class Endereco
    {
        string CEP;
        string Localidade;
        string UF;
        string Logradouro;
        string TipoLogradouro;
        string Bairro;
        int Numero;
        string Complemento;

        public Endereco(string cep, string localidade, string uf, string logradouro, string tipoLogradouro, string bairro, int numero, string complemento)
        {
            this.CEP = cep;
            this.Localidade = localidade;
            this.UF = uf;
            this.Logradouro = logradouro;
            this.TipoLogradouro = tipoLogradouro;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Complemento = complemento;
        }

        public override string? ToString()
        {
            return "\n\nEndereço \nCEP: " + CEP + "\nLocalidade: " + Localidade + "\nEstado: "+ UF + "\nLogradouro: " +TipoLogradouro + " " + Logradouro + ", " + Numero + "\nBairro: " + Bairro + "\nComplemento: " + Complemento;
        }


    }
}
