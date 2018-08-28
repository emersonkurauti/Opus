using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opus.TelasBase
{
    public partial class frmCadBase : frmBase
    {
        byte byRed, byGreen, byBlue;

        public frmCadBase()
        {
            InitializeComponent();
            DefinirStatusBotoes(true);
        }

        protected virtual void InicialiazarForm()
        {
            pnFiltro.Height = 40;
            pnFormulario.Visible = false;
            pnLista.Dock = DockStyle.Fill;
        }

        protected void DefinirStatusBotoes(bool bStatusInicial)
        {
            btnCancelar.Enabled = !bStatusInicial;
            btnSalvar.Enabled = !bStatusInicial;
            btnNovo.Enabled = bStatusInicial;
            btnExcluir.Enabled = bStatusInicial;
        }

        private void pbExpRet_Click(object sender, EventArgs e)
        {
            pnFiltros.Visible = !pnFiltros.Visible;
            bool bExpandir = !pnFiltros.Visible;

            pbExpRet.Image = Properties.Resources.expandir;
            pnFiltro.Height = 40;
            if (!bExpandir)
            {
                pbExpRet.Image = Properties.Resources.retrair;
                pnFiltro.Height = 85;
            }
        }

        private void pnTitulo_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(135, 135, 135);
        }

        private void pnTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            byRed = ((Control)sender).BackColor.R;
            byGreen = ((Control)sender).BackColor.G;
            byBlue = ((Control)sender).BackColor.B;

            ((Control)sender).BackColor = Color.FromArgb(96, 96, 96);
        }

        private void pnTitulo_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(110, 110, 110);
        }

        private void pnTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(byRed, byGreen, byBlue);
        }

        private void ContentPai_MouseDown(object sender, MouseEventArgs e)
        {
            pnTitulo_MouseDown(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseUp(object sender, MouseEventArgs e)
        {
            pnTitulo_MouseUp(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseLeave(object sender, EventArgs e)
        {
            pnTitulo_MouseLeave(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseEnter(object sender, EventArgs e)
        {
            pnTitulo_MouseEnter(((Control)sender).Parent, null);
        }

        protected virtual void btnNovo_Click(object sender, EventArgs e)
        {
            DefinirStatusBotoes(false);
        }

        protected virtual void btnExcluir_Click(object sender, EventArgs e)
        {
            DefinirStatusBotoes(false);
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            DefinirStatusBotoes(true);
        }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {
            DefinirStatusBotoes(true);
        }
    }
}
