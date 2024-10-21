public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string numeroIdentificacao, string endereco, string contato) //construtor Cliente
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes() //Exibe informações do cliente
    {
        Console.WriteLine($"Nome: {Nome}, ID: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}");
    }
}