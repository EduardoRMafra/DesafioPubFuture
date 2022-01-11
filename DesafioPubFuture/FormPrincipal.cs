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
    public partial class FormPrincipal : Form
    {

        Form FrmAtivo;  //indica a pagina que o usuario está no momento (Contas, Receitas, Despesas)
        public FormPrincipal()
        {
            InitializeComponent();
            btnContas.BackColor = Color.Yellow;
        }

        void MostrarForm(Form frm)
        {
            FecharFormAtivo();
            FrmAtivo = frm;
            frm.TopLevel = false;       //permite colocar o form no painel
            frm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(frm);    //coloca o form no painel
            frm.Show(); //mostra o form
            frm.BringToFront(); //traz o form para frente
        }

        void FecharFormAtivo()
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
        private void btnContas_Click(object sender, EventArgs e)
        {
            BtnAtivo(btnContas);
            FecharFormAtivo();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            BtnAtivo(btnReceitas);
            FecharFormAtivo();
            MostrarForm(new Receitas());
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            BtnAtivo(btnDespesas);
            FecharFormAtivo();
            MostrarForm(new Despesas());
        }
    }
}
