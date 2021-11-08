﻿using System;
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
    public partial class FileName : Form
    {
        public FileName()
        {
            InitializeComponent();
            InitLabels();
        }
        public string NameOfFile = "";
        private void InitLabels()
        {
            if (ExcelForm.Labels.TryGetValue("INPUT_FILE_NAME", out string fileLabel))
            {
                FileNameLabel.Text = fileLabel;
                Text = fileLabel;

            }
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {

            NameOfFile = FileNameTextBox.Text;
        }
    }
}