using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSalva
{
    public class Name
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Salario { get; set; }

        public Name() { }

        public Name(int id, string nome, string salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }


    }
}
