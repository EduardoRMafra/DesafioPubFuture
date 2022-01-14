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
    public partial class CadastrarReceitasForm : Form
    {
        DataTable dt = new DataTable();
        public CadastrarReceitasForm()
        {
            InitializeComponent();
        }

        private void btnAddReceita_Click(object sender, EventArgs e)
        {
            if (nReceita.Value <= 0)
            {
                nReceita.Focus();
                MessageBox.Show("Selecione um valor de receita válida!");
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                txtDescricao.Focus();
                MessageBox.Show("Preencha o campo de descrição antes de pressionar o botão Adicionar!");
                return;
            }
            if(nConta.Value <= 0)
            {
                nConta.Focus();
                MessageBox.Show("Por favor, utilize um número de conta existente!");
                return;
            }
            if (txtTipoReceita.Text != "Salário" && txtTipoReceita.Text != "Presente" && txtTipoReceita.Text != "Prêmios" && txtTipoReceita.Text != "Outros")
            {
                txtTipoReceita.Focus();
                MessageBox.Show("Selecione um tipo de receita válida!");
                return;
            }
            try
            {
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_conta=" + nConta.Value);
                if (dt.Rows.Count == 1)
                {
                    BancoDados.NovaReceita((double)nReceita.Value,dRecebimento.Value, dRecebimentoEsperado.Value, txtDescricao.Text, (int)nConta.Value,txtTipoReceita.Text);
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
