using System;
using System.Globalization;
using System.Windows.Forms;


namespace Buttons
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var    x = double.Parse(xTb.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            double result;

            if (x < 0)
            {
                result = Math.Pow(x, 2) + 1;
            }
            else if (x >= 0 && x <= 1)
            {
                result = 2 * x + 1;
            }
            else
            {
                result = 4 * x - 1;
            }

            resultLbl.Text = $@"{result:F}";
        }
    }
}