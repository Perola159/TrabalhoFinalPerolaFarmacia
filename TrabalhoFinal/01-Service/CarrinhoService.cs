using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository _repository;

        public CarrinhoService(ICarrinhoRepository repository)
        {
            _repository = repository;
        }

     
        public void AdicionarProdutoCarrinho(Carrinho carrinho)
        {
          
            if (carrinho.IdPessoa <= 0 || carrinho.IdProduto <= 0)
            {
                throw new ArgumentException("Pessoa ou Produto inválido.");
            }
            _repository.AdicionarProdutoCarrinho(carrinho);
        }

        public List<CarrinhoDTO> ListarProdutoCarrinho()
        {
            return _repository.ListarCarrinhosComDetalhes();
        }


        public void DeletarProdutoCarrinho(int id)
        {
            _repository.DeletarCarrinho(id);
        }

        
        public void EditarProdutoCarrinho(Carrinho carrinho)
        {
    
            throw new NotImplementedException("EditarProdutoCarrinho ainda não foi implementado.");
        }
    }
}
