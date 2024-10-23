public class ProdutoFisico : Produto // Classe herdada de Produto
{
    public double Peso { get; set; }
    
    public string Categoria { get; set; }

    private int Estoque { get; set; } 
    public ProdutoFisico(string nome, decimal preco, double peso, string categoria, int estoqueInicial) : base(nome, preco)
    {
        Peso = peso;
        Categoria = categoria;
        Estoque = estoqueInicial;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal imposto = Preco * 0.10m;
        decimal custoDeEnvio = (decimal)(Peso * 5); //Custo baseado no peso para envio

        return Preco + imposto + custoDeEnvio; // Preço final é o cálculo da base + imposto + custo de envio
    }

    public void AdicionarEstoque(int quantidade) //Método para adicionar produtos
    {
        if (quantidade >= 0)
        {
            Estoque += quantidade;
            Console.WriteLine($"Foram adicionados {quantidade} unidades ao estoque.Estoque atual: {Estoque}!!" );
        }
        else
        {
            Console.WriteLine("Quantidade invalida O valor precisa ser maior do que zero!");
        }
    
    }

    public void RemoverEstoque(int quantidade) //Método para remover produtos
    {
        if (quantidade > 0 && quantidade <= Estoque)
        {
            Estoque -= quantidade;
            Console.WriteLine($"Foram removidas {quantidade} unidades do estoque.Estoque atual: {Estoque}");
        }
        
        else if (quantidade > Estoque)
        {
            Console.WriteLine("Não é possível remover mais unidades do que já está disponível em estoque!");
        }

        else
        {
            Console.WriteLine("Quantidade invalida! O valor precisa ser maior do que zero!");
        }

               
    }
}