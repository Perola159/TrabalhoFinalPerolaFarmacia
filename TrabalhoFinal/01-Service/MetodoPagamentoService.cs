using System.Collections.Generic;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service
{
    public class MetodoPagamentoService
    {
        private readonly IMetodoPagamentoRepository _repository;

        public MetodoPagamentoService(IMetodoPagamentoRepository repository)
        {
            _repository = repository;
        }

        public void AdicionarMetodo(MetodoPagamento metodoPagamento)
        {
            _repository.AdicionarMetodoPagamento(metodoPagamento);
        }

        public List<MetodoPagamento> ListarMetodos()
        {
            return _repository.ListarMetodosPagamento();
        }

        public MetodoPagamento BuscarMetodoPorId(int id)
        {
            return _repository.BuscarMetodoPagamentoPorId(id);
        }

        public void EditarMetodo(MetodoPagamento metodoPagamento)
        {
            _repository.EditarMetodoPagamento(metodoPagamento);
        }

        public void RemoverMetodo(int id)
        {
            _repository.RemoverMetodoPagamento(id);
        }
    }
}
