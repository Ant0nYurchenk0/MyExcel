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
        private void NewLabel_Click(object sender, EventArgs e)
        {
            SaveOrNot(sender, e);
            CurrentFile = null;
            RenameWindow();
            EditorSpace.Clear();
            InitTable();
        }

        private void OpenLabel_Click(object sender, EventArgs e)
        {
            try
            {
                string OpenFile = "";
                FileName FNForm = new FileName();
                DialogResult dialogresult = FNForm.ShowDialog();
                if (dialogresult == DialogResult.OK)
                {
                    OpenFile = FNForm.NameOfFile;
                    if (OpenFile == "")
                    {
                        return;
                    }
                }
                string path = "..\\..\\..\\Saves\\" + OpenFile + ".csv";
                FNForm.Dispose();
                CurrentFile = OpenFile;                
                RenameWindow();
                LoadTable(path);
                ReevaluateBtn_Click(sender, e);                
            }
            catch
            {
                MessageBox.Show(Labels["OPEN_ERROR"]);
                return;
            }

            
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentFile == null)
                {
                    SaveAsLabel_Click(sender, e);
                    return;
                }
                string lines = "";
                lines += MainDataView.RowCount.ToString() + "," + MainDataView.ColumnCount.ToString();
                foreach (var item in MyExcelVisitor.tableIdentifier)
                {
                    if (item.Value.Value == null || item.Value.Value == "")
                    {
                        lines += "\n" + item.Key + "," + "null";
                    }
                    else
                    {
                        lines += "\n" + item.Key + "," + item.Value.Value;
                    }
                }
                StreamWriter file = new StreamWriter("..\\..\\..\\Saves\\" + CurrentFile + ".csv");
                file.WriteLine(lines);
                file.Close();
            }
            catch
            {
                MessageBox.Show("Encountered an error during saving");
            }
        }

        private void SaveAsLabel_Click(object sender, EventArgs e)
        {
            FileName FNForm = new FileName();
            DialogResult dialogresult = FNForm.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                CurrentFile = FNForm.NameOfFile;
                if (CurrentFile == "")
                {
                    return;
                }
                RenameWindow();
                SaveLabel_Click(sender, e);
            }
            else
            {
                return;
            }
            FNForm.Dispose();
        }

        private void PropsLabel_Click(object sender, EventArgs e)
        {
            InitLabels();
        }
        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            row.HeaderCell.Value = Convert.ToString(MainDataView.RowCount + 1);
            MainDataView.Rows.Add(row);
            for (int i = 0; i < MainDataView.Columns.Count; i++)
            {
                Cell cell = new Cell(MainDataView.Columns[i].Name, MainDataView.RowCount);
                MyExcelVisitor.tableIdentifier[cell.Name] = cell;
            }
        }

        private void RemRowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainDataView.Rows.RemoveAt(MainDataView.RowCount - 1);
                for (int i = 0; i < MainDataView.Columns.Count; i++)
                {
                    Cell cell = new Cell(MainDataView.Columns[i].Name, MainDataView.RowCount);
                    MyExcelVisitor.tableIdentifier.Remove(cell.Name);
                }
            }
            catch { }
        }

        private void AddColBtn_Click(object sender, EventArgs e)
        {
            var column = new DataGridViewTextBoxColumn();
            column.Name = "";
            int letterNum = MainDataView.Columns.Count;
            List<int> digits = new List<int>();
            while ((letterNum / 26) > 0) 
            {
                digits.Add(letterNum % 26);
                letterNum = letterNum/26 -1 ;
            } 
            digits.Add(letterNum);
            digits.Reverse();
            foreach (int digit in digits)
            {
                column.Name += Convert.ToString(Convert.ToChar(digit + 65));
            }
            MainDataView.Columns.Add(column);
            for (int i = 0; i < MainDataView.RowCount; i++)
            {
                Cell cell = new Cell(MainDataView.Columns[MainDataView.Columns.Count - 1].Name, i + 1);
                MyExcelVisitor.tableIdentifier[cell.Name] = cell;
            }
        }

        private void RemColBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < MainDataView.RowCount; i++)
                {
                    Cell cell = new Cell(MainDataView.Columns[MainDataView.Columns.Count - 1].Name, i + 1);
                    MyExcelVisitor.tableIdentifier.Remove(cell.Name);
                }
                MainDataView.Columns.RemoveAt(MainDataView.ColumnCount - 1);
            }
            catch { }

        }
        private void AboutLabel_Click(object sender, EventArgs e)
        {
            About AFrom = new About();
            AFrom.ShowDialog(); 
            AFrom.Dispose();
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            Help HForm = new Help();
            HForm.Show();
        }
    }
}
