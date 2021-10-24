using System;
using System.Windows.Forms;


namespace Buttons
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            textLbl.Text = "Привет";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textLbl.Text = string.Empty;
        }
    }
}