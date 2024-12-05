using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace CRUD_DAPPER
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string ConnectionString;

        private readonly IProdutoRepository _repositoryProduto;
        private readonly IPessoaRepositorycs _repositoryPessoa;
        public CarrinhoRepository(IConfiguration connect,  IProdutoRepository prdt_repos, IPessoaRepositorycs pessoa_repos, IEnderecoRepository end_repos)
        {
            ConnectionString = connect.GetConnectionString("DefaultConnection");
            _repositoryProduto = prdt_repos;
            _repositoryPessoa = pessoa_repos;
        }

        public void AdicionarContrib(Carrinho C)
        {

            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carrinho>(C);
        }

        public List<CarrinhoDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);

            List<Carrinho> carrinhos = connection.GetAll<Carrinho>().ToList();

            List<CarrinhoDTO> carrinhosDTO = new List<CarrinhoDTO>();

            foreach (Carrinho c in carrinhos)
            {
                var produto = _repositoryProduto.BuscarProdutosPorId(c.IdProduto);

                // Verifique se o produto foi encontrado antes de adicionar ao DTO
                if (produto != null)
                {
                    CarrinhoDTO carrinhoDTO = new CarrinhoDTO
                    {
                        Id = c.Id,
                        IdPessoa = c.IdPessoa,
                        NomePessoa = _repositoryPessoa.BuscarPessoaPorId(c.IdPessoa)?.Nome,  // Pra caso a pessoa não ser encontrada
                        IdProduto = c.IdProduto,
                        NomeProduto = produto.Nome,
                        PrecoProduto = produto.Preco
                    };

                    carrinhosDTO.Add(carrinhoDTO);
                }
            }

            return carrinhosDTO;
        }



        public void EditarProdutoCarrinho(Carrinho c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(c);
        }

        public void DeletarProdutoCarrinho(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            var carrinho = connection.Get<Carrinho>(id); 
            if (carrinho != null)
            {
                connection.Delete(carrinho); 
            }
        }

        public Carrinho BuscarCarrinhoPorProduto(int idPessoa, int idProduto)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carrinho>().FirstOrDefault(c => c.IdPessoa == idPessoa && c.IdProduto == idProduto);
        }


        public Carrinho BuscarCarrinhoPorId(int id)
        {
        
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carrinho>(id);  
        }



    }
}

