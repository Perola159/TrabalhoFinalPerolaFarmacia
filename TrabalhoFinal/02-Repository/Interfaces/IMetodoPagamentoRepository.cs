using System.Collections.Generic;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface IMetodoPagamentoRepository
    {
        void AdicionarMetodoPagamento(MetodoPagamento metodoPagamento);
        List<MetodoPagamento> ListarMetodosPagamento();
        MetodoPagamento BuscarMetodoPagamentoPorId(int id);
        void EditarMetodoPagamento(MetodoPagamento metodoPagamento);
        void RemoverMetodoPagamento(int id);
    }
}
