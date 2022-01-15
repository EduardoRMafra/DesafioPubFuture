using System;
using System.Data;
using System.Windows.Forms;

namespace DesafioPubFuture.Contas
{
    public partial class TransferenciaEntreContasForm : Form
    {
        DataTable dt = new DataTable();  //inicia um datatable que será utilizado para a consulta de informações no banco de dados
        public TransferenciaEntreContasForm()
        {
            InitializeComponent();
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            //verifica todos os campos para ver se estão devidamente preenchidos e mostra um aviso caso não esteja.
            try
            {
                if(nDaConta.Value <= 0)
                {
                    nDaConta.Focus();
                    MessageBox.Show("Insira um número de conta válido, de onde sera retirado o dinheiro da transferência!");
                    return;
                }
                if (nParaConta.Value <= 0)
                {
                    MessageBox.Show("Insira um número de conta válido, para onde sera transferido o dinheiro!");
                    return;
                }

                dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_Conta=" + nDaConta.Value); //verifica se a conta que vai realizar a transferencia existe no banco de dados
                if (dt.Rows.Count == 1)
                {
                    if(double.Parse(dt.Rows[0][1].ToString()) < (double)nValor.Value)   ////verifica se a conta possui saldo o suficiente para realizar a transferência
                    {
                        MessageBox.Show("O saldo da conta escolhida é insuficiente!");
                        return;
                    }
                    dt = new DataTable();
                    dt = BancoDados.ComandoTabela("SELECT * FROM tb_contas WHERE ID_Conta=" + nParaConta.Value);    //verifica se a conta que vai receber a transferência existe no banco de dados
                    if (dt.Rows.Count == 1)
                    {
                        BancoDados.Transferencia((int)nDaConta.Value, (int)nParaConta.Value, (double)nValor.Value); //realiza a transferência
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Insira um número de conta válido, para onde sera transferido o dinheiro!");
                    }
                }
                else
                {
                    MessageBox.Show("Insira um número de conta válido, de onde sera retirado o dinheiro da transferência!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
