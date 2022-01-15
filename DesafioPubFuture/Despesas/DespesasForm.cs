using System;
using System.Windows.Forms;

namespace DesafioPubFuture.Despesas
{
    public partial class DespesasForm : Form
    {
        public DespesasForm()
        {
            InitializeComponent();
            BancoDados.GetFormDespesas(this);   //envia ao banco de dados acesso ao DespesasForm
            dtDespesas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_despesas");  //atualiza a tabela com informações no banco de dados
        }

        //Ao clicar nos botões abre uma nova janela para realizar a operação escolhida
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
