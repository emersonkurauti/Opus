namespace Opus.TelasBase
{
    partial class frmCadBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnFiltro = new System.Windows.Forms.Panel();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.pbLimparFiltro = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbExpRet = new System.Windows.Forms.PictureBox();
            this.pnControle = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pnLista = new System.Windows.Forms.Panel();
            this.pnFormulario = new System.Windows.Forms.Panel();
            this.pnFiltro.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpRet)).BeginInit();
            this.pnControle.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnFiltro.Controls.Add(this.pnFiltros);
            this.pnFiltro.Controls.Add(this.pnTitulo);
            this.pnFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnFiltro.Name = "pnFiltro";
            this.pnFiltro.Size = new System.Drawing.Size(710, 85);
            this.pnFiltro.TabIndex = 2;
            // 
            // pnFiltros
            // 
            this.pnFiltros.AutoSize = true;
            this.pnFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFiltros.Location = new System.Drawing.Point(0, 40);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(710, 45);
            this.pnFiltros.TabIndex = 1;
            this.pnFiltros.Visible = false;
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnTitulo.Controls.Add(this.pbLimparFiltro);
            this.pnTitulo.Controls.Add(this.label3);
            this.pnTitulo.Controls.Add(this.pbExpRet);
            this.pnTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(710, 40);
            this.pnTitulo.TabIndex = 0;
            this.pnTitulo.Click += new System.EventHandler(this.pbExpRet_Click);
            this.pnTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitulo_MouseDown);
            this.pnTitulo.MouseEnter += new System.EventHandler(this.pnTitulo_MouseEnter);
            this.pnTitulo.MouseLeave += new System.EventHandler(this.pnTitulo_MouseLeave);
            this.pnTitulo.MouseHover += new System.EventHandler(this.pnTitulo_MouseEnter);
            this.pnTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTitulo_MouseUp);
            // 
            // pbLimparFiltro
            // 
            this.pbLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimparFiltro.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbLimparFiltro.Image = global::Opus.Properties.Resources.borracha;
            this.pbLimparFiltro.Location = new System.Drawing.Point(670, 0);
            this.pbLimparFiltro.Name = "pbLimparFiltro";
            this.pbLimparFiltro.Size = new System.Drawing.Size(40, 40);
            this.pbLimparFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimparFiltro.TabIndex = 12;
            this.pbLimparFiltro.TabStop = false;
            this.pbLimparFiltro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitulo_MouseDown);
            this.pbLimparFiltro.MouseEnter += new System.EventHandler(this.pnTitulo_MouseEnter);
            this.pbLimparFiltro.MouseLeave += new System.EventHandler(this.pnTitulo_MouseLeave);
            this.pbLimparFiltro.MouseHover += new System.EventHandler(this.pnTitulo_MouseEnter);
            this.pbLimparFiltro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTitulo_MouseUp);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mostrar filtros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.pbExpRet_Click);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label3.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pbExpRet
            // 
            this.pbExpRet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExpRet.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbExpRet.Image = global::Opus.Properties.Resources.expandir;
            this.pbExpRet.Location = new System.Drawing.Point(0, 0);
            this.pbExpRet.Name = "pbExpRet";
            this.pbExpRet.Size = new System.Drawing.Size(40, 40);
            this.pbExpRet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExpRet.TabIndex = 9;
            this.pbExpRet.TabStop = false;
            this.pbExpRet.Click += new System.EventHandler(this.pbExpRet_Click);
            this.pbExpRet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.pbExpRet.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.pbExpRet.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.pbExpRet.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.pbExpRet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnControle
            // 
            this.pnControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnControle.Controls.Add(this.btnSalvar);
            this.pnControle.Controls.Add(this.btnCancelar);
            this.pnControle.Controls.Add(this.btnExcluir);
            this.pnControle.Controls.Add(this.btnNovo);
            this.pnControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnControle.Location = new System.Drawing.Point(0, 85);
            this.pnControle.Name = "pnControle";
            this.pnControle.Size = new System.Drawing.Size(710, 30);
            this.pnControle.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Opus.Properties.Resources.Salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(300, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Opus.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(200, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Opus.Properties.Resources.Excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(100, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::Opus.Properties.Resources.Add;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Adicionar";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.pnLista);
            this.pnCadastro.Controls.Add(this.pnFormulario);
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastro.Location = new System.Drawing.Point(0, 115);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(710, 276);
            this.pnCadastro.TabIndex = 9;
            // 
            // pnLista
            // 
            this.pnLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLista.Location = new System.Drawing.Point(0, 0);
            this.pnLista.Name = "pnLista";
            this.pnLista.Size = new System.Drawing.Size(357, 276);
            this.pnLista.TabIndex = 5;
            // 
            // pnFormulario
            // 
            this.pnFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFormulario.Location = new System.Drawing.Point(360, 0);
            this.pnFormulario.Name = "pnFormulario";
            this.pnFormulario.Size = new System.Drawing.Size(350, 276);
            this.pnFormulario.TabIndex = 4;
            // 
            // frmCadBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.pnCadastro);
            this.Controls.Add(this.pnControle);
            this.Controls.Add(this.pnFiltro);
            this.Name = "frmCadBase";
            this.pnFiltro.ResumeLayout(false);
            this.pnFiltro.PerformLayout();
            this.pnTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLimparFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpRet)).EndInit();
            this.pnControle.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnFiltro;
        public System.Windows.Forms.Panel pnFiltros;
        public System.Windows.Forms.Panel pnTitulo;
        public System.Windows.Forms.PictureBox pbLimparFiltro;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pbExpRet;
        public System.Windows.Forms.Panel pnControle;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Panel pnCadastro;
        public System.Windows.Forms.Panel pnLista;
        public System.Windows.Forms.Panel pnFormulario;
    }
}
