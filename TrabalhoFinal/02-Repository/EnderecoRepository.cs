using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

using TrabalhoFinal._03_Entidades.DTOS;
using static CRUD_DAPPER.EnderecoRepository;

namespace CRUD_DAPPER
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public readonly string _ConnectionString;
        IEnderecoRepository _repositoryendereco;


        public EnderecoRepository(IConfiguration config, IEnderecoRepository repos)
        {
            _ConnectionString = config.GetConnectionString("DefaultConnection");
            _repositoryendereco = repos;

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
            Endereco NovoEndereco = BuscarEndereco(id);
            connection.Delete<Endereco>(NovoEndereco);
        }
    }
}

