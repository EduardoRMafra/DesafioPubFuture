using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPubFuture.Despesas
{
    public partial class CadastrarDespesasForm : Form
    {
        DataTable dt = new DataTable();
        public CadastrarDespesasForm()
        {
            InitializeComponent();
        }

        private void btnAddDespesa_Click(object sender, EventArgs e)
        {
            if (nValorDespesa.Value <= 0)
            {
                nValorDespesa.Focus();
                MessageBox.Show("Selecione um valor de despesa válida!");
                return;
            }
            if (nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            if (txtTipoDespesa.Text != "Alimentação" && txtTipoDespesa.Text != "Educação" && txtTipoDespesa.Text != "Lazer" && txtTipoDespesa.Text != "Moradia" && txtTipoDespesa.Text != "Roupa" && txtTipoDespesa.Text != "Saúde" && txtTipoDespesa.Text != "Transporte" && txtTipoDespesa.Text != "Outros")
            {
                txtTipoDespesa.Focus();
                MessageBox.Show("Selecione um tipo de despesa válida!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta=" + nConta.Value);
                if (dt.Rows.Count == 1)
                {
                    BancoDados.NovaDespesa((double)nValorDespesa.Value, dPagamento.Value, dPagamentoEsperado.Value, txtTipoDespesa.Text, (int)nConta.Value);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, utilize um número de conta existente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
