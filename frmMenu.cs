using Opus.TelasBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opus
{
    public partial class frmMenu : Form
    {
        private bool _bMaximizado;

        private void AtualizarIconeMaximize()
        {
            pbMaximize.Image = Properties.Resources.Maximize;

            if (_bMaximizado)
                pbMaximize.Image = Properties.Resources.exitMaximize;
        }

        public frmMenu()
        {
            InitializeComponent();
            _bMaximizado = this.WindowState == FormWindowState.Maximized;

            AtualizarIconeMaximize();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (_bMaximizado)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            _bMaximizado = !_bMaximizado;
            AtualizarIconeMaximize();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTopo_DoubleClick(object sender, EventArgs e)
        {
            pbMaximize_Click(null, null);
        }

        private void lbNomeSistema_Click(object sender, EventArgs e)
        {
            frmBase frm = new frmBase();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
        
            pnConteudo.Controls.Add(frm);
            pnConteudo.Tag = frm;
            frm.Show();
        }
    }
}
