using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPubFuture.Receitas
{
    public partial class RemoverReceitasForm : Form
    {
        DataTable dt = new DataTable();
        public RemoverReceitasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (nReceita.Value <= 0)
            {
                nReceita.Focus();
                MessageBox.Show("Por favor, utilize um número de receita existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_receitas WHERE ID_Receita=" + nReceita.Value);
                if (dt.Rows.Count == 1)
                {
                    BancoDados.DeletarReceita((int)nReceita.Value);
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
