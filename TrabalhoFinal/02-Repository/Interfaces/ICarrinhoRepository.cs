using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface ICarrinhoRepository
    {
        void AdicionarProdutoCarrinho(Carrinho carrinho);


        void EditarProdutoCarrinho(Carrinho carrinho);


        List<CarrinhoDTO> ListarCarrinhosComDetalhes();

        void DeletarCarrinho(int id);
    }
}
