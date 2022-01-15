using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Receitas
{
    public partial class EditarReceitasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public EditarReceitasForm()
        {
            InitializeComponent();
        }
        private void btnEditarReceita_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (IdReceita.Value <= 0)
            {
                IdReceita.Focus();
                MessageBox.Show("Selecione uma receita existente!");
                return;
            }
            if (nValorReceita.Value <= 0)
            {
                nValorReceita.Focus();
                MessageBox.Show("Selecione um valor de receita válida!");
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                txtDescricao.Focus();
                MessageBox.Show("Preencha o campo de descrição antes de pressionar o botão Editar!");
                return;
            }
            if (nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            if (txtTipoReceita.Text != "Salário" && txtTipoReceita.Text != "Presente" && txtTipoReceita.Text != "Prêmios" && txtTipoReceita.Text != "Outros")
            {
                txtTipoReceita.Focus();
                MessageBox.Show("Selecione um tipo de receita válida!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_receitas WHERE ID_Receita=" + IdReceita.Value); //procura pelo banco de dados de receita se existe uma receita com esse ID
                if (dt.Rows.Count == 1)
                {
                    dt = new DataTable();
                    dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_Conta=" + nConta.Value);    //procura pelo banco de dados de contas se existe uma conta com esse ID
                    if (dt.Rows.Count == 1)
                    {
                        //caso tenha, chama a função EditarReceita e fecha a janela
                        BancoDados.EditarReceita((int)IdReceita.Value, (double)nValorReceita.Value, dRecebimento.Value, dRecebimentoEsperado.Value, txtDescricao.Text, (int)nConta.Value, txtTipoReceita.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, utilize um número de conta existente!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um número de receita existente!");
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
