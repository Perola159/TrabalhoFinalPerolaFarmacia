using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace CRUD_DAPPER
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public readonly string _ConnectionString;


        public EnderecoRepository(string configuration)
        {
            _ConnectionString = configuration;
        }


        public void AdicionarContrib(Endereco P)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Insert<Endereco>(P);
        }

        public List<Endereco> ListarEndereco()
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.GetAll<Endereco>().ToList(); //TROUXE DO BANCO E RETORNOU A LISTA 
        }


        public Endereco BuscarEndereco(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            return connection.Get<Endereco>(id);
        }

        public void EditarEndereco(Endereco P)
                     {
            using var connection = new SQLiteConnection(_ConnectionString);
            connection.Update<Endereco>(P);
        }


        public void DeleteEndereco(int id)
        {
            using var connection = new SQLiteConnection(_ConnectionString);
            Endereco NovaEndereco = BuscarEndereco(id);
            connection.Delete<Endereco>(NovaEndereco);
        }
    }
}

