using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;
 using System.Collections.Generic;

namespace TrabalhoFinal._02_Repository.Interfaces
{
   
    

   
        public interface IVendaRepository
        {
            void AdicionarVenda(Venda venda);
            List<Venda> ListarVenda(); 
            Venda BuscarVendaPorId(int id);
            void EditarVenda(Venda venda);
            void RemoverVenda(int id);
        }
    


}

