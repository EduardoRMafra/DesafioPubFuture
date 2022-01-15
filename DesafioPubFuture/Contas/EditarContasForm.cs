using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Contas
{
    public partial class EditarContasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public EditarContasForm()
        {
            InitializeComponent();
        }
        private void btnEditarConta_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            if (txtTipoConta.Text != "Carteira" && txtTipoConta.Text != "Conta Corrente" && txtTipoConta.Text != "Poupança")
            {
                txtTipoConta.Focus();
                MessageBox.Show("Selecione um tipo de conta valido!");
                return;
            }
            if (txtInstituicao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome da instituição financeira antes de pressionar o botão Adicionar!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta="+nConta.Value);  //procura pelo banco de dados de contas se existe uma conta com esse ID
                if(dt.Rows.Count == 1)
                {
                    BancoDados.EditarConta((int)nConta.Value, txtTipoConta.Text, txtInstituicao.Text);  //caso tenha, chama a função para editar ela e fecha a janela
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
            this.Close();   //fecha a janela
        }
    }
}
