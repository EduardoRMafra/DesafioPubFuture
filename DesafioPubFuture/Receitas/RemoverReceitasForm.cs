using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Receitas
{
    public partial class RemoverReceitasForm : Form
    {
        DataTable dt = new DataTable(); //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public RemoverReceitasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.

            if (IdReceita.Value <= 0)
            {
                IdReceita.Focus();
                MessageBox.Show("Por favor, utilize um número de receita existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_receitas WHERE ID_Receita=" + IdReceita.Value); //procura pelo banco de dados de receita se existe uma receita com esse ID
                if (dt.Rows.Count == 1)
                {
                    //caso tenha, chama a função DeletarReceita e fecha a janela
                    BancoDados.DeletarReceita((int)IdReceita.Value);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, utilize um número de receita existente!");
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
