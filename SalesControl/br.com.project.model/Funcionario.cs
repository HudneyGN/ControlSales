using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.br.com.project.model
{
    public class Funcionario : Cliente // Herdando atributos de cliente
    {
        // criando métodos get e set com auto properties
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivelAcesso { get; set; }
    }
}
