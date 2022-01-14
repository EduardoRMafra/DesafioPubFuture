using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPubFuture.Contas
{
    public partial class RemoverContasForm : Form
    {
        DataTable dt = new DataTable();
        public RemoverContasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta=" + nConta.Value);
                if (dt.Rows.Count == 1)
                {
                    BancoDados.DeletarConta((int)nConta.Value);
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
