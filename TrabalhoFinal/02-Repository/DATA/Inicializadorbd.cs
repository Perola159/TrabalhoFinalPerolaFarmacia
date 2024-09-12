using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._02_Repository.DATA
{
    public static class InicializadorBd
    {
        

        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=PerolinhaFarmacêutica.db"); //criar conexão
            
                string criarTabela = @"   
                 CREATE TABLE IF NOT EXISTS Pessoas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL
                  
                );";

               criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Produtos(
                 Nome TEXT NOT NULL,
                 Preco  NOT NULL,
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 QuantidadeEstoque  NOT NULL
                );";

              connection.Execute(criarTabela);
        }
    }
}
