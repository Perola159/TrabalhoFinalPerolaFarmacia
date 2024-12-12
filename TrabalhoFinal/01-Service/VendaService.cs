using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades.DTOS;

public class VendaService : IVendaService
{
    private readonly IVendaRepository _vendaRepository;
    private readonly IProdutoRepository _produtoRepository;

    public VendaService(IVendaRepository vendaRepository, IProdutoRepository produtoRepository)
    {
        _vendaRepository = vendaRepository;
        _produtoRepository = produtoRepository;
    }

    public void AdicionarVenda(Venda venda)
    {
        _vendaRepository.AdicionarVenda(venda);
    }

    public Venda BuscarVendaPorId(int id)
    {
        return _vendaRepository.BuscarVendaPorId(id);
    }

    public void EditarVenda(Venda venda)
    {
        _vendaRepository.EditarVenda(venda);
    }

    public List<VendaComCarrinhoDTO> ListarVendasComCarrinho()
    {
        var vendas = _vendaRepository.ListarVenda();
        var vendasComCarrinho = vendas.Select(v => new VendaComCarrinhoDTO
        {
            IdVenda = v.Id,
            IdCarrinho = v.IdCarrinho,
            ItensCarrinho = ListarVenda(v.IdCarrinho)  // Preenche os itens da venda
        }).ToList();

        return vendasComCarrinho;
    }

    public void RemoverVenda(int id)
    {
        _vendaRepository.RemoverVenda(id);
    }

    // Método que busca os itens do carrinho e os transforma em itens da venda
    private List<ItemVenda> ListarVenda(int carrinhoId)
    {
        var itensVenda = new List<ItemVenda>();

        var carrinho = _vendaRepository.BuscarVendaPorId(carrinhoId);  // Recupera o carrinho associado à venda
        foreach (var item in carrinho.Itens)  // Acessa os itens do carrinho
        {
            var produto = _produtoRepository.BuscarProdutosPorId(item.ProdutoId);  // Recupera o produto por ID
            itensVenda.Add(new ItemVenda
            {
                ProdutoId = produto.Id,
                Quantidade = item.Quantidade,
                Preco = produto.Preco,
                NomeProduto = produto.Nome
            });
        }
        return itensVenda;
    }
}
