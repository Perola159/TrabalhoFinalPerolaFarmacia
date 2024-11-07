using AutoMapper;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace CRUD_DAPPER
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string ConnectionString;
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _repositoryProduto;
        private readonly IPessoaRepositorycs _repositoryPessoa;
        private readonly IEnderecoRepository _repositoryEndereco;
        public CarrinhoRepository(string connectioString, IMapper mapper, IProdutoRepository prdt_repos, IPessoaRepositorycs pessoa_repos, IEnderecoRepository end_repos)
        {
            ConnectionString = connectioString;
            _mapper = mapper;
            _repositoryProduto = prdt_repos;
            _repositoryPessoa = pessoa_repos;
            _repositoryEndereco= end_repos;
          
        }

        public void AdicionarContrib(Carrinho C)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carrinho>(C);
        }

        public List<CarrinhoDTO> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Carrinho> rotinas = connection.GetAll<Carrinho>().ToList();
            List<CarrinhoDTO> CarrinhosDTO = new List<CarrinhoDTO>();//_mapper.Map<List<ReadRotinaDTO>>(lista);
            foreach (Carrinho c in rotinas)
            {
                 CarrinhoDTO CDTO = new CarrinhoDTO();
                CDTO.Id = c.Id;
                CDTO.IdPessoa = c.IdPessoa;
                CDTO.Pessoa = _repositoryPessoa.BuscarPessoaPorId(c.IdPessoa);
                CDTO.Produto = _repositoryProduto.BuscarProdutosPorId(c.IdProduto);
                CarrinhosDTO.Add(CDTO);
            }
            return CarrinhosDTO;
        }
        public void EditarProdutoCarrinho(Carrinho c)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carrinho>(c);
        }
    }
}

