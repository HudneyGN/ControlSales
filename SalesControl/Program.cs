using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesControl.br.com.project.view;

namespace SalesControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmClientes());
            //Application.Run(new FrmFuncionarios());
            //Application.Run(new Frmfornecedores());
            Application.Run(new FrmProdutos());
        }
    }
}
