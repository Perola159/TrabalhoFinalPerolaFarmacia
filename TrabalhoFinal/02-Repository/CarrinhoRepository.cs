using System.Data.SQLite;
using Dapper;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string _connectionString;

        // Construtor que recebe a string de conexão
        public CarrinhoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para adicionar um produto ao carrinho
        public void AdicionarProdutoCarrinho(Carrinho carrinho)
        {
            using var connection = new SQLiteConnection(_connectionString);
            var sql = "INSERT INTO Carrinhos (IdPessoa, IdProduto) VALUES (@IdPessoa, @IdProduto)";
            connection.Execute(sql, carrinho);
        }

        // Método para listar carrinhos com detalhes (ajustado)
        public List<CarrinhoDTO> ListarCarrinhosComDetalhes()
        {
            using var connection = new SQLiteConnection(_connectionString);

            // Query SQL simplificada para retornar os dados essenciais
            var sql = @"
                SELECT 
                    c.Id AS CarrinhoId,
                    c.IdPessoa,
                    c.IdProduto
                FROM Carrinhos c";

            var result = connection.Query<CarrinhoDTO>(sql).ToList();
            return result;
        }

        // Método para deletar um carrinho
        public void DeletarCarrinho(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            var sql = "DELETE FROM Carrinhos WHERE Id = @Id";
            connection.Execute(sql, new { Id = id });
        }

        // Método para editar um produto no carrinho (ainda não implementado)
        public void EditarProdutoCarrinho(Carrinho carrinho)
        {
            // Caso você precise implementar, adicione a lógica para editar um produto no carrinho.
            throw new NotImplementedException("EditarProdutoCarrinho não está implementado.");
        }
    }
}
