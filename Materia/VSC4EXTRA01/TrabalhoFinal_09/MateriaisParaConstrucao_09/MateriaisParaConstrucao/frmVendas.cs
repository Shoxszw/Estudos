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

        private void txtCodBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                /*Assim que o código de barras é inserido no TextBox, o objeto dadosTabelaProdutos
                armazena todos os códigos de barras do banco.*/
                novoProduto = new RegraNegocio.ProdutosRegraNegocio();
                DataTable dadosTabelaProdutos = new DataTable();
                dadosTabelaProdutos = novoProduto.RetornarProduto(txtCodBarras.Text);

                if (dadosTabelaProdutos.Rows.Count > 0) //Verifica se o código de barras existe no banco.
                {
                    //Se conter o código, examina se é a primeira vez que o produto aparece no DataGridView.
                    if (dtgVendas.Rows.Count == 0)
                    {
                        //Se sim, as Labels da área Item em destaque são preenchidas com as informações do produto.
                        lblItem.Text = dadosTabelaProdutos.Rows[0]["NOME_PRODUTO"].ToString();
                        lblValor.Text = dadosTabelaProdutos.Rows[0]["VALOR_VENDA"].ToString();
                        lblDescricao.Text = dadosTabelaProdutos.Rows[0]["DESCRICAO_PRODUTO"].ToString();
                        lblQuantidade.Text = "1";

                        //Realiza o cálculo do subtotal da venda, armazenando na Label lblSubtotal.
                        lblSubtotal.Text = (Convert.ToDecimal(lblValor.Text) * Convert.ToInt32(lblQuantidade.Text)).ToString();

                        //Salva a venda na tabela Vendas.
                        novaVenda = new RegraNegocio.VendasRegraNegocio();
                        novaVenda.SalvarVenda(idUsuario, idCliente, DateTime.Now, false);

                        //Retorna as informações da venda atual do cliente, baseado em seu ID, para obtermos o código da venda.
                        novaVenda = new RegraNegocio.VendasRegraNegocio();
                        DataTable dadosTabelaVendas = new DataTable();
                        dadosTabelaVendas = novaVenda.RetornarVenda(idCliente);

                        //Salva os dados na tabela Detalhes_venda.
                        novaVenda = new RegraNegocio.VendasRegraNegocio();
                        novaVenda.SalvarDetalhes(Convert.ToInt32(dadosTabelaVendas.Rows[0]["ID_VENDA"]), Convert.ToInt32(dadosTabelaProdutos.Rows[0]["ID_PRODUTO"]), Convert.ToInt32(lblQuantidade.Text));
                    }
                    else
                    {
                        //O DataGridView será percorrido linha por linha.
                        for (int i = 0; i < dtgVendas.Rows.Count; i++)
                        {
                            //Se o conteúdo da caixa de texto do produto novo for igual ao campo CODIGO_BARRAS do DataGridView.
                            if (txtCodBarras.Text == dtgVendas.Rows[i].Cells["CODIGO_BARRAS"].Value.ToString())
                            {
                                lblItem.Text = dtgVendas.Rows[i].Cells["NOME_PRODUTO"].Value.ToString();
                                lblValor.Text = dtgVendas.Rows[i].Cells["VALOR_VENDA"].Value.ToString();
                                lblDescricao.Text = dtgVendas.Rows[i].Cells["DESCRICAO_PRODUTO"].Value.ToString();

                                //Altera a quantidade e também o subtotal que calcula a multiplicação do valor com a quantidade dele.
                                int quantidade = Convert.ToInt32(dtgVendas.Rows[i].Cells["QUANTIDADE"].Value.ToString()) + 1;
                                lblQuantidade.Text = quantidade.ToString();
                                lblSubtotal.Text = (Convert.ToDecimal(lblValor.Text) * quantidade).ToString();

                                //Realiza a alteração da quantidade do produto na tabela Detalhes_venda.
                                novaVenda = new RegraNegocio.VendasRegraNegocio();
                                novaVenda.AlterarDetalhes(Convert.ToInt32(dtgVendas.Rows[i].Cells["ID_DETALHES"].Value), quantidade);

                                //Finalizamos a estrutura for.
                                break;
                            }
                            else //Se não, caso o código de barras não for encontrado,
                            {
                                //verifica se está na última linha do DataGridView.
                                if ((dtgVendas.Rows.Count - 1) == i)
                                {
                                    //Se estiver na última linha, os Labels da área Item em destaque receberão os dados do novo produto.
                                    lblItem.Text = dadosTabelaProdutos.Rows[0]["NOME_PRODUTO"].ToString();
                                    lblValor.Text = dadosTabelaProdutos.Rows[0]["VALOR_VENDA"].ToString();
                                    lblDescricao.Text = dadosTabelaProdutos.Rows[0]["DESCRICAO_PRODUTO"].ToString();
                                    lblQuantidade.Text = "1";
                                    lblSubtotal.Text = (Convert.ToDecimal(lblValor.Text) * Convert.ToInt32(lblQuantidade.Text)).ToString();

                                    //Retorna as informações da venda atual do cliente, baseado em seu ID, para obtermos o código da venda.
                                    novaVenda = new RegraNegocio.VendasRegraNegocio();
                                    DataTable dadosTabelaVendas = new DataTable();
                                    dadosTabelaVendas = novaVenda.RetornarVenda(idCliente);

                                    //Salva os dados na tabela Detalhes_venda.
                                    novaVenda = new RegraNegocio.VendasRegraNegocio();
                                    novaVenda.SalvarDetalhes(Convert.ToInt32(dadosTabelaVendas.Rows[0]["ID_VENDA"]), Convert.ToInt32(dadosTabelaProdutos.Rows[0]["ID_PRODUTO"]), Convert.ToInt32(lblQuantidade.Text));
                                }
                            }
                        }
                    }
                    ListarVendas();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
