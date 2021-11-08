using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MyExcel
{ 
    public partial class ExcelForm : Form
    {
        DataGridViewCell PreviousCell = null;
        string CurrentFile = null;
        static public Dictionary<string, string> Labels = new Dictionary<string, string>();
        public ExcelForm()
        {
            InitializeComponent();
            Labels["CHOOSE_LANGUAGE"] = "Choose language:";
            SaveFileDialog.Filter = "Table files(*.csv)|*.csv|All files(*.*)|*.*";
            OpenFileDialog.Filter = "Table files(*.csv)|*.csv|All files(*.*)|*.*";
            InitTable();
            string ConfigPath = "..\\..\\..\\config.csv";
            try
            {
                var config = File.ReadLines(ConfigPath).Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);
                InitLabels(config["language"]);
            }
            catch
            {
                InitLabels();
            }
        }
        private void MainDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MyExcelVisitor.tableIdentifier.TryGetValue(GetCurrentCellName(), out Cell cell))
                {
                    EditorSpace.Text = cell.Value ;
                    MainDataView.CurrentCell.Value = cell.Value;

                }
            }
            catch { }
            finally
            {
                PreviousCell = MainDataView.CurrentCell;
                CoordinateBox.Text = GetCurrentCellName();
                
            }
        }
        private void EditorSpace_TextChanged(object sender, EventArgs e)
        {
            EditorSpace.SelectionColor = Color.Black;
            EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            try
            {
                MyExcelVisitor.tableIdentifier[GetCurrentCellName()].Value = EditorSpace.Text;
                MainDataView.CurrentCell.Value = EditorSpace.Text;
                Calculator.Evaluate(EditorSpace.Text);
            }
            catch (Exception ex)
            {
                Regex regex = new Regex(@"'(\w*\W*)'");
                MatchCollection matches = regex.Matches(ex.Message);
                int index = EditorSpace.Text.IndexOf(Convert.ToString(matches[0])[1]);
                string text = EditorSpace.Text;
                EditorSpace.Text = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != index)
                    {
                        EditorSpace.SelectedText = text[i].ToString();
                    }
                    else
                    {
                        EditorSpace.SelectionColor = Color.Red;
                        EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Underline);
                        EditorSpace.SelectedText = Convert.ToString(matches[0])[1].ToString();
                        EditorSpace.SelectionColor = Color.Black;
                        EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
                    }
                }
            }

        }
        private void EditorSpace_Click(object sender, EventArgs e)
        {
            PreviousCell = MainDataView.Rows[MainDataView.CurrentCell.RowIndex].Cells[MainDataView.CurrentCell.ColumnIndex];
        }
        private void MainDataView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            ReevaluateBtn_Click(sender, e);
        }
        private void ExcelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOrNot(sender, e);
        }
        private void ReevaluateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MainDataView.Rows.Count; i++)
            {
                for (int j = 0; j < MainDataView.Columns.Count; j++)
                {
                    if (MainDataView.Rows[i].Cells[j] != null && 
                        MainDataView.Rows[i].Cells[j].Value != null && 
                        MainDataView.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        string CellName = MainDataView.Rows[i].Cells[j].OwningColumn.Name + Convert.ToString(i + 1);
                        if (MyExcelVisitor.tableIdentifier.TryGetValue(CellName, out Cell cell))
                        {
                            try
                            {
                                MainDataView.Rows[i].Cells[j].Value = Calculator.Evaluate(cell.Value);
                            }
                            catch
                            {
                                MainDataView.Rows[i].Cells[j].Value = "ERROR";
                            }
                        } 
                    }
                }
            }
        }

    }
}
