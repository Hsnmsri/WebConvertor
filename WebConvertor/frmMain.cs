using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebConvertor.Classes;

namespace WebConvertor
{
    public partial class frmMain : Form
    {
        Color colorTheme1 = Color.FromArgb(255, 206, 26, 81);
        Color colorTheme2 = Color.FromArgb(255, 223, 223, 223);
        Color colorTheme3 = Color.FromArgb(255, 255, 255, 255);
        double rootSize;
        double pixelSize;
        double remSize;
        double emRootSize;
        double emSize;
        double percentSize;
        double pointSize;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtpx_TextChanged(sender, e);
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            frmMain frmMainNew = new frmMain();
            frmMainNew.ShowDialog();
        }

        private void txtRootSize_TextChanged(object sender, EventArgs e)
        {
            if (txtRootSize.Text != "")
            {
                rootSize = txtRootSize.Text.PointToDecimalPoint().ToDoubleType();
                pixelSize = remSize * rootSize;
                txtpx.Text = pixelSize.PointToDecimalPoint(true);
            }
        }

        private void txtpx_TextChanged(object sender, EventArgs e)
        {
            if (txtpx.Text != "")
            {
                rootSize = txtRootSize.Text.PointToDecimalPoint().ToDoubleType();
                emRootSize = txtEmRoot.Text.PointToDecimalPoint().ToDoubleType();
                pixelSize = txtpx.Text.PointToDecimalPoint().ToDoubleType();
                remSize = pixelSize / rootSize;
                emSize = pixelSize / emRootSize;
                percentSize = pixelSize / rootSize * 100;
                txtRem.Text = remSize.PointToDecimalPoint(true);
                txtEm.Text = emSize.PointToDecimalPoint(true);
                txtPercent.Text = percentSize.PointToDecimalPoint(true);
            }
        }

        private void txtRem_TextChanged(object sender, EventArgs e)
        {
            if (txtRem.Text != "")
            {
                remSize = txtRem.Text.PointToDecimalPoint().ToDoubleType();
                pixelSize = remSize * rootSize;
                txtpx.Text = pixelSize.PointToDecimalPoint(true);
            }
        }

        private void txtEmRoot_TextChanged(object sender, EventArgs e)
        {
            if (txtEmRoot.Text != "")
            {
                emRootSize = txtEmRoot.Text.PointToDecimalPoint().ToDoubleType();
                emSize = pixelSize / emRootSize;
                txtEm.Text = emSize.PointToDecimalPoint(true);
            }
        }

        private void txtEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            if (txtPercent.Text != "")
            {
                percentSize = txtPercent.Text.PointToDecimalPoint().ToDoubleType();
                pixelSize = (percentSize / 100) * rootSize;
                txtpx.Text = pixelSize.PointToDecimalPoint(true);
            }
        }

        private void lblCopypx_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtpx.Text + "px");
        }

        private void lblCopyRem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRem.Text + "rem");
        }

        private void lblCopyEm_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEm.Text + "em");
        }

        private void lblCopyPercent_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPercent.Text + "%");
        }
    }
}
