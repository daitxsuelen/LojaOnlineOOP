public class Pedido : ICarriavel // implemento de Interface
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public string Status { get; set; }
    private List<Produto> Produtos { get; set; }

    public Pedido (Cliente cliente) // construtor Pedido
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em processamento"; 
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto) //Implemento do método para adicionar produto
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido!!");
    }

    public void RemoverProduto(Produto produto)
    {
        if (Produtos.Remove(produto))

            Console.WriteLine($"Produto {produto.Nome} removido!");
        else

            Console.WriteLine("Produto não encontrado!");
    }

    public decimal CalcularTotal() // Implemento de método para calcular o total
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal(); // Soma o valor total de cada produto
        }

        return total;
    }

    public void FinalizarPedido() //método para finalizar o pedido
    {
        Status = "Finalizado";
        Console.WriteLine($"Pedido finalizado com sucesso! O valor total é de: {CalcularTotal()}");
    }
}