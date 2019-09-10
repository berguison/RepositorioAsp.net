using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinawe.ApiRest.Dominio
{
    public class Aluno
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public decimal mensalidade { get; set; }
    }
}
