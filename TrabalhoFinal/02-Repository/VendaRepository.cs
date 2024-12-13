using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository.Interfaces;

using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._02_Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly string ConnectionString;

        public VendaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }


        public void AdicionarVenda(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Venda>(venda);
        }


        public List<Venda> ListarVenda()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Venda>().ToList();
        }


        public Venda BuscarVendaPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Venda>(id);
        }


        public void EditarVenda(Venda venda)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Venda>(venda);
        }


        public void RemoverVenda(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Venda removendovenda = BuscarVendaPorId(id);
            connection.Delete<Venda>(removendovenda);
        }
    }
}