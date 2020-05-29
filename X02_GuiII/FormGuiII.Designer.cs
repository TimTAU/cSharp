namespace cs_snippets
{
    partial class FormGuiII
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
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearMsg = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSimpleCtrls = new System.Windows.Forms.TabPage();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.buttonTo2 = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.tabPageAdvCtrls = new System.Windows.Forms.TabPage();
            this.labelMouse = new System.Windows.Forms.Label();
            this.panelMouse = new System.Windows.Forms.Panel();
            this.progressBarTest = new System.Windows.Forms.ProgressBar();
            this.buttonStopTimer = new System.Windows.Forms.Button();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.buttonDelSubtree = new System.Windows.Forms.Button();
            this.buttonAddChild = new System.Windows.Forms.Button();
            this.buttonAddSibl = new System.Windows.Forms.Button();
            this.treeViewTest = new System.Windows.Forms.TreeView();
            this.tabPageProps = new System.Windows.Forms.TabPage();
            this.checkBoxProp = new System.Windows.Forms.CheckBox();
            this.buttonProp = new System.Windows.Forms.Button();
            this.propertyGridMain = new System.Windows.Forms.PropertyGrid();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageSimpleCtrls.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageAdvCtrls.SuspendLayout();
            this.tabPageProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(172, 320);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.IntegralHeight = false;
            this.listBoxMsg.Location = new System.Drawing.Point(6, 12);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(241, 302);
            this.listBoxMsg.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClearMsg);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.listBoxMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 349);
            this.panel1.TabIndex = 3;
            // 
            // buttonClearMsg
            // 
            this.buttonClearMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearMsg.Location = new System.Drawing.Point(6, 320);
            this.buttonClearMsg.Name = "buttonClearMsg";
            this.buttonClearMsg.Size = new System.Drawing.Size(75, 23);
            this.buttonClearMsg.TabIndex = 3;
            this.buttonClearMsg.Text = "clear msg";
            this.buttonClearMsg.UseVisualStyleBackColor = true;
            this.buttonClearMsg.Click += new System.EventHandler(this.buttonClearMsg_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSimpleCtrls);
            this.tabControlMain.Controls.Add(this.tabPageAdvCtrls);
            this.tabControlMain.Controls.Add(this.tabPageProps);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(437, 349);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageSimpleCtrls
            // 
            this.tabPageSimpleCtrls.Controls.Add(this.groupBoxTest);
            this.tabPageSimpleCtrls.Location = new System.Drawing.Point(4, 22);
            this.tabPageSimpleCtrls.Name = "tabPageSimpleCtrls";
            this.tabPageSimpleCtrls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimpleCtrls.Size = new System.Drawing.Size(429, 323);
            this.tabPageSimpleCtrls.TabIndex = 0;
            this.tabPageSimpleCtrls.Text = "Simple Ctrls";
            this.tabPageSimpleCtrls.UseVisualStyleBackColor = true;
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTest.Controls.Add(this.buttonTo2);
            this.groupBoxTest.Controls.Add(this.textBoxTest);
            this.groupBoxTest.Controls.Add(this.groupBoxSelect);
            this.groupBoxTest.Controls.Add(this.labelTest);
            this.groupBoxTest.Controls.Add(this.buttonToggle);
            this.groupBoxTest.Controls.Add(this.buttonTest);
            this.groupBoxTest.Controls.Add(this.checkBoxTest);
            this.groupBoxTest.Location = new System.Drawing.Point(19, 17);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(368, 260);
            this.groupBoxTest.TabIndex = 2;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Group Box";
            // 
            // buttonTo2
            // 
            this.buttonTo2.Location = new System.Drawing.Point(232, 120);
            this.buttonTo2.Name = "buttonTo2";
            this.buttonTo2.Size = new System.Drawing.Size(114, 94);
            this.buttonTo2.TabIndex = 6;
            this.buttonTo2.Text = "Go To Tab2";
            this.buttonTo2.UseVisualStyleBackColor = true;
            this.buttonTo2.Click += new System.EventHandler(this.buttonTo2_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(232, 53);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(114, 20);
            this.textBoxTest.TabIndex = 5;
            this.textBoxTest.TextChanged += new System.EventHandler(this.textBoxTest_TextChanged);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButton3);
            this.groupBoxSelect.Controls.Add(this.radioButton2);
            this.groupBoxSelect.Controls.Add(this.radioButton1);
            this.groupBoxSelect.Location = new System.Drawing.Point(24, 120);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(137, 94);
            this.groupBoxSelect.TabIndex = 4;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Select Test";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "radio3";
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonn_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "radio2";
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "radio1";
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonn_CheckedChanged);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(229, 37);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(90, 13);
            this.labelTest.TabIndex = 3;
            this.labelTest.Text = "input some text ...";
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(111, 75);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(50, 23);
            this.buttonToggle.TabIndex = 2;
            this.buttonToggle.Text = "Toggle";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(24, 32);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(137, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test Button";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Location = new System.Drawing.Point(24, 79);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(81, 17);
            this.checkBoxTest.TabIndex = 1;
            this.checkBoxTest.Text = "Check Test";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            this.checkBoxTest.CheckedChanged += new System.EventHandler(this.checkBoxTest_CheckedChanged);
            // 
            // tabPageAdvCtrls
            // 
            this.tabPageAdvCtrls.Controls.Add(this.labelMouse);
            this.tabPageAdvCtrls.Controls.Add(this.panelMouse);
            this.tabPageAdvCtrls.Controls.Add(this.progressBarTest);
            this.tabPageAdvCtrls.Controls.Add(this.buttonStopTimer);
            this.tabPageAdvCtrls.Controls.Add(this.buttonStartTimer);
            this.tabPageAdvCtrls.Controls.Add(this.buttonDelSubtree);
            this.tabPageAdvCtrls.Controls.Add(this.buttonAddChild);
            this.tabPageAdvCtrls.Controls.Add(this.buttonAddSibl);
            this.tabPageAdvCtrls.Controls.Add(this.treeViewTest);
            this.tabPageAdvCtrls.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvCtrls.Name = "tabPageAdvCtrls";
            this.tabPageAdvCtrls.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvCtrls.Size = new System.Drawing.Size(429, 323);
            this.tabPageAdvCtrls.TabIndex = 1;
            this.tabPageAdvCtrls.Text = "Adv. Ctrls";
            this.tabPageAdvCtrls.UseVisualStyleBackColor = true;
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(217, 133);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(102, 13);
            this.labelMouse.TabIndex = 8;
            this.labelMouse.Text = "move your mouse ...";
            // 
            // panelMouse
            // 
            this.panelMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMouse.Location = new System.Drawing.Point(220, 149);
            this.panelMouse.Name = "panelMouse";
            this.panelMouse.Size = new System.Drawing.Size(113, 154);
            this.panelMouse.TabIndex = 7;
            this.panelMouse.Click += new System.EventHandler(this.panelMouse_Click);
            this.panelMouse.DoubleClick += new System.EventHandler(this.panelMouse_DoubleClick);
            this.panelMouse.MouseEnter += new System.EventHandler(this.panelMouse_MouseEnter);
            this.panelMouse.MouseLeave += new System.EventHandler(this.panelMouse_MouseLeave);
            this.panelMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouse_MouseMove);
            // 
            // progressBarTest
            // 
            this.progressBarTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTest.Location = new System.Drawing.Point(339, 82);
            this.progressBarTest.Name = "progressBarTest";
            this.progressBarTest.Size = new System.Drawing.Size(75, 221);
            this.progressBarTest.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTest.TabIndex = 6;
            this.progressBarTest.Value = 10;
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopTimer.Location = new System.Drawing.Point(339, 47);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTimer.TabIndex = 5;
            this.buttonStopTimer.Text = "stop";
            this.buttonStopTimer.UseVisualStyleBackColor = true;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartTimer.Location = new System.Drawing.Point(339, 18);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTimer.TabIndex = 4;
            this.buttonStartTimer.Text = "start";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // buttonDelSubtree
            // 
            this.buttonDelSubtree.Location = new System.Drawing.Point(211, 82);
            this.buttonDelSubtree.Name = "buttonDelSubtree";
            this.buttonDelSubtree.Size = new System.Drawing.Size(75, 23);
            this.buttonDelSubtree.TabIndex = 3;
            this.buttonDelSubtree.Text = "del subtree";
            this.buttonDelSubtree.UseVisualStyleBackColor = true;
            this.buttonDelSubtree.Click += new System.EventHandler(this.buttonDelSubtree_Click);
            // 
            // buttonAddChild
            // 
            this.buttonAddChild.Location = new System.Drawing.Point(211, 47);
            this.buttonAddChild.Name = "buttonAddChild";
            this.buttonAddChild.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChild.TabIndex = 2;
            this.buttonAddChild.Text = "add child";
            this.buttonAddChild.UseVisualStyleBackColor = true;
            this.buttonAddChild.Click += new System.EventHandler(this.buttonAddChild_Click);
            // 
            // buttonAddSibl
            // 
            this.buttonAddSibl.Location = new System.Drawing.Point(211, 18);
            this.buttonAddSibl.Name = "buttonAddSibl";
            this.buttonAddSibl.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSibl.TabIndex = 1;
            this.buttonAddSibl.Text = "add sibling";
            this.buttonAddSibl.UseVisualStyleBackColor = true;
            this.buttonAddSibl.Click += new System.EventHandler(this.buttonAddSibl_Click);
            // 
            // treeViewTest
            // 
            this.treeViewTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewTest.Location = new System.Drawing.Point(20, 18);
            this.treeViewTest.Name = "treeViewTest";
            this.treeViewTest.Size = new System.Drawing.Size(185, 285);
            this.treeViewTest.TabIndex = 0;
            // 
            // tabPageProps
            // 
            this.tabPageProps.Controls.Add(this.checkBoxProp);
            this.tabPageProps.Controls.Add(this.buttonProp);
            this.tabPageProps.Controls.Add(this.propertyGridMain);
            this.tabPageProps.Location = new System.Drawing.Point(4, 22);
            this.tabPageProps.Name = "tabPageProps";
            this.tabPageProps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProps.Size = new System.Drawing.Size(429, 323);
            this.tabPageProps.TabIndex = 2;
            this.tabPageProps.Text = "Property Ctrl";
            this.tabPageProps.UseVisualStyleBackColor = true;
            // 
            // checkBoxProp
            // 
            this.checkBoxProp.AutoSize = true;
            this.checkBoxProp.Location = new System.Drawing.Point(321, 72);
            this.checkBoxProp.Name = "checkBoxProp";
            this.checkBoxProp.Size = new System.Drawing.Size(73, 17);
            this.checkBoxProp.TabIndex = 2;
            this.checkBoxProp.Text = "checkbox";
            this.checkBoxProp.UseVisualStyleBackColor = true;
            this.checkBoxProp.CheckedChanged += new System.EventHandler(this.checkBoxProp_CheckedChanged);
            // 
            // buttonProp
            // 
            this.buttonProp.Location = new System.Drawing.Point(321, 32);
            this.buttonProp.Name = "buttonProp";
            this.buttonProp.Size = new System.Drawing.Size(75, 23);
            this.buttonProp.TabIndex = 1;
            this.buttonProp.Text = "button";
            this.buttonProp.UseVisualStyleBackColor = true;
            this.buttonProp.Click += new System.EventHandler(this.buttonProp_Click);
            // 
            // propertyGridMain
            // 
            this.propertyGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridMain.Location = new System.Drawing.Point(8, 6);
            this.propertyGridMain.Name = "propertyGridMain";
            this.propertyGridMain.Size = new System.Drawing.Size(278, 309);
            this.propertyGridMain.TabIndex = 0;
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 1000;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormGuiII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 349);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.Name = "FormGuiII";
            this.Text = "GUI II";
            this.panel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSimpleCtrls.ResumeLayout(false);
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageAdvCtrls.ResumeLayout(false);
            this.tabPageAdvCtrls.PerformLayout();
            this.tabPageProps.ResumeLayout(false);
            this.tabPageProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSimpleCtrls;
        private System.Windows.Forms.TabPage tabPageAdvCtrls;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonTo2;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.TreeView treeViewTest;
        private System.Windows.Forms.Button buttonDelSubtree;
        private System.Windows.Forms.Button buttonAddChild;
        private System.Windows.Forms.Button buttonAddSibl;
        private System.Windows.Forms.ProgressBar progressBarTest;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Panel panelMouse;
        private System.Windows.Forms.Button buttonClearMsg;
        private System.Windows.Forms.TabPage tabPageProps;
        private System.Windows.Forms.CheckBox checkBoxProp;
        private System.Windows.Forms.Button buttonProp;
        private System.Windows.Forms.PropertyGrid propertyGridMain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

