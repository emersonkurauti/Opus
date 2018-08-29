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

        private void frmCadUnidadeMedida_Load(object sender, EventArgs e)
        {
            dtDados = this.opus_dbDataSet.cobUnidadeMedida;
            TableAdapter = this.cobUnidadeMedidaTableAdapter;
            oAdapter = this.cobUnidadeMedidaTableAdapter.Adapter;
            tpTableAdapter = typeof(Opus_dbDataSetTableAdapters.cobUnidadeMedidaTableAdapter);
            oBindingSource = cobUnidadeMedidaBindingSource;
            oDataSet = opus_dbDataSet;
            CarregarObjetos();
        }

        protected override void InicialiazarForm()
        {
            base.InicialiazarForm();
            dgvFiltro.Rows.Add(string.Empty);
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
