
namespace MyExcel
{
    partial class ChooseLang
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
            this.EngButton = new System.Windows.Forms.Button();
            this.UkrButton = new System.Windows.Forms.Button();
            this.ChooseLangLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EngButton
            // 
            this.EngButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.EngButton.Location = new System.Drawing.Point(133, 68);
            this.EngButton.Name = "EngButton";
            this.EngButton.Size = new System.Drawing.Size(75, 23);
            this.EngButton.TabIndex = 0;
            this.EngButton.Text = "English";
            this.EngButton.UseVisualStyleBackColor = true;
            // 
            // UkrButton
            // 
            this.UkrButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.UkrButton.Location = new System.Drawing.Point(133, 111);
            this.UkrButton.Name = "UkrButton";
            this.UkrButton.Size = new System.Drawing.Size(75, 23);
            this.UkrButton.TabIndex = 1;
            this.UkrButton.Text = "Українська";
            this.UkrButton.UseVisualStyleBackColor = true;
            // 
            // ChooseLangLabel
            // 
            this.ChooseLangLabel.AutoSize = true;
            this.ChooseLangLabel.Location = new System.Drawing.Point(116, 25);
            this.ChooseLangLabel.Name = "ChooseLangLabel";
            this.ChooseLangLabel.Size = new System.Drawing.Size(38, 15);
            this.ChooseLangLabel.TabIndex = 2;
            this.ChooseLangLabel.Text = "label1";
            this.ChooseLangLabel.Click += new System.EventHandler(this.ChoseLangLabel_Click);
            // 
            // ChooseLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 174);
            this.Controls.Add(this.ChooseLangLabel);
            this.Controls.Add(this.UkrButton);
            this.Controls.Add(this.EngButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseLang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EngButton;
        private System.Windows.Forms.Button UkrButton;
        private System.Windows.Forms.Label ChooseLangLabel;
    }
}