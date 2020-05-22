namespace A6_Fyilion
{
    partial class Form1
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
            this.randomNumListBox = new System.Windows.Forms.ListBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomNumListBox
            // 
            this.randomNumListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.randomNumListBox.FormattingEnabled = true;
            this.randomNumListBox.Location = new System.Drawing.Point(680, 0);
            this.randomNumListBox.Name = "randomNumListBox";
            this.randomNumListBox.Size = new System.Drawing.Size(120, 450);
            this.randomNumListBox.TabIndex = 0;
            this.randomNumListBox.SelectedIndexChanged += new System.EventHandler(this.randomNumListBox_SelectedIndexChanged);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(146, 91);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 20);
            this.numberBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.randomNumListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox randomNumListBox;
        private System.Windows.Forms.TextBox numberBox;
    }
}

