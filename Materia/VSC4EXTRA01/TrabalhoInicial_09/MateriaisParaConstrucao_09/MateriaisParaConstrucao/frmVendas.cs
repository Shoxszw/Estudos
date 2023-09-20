using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmVendas : Form
    {
        RegraNegocio.ProdutosRegraNegocio novoProduto;
        RegraNegocio.VendasRegraNegocio novaVenda;

        int idUsuario, idCliente;
        string nomeUsuario;

        public frmVendas(int idUsuario, string nomeUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            lblUsuário.Text = nomeUsuario;
            lblData.Text = DateTime.Today.Date.ToShortDateString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarVendas()
        {
            try
            {
                decimal valorSubtotal = 0;

                novaVenda = new RegraNegocio.VendasRegraNegocio();
                DataTable dadosTabelaVendas = new DataTable();
                dadosTabelaVendas = novaVenda.RetornarVenda(idCliente);

                novaVenda = new RegraNegocio.VendasRegraNegocio();
                DataTable dadosTabelaDetalhes = new DataTable();
                dadosTabelaDetalhes = novaVenda.RetornarDetalhes(Convert.ToInt32(dadosTabelaVendas.Rows[0]["ID_VENDA"].ToString()));
                dtgVendas.DataSource = dadosTabelaDetalhes;

                for (int i = 0; i < dtgVendas.Rows.Count; i++)
                {
                    dtgVendas.Rows[i].Cells["SUBTOTAL"].Value = (Convert.ToInt32(dtgVendas.Rows[i].Cells["QUANTIDADE"].Value) * Convert.ToDecimal(dtgVendas.Rows[i].Cells["VALOR_VENDA"].Value)).ToString();
                    valorSubtotal += Convert.ToDecimal(dtgVendas.Rows[i].Cells["SUBTOTAL"].Value);
                }

                lblValorSubtotal.Text = "R$ " + valorSubtotal.ToString();

                Estilo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Estilo()
        {
            for (int i = 0; i < dtgVendas.Rows.Count; i += 2)
            {
                dtgVendas.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

    }
}
