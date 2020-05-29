namespace cs_220_GUI_Examples
{
    partial class FormGuiIII
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTTT = new System.Windows.Forms.TabPage();
            this.panelGameControl = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.propertyGridTTT = new System.Windows.Forms.PropertyGrid();
            this.tabControlMain.SuspendLayout();
            this.tabPageTTT.SuspendLayout();
            this.panelGameControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTTT);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(640, 382);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTTT
            // 
            this.tabPageTTT.Controls.Add(this.panelGameControl);
            this.tabPageTTT.Location = new System.Drawing.Point(4, 22);
            this.tabPageTTT.Name = "tabPageTTT";
            this.tabPageTTT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTTT.Size = new System.Drawing.Size(632, 356);
            this.tabPageTTT.TabIndex = 0;
            this.tabPageTTT.Text = "Tic Tac Toe";
            this.tabPageTTT.UseVisualStyleBackColor = true;
            this.tabPageTTT.Click += new System.EventHandler(this.tabPageTTT_Click);
            // 
            // panelGameControl
            // 
            this.panelGameControl.Controls.Add(this.labelInfo);
            this.panelGameControl.Controls.Add(this.buttonStart);
            this.panelGameControl.Controls.Add(this.propertyGridTTT);
            this.panelGameControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGameControl.Location = new System.Drawing.Point(352, 3);
            this.panelGameControl.Name = "panelGameControl";
            this.panelGameControl.Size = new System.Drawing.Size(277, 350);
            this.panelGameControl.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(84, 327);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Info";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Location = new System.Drawing.Point(3, 322);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // propertyGridTTT
            // 
            this.propertyGridTTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridTTT.HelpVisible = false;
            this.propertyGridTTT.Location = new System.Drawing.Point(3, 3);
            this.propertyGridTTT.Name = "propertyGridTTT";
            this.propertyGridTTT.Size = new System.Drawing.Size(271, 313);
            this.propertyGridTTT.TabIndex = 1;
            // 
            // FormGuiIII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 382);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormGuiIII";
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTTT.ResumeLayout(false);
            this.panelGameControl.ResumeLayout(false);
            this.panelGameControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTTT;
        private System.Windows.Forms.PropertyGrid propertyGridTTT;
        private System.Windows.Forms.Panel panelGameControl;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInfo;
    }
}

