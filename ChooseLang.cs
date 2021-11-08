using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExcel
{
    public partial class ChooseLang : Form
    {
        public ChooseLang()
        {
            InitializeComponent();
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
