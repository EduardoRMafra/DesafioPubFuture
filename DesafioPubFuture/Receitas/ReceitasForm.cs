using System;
using System.Windows.Forms;

namespace DesafioPubFuture.Receitas
{
    public partial class ReceitasForm : Form
    {
        public ReceitasForm()
        {
            InitializeComponent();
            BancoDados.GetFormReceitas(this);   //envia ao banco de dados acesso ao ReceitasForm
            dtReceitas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_receitas");  //atualiza a tabela com informações no banco de dados
        }

        //Ao clicar nos botões abre uma nova janela para realizar a operação escolhida
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
