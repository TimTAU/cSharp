namespace cs_snippets
{
    partial class FormGuiI
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
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonDelItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonShowMsgBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(526, 14);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "add";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textBoxItem
            // 
            this.textBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItem.Location = new System.Drawing.Point(535, 43);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(75, 20);
            this.textBoxItem.TabIndex = 1;
            // 
            // listBoxItems
            // 
            this.listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.IntegralHeight = false;
            this.listBoxItems.Items.AddRange(new object[] {
            "Insert Text and pres <add>"});
            this.listBoxItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(491, 287);
            this.listBoxItems.TabIndex = 2;
            // 
            // buttonDelItem
            // 
            this.buttonDelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelItem.Location = new System.Drawing.Point(526, 69);
            this.buttonDelItem.Name = "buttonDelItem";
            this.buttonDelItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDelItem.TabIndex = 3;
            this.buttonDelItem.Text = "delete";
            this.buttonDelItem.UseVisualStyleBackColor = true;
            this.buttonDelItem.Click += new System.EventHandler(this.buttonDelItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(616, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 311);
            this.panel1.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(262, 192);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(214, 86);
            this.button11.TabIndex = 5;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonShowMsgBox
            // 
            this.buttonShowMsgBox.Location = new System.Drawing.Point(526, 224);
            this.buttonShowMsgBox.Name = "buttonShowMsgBox";
            this.buttonShowMsgBox.Size = new System.Drawing.Size(75, 23);
            this.buttonShowMsgBox.TabIndex = 7;
            this.buttonShowMsgBox.Text = "MsgBox";
            this.buttonShowMsgBox.UseVisualStyleBackColor = true;
            this.buttonShowMsgBox.Click += new System.EventHandler(this.buttonShowMsgBox_Click);
            // 
            // FormGuiI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 311);
            this.Controls.Add(this.buttonShowMsgBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDelItem);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.buttonAddItem);
            this.Name = "FormGuiI";
            this.Text = "GUI I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonDelItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonShowMsgBox;
    }
}

