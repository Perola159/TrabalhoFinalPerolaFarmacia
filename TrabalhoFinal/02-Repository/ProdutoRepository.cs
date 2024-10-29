using AutoMapper;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace CRUD_DAPPER
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string ConnectionString;
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _repositoryProduto;
        private readonly IPessoaRepositorycs _repositoryPessoa;
        private readonly IEnderecoRepository _repositoryEndereco;
        public ProdutoRepository(string connectioString, IMapper mapper)
        {
            ConnectionString = connectioString;
            _mapper = mapper;
            _repositoryProduto = new ProdutoRepository(connectioString, mapper);
            _repositoryPessoa = new PessoaRepository(connectioString);
            _repositoryEndereco = new EnderecoRepository(connectioString);
        }

         public void AdicionarContrib(Produtos P) 
         {
         using var connection = new SQLiteConnection(ConnectionString);
         connection.Insert<Produtos>(P);
         }

        public List<Produtos> ListarProduto()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Produtos>().ToList(); //TROUXE DO BANCO E RETORNOU A LISTA 
        }


        public Produtos BuscarProdutosPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Produtos>(id);
        }

        public void EditarProduto( Produtos P)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Produtos>(P);
        }


        public void RemoverProduto(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Produtos NovoProduto = BuscarProdutosPorId(id);
            connection.Delete<Produtos>(NovoProduto);
        }
    }
}

