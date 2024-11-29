using System.Collections.Generic;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IVendaService  
    {
        void AdicionarVenda(Venda venda);  
        void RemoverVenda(int id);           
        List<Venda> listarVenda();          
        Venda BuscarVendaPorId(int id);    
        void EditarVenda(Venda venda);      
    }
}
