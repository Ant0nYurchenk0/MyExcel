
namespace MyExcel
{
    partial class ExcelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditorSpace = new System.Windows.Forms.RichTextBox();
            this.MainDataView = new System.Windows.Forms.DataGridView();
            this.CoordinateBox = new System.Windows.Forms.TextBox();
            this.CoordLabel = new System.Windows.Forms.Label();
            this.FuncLabels = new System.Windows.Forms.Label();
            this.ReevaluateBtn = new System.Windows.Forms.Button();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.AddColBtn = new System.Windows.Forms.Button();
            this.NewLabel = new System.Windows.Forms.Label();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveAsLabel = new System.Windows.Forms.Label();
            this.PropsLabel = new System.Windows.Forms.Label();
            this.RemRowBtn = new System.Windows.Forms.Button();
            this.RemColBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorSpace
            // 
            this.EditorSpace.Location = new System.Drawing.Point(223, 63);
            this.EditorSpace.Name = "EditorSpace";
            this.EditorSpace.Size = new System.Drawing.Size(458, 23);
            this.EditorSpace.TabIndex = 3;
            this.EditorSpace.Text = "";
            this.EditorSpace.Click += new System.EventHandler(this.EditorSpace_Click);
            this.EditorSpace.TextChanged += new System.EventHandler(this.EditorSpace_TextChanged);
            // 
            // MainDataView
            // 
            this.MainDataView.AllowUserToAddRows = false;
            this.MainDataView.AllowUserToDeleteRows = false;
            this.MainDataView.AllowUserToOrderColumns = true;
            this.MainDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataView.BackgroundColor = System.Drawing.Color.MintCream;
            this.MainDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainDataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.MainDataView.Location = new System.Drawing.Point(12, 93);
            this.MainDataView.MultiSelect = false;
            this.MainDataView.Name = "MainDataView";
            this.MainDataView.ReadOnly = true;
            this.MainDataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainDataView.RowTemplate.Height = 25;
            this.MainDataView.Size = new System.Drawing.Size(773, 352);
            this.MainDataView.TabIndex = 6;
            this.MainDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataView_CellClick);
            this.MainDataView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataView_CellLeave);
            // 
            // CoordinateBox
            // 
            this.CoordinateBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CoordinateBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CoordinateBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CoordinateBox.Location = new System.Drawing.Point(97, 62);
            this.CoordinateBox.Name = "CoordinateBox";
            this.CoordinateBox.ReadOnly = true;
            this.CoordinateBox.Size = new System.Drawing.Size(84, 25);
            this.CoordinateBox.TabIndex = 7;
            this.CoordinateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoordLabel
            // 
            this.CoordLabel.AutoSize = true;
            this.CoordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoordLabel.Location = new System.Drawing.Point(12, 63);
            this.CoordLabel.Name = "CoordLabel";
            this.CoordLabel.Size = new System.Drawing.Size(79, 19);
            this.CoordLabel.TabIndex = 8;
            this.CoordLabel.Text = "CoordLabel";
            // 
            // FuncLabels
            // 
            this.FuncLabels.AutoSize = true;
            this.FuncLabels.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FuncLabels.Location = new System.Drawing.Point(185, 63);
            this.FuncLabels.Name = "FuncLabels";
            this.FuncLabels.Size = new System.Drawing.Size(41, 19);
            this.FuncLabels.TabIndex = 9;
            this.FuncLabels.Text = "f(x) =";
            // 
            // ReevaluateBtn
            // 
            this.ReevaluateBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ReevaluateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReevaluateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReevaluateBtn.Location = new System.Drawing.Point(687, 62);
            this.ReevaluateBtn.Name = "ReevaluateBtn";
            this.ReevaluateBtn.Size = new System.Drawing.Size(98, 25);
            this.ReevaluateBtn.TabIndex = 15;
            this.ReevaluateBtn.Text = "reeval";
            this.ReevaluateBtn.UseVisualStyleBackColor = false;
            this.ReevaluateBtn.Click += new System.EventHandler(this.ReevaluateBtn_Click);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.Location = new System.Drawing.Point(35, 33);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(156, 23);
            this.AddRowBtn.TabIndex = 16;
            this.AddRowBtn.Text = "+row";
            this.AddRowBtn.UseVisualStyleBackColor = true;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // AddColBtn
            // 
            this.AddColBtn.Location = new System.Drawing.Point(359, 34);
            this.AddColBtn.Name = "AddColBtn";
            this.AddColBtn.Size = new System.Drawing.Size(156, 23);
            this.AddColBtn.TabIndex = 17;
            this.AddColBtn.Text = "+col";
            this.AddColBtn.UseVisualStyleBackColor = true;
            this.AddColBtn.Click += new System.EventHandler(this.AddColBtn_Click);
            // 
            // NewLabel
            // 
            this.NewLabel.AutoSize = true;
            this.NewLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewLabel.Location = new System.Drawing.Point(6, 6);
            this.NewLabel.Name = "NewLabel";
            this.NewLabel.Size = new System.Drawing.Size(29, 15);
            this.NewLabel.TabIndex = 18;
            this.NewLabel.Text = "new";
            this.NewLabel.Click += new System.EventHandler(this.NewLabel_Click);
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.BackColor = System.Drawing.Color.Transparent;
            this.OpenLabel.Location = new System.Drawing.Point(57, 6);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(34, 15);
            this.OpenLabel.TabIndex = 19;
            this.OpenLabel.Text = "open";
            this.OpenLabel.Click += new System.EventHandler(this.OpenLabel_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.Location = new System.Drawing.Point(122, 6);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(30, 15);
            this.SaveLabel.TabIndex = 20;
            this.SaveLabel.Text = "save";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // SaveAsLabel
            // 
            this.SaveAsLabel.AutoSize = true;
            this.SaveAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaveAsLabel.Location = new System.Drawing.Point(185, 6);
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Size = new System.Drawing.Size(41, 15);
            this.SaveAsLabel.TabIndex = 21;
            this.SaveAsLabel.Text = "saveas";
            this.SaveAsLabel.Click += new System.EventHandler(this.SaveAsLabel_Click);
            // 
            // PropsLabel
            // 
            this.PropsLabel.AutoSize = true;
            this.PropsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PropsLabel.Location = new System.Drawing.Point(265, 6);
            this.PropsLabel.Name = "PropsLabel";
            this.PropsLabel.Size = new System.Drawing.Size(67, 15);
            this.PropsLabel.TabIndex = 22;
            this.PropsLabel.Text = "propperties";
            this.PropsLabel.Click += new System.EventHandler(this.PropsLabel_Click);
            // 
            // RemRowBtn
            // 
            this.RemRowBtn.Location = new System.Drawing.Point(197, 33);
            this.RemRowBtn.Name = "RemRowBtn";
            this.RemRowBtn.Size = new System.Drawing.Size(156, 23);
            this.RemRowBtn.TabIndex = 23;
            this.RemRowBtn.Text = "-row";
            this.RemRowBtn.UseVisualStyleBackColor = true;
            this.RemRowBtn.Click += new System.EventHandler(this.RemRowBtn_Click);
            // 
            // RemColBtn
            // 
            this.RemColBtn.Location = new System.Drawing.Point(521, 34);
            this.RemColBtn.Name = "RemColBtn";
            this.RemColBtn.Size = new System.Drawing.Size(156, 23);
            this.RemColBtn.TabIndex = 24;
            this.RemColBtn.Text = "-col";
            this.RemColBtn.UseVisualStyleBackColor = true;
            this.RemColBtn.Click += new System.EventHandler(this.RemColBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.AutoSize = true;
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.Location = new System.Drawing.Point(359, 6);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(30, 15);
            this.HelpBtn.TabIndex = 25;
            this.HelpBtn.Text = "help";
            // 
            // ExcelForm
            // 
            this.AcceptButton = this.ReevaluateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(792, 456);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.RemColBtn);
            this.Controls.Add(this.RemRowBtn);
            this.Controls.Add(this.PropsLabel);
            this.Controls.Add(this.SaveAsLabel);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.OpenLabel);
            this.Controls.Add(this.NewLabel);
            this.Controls.Add(this.AddColBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.ReevaluateBtn);
            this.Controls.Add(this.EditorSpace);
            this.Controls.Add(this.FuncLabels);
            this.Controls.Add(this.CoordinateBox);
            this.Controls.Add(this.CoordLabel);
            this.Controls.Add(this.MainDataView);
            this.Name = "ExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyExcel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox EditorSpace;
        private System.Windows.Forms.DataGridView MainDataView;
        private System.Windows.Forms.TextBox CoordinateBox;
        private System.Windows.Forms.Label CoordLabel;
        private System.Windows.Forms.Label FuncLabels;
        private System.Windows.Forms.Button ReevaluateBtn;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button AddColBtn;
        private System.Windows.Forms.Label NewLabel;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Label SaveAsLabel;
        private System.Windows.Forms.Label PropsLabel;
        private System.Windows.Forms.Button RemRowBtn;
        private System.Windows.Forms.Button RemColBtn;
        private System.Windows.Forms.Label HelpBtn;
    }
}

