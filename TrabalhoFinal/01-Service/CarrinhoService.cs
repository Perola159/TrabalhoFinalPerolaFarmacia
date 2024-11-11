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
            _repository.AdicionarContrib(C);
        }

        public List<CarrinhoDTO> ListarProdutoCarrinho()
        {
            return _repository.Listar();
        }

        public void EditarProdutoCarrinho(Carrinho c)
        {
            _repository.EditarProdutoCarrinho(c);
        }
    }
}
