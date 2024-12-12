public interface IVendaRepository
{
    void AdicionarVenda(Venda venda);
    void EditarVenda(Venda venda);
    List<Venda> ListarVenda();
    void RemoverVenda(int id);
    public Venda BuscarVendaPorId(int id);
  

}
