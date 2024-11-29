using System.Collections.Generic;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IMetodoPagamentoService
    {
      
        void AdicionarMetodoPagamento(MetodoPagamento metodoPagamento);

        
        List<MetodoPagamento> ListarMetodosPagamento();

     
        MetodoPagamento BuscarMetodoPagamentoPorId(int id);

        void EditarMetodoPagamento(MetodoPagamento metodoPagamento);

        void RemoverMetodoPagamento(int id);
    }
}
