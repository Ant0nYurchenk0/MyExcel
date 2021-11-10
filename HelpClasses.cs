using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace MyExcel
{
    public class Cell
    {
        private string letter;
        private int number;

        private string _value;
        public string Value
        {
            get => _value;
            set => _value = value;
        }

        private string _name;
        public string Name => _name;


        public Cell(string letter, int number)
        {
            this.letter = letter;
            this.number = number;
            _name = this.letter + Convert.ToString(this.number);
            _value = null;
        }
    }
    public static class HelpClass
    {
        public static void BuildForm(dynamic form)
        {
            form.SaveFileDialog.Filter = "Table files(*.csv)|*.csv|All files(*.*)|*.*";
            form.OpenFileDialog.Filter = "Table files(*.csv)|*.csv|All files(*.*)|*.*";
            ExcelForm.Labels["CHOOSE_LANGUAGE"] = "Choose language:";
            HelpClass.InitTable(form);
            string ConfigPath = "..\\..\\..\\config.csv";
            try
            {
                var config = File.ReadLines(ConfigPath).Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);
                HelpClass.InitLabels(form, config["language"]);
            }
            catch
            {
                HelpClass.InitTable(form);
            }
        }
        public static void InitLabels(dynamic form, string FileName = null)
        {
            string path = "";
            string LangFile = "";
            if (FileName != null)
            {
                path = "..\\..\\..\\" + FileName;
            }
            else
            {
                ChooseLang CLForm = new ChooseLang();
                DialogResult dialogresult = CLForm.ShowDialog();
                if (dialogresult == DialogResult.Yes)
                {
                    LangFile = "LabelsENG.csv";
                }
                else if (dialogresult == DialogResult.No)
                {
                    LangFile = "LabelsUKR.csv";
                }
                path = "..\\..\\..\\" + LangFile;
                CLForm.Dispose();
                StreamWriter file = new StreamWriter("..\\..\\..\\config.csv");
                file.WriteLine("language," + LangFile);
                file.Close();
            }
            ExcelForm.Labels = File.ReadLines(path).Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);
            form.CoordLabel.Text = ExcelForm.Labels["SELECTED_CELL"];
            form.NewLabel.Text = ExcelForm.Labels["NEW"];
            form.OpenLabel.Text = ExcelForm.Labels["OPEN"];
            form.SaveLabel.Text = ExcelForm.Labels["SAVE"];
            form.SaveAsLabel.Text = ExcelForm.Labels["SAVE_AS"];
            form.PropsLabel.Text = ExcelForm.Labels["PROPPERTIES"];
            form.ReevaluateBtn.Text = ExcelForm.Labels["REEVALUATE"];
            form.AddColBtn.Text = ExcelForm.Labels["ADD_COLUMN"];
            form.RemColBtn.Text = ExcelForm.Labels["REMOVE_COLUMN"];
            form.AddRowBtn.Text = ExcelForm.Labels["ADD_ROW"];
            form.RemRowBtn.Text = ExcelForm.Labels["REMOVE_ROW"];
            form.AboutLabel.Text = ExcelForm.Labels["ABOUT_LABEL"];
            form.HelpLabel.Text = ExcelForm.Labels["HELP_LABEL"];
        }
        public static void InitTable(dynamic form, int? Rows = null, int? Columns = null)
        {
            form.EditorSpace.Clear();
            form.MainDataView.Rows.Clear();
            form.MainDataView.Columns.Clear();
            form.MainDataView.Refresh();
            form.MainDataView.RowHeadersWidth = 50;
            DataGridViewColumn Column = new DataGridViewColumn();
            for (int i = 0; Columns != null ? i < Columns : (i + 1) * Column.Width < form.MainDataView.Width; i++)
            {
                Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = Convert.ToString(Convert.ToChar(65 + i));
                Column.Name = Convert.ToString(Convert.ToChar(65 + i));
                form.MainDataView.Columns.Add(Column);
            }
            for (int j = 0; Rows != null ? j < Rows : (j + 2) * form.MainDataView.RowTemplate.Height < form.MainDataView.Height; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToString(j + 1);
                form.MainDataView.Rows.Add(row);

            }
            CreateCells(form);
        }
        public static void CreateCells(dynamic form)
        {
            form.MainDataView.ClearSelection();
            for (int i = 0; i < form.MainDataView.Rows.Count; i++)
            {
                for (int j = 0; j < form.MainDataView.Columns.Count; j++)
                {
                    Cell cell = new Cell(form.MainDataView.Columns[j].Name, i + 1);
                    MyExcelVisitor.tableIdentifier[cell.Name] = cell;
                }
            }
        }
        public static void SaveOrNot(dynamic form, object sender, EventArgs e)
        {
            SaveOrNot SONForm = new SaveOrNot();
            DialogResult dialogresult = SONForm.ShowDialog();
            if (dialogresult == DialogResult.Yes)
            {
                if (form.CurrentFile != null)
                {
                    Tools.SaveLabel_Click(form, sender, e);
                }
                else
                {
                    Tools.SaveAsLabel_Click(form, sender, e);
                }
            }
            SONForm.Dispose();
        }
        public static string GetCurrentCellName(dynamic form)
        {
            return form.MainDataView.CurrentCell.OwningColumn.Name + Convert.ToString(form.MainDataView.CurrentCell.RowIndex + 1);
        }
        public static void LoadTable(dynamic form, string path)
        {
            TextReader TextReader = new StreamReader(path);
            string line = TextReader.ReadLine();
            string[] size = line.Split(',');
            InitTable(form, Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));
            var table = new Dictionary<string, string>();
            while ((line = TextReader.ReadLine()) != null)
            {
                string[] arr = line.Split(',');
                table.Add(arr[0], arr[1]);
            }
            foreach (var item in table)
            {
                MyExcelVisitor.tableIdentifier[item.Key] = new Cell(Convert.ToString(item.Key[0]),
                                                                    Convert.ToInt32(item.Key[1]));
                if (item.Value == "null")
                {
                    MyExcelVisitor.tableIdentifier[item.Key].Value = null;
                }
                else
                {
                    MyExcelVisitor.tableIdentifier[item.Key].Value = item.Value;

                    form.MainDataView.Rows[Convert.ToInt32(item.Key[1]) - 49].Cells[Convert.ToInt32(item.Key[0]) - 65].Value = item.Value;
                }
            }
            TextReader.Close();
        }
        public static void RenameWindow(dynamic form)
        {
            if (form.CurrentFile != null)
            {
                form.Text = "MyExcel | " + form.CurrentFile;
            }
            else
            {
                form.Text = "MyExcel";
            }
        }
    }
}
