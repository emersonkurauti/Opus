namespace Opus
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnTopo = new System.Windows.Forms.Panel();
            this.blNomeJanela = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnCadastros = new System.Windows.Forms.Panel();
            this.pnComodos = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnAtividades = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pbExpRet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbNomeSistema = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnConteudo = new System.Windows.Forms.Panel();
            this.pnObras = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnProdutos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnUnidadesMedida = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnCadastros.SuspendLayout();
            this.pnComodos.SuspendLayout();
            this.pnAtividades.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpRet)).BeginInit();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnObras.SuspendLayout();
            this.pnProdutos.SuspendLayout();
            this.pnUnidadesMedida.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnTopo.Controls.Add(this.blNomeJanela);
            this.pnTopo.Controls.Add(this.pbMinimize);
            this.pnTopo.Controls.Add(this.pbMaximize);
            this.pnTopo.Controls.Add(this.pbClose);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(800, 31);
            this.pnTopo.TabIndex = 0;
            this.pnTopo.DoubleClick += new System.EventHandler(this.pnTopo_DoubleClick);
            // 
            // blNomeJanela
            // 
            this.blNomeJanela.Dock = System.Windows.Forms.DockStyle.Left;
            this.blNomeJanela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blNomeJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.blNomeJanela.Location = new System.Drawing.Point(0, 0);
            this.blNomeJanela.Name = "blNomeJanela";
            this.blNomeJanela.Size = new System.Drawing.Size(180, 31);
            this.blNomeJanela.TabIndex = 3;
            this.blNomeJanela.Text = "Gerenciamento de obras";
            this.blNomeJanela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::Opus.Properties.Resources.Minimize;
            this.pbMinimize.Location = new System.Drawing.Point(714, 3);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 2;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximize.Image")));
            this.pbMaximize.Location = new System.Drawing.Point(742, 3);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(25, 25);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximize.TabIndex = 1;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Opus.Properties.Resources.Cancel;
            this.pbClose.Location = new System.Drawing.Point(770, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // scMenu
            // 
            this.scMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 31);
            this.scMenu.Name = "scMenu";
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.scMenu.Panel1.Controls.Add(this.pnMenu);
            this.scMenu.Panel1.Controls.Add(this.pnLogo);
            this.scMenu.Panel1MinSize = 50;
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.scMenu.Panel2.Controls.Add(this.pnConteudo);
            this.scMenu.Size = new System.Drawing.Size(800, 504);
            this.scMenu.SplitterDistance = 189;
            this.scMenu.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Controls.Add(this.pnCadastros);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 43);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(189, 461);
            this.pnMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.panel1.Size = new System.Drawing.Size(189, 40);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Controle";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label2.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 38);
            this.panel7.TabIndex = 0;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel7.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel7.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnCadastros
            // 
            this.pnCadastros.AutoSize = true;
            this.pnCadastros.Controls.Add(this.pnUnidadesMedida);
            this.pnCadastros.Controls.Add(this.pnProdutos);
            this.pnCadastros.Controls.Add(this.pnObras);
            this.pnCadastros.Controls.Add(this.pnComodos);
            this.pnCadastros.Controls.Add(this.pnAtividades);
            this.pnCadastros.Controls.Add(this.pnCadastro);
            this.pnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCadastros.Location = new System.Drawing.Point(0, 0);
            this.pnCadastros.Name = "pnCadastros";
            this.pnCadastros.Size = new System.Drawing.Size(189, 190);
            this.pnCadastros.TabIndex = 3;
            // 
            // pnComodos
            // 
            this.pnComodos.Controls.Add(this.label4);
            this.pnComodos.Controls.Add(this.panel6);
            this.pnComodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnComodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnComodos.Location = new System.Drawing.Point(0, 70);
            this.pnComodos.Name = "pnComodos";
            this.pnComodos.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnComodos.Size = new System.Drawing.Size(189, 30);
            this.pnComodos.TabIndex = 5;
            this.pnComodos.Visible = false;
            this.pnComodos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnComodos.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnComodos.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnComodos.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnComodos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cômodos...";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label4.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(10, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 28);
            this.panel6.TabIndex = 0;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel6.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel6.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnAtividades
            // 
            this.pnAtividades.Controls.Add(this.label3);
            this.pnAtividades.Controls.Add(this.panel4);
            this.pnAtividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAtividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAtividades.Location = new System.Drawing.Point(0, 40);
            this.pnAtividades.Name = "pnAtividades";
            this.pnAtividades.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnAtividades.Size = new System.Drawing.Size(189, 30);
            this.pnAtividades.TabIndex = 4;
            this.pnAtividades.Visible = false;
            this.pnAtividades.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnAtividades.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnAtividades.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnAtividades.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnAtividades.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Atividades...";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label3.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 28);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel4.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.pbExpRet);
            this.pnCadastro.Controls.Add(this.label1);
            this.pnCadastro.Controls.Add(this.panel2);
            this.pnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCadastro.Location = new System.Drawing.Point(0, 0);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.pnCadastro.Size = new System.Drawing.Size(189, 40);
            this.pnCadastro.TabIndex = 3;
            this.pnCadastro.Click += new System.EventHandler(this.pnCadastro_Click);
            this.pnCadastro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnCadastro.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnCadastro.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnCadastro.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnCadastro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // pbExpRet
            // 
            this.pbExpRet.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbExpRet.Image = global::Opus.Properties.Resources.expandir;
            this.pbExpRet.Location = new System.Drawing.Point(148, 1);
            this.pbExpRet.Name = "pbExpRet";
            this.pbExpRet.Size = new System.Drawing.Size(40, 38);
            this.pbExpRet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExpRet.TabIndex = 5;
            this.pbExpRet.TabStop = false;
            this.pbExpRet.Click += new System.EventHandler(this.pnCadastro_Click);
            this.pbExpRet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrocarIconeExpandirExtrair_MouseClick);
            this.pbExpRet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.pbExpRet.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.pbExpRet.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.pbExpRet.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.pbExpRet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastros";
            this.label1.Click += new System.EventHandler(this.pnCadastro_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 38);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.pnCadastro_Click);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.pnLogo.Controls.Add(this.lbNomeSistema);
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(189, 43);
            this.pnLogo.TabIndex = 0;
            // 
            // lbNomeSistema
            // 
            this.lbNomeSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNomeSistema.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lbNomeSistema.Location = new System.Drawing.Point(63, 0);
            this.lbNomeSistema.Name = "lbNomeSistema";
            this.lbNomeSistema.Size = new System.Drawing.Size(126, 43);
            this.lbNomeSistema.TabIndex = 1;
            this.lbNomeSistema.Text = "Opus";
            this.lbNomeSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNomeSistema.Click += new System.EventHandler(this.lbNomeSistema_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(63, 43);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnConteudo
            // 
            this.pnConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnConteudo.Location = new System.Drawing.Point(0, 0);
            this.pnConteudo.Name = "pnConteudo";
            this.pnConteudo.Size = new System.Drawing.Size(607, 504);
            this.pnConteudo.TabIndex = 0;
            // 
            // pnObras
            // 
            this.pnObras.Controls.Add(this.label5);
            this.pnObras.Controls.Add(this.panel5);
            this.pnObras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnObras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnObras.Location = new System.Drawing.Point(0, 100);
            this.pnObras.Name = "pnObras";
            this.pnObras.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnObras.Size = new System.Drawing.Size(189, 30);
            this.pnObras.TabIndex = 8;
            this.pnObras.Visible = false;
            this.pnObras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnObras.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnObras.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnObras.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnObras.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(21, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Obras...";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label5.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(10, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 28);
            this.panel5.TabIndex = 0;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel5.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel5.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnProdutos
            // 
            this.pnProdutos.Controls.Add(this.label6);
            this.pnProdutos.Controls.Add(this.panel9);
            this.pnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnProdutos.Location = new System.Drawing.Point(0, 130);
            this.pnProdutos.Name = "pnProdutos";
            this.pnProdutos.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnProdutos.Size = new System.Drawing.Size(189, 30);
            this.pnProdutos.TabIndex = 9;
            this.pnProdutos.Visible = false;
            this.pnProdutos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnProdutos.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnProdutos.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnProdutos.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnProdutos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(21, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Produtos...";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label6.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label6.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(10, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 0;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel9.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel9.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // pnUnidadesMedida
            // 
            this.pnUnidadesMedida.Controls.Add(this.label7);
            this.pnUnidadesMedida.Controls.Add(this.panel11);
            this.pnUnidadesMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnUnidadesMedida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUnidadesMedida.Location = new System.Drawing.Point(0, 160);
            this.pnUnidadesMedida.Name = "pnUnidadesMedida";
            this.pnUnidadesMedida.Padding = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.pnUnidadesMedida.Size = new System.Drawing.Size(189, 30);
            this.pnUnidadesMedida.TabIndex = 10;
            this.pnUnidadesMedida.Visible = false;
            this.pnUnidadesMedida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseDown);
            this.pnUnidadesMedida.MouseEnter += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnUnidadesMedida.MouseLeave += new System.EventHandler(this.pnButton_MouseLeave);
            this.pnUnidadesMedida.MouseHover += new System.EventHandler(this.pnButton_MouseEnter);
            this.pnUnidadesMedida.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnButton_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(21, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unidades de medida...";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.label7.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(10, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 0;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseDown);
            this.panel11.MouseEnter += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel11.MouseLeave += new System.EventHandler(this.ContentPai_MouseLeave);
            this.panel11.MouseHover += new System.EventHandler(this.ContentPai_MouseEnter);
            this.panel11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContentPai_MouseUp);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.scMenu);
            this.Controls.Add(this.pnTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opus";
            this.pnTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnCadastros.ResumeLayout(false);
            this.pnComodos.ResumeLayout(false);
            this.pnComodos.PerformLayout();
            this.pnAtividades.ResumeLayout(false);
            this.pnAtividades.PerformLayout();
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpRet)).EndInit();
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnObras.ResumeLayout(false);
            this.pnObras.PerformLayout();
            this.pnProdutos.ResumeLayout(false);
            this.pnProdutos.PerformLayout();
            this.pnUnidadesMedida.ResumeLayout(false);
            this.pnUnidadesMedida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.Label blNomeJanela;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbNomeSistema;
        private System.Windows.Forms.Panel pnConteudo;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnCadastros;
        private System.Windows.Forms.Panel pnComodos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnAtividades;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbExpRet;
        private System.Windows.Forms.Panel pnUnidadesMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnObras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
    }
}

