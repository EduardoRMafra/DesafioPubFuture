﻿using System;
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
    public partial class Despesas : Form
    {
        public Despesas()
        {
            InitializeComponent();
            dtDespesas.DataSource = BancoDados.ObterTabela("tb_despesas");
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
