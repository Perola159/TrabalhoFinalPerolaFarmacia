// Implementação do serviço de vendas
public class VendaService
{
    private readonly ICarrinhoRepository _carrinhoRepository;

    // Construtor para receber o repositório
    public VendaService(ICarrinhoRepository carrinhoRepository)
    {
        _carrinhoRepository = carrinhoRepository;
    }

    // Método para listar todas as vendas com os detalhes dos itens
    public void ListarVendas()
    {
        var carrinhos = _carrinhoRepository.ListarCarrinhosComDetalhes();

        foreach (var carrinho in carrinhos)
        {
            Console.WriteLine($"Carrinho ID: {carrinho.Id}");   
            foreach (var item in carrinho.Itens)
            {
                Console.WriteLine($"Produto ID: {item.ProdutoId}, Quantidade: {item.Quantidade}, Preço: {item.Preco:C}");
            }
        }
    }
}
