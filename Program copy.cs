public class Program
{
    public static void Main(string[] args)
    {
        Loja loja = new Loja();

    ProdutoFisico livro = new ProdutoFisico("Livro", 50, 0.5, "Livros");
    ProdutoDigital eBook = new ProdutoDigital("Ebook", 30, 10, "PDF");

    loja.CadastrarProduto(livro);
    loja.CadastrarProduto(eBook);

    //Cadastro de cliente
    Cliente cliente = new Cliente("Suelen", "123456789", "Rua José Luiz de Freitas", "suelendaitx@rede.ulbra.br");
    loja.CadastrarCliente(cliente);

    //Criação de perido
    Pedido pedido = loja.CriarPedido(cliente);
    pedido.AdicionarProduto(livro);
    pedido.AdicionarProduto(eBook);
    

    //Finalização do pedido

    loja.FinalizarPedido(pedido);

    }
    
}
