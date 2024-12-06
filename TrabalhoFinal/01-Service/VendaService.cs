using System;
using System.Collections.Generic;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces.TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;
using static TrabalhoFinal._03_Entidades.DTOS.VendaDTO;

namespace TrabalhoFinal._01_Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        private readonly ICarrinhoRepository _carrinhoRepository; 

        public VendaService(IVendaRepository repository, ICarrinhoRepository carrinhoRepository)
        {
            _repository = repository;
            _carrinhoRepository = carrinhoRepository; 
        }

   
        public void AdicionarVenda(Venda venda)
        {
            _repository.AdicionarVenda(venda);
        }

     
        public void RemoverVenda(int id)
        {
            _repository.RemoverVenda(id);
        }

        // Método para listar todas as vendas DETALHADAS
        public List<VendaDTO> ListarVendasComCarrinho()
        {
            var vendas = _repository.ListarVenda();
            var vendasComCarrinho = new List<VendaDTO>();

            foreach (var venda in vendas)
            {
                Carrinho carrinho = _carrinhoRepository.BuscarCarrinhoPorId(venda.IdCarrinho); // Buscar o carrinho associado à venda
                var itensCarrinho = carrinho.Itens.Select(i => new ItemCarrinho
                {
                    ProdutoId = i.ProdutoId,
                    NomeProduto = i.NomeProduto,
                    Preco = i.Preco,
                    Quantidade = i.Quantidade
                }).ToList();

                // Adicionar os dados da venda junto com os itens do carrinho
                vendasComCarrinho.Add(new VendaDTO
                {
                    Id = venda.Id,
                    IdCarrinho = venda.IdCarrinho,
                    ItensCarrinho = itensCarrinho
                });
            }

            return vendasComCarrinho; 
        }

     
        public Venda BuscarVendaPorId(int id)
        {
            return _repository.BuscarVendaPorId(id);
        }

     
        public void EditarVenda(Venda venda)
        {
            _repository.EditarVenda(venda);
        }
    }
}
