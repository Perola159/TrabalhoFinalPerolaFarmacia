using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace CRUD_DAPPER
{
    public class PessoaRepository : IPessoaRepositorycs
    {
        public readonly string _ConnectionString;
        IPessoaRepositorycs _repositoryPessoa;


        public PessoaRepository(IConfiguration config, IPessoaRepositorycs repos)
        {
             _ConnectionString = config.GetConnectionString("DefaultConnection");
             _repositoryPessoa = repos;
        }

        public void AdicionarPessoa(Pessoa P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Insert<Pessoa>(P);
        }

        public List<Pessoa> ListarPessoa()
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.GetAll<Pessoa>().ToList(); //TROUXE DO BANCO E RETORNOU A LISTA 
        }


        public Pessoa BuscarPessoaPorId(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.Get<Pessoa>(id);
        }

        public void EditarPessoa(Pessoa P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Update<Pessoa>(P);
        }


        public void DeletePessoa(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            Pessoa NovaPessoa = BuscarPessoaPorId(id);
            connection.Delete<Pessoa>(NovaPessoa);
        }

    }
}

