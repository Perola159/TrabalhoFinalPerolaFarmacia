using System.Data.SQLite;
using Dapper;
using Microsoft.Extensions.Configuration;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string _connectionString;

        public CarrinhoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }



        public void AdicionarProdutoCarrinho(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(_connectionString);
            var sql = "INSERT INTO Carrinhos (IdPessoa, IdProduto) VALUES (@IdPessoa, @IdProduto)";
            connection.Execute(sql, carrinho);
        }


        public List<CarrinhoDTO> ListarCarrinhosComDetalhes()
        {
            using var connection = new SQLiteConnection(_connectionString);


            var sql = @"
                SELECT 
                    c.Id AS CarrinhoId,
                    c.IdPessoa,
                    c.IdProduto
                FROM Carrinhos c";

            var result = connection.Query<CarrinhoDTO>(sql).ToList();
            return result;
        }


        public void DeletarCarrinho(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            var sql = "DELETE FROM Carrinhos WHERE Id = @Id";
            connection.Execute(sql, new { Id = id });
        }


        public void EditarProdutoCarrinho(Carrinho carrinho)
        {

            throw new NotImplementedException("EditarProdutoCarrinho não está implementado.");
        }
    }
}
