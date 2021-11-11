using System;
using System.Windows.Forms;

namespace MyExcel
{
    public partial class ChooseLang : Form
    {
        public ChooseLang()
        {
            InitializeComponent();
            InitLabels();
        }
        private void InitLabels()
        {
            if (ExcelForm.Labels.TryGetValue("CHOOSE_LANGUAGE", out string chooseLangLabel))
            {
                ChooseLangLabel.Text = chooseLangLabel;
                Text = chooseLangLabel;
            }
        }

        private void ChoseLangLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
