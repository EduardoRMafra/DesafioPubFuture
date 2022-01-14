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
    public partial class DespesasForm : Form
    {
        public DespesasForm()
        {
            InitializeComponent();
            BancoDados.GetFormDespesas(this);
            dtDespesas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_despesas");
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarDespesasForm c = new CadastrarDespesasForm();
            c.ShowDialog();
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            EditarDespesasForm ed = new EditarDespesasForm();
            ed.ShowDialog();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverDespesasForm r = new RemoverDespesasForm();
            r.ShowDialog();
        }
    }
}
