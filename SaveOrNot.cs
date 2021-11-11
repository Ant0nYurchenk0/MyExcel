using System.Windows.Forms;

namespace MyExcel
{
    public partial class SaveOrNot : Form
    {
        public SaveOrNot()
        {
            InitializeComponent();
            InitLabels();
        }
        private void InitLabels()
        {
            if (ExcelForm.Labels.TryGetValue("SAVE_LABEL", out string saveLabel))
            {
                SaveLabel.Text = saveLabel;
                Text = saveLabel;
            }
            if (ExcelForm.Labels.TryGetValue("NO", out string noLabel))
            {
                NoBtn.Text = noLabel;
            }
            if (ExcelForm.Labels.TryGetValue("YES", out string yesLabel))
            {
                YesBtn.Text = yesLabel;
            }

        }
    }
}
