using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service
{
    public class MetodoPagamentoService : IMetodoPagamentoService  // Implementar a interface
    {
        private readonly IMetodoPagamentoRepository _repository;

        public MetodoPagamentoService(IMetodoPagamentoRepository repository)
        {
            _repository = repository;
        }

        public void AdicionarMetodoPagamento(MetodoPagamento metodoPagamento)
        {
            _repository.AdicionarMetodoPagamento(metodoPagamento);
        }

        public List<MetodoPagamento> ListarMetodosPagamento()
        {
            return _repository.ListarMetodosPagamento();
        }

        public MetodoPagamento BuscarMetodoPagamentoPorId(int id)
        {
            return _repository.BuscarMetodoPagamentoPorId(id);
        }

        public void EditarMetodoPagamento(MetodoPagamento metodoPagamento)
        {
            _repository.EditarMetodoPagamento(metodoPagamento);
        }

        public void RemoverMetodoPagamento(int id)
        {
            _repository.RemoverMetodoPagamento(id);
        }
    }
}
