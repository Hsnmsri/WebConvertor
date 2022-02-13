using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebConvertor
{
    public partial class frmMain : Form
    {
        Color colorTheme1 = Color.FromArgb(255, 206, 26, 81);
        Color colorTheme2 = Color.FromArgb(255, 223, 223, 223);
        Color colorTheme3 = Color.FromArgb(255, 255, 255, 255);
        public frmMain()
        {
            InitializeComponent();
        }
        private void SetStyleForm()
        {
            //this.BackColor = colorTheme2;
            //// Panel theme
            //pnlMenuBar.BackColor = colorTheme1;
            //pnlToRem.BackColor = colorTheme1;
            //pnlToEm.BackColor = colorTheme1;
            //pnlTopt.BackColor = colorTheme1;
            //pnlToPercent.BackColor = colorTheme1;
            //// Textbox theme
            //txtRootSize.BackColor=colorTheme1;
            //txtRootSize.BorderStyle = BorderStyle.None;
            //txtRootSize.ForeColor = colorTheme3;

            //txtPx.BackColor=colorTheme1;
            //txtPx.BorderStyle = BorderStyle.None;
            //txtPx.ForeColor = colorTheme3;

            //txtFrameName.BackColor = colorTheme1;
            //txtFrameName.BorderStyle = BorderStyle.None;
            //txtFrameName.ForeColor = colorTheme3;
            //txtrem.BackColor = colorTheme1;
            //txtrem.BorderStyle = BorderStyle.None;
            //txtrem.ForeColor = colorTheme3;
            //txtem.BackColor = colorTheme1;
            //txtem.BorderStyle = BorderStyle.None;
            //txtem.ForeColor = colorTheme3;
            //txtemRoot.BackColor = colorTheme1;
            //txtemRoot.BorderStyle = BorderStyle.None;
            //txtemRoot.ForeColor = colorTheme3;
            //txtpt.BackColor = colorTheme1;
            //txtpt.BorderStyle = BorderStyle.None;
            //txtpt.ForeColor = colorTheme3;
            //txtPercent.BackColor = colorTheme1;
            //txtPercent.BorderStyle = BorderStyle.None;
            //txtPercent.ForeColor = colorTheme3;
            //// Label theme
            //lblRootSize.ForeColor = colorTheme3;
            //lblrem.ForeColor = colorTheme3;
            //lblem.ForeColor = colorTheme3;
            //lblpt.ForeColor = colorTheme3;
            //lblpercent.ForeColor = colorTheme3;
            //lblCopyem.ForeColor = colorTheme3;
            //lblCopyPercent.ForeColor = colorTheme3;
            //lblCopypt.ForeColor = colorTheme3;
            //lblCopyrem.ForeColor = colorTheme3;
            //lblemroot.ForeColor = colorTheme3;
            //lblNew.ForeColor = colorTheme1;
            //lblAdd.ForeColor = colorTheme1;
            //lblCopyright.ForeColor = colorTheme1;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            frmMain frmMainNew = new frmMain();
            frmMainNew.ShowDialog();
        }

        private void txtRootSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
