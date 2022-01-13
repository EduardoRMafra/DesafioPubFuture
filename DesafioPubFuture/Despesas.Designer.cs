
namespace DesafioPubFuture
{
    partial class Despesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDespesas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.brnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDespesas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDespesas
            // 
            this.dtDespesas.AllowUserToAddRows = false;
            this.dtDespesas.AllowUserToDeleteRows = false;
            this.dtDespesas.AllowUserToResizeColumns = false;
            this.dtDespesas.AllowUserToResizeRows = false;
            this.dtDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDespesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDespesas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDespesas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDespesas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtDespesas.Location = new System.Drawing.Point(12, 181);
            this.dtDespesas.MultiSelect = false;
            this.dtDespesas.Name = "dtDespesas";
            this.dtDespesas.ReadOnly = true;
            this.dtDespesas.RowHeadersWidth = 51;
            this.dtDespesas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtDespesas.RowTemplate.Height = 29;
            this.dtDespesas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtDespesas.Size = new System.Drawing.Size(717, 285);
            this.dtDespesas.TabIndex = 5;
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
            this.tableLayoutPanel1.TabIndex = 4;
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
            // 
            // btnTransferir
            // 
            this.btnTransferir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransferir.Location = new System.Drawing.Point(180, 39);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(94, 30);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Filtrar";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 478);
            this.Controls.Add(this.dtDespesas);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Despesas";
            this.Text = "Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.dtDespesas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDespesas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button brnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnTransferir;
    }
}