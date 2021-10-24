using System;
using System.Windows.Forms;


namespace Buttons
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var length = double.Parse(lengthTb.Text);

            var result = length / 100;
            resultLbl.Text = $@"{result:F}";
        }
    }
}