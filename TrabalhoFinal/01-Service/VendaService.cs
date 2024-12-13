using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

public class VendaService : IVendaService
{
    private readonly IVendaRepository _vendaRepository;

    public VendaService(IVendaRepository vendaRepository)
    {
        _vendaRepository = vendaRepository;
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

    public void RemoverVenda(int id)
    {
        _vendaRepository.RemoverVenda(id);
    }

    public List<VendaComCarrinhoDTO> ListarVendasComCarrinho()
    {
        var vendas = _vendaRepository.ListarVenda();
        var vendasComCarrinho = vendas.Select(v => new VendaComCarrinhoDTO
        {
            IdVenda = v.Id,
            IdCarrinho = v.IdCarrinho,
            // Preencha os detalhes necessários
        }).ToList();

        return vendasComCarrinho;
    }
}