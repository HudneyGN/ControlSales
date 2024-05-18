using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.br.com.project.model
{
    public class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtdestoque { get; set; }
        public int codigoFornecedor { get; set; }
    }
}
