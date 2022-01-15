using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Despesas
{
    public partial class CadastrarDespesasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public CadastrarDespesasForm()
        {
            InitializeComponent();
        }

        private void btnAddDespesa_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
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
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta=" + nConta.Value);    //procura pelo banco de dados de contas se existe uma conta com esse ID
                if (dt.Rows.Count == 1)
                {
                    //caso tenha, chama a função NovaDespesa e fecha a janela
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
