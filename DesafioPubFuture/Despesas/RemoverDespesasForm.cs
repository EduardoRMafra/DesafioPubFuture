using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Despesas
{
    public partial class RemoverDespesasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public RemoverDespesasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (IdDespesa.Value <= 0)
            {
                IdDespesa.Focus();
                MessageBox.Show("Por favor, utilize um número de despesa existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_despesas WHERE ID_Despesa =" + IdDespesa.Value);    //procura pelo banco de dados de despesas se existe uma despesa com esse ID
                if (dt.Rows.Count == 1)
                {
                    //caso tenha, chama a função DeletarDespesa e fecha a janela
                    BancoDados.DeletarDespesa((int)IdDespesa.Value);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, utilize um número de despesa existente!");
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
