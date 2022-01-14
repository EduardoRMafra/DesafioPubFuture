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
    public partial class RemoverDespesasForm : Form
    {
        DataTable dt = new DataTable();
        public RemoverDespesasForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (IdDespesa.Value <= 0)
            {
                IdDespesa.Focus();
                MessageBox.Show("Por favor, utilize um número de despesa existente!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_despesas WHERE ID_Despesa =" + IdDespesa.Value);
                if (dt.Rows.Count == 1)
                {
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
