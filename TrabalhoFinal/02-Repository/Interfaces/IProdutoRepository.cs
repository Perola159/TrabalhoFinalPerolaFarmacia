using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface IProdutoRepository
    {
        void AdicionarContrib(Produtos P);
        List<Produtos> ListarProduto();
        Produtos BuscarProdutosPorId(int id);
        void EditarProduto(Produtos produtos);

        void RemoverProduto(int id);
    }
}
