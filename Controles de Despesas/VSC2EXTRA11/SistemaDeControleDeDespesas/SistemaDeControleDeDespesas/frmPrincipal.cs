using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControleDeDespesas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
           
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //evento Click do btnCategorias onde o formulário frmCategorias é instanciado e exibido.
            frmCategorias novaCategoria = new frmCategorias();
            novaCategoria.ShowDialog();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            //evento Click do btnContas onde o formulário frmContas é instanciado e exibido.
            frmContas novaConta = new frmContas();
            novaConta.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        { /* evento Load do frmPrincipal, que utiliza a query ListarDespesas criadas no tableAdapter da tabela Contas
           * para buscar todos os registros da mesma e exibir no DataGridView */
            dtgPesquisa.DataSource = contasTableAdapter1.ListarDespesas();
        }
    }
}
