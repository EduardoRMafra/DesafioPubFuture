using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Contas
{
    public partial class RemoverContasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public RemoverContasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta=" + nConta.Value);    //verifica se a conta existe no banco de dados
                if (dt.Rows.Count == 1)
                {
                    BancoDados.DeletarConta((int)nConta.Value); //chama a função para excluir a conta
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
