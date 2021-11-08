using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyExcel
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            if (ExcelForm.Labels.TryGetValue("HELP_TEXT", out string helpText))
            {
                HelpText.Text = helpText;
            }
            if (ExcelForm.Labels.TryGetValue("HELP_LABEL", out string helpLabel))
            {
                Text = helpLabel;
            }
        }
    }
}
