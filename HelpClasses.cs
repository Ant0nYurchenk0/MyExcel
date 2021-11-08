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
        private void RenameWindow()
        {
            if (CurrentFile != null)
            {
                Text = "MyExcel | " + CurrentFile;
            }
            else
            {
                Text = "MyExcel";
            }
        }
        private void LoadTable(string path)
        {
            TextReader TextReader = new StreamReader(path);
            string line = TextReader.ReadLine();
            string[] size = line.Split(',');
            InitTable(Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));
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

                    MainDataView.Rows[Convert.ToInt32(item.Key[1]) - 49].Cells[Convert.ToInt32(item.Key[0]) - 65].Value = item.Value;
                }
            }
            TextReader.Close();
        }
        private void SaveOrNot(object sender, EventArgs e)
        {
            SaveOrNot SONForm = new SaveOrNot();
            DialogResult dialogresult = SONForm.ShowDialog();
            if (dialogresult == DialogResult.Yes)
            {
                if (CurrentFile != null)
                {
                    SaveLabel_Click(sender, e);
                }
                else
                {
                    SaveAsLabel_Click(sender, e);
                }
            }
            SONForm.Dispose();
        }
        private void CreateCells()
        {
            MainDataView.ClearSelection();
            for (int i = 0; i < MainDataView.Rows.Count; i++)
            {
                for (int j = 0; j < MainDataView.Columns.Count; j++)
                {
                    Cell cell = new Cell(MainDataView.Columns[j].Name, i + 1);
                    MyExcelVisitor.tableIdentifier[cell.Name] = cell;
                }
            }
        }
        private void InitLabels(string FileName = null)
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
            Labels = File.ReadLines(path).Select(line => line.Split(',')).ToDictionary(line => line[0], line => line[1]);
            CoordLabel.Text = Labels["SELECTED_CELL"];
            NewLabel.Text = Labels["NEW"];
            OpenLabel.Text = Labels["OPEN"];
            SaveLabel.Text = Labels["SAVE"];
            SaveAsLabel.Text = Labels["SAVE_AS"];
            PropsLabel.Text = Labels["PROPPERTIES"];
            ReevaluateBtn.Text = Labels["REEVALUATE"];
            AddColBtn.Text = Labels["ADD_COLUMN"];
            RemColBtn.Text = Labels["REMOVE_COLUMN"];
            AddRowBtn.Text = Labels["ADD_ROW"];
            RemRowBtn.Text = Labels["REMOVE_ROW"];
            AboutLabel.Text = Labels["ABOUT_LABEL"];
            HelpLabel.Text = Labels["HELP_LABEL"];
        }
        public string GetCurrentCellName()
        {
            return MainDataView.CurrentCell.OwningColumn.Name + Convert.ToString(MainDataView.CurrentCell.RowIndex + 1);
        }
        private void InitTable(int? Rows = null, int? Columns = null)
        {
            MainDataView.Rows.Clear();
            MainDataView.Columns.Clear();
            MainDataView.Refresh();
            MainDataView.RowHeadersWidth = 50;
            DataGridViewColumn Column = new DataGridViewColumn();
            for (int i = 0; Columns != null ? i < Columns : (i + 1) * Column.Width < MainDataView.Width; i++)
            {
                Column = new DataGridViewTextBoxColumn();
                Column.HeaderText = Convert.ToString(Convert.ToChar(65 + i));
                Column.Name = Convert.ToString(Convert.ToChar(65 + i));
                MainDataView.Columns.Add(Column);
            }
            for (int j = 0; Rows != null ? j < Rows : (j + 2) * MainDataView.RowTemplate.Height < MainDataView.Height; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToString(j + 1);
                MainDataView.Rows.Add(row);

            }
            CreateCells();
        }
    }
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
}
