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
              
                CarrinhoDTO carrinhoDTO = new CarrinhoDTO
                {
                    Id = c.Id,              
                    IdPessoa = c.IdPessoa,  
                    Produto = _repositoryProduto.BuscarProdutosPorId(c.IdProduto)  
                };

            
                carrinhosDTO.Add(carrinhoDTO);
            }

            
            return carrinhosDTO;
        }

        public void EditarProdutoCarrinho(Carrinho c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(c);
        }
    }
}

