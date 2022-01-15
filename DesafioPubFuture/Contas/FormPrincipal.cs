using System;
using System.Drawing;
using System.Windows.Forms;
using DesafioPubFuture.Receitas;
using DesafioPubFuture.Despesas;

namespace DesafioPubFuture.Contas
{
    public partial class FormPrincipal : Form
    {

        Form FrmAtivo;                       //indica a pagina que o usuario está no momento (Contas, Receitas, Despesas)
        public FormPrincipal()
        {
            InitializeComponent();
            btnContas.BackColor = Color.Yellow; //Muda a cor do botão Contas para mostrar que está selecionado
            BancoDados.GetFormPrincipal(this);  //envia ao banco de dados acesso ao FormPrincipal
            dtContas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_contas");  //atualiza a tabela com informações no banco de dados
        }

        void MostrarForm(Form frm)
        {
            FecharFormAtivo();
            FrmAtivo = frm;
            frm.TopLevel = false;           //permite colocar o form no painel
            frm.Dock = DockStyle.Fill;      //permite o form ser responsivo
            panelForm.Controls.Add(frm);    //coloca o form no painel
            frm.BringToFront();             //traz o form para frente
            frm.Show();                     //mostra o form
        }

        void FecharFormAtivo()              //caso algum form estiver aberto fecha
        {
            if(FrmAtivo != null)
            {
                FrmAtivo.Close();
            }
        }
        void BtnAtivo(Button frmAtivo)  //Coloca todos os botões do menu para a cor padrao e muda a cor do botão selecionado
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                ctrl.BackColor = Color.Lime;
            }
            frmAtivo.BackColor = Color.Yellow;
        }
        private void btnContas_Click(object sender, EventArgs e)    //fecha os outros forms
        {
            BtnAtivo(btnContas);
            FecharFormAtivo();
        }

        private void btnReceitas_Click(object sender, EventArgs e)  //fecha o form despesa caso aberto e ativa o receitas
        {
            BtnAtivo(btnReceitas);
            FecharFormAtivo();
            MostrarForm(new ReceitasForm());
        }

        private void btnDespesas_Click(object sender, EventArgs e)  //fecha o form receitas caso aberto e ativa o despesa
        {
            BtnAtivo(btnDespesas);
            FecharFormAtivo();
            MostrarForm(new DespesasForm());
        }

        //Ao clicar nos botões abre uma nova janela para realizar a operação escolhida
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroContasForm c = new CadastroContasForm();
            c.ShowDialog();
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            EditarContasForm ed = new EditarContasForm();
            ed.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverContasForm r = new RemoverContasForm();
            r.ShowDialog();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            TransferenciaEntreContasForm t = new TransferenciaEntreContasForm();
            t.ShowDialog();
        }
    }
}
