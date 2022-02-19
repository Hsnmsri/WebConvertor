namespace WebConvertor
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrameName = new System.Windows.Forms.TextBox();
            this.txtRootSize = new System.Windows.Forms.TextBox();
            this.lblRootSize = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblRootUnit = new System.Windows.Forms.Label();
            this.txtpx = new System.Windows.Forms.TextBox();
            this.lblCopypx = new System.Windows.Forms.Label();
            this.lblpx = new System.Windows.Forms.Label();
            this.lblCopyRem = new System.Windows.Forms.Label();
            this.lblrem = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.lblCopyEm = new System.Windows.Forms.Label();
            this.lblem = new System.Windows.Forms.Label();
            this.txtEmRoot = new System.Windows.Forms.TextBox();
            this.lblCopyPercent = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.lblemRoot = new System.Windows.Forms.Label();
            this.lblNewWindow = new System.Windows.Forms.Label();
            this.lblCopyPt = new System.Windows.Forms.Label();
            this.lblPt = new System.Windows.Forms.Label();
            this.txtpt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFrameName
            // 
            this.txtFrameName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFrameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrameName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrameName.Location = new System.Drawing.Point(11, 11);
            this.txtFrameName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrameName.Name = "txtFrameName";
            this.txtFrameName.Size = new System.Drawing.Size(141, 27);
            this.txtFrameName.TabIndex = 1;
            this.txtFrameName.Text = "FrameName";
            // 
            // txtRootSize
            // 
            this.txtRootSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRootSize.Location = new System.Drawing.Point(279, 17);
            this.txtRootSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtRootSize.Name = "txtRootSize";
            this.txtRootSize.Size = new System.Drawing.Size(43, 25);
            this.txtRootSize.TabIndex = 1;
            this.txtRootSize.Text = "16";
            this.txtRootSize.TextChanged += new System.EventHandler(this.txtRootSize_TextChanged);
            // 
            // lblRootSize
            // 
            this.lblRootSize.AutoSize = true;
            this.lblRootSize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRootSize.Location = new System.Drawing.Point(210, 20);
            this.lblRootSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRootSize.Name = "lblRootSize";
            this.lblRootSize.Size = new System.Drawing.Size(65, 19);
            this.lblRootSize.TabIndex = 2;
            this.lblRootSize.Text = "Root Size";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(8, 350);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(180, 13);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "© copyright 2022 by Mr Mansouri";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblAdd.Location = new System.Drawing.Point(319, 347);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(27, 20);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblRootUnit
            // 
            this.lblRootUnit.AutoSize = true;
            this.lblRootUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRootUnit.Location = new System.Drawing.Point(326, 20);
            this.lblRootUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRootUnit.Name = "lblRootUnit";
            this.lblRootUnit.Size = new System.Drawing.Size(23, 19);
            this.lblRootUnit.TabIndex = 2;
            this.lblRootUnit.Text = "px";
            // 
            // txtpx
            // 
            this.txtpx.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpx.Location = new System.Drawing.Point(52, 78);
            this.txtpx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpx.Name = "txtpx";
            this.txtpx.Size = new System.Drawing.Size(254, 43);
            this.txtpx.TabIndex = 3;
            this.txtpx.Text = "16";
            this.txtpx.TextChanged += new System.EventHandler(this.txtpx_TextChanged);
            // 
            // lblCopypx
            // 
            this.lblCopypx.AutoSize = true;
            this.lblCopypx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopypx.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblCopypx.Location = new System.Drawing.Point(317, 93);
            this.lblCopypx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopypx.Name = "lblCopypx";
            this.lblCopypx.Size = new System.Drawing.Size(29, 20);
            this.lblCopypx.TabIndex = 2;
            this.lblCopypx.Text = "copy";
            this.lblCopypx.Click += new System.EventHandler(this.lblCopypx_Click);
            // 
            // lblpx
            // 
            this.lblpx.AutoSize = true;
            this.lblpx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpx.Location = new System.Drawing.Point(11, 93);
            this.lblpx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpx.Name = "lblpx";
            this.lblpx.Size = new System.Drawing.Size(23, 19);
            this.lblpx.TabIndex = 2;
            this.lblpx.Text = "px";
            // 
            // lblCopyRem
            // 
            this.lblCopyRem.AutoSize = true;
            this.lblCopyRem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyRem.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblCopyRem.Location = new System.Drawing.Point(317, 144);
            this.lblCopyRem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyRem.Name = "lblCopyRem";
            this.lblCopyRem.Size = new System.Drawing.Size(29, 20);
            this.lblCopyRem.TabIndex = 2;
            this.lblCopyRem.Text = "copy";
            this.lblCopyRem.Click += new System.EventHandler(this.lblCopyRem_Click);
            // 
            // lblrem
            // 
            this.lblrem.AutoSize = true;
            this.lblrem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrem.Location = new System.Drawing.Point(11, 144);
            this.lblrem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrem.Name = "lblrem";
            this.lblrem.Size = new System.Drawing.Size(36, 19);
            this.lblrem.TabIndex = 2;
            this.lblrem.Text = "Rem";
            // 
            // txtRem
            // 
            this.txtRem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRem.Location = new System.Drawing.Point(52, 129);
            this.txtRem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(254, 43);
            this.txtRem.TabIndex = 3;
            this.txtRem.Text = "1";
            this.txtRem.TextChanged += new System.EventHandler(this.txtRem_TextChanged);
            // 
            // lblCopyEm
            // 
            this.lblCopyEm.AutoSize = true;
            this.lblCopyEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyEm.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblCopyEm.Location = new System.Drawing.Point(317, 195);
            this.lblCopyEm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyEm.Name = "lblCopyEm";
            this.lblCopyEm.Size = new System.Drawing.Size(29, 20);
            this.lblCopyEm.TabIndex = 2;
            this.lblCopyEm.Text = "copy";
            this.lblCopyEm.Click += new System.EventHandler(this.lblCopyEm_Click);
            // 
            // lblem
            // 
            this.lblem.AutoSize = true;
            this.lblem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblem.Location = new System.Drawing.Point(11, 195);
            this.lblem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblem.Name = "lblem";
            this.lblem.Size = new System.Drawing.Size(28, 19);
            this.lblem.TabIndex = 2;
            this.lblem.Text = "em";
            // 
            // txtEmRoot
            // 
            this.txtEmRoot.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmRoot.Location = new System.Drawing.Point(52, 180);
            this.txtEmRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmRoot.Name = "txtEmRoot";
            this.txtEmRoot.Size = new System.Drawing.Size(118, 43);
            this.txtEmRoot.TabIndex = 3;
            this.txtEmRoot.Text = "16";
            this.txtEmRoot.TextChanged += new System.EventHandler(this.txtEmRoot_TextChanged);
            // 
            // lblCopyPercent
            // 
            this.lblCopyPercent.AutoSize = true;
            this.lblCopyPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyPercent.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblCopyPercent.Location = new System.Drawing.Point(317, 246);
            this.lblCopyPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyPercent.Name = "lblCopyPercent";
            this.lblCopyPercent.Size = new System.Drawing.Size(29, 20);
            this.lblCopyPercent.TabIndex = 2;
            this.lblCopyPercent.Text = "copy";
            this.lblCopyPercent.Click += new System.EventHandler(this.lblCopyPercent_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(11, 246);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(20, 19);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "%";
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(52, 231);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(254, 43);
            this.txtPercent.TabIndex = 3;
            this.txtPercent.Text = "1";
            this.txtPercent.TextChanged += new System.EventHandler(this.txtPercent_TextChanged);
            // 
            // txtEm
            // 
            this.txtEm.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEm.Location = new System.Drawing.Point(244, 180);
            this.txtEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(62, 43);
            this.txtEm.TabIndex = 3;
            this.txtEm.Text = "0";
            // 
            // lblemRoot
            // 
            this.lblemRoot.AutoSize = true;
            this.lblemRoot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemRoot.Location = new System.Drawing.Point(175, 196);
            this.lblemRoot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemRoot.Name = "lblemRoot";
            this.lblemRoot.Size = new System.Drawing.Size(64, 19);
            this.lblemRoot.TabIndex = 2;
            this.lblemRoot.Text = "px To em";
            // 
            // lblNewWindow
            // 
            this.lblNewWindow.AutoSize = true;
            this.lblNewWindow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewWindow.Location = new System.Drawing.Point(225, 347);
            this.lblNewWindow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewWindow.Name = "lblNewWindow";
            this.lblNewWindow.Size = new System.Drawing.Size(90, 19);
            this.lblNewWindow.TabIndex = 2;
            this.lblNewWindow.Text = "New Window";
            this.lblNewWindow.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblCopyPt
            // 
            this.lblCopyPt.AutoSize = true;
            this.lblCopyPt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyPt.Enabled = false;
            this.lblCopyPt.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 15F);
            this.lblCopyPt.Location = new System.Drawing.Point(317, 297);
            this.lblCopyPt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyPt.Name = "lblCopyPt";
            this.lblCopyPt.Size = new System.Drawing.Size(29, 20);
            this.lblCopyPt.TabIndex = 2;
            this.lblCopyPt.Text = "copy";
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.Enabled = false;
            this.lblPt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPt.Location = new System.Drawing.Point(11, 297);
            this.lblPt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(22, 19);
            this.lblPt.TabIndex = 2;
            this.lblPt.Text = "pt";
            // 
            // txtpt
            // 
            this.txtpt.Enabled = false;
            this.txtpt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpt.Location = new System.Drawing.Point(52, 282);
            this.txtpt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpt.Name = "txtpt";
            this.txtpt.Size = new System.Drawing.Size(254, 43);
            this.txtpt.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.txtpt);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtEm);
            this.Controls.Add(this.txtEmRoot);
            this.Controls.Add(this.lblPt);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtpx);
            this.Controls.Add(this.lblemRoot);
            this.Controls.Add(this.lblem);
            this.Controls.Add(this.txtRootSize);
            this.Controls.Add(this.lblrem);
            this.Controls.Add(this.lblCopyPt);
            this.Controls.Add(this.lblRootUnit);
            this.Controls.Add(this.lblCopyPercent);
            this.Controls.Add(this.lblpx);
            this.Controls.Add(this.lblCopyEm);
            this.Controls.Add(this.lblNewWindow);
            this.Controls.Add(this.lblRootSize);
            this.Controls.Add(this.lblCopyRem);
            this.Controls.Add(this.txtFrameName);
            this.Controls.Add(this.lblCopypx);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblCopyright);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web unit convertor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRootSize;
        private System.Windows.Forms.Label lblRootSize;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtFrameName;
        private System.Windows.Forms.Label lblRootUnit;
        private System.Windows.Forms.TextBox txtpx;
        private System.Windows.Forms.Label lblCopypx;
        private System.Windows.Forms.Label lblpx;
        private System.Windows.Forms.Label lblCopyRem;
        private System.Windows.Forms.Label lblrem;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label lblCopyEm;
        private System.Windows.Forms.Label lblem;
        private System.Windows.Forms.TextBox txtEmRoot;
        private System.Windows.Forms.Label lblCopyPercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.Label lblemRoot;
        private System.Windows.Forms.Label lblNewWindow;
        private System.Windows.Forms.Label lblCopyPt;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.TextBox txtpt;
    }
}

