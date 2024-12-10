using AutoMapper;
using CRUD_DAPPER;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;
using static TrabalhoFinal._01_Services.CarrinhoService;

namespace TrabalhoFinal._01_Services
{

    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository _repository;

        public CarrinhoService(ICarrinhoRepository config)
        {
            _repository = config;
        }

        public void AdicionarProdutoCarrinho(Carrinho C)
        {
            // Verificando se IdPessoa e IdProduto são válidos
            if (C.IdPessoa <= 0 || C.IdProduto <= 0)
            {
                throw new ArgumentException("Pessoa ou Produto inválido.");
            }
            _repository.AdicionarProdutoCarrinho(C);
        }

        public List<CarrinhoDTO> ListarProdutoCarrinho()
        {
            return _repository.ListarCarrinhosComDetalhes();
        }

        public void EditarProdutoCarrinho(int id)
        {
            _repository.EditarProdutoCarrinho(id);
        }

        public void DeletarProdutoCarrinho(int id)
        {
            _repository.DeletarCarrinho(id);  
        }


    }
}
