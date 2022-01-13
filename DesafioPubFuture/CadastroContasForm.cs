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
    public partial class CadastroContasForm : Form
    {
        public CadastroContasForm()
        {
            InitializeComponent();
        }

        private void btnAddConta_Click(object sender, EventArgs e)
        {
            if (txtTipoConta.Text != "Carteira" && txtTipoConta.Text != "Conta Corrente" && txtTipoConta.Text != "Poupança")
            {
                txtTipoConta.Focus();
                MessageBox.Show("Selecione um tipo de conta valido!");
                return;
            }
            if (txtInstituicao.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome da instituição financeira antes de pressionar o botão Adicionar!");
                return;
            }
            try
            {
                BancoDados.NovaConta(txtTipoConta.Text, txtInstituicao.Text);
                this.Close();
            }
            catch(Exception ex)
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
