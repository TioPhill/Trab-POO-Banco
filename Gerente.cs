using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Gerente
    {

        public string Nome { get; set; }
        public string Endereço { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Tel { get; set; }
        public int Matricula { get; set; }
        public int Senha { get; set; }

        public Gerente()
        {

            this.Nome = "Eduardo";
            this.Matricula = 2015;
            this.Senha = 12345678;

        }

    }
}
