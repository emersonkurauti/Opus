using System;
using System.Windows.Forms;

namespace Opus.View
{
    public partial class frmCadUnidadeMedida : TelasBase.frmCadBase
    {
        public frmCadUnidadeMedida()
        {
            InitializeComponent();
            InicialiazarForm();
        }

        protected override void InicialiazarForm()
        {
            base.InicialiazarForm();
            dgvFiltro.Rows.Add(string.Empty);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cobUnidadeMedidaBindingSource.AddNew();
            base.btnNovo_Click(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cobUnidadeMedidaBindingSource.RemoveCurrent();
            base.btnExcluir_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cobUnidadeMedidaBindingSource.CancelEdit();
            this.cobUnidadeMedidaTableAdapter.Fill(this.opus_dbDataSet.cobUnidadeMedida);
            base.btnCancelar_Click(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cobUnidadeMedidaBindingSource.EndEdit();
            cobUnidadeMedidaTableAdapter.Adapter.Update(opus_dbDataSet);
            base.btnSalvar_Click(sender, e);
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
            dgvFiltro.CancelEdit();
            if (dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value == null)
            {
                return;
            }
            dgvFiltro.Rows[0].Cells["deUnidadeMedida"].Value = string.Empty;
        }

        private void dgvDados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvDados.CancelEdit();
                cobUnidadeMedidaBindingSource.CancelEdit();
                DefinirStatusBotoes(true);
            }
        }

        private void dgvDados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DefinirStatusBotoes(false);
        }
    }
}
