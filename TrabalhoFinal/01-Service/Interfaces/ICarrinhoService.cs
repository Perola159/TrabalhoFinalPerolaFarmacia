using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface ICarrinhoService
    {

        void AdicionarProdutoCarrinho(Carrinho carrinho);


        List<CarrinhoDTO> ListarProdutoCarrinho();


        void DeletarProdutoCarrinho(int id);


        void EditarProdutoCarrinho(Carrinho carrinho);
    }
}
