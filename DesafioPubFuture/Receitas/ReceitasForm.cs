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
    public partial class ReceitasForm : Form
    {
        public ReceitasForm()
        {
            InitializeComponent();
            BancoDados.GetFormReceitas(this);
            dtReceitas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_receitas");
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarReceitasForm c = new CadastrarReceitasForm();
            c.ShowDialog();
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            EditarReceitasForm ed = new EditarReceitasForm();
            ed.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverReceitasForm ed = new RemoverReceitasForm();
            ed.ShowDialog();
        }
    }
}
