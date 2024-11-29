using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces.TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository configu)
        {
            _repository = configu;
        }

        public void AdicionarVenda(Venda venda)
        {
            _repository.AdicionarVenda(venda);
        }


        public void RemoverVenda(int id)
        {
            _repository.RemoverVenda(id);
        }

        public List<Venda> listarVenda()
        {
            return _repository.ListarVenda();
        }

        public Venda BuscarVendaPorId(int id)
        {
            return _repository.BuscarVendaPorId(id);
        }

        public void EditarVenda(Venda venda)
        {
            _repository.AdicionarVenda(venda);
        }

    }
}
