using System;
using System.Windows.Forms;

namespace Decorator
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerColor = "Red";

            if (radioButton1.Checked)
            {
                playerColor = "Red";
            }
            if (radioButton2.Checked)
            {
                playerColor = "Blue";
            }
            if (radioButton3.Checked)
            {
                playerColor = "Green";
            }

            ApplicationGame app = new ApplicationGame();
            app.Run(playerColor);
        }
    }
}