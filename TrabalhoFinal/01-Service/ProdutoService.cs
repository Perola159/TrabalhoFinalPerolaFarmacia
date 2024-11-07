using AutoMapper;
using CRUD_DAPPER;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Services
{

    public class ProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository configu)
        {
            _repository = configu ;
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