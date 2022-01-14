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
    public partial class EditarReceitasForm : Form
    {
        DataTable dt = new DataTable();
        public EditarReceitasForm()
        {
            InitializeComponent();
        }
        private void btnEditarReceita_Click(object sender, EventArgs e)
        {
            if(IdReceita.Value <= 0)
            {
                IdReceita.Focus();
                MessageBox.Show("Selecione uma receita existente!");
                return;
            }
            if (nReceita.Value <= 0)
            {
                nReceita.Focus();
                MessageBox.Show("Selecione um valor de receita válida!");
                return;
            }
            if (txtDescricao.Text.Trim() == "")
            {
                txtDescricao.Focus();
                MessageBox.Show("Preencha o campo de descrição antes de pressionar o botão Editar!");
                return;
            }
            if (nConta.Value <= 0)
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
                dt = BancoDados.ComandoTabela("SELECT * FROM tb_receitas WHERE ID_Receita=" + IdReceita.Value);
                if (dt.Rows.Count == 1)
                {
                    dt = new DataTable();
                    dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_Conta=" + nConta.Value);
                    if (dt.Rows.Count == 1)
                    {
                        BancoDados.EditarReceita((int)IdReceita.Value, (double)nReceita.Value, dRecebimento.Value, dRecebimentoEsperado.Value, txtDescricao.Text, (int)nConta.Value, txtTipoReceita.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, utilize um número de conta existente!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um número de receita existente!");
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
