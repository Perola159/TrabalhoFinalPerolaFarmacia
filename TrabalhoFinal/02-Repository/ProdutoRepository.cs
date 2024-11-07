using AutoMapper;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace CRUD_DAPPER
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string ConnectionString;
    
        private readonly IProdutoRepository _repositoryProduto;

      
        public ProdutoRepository(IConfiguration config, IProdutoRepository repos)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
            _repositoryProduto= repos;
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

