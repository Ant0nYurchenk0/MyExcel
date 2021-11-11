using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace MyExcel
{
    public static class Tools
    {
        public static void ExcelForm_FormClosing(dynamic form, object sender, FormClosingEventArgs e)
        {
            HelpClass.SaveOrNot(form, sender, e);
        }
        public static void MainDataView_CellClick(dynamic form, object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MyExcelVisitor.tableIdentifier.TryGetValue(HelpClass.GetCurrentCellName(form), out Cell cell))
                {
                    form.EditorSpace.Text = cell.Value;
                    form.MainDataView.CurrentCell.Value = cell.Value;

                }
            }
            catch { }
            finally
            {
                form.PreviousCell = form.MainDataView.CurrentCell;
                form.CoordinateBox.Text = HelpClass.GetCurrentCellName(form);

            }
        }
        public static void MainDataView_CellLeave(dynamic form, object sender, DataGridViewCellEventArgs e)
        {
            ReevaluateBtn_Click(form, sender, e);
        }
        public static void EditorSpace_TextChanged(dynamic form, object sender, EventArgs e)
        {
            form.EditorSpace.SelectionColor = Color.Black;
            form.EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            try
            {
                MyExcelVisitor.tableIdentifier[HelpClass.GetCurrentCellName(form)].Value = form.EditorSpace.Text;
                form.MainDataView.CurrentCell.Value = form.EditorSpace.Text;
                Calculator.Evaluate(form.EditorSpace.Text);
            }
            catch (Exception ex)
            {
                Regex regex = new Regex(@"'(\w*\W*)'");
                MatchCollection matches = regex.Matches(ex.Message);
                int index = form.EditorSpace.Text.IndexOf(Convert.ToString(matches[0])[1]);
                string text = form.EditorSpace.Text;
                form.EditorSpace.Text = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != index)
                    {
                        form.EditorSpace.SelectedText = text[i].ToString();
                    }
                    else
                    {
                        form.EditorSpace.SelectionColor = Color.Red;
                        form.EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Underline);
                        form.EditorSpace.SelectedText = Convert.ToString(matches[0])[1].ToString();
                        form.EditorSpace.SelectionColor = Color.Black;
                        form.EditorSpace.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
                    }
                }
            }

        }
        public static void EditorSpace_Click(dynamic form, object sender, EventArgs e)
        {
            form.PreviousCell = form.MainDataView.Rows[form.MainDataView.CurrentCell.RowIndex].Cells[form.MainDataView.CurrentCell.ColumnIndex];
        }
        public static void NewLabel_Click(dynamic form, object sender, EventArgs e)
        {
            HelpClass.SaveOrNot(form, sender, e);
            form.CurrentFile = null;
            HelpClass.RenameWindow(form);
            HelpClass.InitTable(form);
        }
        public static void OpenLabel_Click(dynamic form, object sender, EventArgs e)
        {

            try
            {
                if (form.OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                form.CurrentFile = form.OpenFileDialog.FileName;
                HelpClass.RenameWindow(form);
                HelpClass.LoadTable(form, form.CurrentFile);
                ReevaluateBtn_Click(form, sender, e);
            }
            catch
            {
                MessageBox.Show(ExcelForm.Labels["OPEN_ERROR"]);
                return;
            }

        }
        public static void SaveLabel_Click(dynamic form, object sender, EventArgs e)
        {
            try
            {
                if (form.CurrentFile == null)
                {
                    SaveAsLabel_Click(form, sender, e);
                    return;
                }
                string lines = "";
                lines += form.MainDataView.RowCount.ToString() + "," + form.MainDataView.ColumnCount.ToString();
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
                StreamWriter file = new StreamWriter(form.CurrentFile);
                file.WriteLine(lines);
                file.Close();
            }
            catch
            {
                MessageBox.Show("SAVE_ERROR");
            }
        }
        public static void SaveAsLabel_Click(dynamic form, object sender, EventArgs e)
        {
            try
            {
                if (form.SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                form.CurrentFile = form.SaveFileDialog.FileName;
                HelpClass.RenameWindow(form);
                SaveLabel_Click(form, sender, e);
            }
            catch
            {
                MessageBox.Show("SAVE_ERROR");
            }

        }
        public static void PropsLabel_Click(dynamic form, object sender, EventArgs e)
        {
            HelpClass.InitLabels(form);
        }
        public static void AboutLabel_Click(dynamic form, object sender, EventArgs e)
        {
            About AFrom = new About();
            AFrom.ShowDialog();
            AFrom.Dispose();
        }
        public static void HelpLabel_Click(dynamic form, object sender, EventArgs e)
        {
            Help HForm = new Help();
            HForm.ShowDialog(); ;
            HForm.Dispose();
        }
        public static void AddRowBtn_Click(dynamic form, object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            row.HeaderCell.Value = Convert.ToString(form.MainDataView.RowCount + 1);
            try
            {
                form.MainDataView.Rows.Add(row);
            }
            catch (InvalidOperationException)
            {
                AddColBtn_Click(form, sender, e);
                form.MainDataView.Rows.Add(row);
            }
            for (int i = 0; i < form.MainDataView.Columns.Count; i++)
            {
                Cell cell = new Cell(form.MainDataView.Columns[i].Name, form.MainDataView.RowCount);
                MyExcelVisitor.tableIdentifier[cell.Name] = cell;
            }
        }
        public static void AddColBtn_Click(dynamic form, object sender, EventArgs e)
        {
            var column = new DataGridViewTextBoxColumn();
            column.Name = "";
            int letterNum = form.MainDataView.Columns.Count;
            List<int> digits = new List<int>();
            while ((letterNum / 26) > 0)
            {
                digits.Add(letterNum % 26);
                letterNum = letterNum / 26 - 1;
            }
            digits.Add(letterNum);
            digits.Reverse();
            foreach (int digit in digits)
            {
                column.Name += Convert.ToString(Convert.ToChar(digit + 65));
            }
            form.MainDataView.Columns.Add(column);
            for (int i = 0; i < form.MainDataView.RowCount; i++)
            {
                Cell cell = new Cell(form.MainDataView.Columns[form.MainDataView.Columns.Count - 1].Name, i + 1);
                MyExcelVisitor.tableIdentifier[cell.Name] = cell;
            }
        }
        public static void RemRowBtn_Click(dynamic form,object sender, EventArgs e)
        {
            try
            {
                form.MainDataView.Rows.RemoveAt(form.MainDataView.RowCount - 1);
                for (int i = 0; i < form.MainDataView.Columns.Count; i++)
                {
                    Cell cell = new Cell(form.MainDataView.Columns[i].Name, form.MainDataView.RowCount);
                    MyExcelVisitor.tableIdentifier.Remove(cell.Name);
                }
            }
            catch { }
        }
        public static void RemColBtn_Click(dynamic form, object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < form.MainDataView.RowCount; i++)
                {
                    Cell cell = new Cell(form.MainDataView.Columns[form.MainDataView.Columns.Count - 1].Name, i + 1);
                    MyExcelVisitor.tableIdentifier.Remove(cell.Name);
                }
                form.MainDataView.Columns.RemoveAt(form.MainDataView.ColumnCount - 1);
            }
            catch { }

        }
        public static void ReevaluateBtn_Click(dynamic form, object sender, EventArgs e)
        {
            for (int i = 0; i < form.MainDataView.Rows.Count; i++)
            {
                for (int j = 0; j < form.MainDataView.Columns.Count; j++)
                {
                    if (form.MainDataView.Rows[i].Cells[j] != null &&
                        form.MainDataView.Rows[i].Cells[j].Value != null &&
                        form.MainDataView.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        string CellName = form.MainDataView.Rows[i].Cells[j].OwningColumn.Name + Convert.ToString(i + 1);
                        if (MyExcelVisitor.tableIdentifier.TryGetValue(CellName, out Cell cell))
                        {
                            try
                            {
                                form.MainDataView.Rows[i].Cells[j].Value = Calculator.Evaluate(cell.Value);
                            }
                            catch
                            {
                                form.MainDataView.Rows[i].Cells[j].Value = "ERROR";
                            }
                        }
                    }
                }
            }
        }
    }
}
