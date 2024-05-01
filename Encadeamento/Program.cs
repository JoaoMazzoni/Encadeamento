using Encadeamento;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa;
        Endereco endereco = new Endereco("14801300", "Araraquara", "SP", "São Bento", "Rua", "Centro", 2291, "");
        pessoa = new Pessoa("João", 19, endereco);
        Console.WriteLine(pessoa.ToString());

    }
}