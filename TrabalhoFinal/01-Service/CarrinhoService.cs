using AutoMapper;
using CRUD_DAPPER;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{

    public class CarrinhoService
    {
        public ICarrinhoRepository _repository { get; set; }

        public CarrinhoService(string configuration, IMapper _mapper)
        {
            _repository = new CarrinhoRepository(configuration, _mapper);
        }

        public void AdicionarProdutoCarrinho(Carrinho C)
        {
            _repository.AdicionarContrib(C);
        }

        public List<CarrinhoDTO> ListarProdutoCarrinho()
        {
            return _repository.Listar();
        }

        public void EditarProdutoCarrinho(Carrinho c )
        {
            _repository.EditarProdutoCarrinho(c);
        }
    }
}
