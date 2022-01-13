using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioPubFuture
{
    public partial class Despesas : Form
    {
        public Despesas()
        {
            InitializeComponent();
            BancoDados.GetFormDespesas(this);
            dtDespesas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_despesas");
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
