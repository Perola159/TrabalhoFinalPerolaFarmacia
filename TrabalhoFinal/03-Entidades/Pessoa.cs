using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades
{
    public class Pessoa
    {
        
        public string Nome { get; set; }

        private double CPF;

        public double buscarcpf()
        {
            return CPF;
        }
        public int ID { get; set; }
        public int EnderecoId { get; set; }
    }
}
