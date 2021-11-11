using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyExcel
{
    public partial class ExcelForm : Form
    {
        public DataGridViewCell PreviousCell = null;
        public string CurrentFile = null;
        static public Dictionary<string, string> Labels = new Dictionary<string, string>();
        public ExcelForm()
        {
            InitializeComponent();
            HelpClass.BuildForm(this);
        }
        private void ExcelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools.ExcelForm_FormClosing(this, sender, e);
        }
        private void MainDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tools.MainDataView_CellClick(this, sender, e);
        }
        private void MainDataView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            Tools.MainDataView_CellLeave(this, sender, e);
        }
        private void EditorSpace_TextChanged(object sender, EventArgs e)
        {
            Tools.EditorSpace_TextChanged(this, sender, e);

        }
        private void EditorSpace_Click(object sender, EventArgs e)
        {
            Tools.EditorSpace_Click(this, sender, e);
        }
        private void NewLabel_Click(object sender, EventArgs e)
        {
            Tools.NewLabel_Click(this, sender, e);
        }
        private void OpenLabel_Click(object sender, EventArgs e)
        {
            Tools.OpenLabel_Click(this, sender, e);
        }
        private void SaveLabel_Click(object sender, EventArgs e)
        {
            Tools.SaveLabel_Click(this, sender, e);
        }
        private void SaveAsLabel_Click(object sender, EventArgs e)
        {
            Tools.SaveAsLabel_Click(this, sender, e);
        }
        private void PropsLabel_Click(object sender, EventArgs e)
        {
            Tools.PropsLabel_Click(this, sender, e);
        }
        private void AboutLabel_Click(object sender, EventArgs e)
        {
            Tools.AboutLabel_Click(this, sender, e);
        }
        private void HelpLabel_Click(object sender, EventArgs e)
        {
            Tools.HelpLabel_Click(this, sender, e);
        }
        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            Tools.AddRowBtn_Click(this, sender, e);
        }
        private void AddColBtn_Click(object sender, EventArgs e)
        {
            Tools.AddColBtn_Click(this, sender, e);
        }
        private void RemRowBtn_Click(object sender, EventArgs e)
        {
            Tools.RemRowBtn_Click(this, sender, e);
        }
        private void RemColBtn_Click(object sender, EventArgs e)
        {
            Tools.RemColBtn_Click(this, sender, e);

        }
        private void ReevaluateBtn_Click(object sender, EventArgs e)
        {
            Tools.ReevaluateBtn_Click(this, sender, e);
        }

    }
}
