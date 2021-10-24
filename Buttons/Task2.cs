using System;
using System.Drawing;
using System.Windows.Forms;


namespace Buttons
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void write1Btn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = "Щелчок по кнопке 1";
            resultLbl.ForeColor = Color.Red;
        }

        private void write2Btn_Click(object sender, EventArgs e)
        {
            resultLbl.Text      = "Щелчок по кнопке 2";
            resultLbl.ForeColor = Color.Green;
        }

        private void write3Btn_Click(object sender, EventArgs e)
        {
            resultLbl.Text      = "Щелчок по кнопке 3";
            resultLbl.ForeColor = Color.Blue;
        }

        private void write4Btn_Click(object sender, EventArgs e)
        {
            resultLbl.Text      = "Щелчок по кнопке 4";
            resultLbl.ForeColor = Color.Magenta;
        }
    }
}