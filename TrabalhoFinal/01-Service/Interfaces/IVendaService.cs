using System.Collections.Generic;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IVendaService
    {
        void AdicionarVenda(Venda venda);
        Venda BuscarVendaPorId(int id);
        void EditarVenda(Venda venda);
        void RemoverVenda(int id);
        List<VendaComCarrinhoDTO> ListarVendasComCarrinho();
    }
}