public class Program
{
    public static void Main(string[] args)
    {
        Loja loja = new Loja();

    ProdutoFisico livro = new ProdutoFisico("Livro", 50, 0.5, "Livros", 10);
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

    
    //Criar um estoque inicial
    //já adiciona o estoque ap criar o produto livro
    livro.AdicionarEstoque(10);

    //chamar o remover estoque quando finalizar o pedido
    livro.RemoverEstoque(5);
      

    }
    
}