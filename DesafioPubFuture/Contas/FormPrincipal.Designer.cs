
namespace DesafioPubFuture.Contas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.btnContas = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.dtContas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.brnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtContas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnDespesas);
            this.panelMenu.Controls.Add(this.btnReceitas);
            this.panelMenu.Controls.Add(this.btnContas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 478);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDespesas
            // 
            this.btnDespesas.BackColor = System.Drawing.Color.Lime;
            this.btnDespesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesas.FlatAppearance.BorderSize = 2;
            this.btnDespesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDespesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDespesas.Location = new System.Drawing.Point(0, 136);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(165, 68);
            this.btnDespesas.TabIndex = 2;
            this.btnDespesas.Text = "Despesas";
            this.btnDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespesas.UseVisualStyleBackColor = false;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.BackColor = System.Drawing.Color.Lime;
            this.btnReceitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitas.FlatAppearance.BorderSize = 2;
            this.btnReceitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnReceitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReceitas.Location = new System.Drawing.Point(0, 68);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(165, 68);
            this.btnReceitas.TabIndex = 1;
            this.btnReceitas.Text = "Receitas";
            this.btnReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceitas.UseVisualStyleBackColor = false;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // btnContas
            // 
            this.btnContas.BackColor = System.Drawing.Color.Lime;
            this.btnContas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContas.FlatAppearance.BorderSize = 2;
            this.btnContas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContas.ForeColor = System.Drawing.Color.Black;
            this.btnContas.Location = new System.Drawing.Point(0, 0);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(165, 68);
            this.btnContas.TabIndex = 0;
            this.btnContas.Text = "Contas";
            this.btnContas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContas.UseVisualStyleBackColor = false;
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.dtContas);
            this.panelForm.Controls.Add(this.tableLayoutPanel1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(165, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(741, 478);
            this.panelForm.TabIndex = 1;
            // 
            // dtContas
            // 
            this.dtContas.AllowUserToAddRows = false;
            this.dtContas.AllowUserToDeleteRows = false;
            this.dtContas.AllowUserToResizeColumns = false;
            this.dtContas.AllowUserToResizeRows = false;
            this.dtContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtContas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtContas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtContas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtContas.Location = new System.Drawing.Point(12, 181);
            this.dtContas.MultiSelect = false;
            this.dtContas.Name = "dtContas";
            this.dtContas.ReadOnly = true;
            this.dtContas.RowHeadersWidth = 51;
            this.dtContas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtContas.RowTemplate.Height = 29;
            this.dtContas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtContas.Size = new System.Drawing.Size(717, 285);
            this.dtContas.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.brnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemover, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTransferir, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(184, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(80, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 30);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // brnEditar
            // 
            this.brnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brnEditar.Location = new System.Drawing.Point(180, 3);
            this.brnEditar.Name = "brnEditar";
            this.brnEditar.Size = new System.Drawing.Size(94, 30);
            this.brnEditar.TabIndex = 1;
            this.brnEditar.Text = "Editar";
            this.brnEditar.UseVisualStyleBackColor = true;
            this.brnEditar.Click += new System.EventHandler(this.brnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemover.Location = new System.Drawing.Point(80, 39);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(94, 30);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransferir.Location = new System.Drawing.Point(180, 39);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(94, 30);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 478);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.Text = "Gerenciador de finanças pessoais";
            this.panelMenu.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtContas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button brnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnTransferir;
        public System.Windows.Forms.DataGridView dtContas;
    }
}

