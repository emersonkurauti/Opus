using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Opus.TelasBase
{
    public partial class frmCadBase : frmBase
    {
        private byte byRed, byGreen, byBlue;

        protected object TableAdapter;
        protected object oAdapter;
        protected BindingSource oBindingSource;
        protected Type tpTableAdapter;
        protected DataTable dtDados;
        protected Opus_dbDataSet oDataSet;

        public frmCadBase()
        {
            InitializeComponent();
            DefinirStatusBotoes(true);
        }

        protected virtual void CarregarObjetos()
        {
            MethodInfo oMetodo = tpTableAdapter.GetMethod("Fill");
            oMetodo.Invoke(TableAdapter, new object[] { dtDados });
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
            oBindingSource.AddNew();
            DefinirStatusBotoes(false);
        }

        protected virtual void btnExcluir_Click(object sender, EventArgs e)
        {
            oBindingSource.RemoveCurrent();
            DefinirStatusBotoes(false);
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            oBindingSource.CancelEdit();
            CarregarObjetos();
            DefinirStatusBotoes(true);
        }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {
            oBindingSource.EndEdit();
            MethodInfo oMetodo = oAdapter.GetType().GetMethod("Update", new Type[] { typeof(DataSet) });
            oMetodo.Invoke(oAdapter, new object[] { oDataSet });            
            DefinirStatusBotoes(true);
        }
    }
}
