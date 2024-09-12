using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._03_Entidades;

namespace CRUD_DAPPER
{
    public class ProdutoRepository
    {
        public readonly string _ConnectionString;

        public ProdutoRepository(string configuration)
        {
            _ConnectionString = configuration;
        }

        public void AdicionarContrib(Produtos P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Insert<Produtos>(P);
        }

        public List<Produtos> ListarProduto()
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.GetAll<Produtos>().ToList(); //TROUXE DO BANCO E RETORNOU A LISTA 
        }


        public Produtos BuscarProdutosPorId(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.Get<Produtos>(id);
        }

        public void EditarProduto( Produtos P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Update<Produtos>(P);
        }


        public void RemoverProduto(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            Produtos NovoProduto = BuscarProdutosPorId(id);
            connection.Delete<Produtos>(NovoProduto);
        }
    }
}

