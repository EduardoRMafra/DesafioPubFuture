using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Despesas
{
    public partial class EditarDespesasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public EditarDespesasForm()
        {
            InitializeComponent();
        }

        private void btnEditarDespesa_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (IdDespesa.Value <= 0)
            {
                IdDespesa.Focus();
                MessageBox.Show("Selecione uma despesa existente!");
                return;
            }
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
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_despesas WHERE ID_Despesa=" + IdDespesa.Value);    //procura pelo banco de dados de despesas se existe uma despesa com esse ID
                if (dt.Rows.Count == 1)
                {
                    dt = new DataTable();
                    dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_Conta=" + nConta.Value);    //procura pelo banco de dados de contas se existe uma conta com esse ID
                    if (dt.Rows.Count == 1)
                    {
                        //caso tenha, chama a função EditarDespesa e fecha a janela
                        BancoDados.EditarDespesa((int)IdDespesa.Value, (double)nValorDespesa.Value, dPagamento.Value, dPagamentoEsperado.Value, txtTipoDespesa.Text, (int)nConta.Value);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, utilize um número de conta existente!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um número de despesa existente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
