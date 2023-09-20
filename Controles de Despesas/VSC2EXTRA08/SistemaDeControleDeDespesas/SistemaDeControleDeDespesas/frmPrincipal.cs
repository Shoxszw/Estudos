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
    }
}
