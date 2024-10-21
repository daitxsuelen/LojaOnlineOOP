public interface ICarriavel //Interface
{
    void AdicionarProduto(Produto produto); //Add produto no carrinho
    void RemoverProduto(Produto produto); //Remove produto do carrinho
    decimal CalcularTotal(); //Calcula o valor total
}