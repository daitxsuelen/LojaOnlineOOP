public abstract class Produto // Classe abstrata
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco) // Construtor
    {
        Nome = nome;
        Codigo = Guid.NewGuid().ToString(); //Gera um código único
        Preco = preco;
    }

    public abstract decimal CalcularPrecoFinal(); //Método para classes derivadas
}