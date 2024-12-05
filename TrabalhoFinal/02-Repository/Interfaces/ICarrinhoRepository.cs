using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface ICarrinhoRepository
    {
        void AdicionarContrib(Carrinho C);
        List<CarrinhoDTO> Listar();
        void EditarProdutoCarrinho(Carrinho c);
       void DeletarProdutoCarrinho(int id);
       Carrinho BuscarCarrinhoPorId(int id);
       



    }
}
