using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository
{
    public class MetodoPagamentoRepository : IMetodoPagamentoRepository
    {
        private readonly string _connectionString;

        public MetodoPagamentoRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

       
        public void AdicionarMetodoPagamento(MetodoPagamento metodoPagamento)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "INSERT INTO MetodoPagamentos (Nome, Tipo, Ativo, TaxaTransacao) VALUES (@Nome, @Tipo, @Ativo, @TaxaTransacao)";
                connection.Execute(query, metodoPagamento);
            }
        }

      
        public List<MetodoPagamento> ListarMetodosPagamento()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "SELECT * FROM MetodoPagamentos";
                return connection.Query<MetodoPagamento>(query).ToList();
            }
        }

 
        public MetodoPagamento BuscarMetodoPagamentoPorId(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "SELECT * FROM MetodoPagamentos WHERE Id = @Id";
                return connection.QueryFirstOrDefault<MetodoPagamento>(query, new { Id = id });
            }
        }

        
        public void EditarMetodoPagamento(MetodoPagamento metodoPagamento)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "UPDATE MetodoPagamentos SET Nome = @Nome, Tipo = @Tipo, Ativo = @Ativo, TaxaTransacao = @TaxaTransacao WHERE Id = @Id";
                connection.Execute(query, metodoPagamento);
            }
        }

   
        public void RemoverMetodoPagamento(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "DELETE FROM MetodoPagamentos WHERE Id = @Id";
                connection.Execute(query, new { Id = id });
            }
        }
    }
}

