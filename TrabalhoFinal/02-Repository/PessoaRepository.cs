using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._03_Entidades;

namespace CRUD_DAPPER
{
    public class PessoaRepository
    {
        public readonly string _ConnectionString;


        public PessoaRepository(string configuration)
        {
            _ConnectionString = configuration;
        }


        public void AdicionarContrib(Pessoa P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Insert<Pessoa>(P);
        }

        public List<Pessoa> ListarPessoa()
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.GetAll<Pessoa>().ToList(); //TROUXE DO BANCO E RETORNOU A LISTA 
        }


        public Pessoa BuscarPessoa(int id)
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
            Pessoa NovaPessoa = BuscarPessoa(id);
            connection.Delete<Pessoa>(NovaPessoa);
        }
    }
}

