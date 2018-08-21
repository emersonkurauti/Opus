using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opus.View
{
    public partial class frmCadUnidadeMedida : Opus.TelasBase.frmBase
    {
        byte byRed, byGreen, byBlue;

        public frmCadUnidadeMedida()
        {
            InitializeComponent();
            pnLista.Dock = DockStyle.Fill;
            pnFormulario.Visible = false;
            pnFiltro.Height = 40;
            dgvFiltro.Rows.Add(string.Empty);
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

        private void frmCadUnidadeMedida_Load(object sender, EventArgs e)
        {
            this.cobUnidadeMedidaTableAdapter.Fill(this.opus_dbDataSet.cobUnidadeMedida);
        }

        private void FiltrarRegistros()
        {
            cobUnidadeMedidaBindingSource.Filter = string.Empty;

            if (dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value == null)
            {
                return;
            }

            if (dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value.ToString() == string.Empty)
            {
                return;
            }
            cobUnidadeMedidaBindingSource.Filter = "deUnidadeMedida like '%" + dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value.ToString() + "%'";
        }

        private void dgvFiltro_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            FiltrarRegistros();
        }

        private void dgvFiltro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            FiltrarRegistros();
        }

        private void pbLimparFiltro_Click(object sender, EventArgs e)
        {
            cobUnidadeMedidaBindingSource.Filter = string.Empty;
            if (dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value == null)
            {
                return;
            }
            dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value = string.Empty;
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
    }
}
