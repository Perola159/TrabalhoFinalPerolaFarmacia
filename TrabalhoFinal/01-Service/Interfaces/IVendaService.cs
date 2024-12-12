using TrabalhoFinal._03_Entidades.DTOS;

public interface IVendaService
{
    void AdicionarVenda(Venda venda);
    Venda BuscarVendaPorId(int id);
    void EditarVenda(Venda venda);
    List<VendaComCarrinhoDTO> ListarVendasComCarrinho();
    void RemoverVenda(int id);
}
