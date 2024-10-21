public class ProdutoDigital : Produto // Classe herdada de Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, decimal preco, double tamanhoArquivo, string formato) : base (nome, preco) // construtor que chama o construtor da classe base
    {
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal() //Método abstrato
    {
        decimal desconto = Preco * 0.10m; // desconto dos produtos digitais (10%)
        return Preco - desconto; 
    }
}