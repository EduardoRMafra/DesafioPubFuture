using System;
using System.Windows.Forms;

namespace DesafioPubFuture.Contas
{
    public partial class CadastroContasForm : Form
    {
        public CadastroContasForm()
        {
            InitializeComponent();
        }

        private void btnAddConta_Click(object sender, EventArgs e)  //ao pressionar o botão Adicionar
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            if (txtTipoConta.Text != "Carteira" && txtTipoConta.Text != "Conta Corrente" && txtTipoConta.Text != "Poupança")
            {
                txtTipoConta.Focus();
                MessageBox.Show("Selecione um tipo de conta valido!");
                return;
            }
            if (txtInstituicao.Text.Trim() == "")       //retira todos os espaços da string para verificar se está devidamente preenchida e não apenas com espaços
            {
                MessageBox.Show("Preencha o nome da instituição financeira antes de pressionar o botão Adicionar!");
                return;
            }
            try
            {
                BancoDados.NovaConta(txtTipoConta.Text, txtInstituicao.Text);   //chama a função do banco de dados para adicionar uma nova conta na tabela tb_contas
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Occoreu um erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)  //fecha a janela
        {
            this.Close();
        }
    }
}
