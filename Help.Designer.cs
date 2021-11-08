
namespace MyExcel
{
    partial class Help
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
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.AutoSize = true;
            this.HelpText.Location = new System.Drawing.Point(27, 36);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(30, 15);
            this.HelpText.TabIndex = 0;
            this.HelpText.Text = "help";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 295);
            this.Controls.Add(this.HelpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Help";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelpText;
    }
}