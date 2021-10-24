using System;
using System.Windows.Forms;


namespace Buttons
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            textLbl.Text = "Тест выведен!";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textLbl.Text = string.Empty;
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            disableBtn.Enabled = false;
        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            disableBtn.Enabled = true;
        }

        private void invisibleBtn_Click(object sender, EventArgs e)
        {
            invisibleBtn.Visible = false;
        }

        private void visibleBtn_Click(object sender, EventArgs e)
        {
            invisibleBtn.Visible = true;
        }
    }
}