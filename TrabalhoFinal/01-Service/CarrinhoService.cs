using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Services
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoRepository _repository;

        // Construtor que recebe o repositório
        public CarrinhoService(ICarrinhoRepository repository)
        {
            _repository = repository;
        }

        // Método para adicionar um produto ao carrinho
        public void AdicionarProdutoCarrinho(Carrinho carrinho)
        {
            // Validação simplificada
            if (carrinho.IdPessoa <= 0 || carrinho.IdProduto <= 0)
            {
                throw new ArgumentException("Pessoa ou Produto inválido.");
            }
            _repository.AdicionarProdutoCarrinho(carrinho);
        }

        // Método para listar os carrinhos com detalhes
        public List<CarrinhoDTO> ListarProdutoCarrinho()
        {
            return _repository.ListarCarrinhosComDetalhes();
        }

        // Método para deletar um carrinho
        public void DeletarProdutoCarrinho(int id)
        {
            _repository.DeletarCarrinho(id);
        }

        // Método para editar um produto no carrinho (ainda não implementado)
        public void EditarProdutoCarrinho(Carrinho carrinho)
        {
            // Aqui podemos implementar a lógica de editar um produto no carrinho, se necessário
            // Por enquanto, deixamos ele vazio ou podemos lançar um NotImplementedException
            throw new NotImplementedException("EditarProdutoCarrinho ainda não foi implementado.");
        }
    }
}
