using Opus.TelasBase;
using Opus.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Opus
{
    public partial class frmMenu : Form 
    {
        private bool _bMaximizado;
        byte byRed, byGreen, byBlue;
        string nmPanelClicado;
        List<object> slTelas;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
            slTelas = new List<object>();
            AbreTela(typeof(frmPrincipal));
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

        private void AbreTela(Type poTpForm)
        {
            object oTela = null;

            foreach (object obj in slTelas)
            {
                if (obj.GetType() == poTpForm)
                {
                    oTela = obj;
                    break;
                }
            }

            if (oTela == null)
            {
                oTela = (Form)Activator.CreateInstance(poTpForm);
                slTelas.Add(oTela);
            }

            ((Form)oTela).TopLevel = false;
            ((Form)oTela).Dock = DockStyle.Fill;

            if(pnConteudo.Controls.Count > 0)
            {
                pnConteudo.Controls.RemoveAt(0);
            }

            pnConteudo.Controls.Add(((Form)oTela));
            pnConteudo.Tag = ((Form)oTela);
            ((Form)oTela).Show();

            LimparMenuClicado();
        }

        private void LimparMenuClicado()
        {
            pnUnidadesMedida.BackColor = Color.FromArgb(110, 110, 110);
            pnProdutos.BackColor = Color.FromArgb(110, 110, 110);
            pnObras.BackColor = Color.FromArgb(110, 110, 110);
            pnComodos.BackColor = Color.FromArgb(110, 110, 110);
            pnAtividades.BackColor = Color.FromArgb(110, 110, 110);
            nmPanelClicado = string.Empty;
        }

        private void lbNomeSistema_Click(object sender, EventArgs e)
        {
            AbreTela(typeof(frmPrincipal));
        }

        private void pnUnidadesMedida_Click(object sender, EventArgs e)
        {
            AbreTela(typeof(frmCadUnidadeMedida));
            pnUnidadesMedida.BackColor = Color.FromArgb(96, 96, 96);
            nmPanelClicado = pnUnidadesMedida.Name;
        }

        //Para controles pai
        private void pnButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (nmPanelClicado == ((Panel)sender).Name)
            {
                return;
            }
            byRed = ((Panel)sender).BackColor.R;
            byGreen = ((Panel)sender).BackColor.G;
            byBlue = ((Panel)sender).BackColor.B;

            ((Panel)sender).BackColor = Color.FromArgb(96, 96, 96);
        }

        private void pnButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (nmPanelClicado == ((Panel)sender).Name)
            {
                return;
            }
            ((Panel)sender).BackColor = Color.FromArgb(byRed, byGreen, byBlue);
        }

        private void pnButton_MouseLeave(object sender, EventArgs e)
        {
            if (nmPanelClicado == ((Panel)sender).Name)
            {
                return;
            }
            ((Panel)sender).BackColor = Color.FromArgb(110, 110, 110);
        }

        private void pnButton_MouseEnter(object sender, EventArgs e)
        {
            if (nmPanelClicado == ((Panel)sender).Name)
            {
                return;
            }
            ((Panel)sender).BackColor = Color.FromArgb(135, 135, 135);
        }

        //Para controles filhos
        private void ContentPai_MouseDown(object sender, MouseEventArgs e)
        {
            pnButton_MouseDown(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseUp(object sender, MouseEventArgs e)
        {
            pnButton_MouseUp(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseLeave(object sender, EventArgs e)
        {
            pnButton_MouseLeave(((Control)sender).Parent, null);
        }

        private void ContentPai_MouseEnter(object sender, EventArgs e)
        {
            pnButton_MouseEnter(((Control)sender).Parent, null);
        }

        //Itens do menu
        private void pnCadastro_Click(object sender, EventArgs e)
        {
            pnUnidadesMedida.Visible = !pnUnidadesMedida.Visible;
            pnProdutos.Visible = !pnProdutos.Visible;
            pnObras.Visible = !pnObras.Visible;
            pnComodos.Visible = !pnComodos.Visible;
            pnAtividades.Visible = !pnAtividades.Visible;
            
            TrocarIconeExpandirExtrair_MouseClick(pbExpRet, null);
        }

        private void TrocarIconeExpandirExtrair_MouseClick(object sender, MouseEventArgs e)
        {
            bool bExpandir = false;

            Panel pnCadastro = ((Panel)((Control)sender).Parent);
            Panel pnCadastros = ((Panel)pnCadastro.Parent);
            Control.ControlCollection controles = ((Control.ControlCollection)pnCadastros.Controls);

            foreach (Control coControleFilho in controles)
            {
                if (!coControleFilho.Visible)
                {
                    bExpandir = true;
                    break;
                }
            }

            ((PictureBox)sender).Image = Properties.Resources.retrair;

            if (bExpandir)
            {
                ((PictureBox)sender).Image = Properties.Resources.expandir;
            }
        }
    }
}
