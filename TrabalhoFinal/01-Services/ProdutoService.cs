using CRUD_DAPPER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services
{

    public class ProdutoService
    {
        public ProdutoRepository _repository { get; set; }

        public ProdutoService(string configuration)
        {
            _repository = new ProdutoRepository(configuration);
        }

        public void AdicionarProduto(Produtos P)
        {
            _repository.AdicionarContrib(P);
        }


        public void RemoverProduto(int id)
        {
            _repository.RemoverProduto(id);
        }

        public List<Produtos> listarProduto()
        {
            return _repository.ListarProduto();
        }

        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarProdutosPorId(id);
        }



        public void EditarProduto( Produtos p)
        {
            _repository.EditarProduto(p);
        }
    }
}