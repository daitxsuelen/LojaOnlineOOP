public class Loja
{
    private List<Produto> Produtos { get; set; }
    private List<Cliente> Clientes { get; set; }
    private List<Pedido> Pedidos { get; set; }

    public Loja() //Construtor da loja para iniciar listas
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }

    public void CadastrarProduto(Produto produto) //Método para cadastrar
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} cadastrado!");
    }

    public Produto ConsultarProdutoPorCodigo(string codigo) //Método para consultar pelo código
    {
        return Produtos.Find(p => p.Codigo == codigo); //retorna o produto pelo código dele
    }
    public void CadastrarCliente(Cliente cliente) // metodo para cadastrar cliente
    {
        Clientes.Add(cliente);
        Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso!");
    }
    public Pedido CriarPedido (Cliente cliente)
        {
            var pedido = new Pedido(cliente);
            Pedidos.Add(pedido);
            return pedido;
        }
    public void FinalizarPedido(Pedido pedido)
    {
        pedido.FinalizarPedido();
        Console.WriteLine("Pedido finalizado com sucesso");
    }
    
}   
