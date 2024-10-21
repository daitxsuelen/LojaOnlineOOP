public class ProdutoFisico : Produto // Classe herdada de Produto
{
    public double Peso { get; set; }
    
    public string Categoria { get; set; }

    public ProdutoFisico(string nome, decimal preco, double peso, string categoria) : base(nome, preco)
    {
        Peso = peso;
        Categoria = categoria;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal imposto = Preco * 0.10m;
        decimal custoDeEnvio = (decimal)(Peso * 5); //Custo baseado no peso para envio

        return Preco + imposto + custoDeEnvio; // Preço final é o cálculo da base + imposto + custo de envio
    }
}