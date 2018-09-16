using System;
using System.Windows.Forms;

namespace Decorator
{
    public partial class FormOptions : Form
    {
        private bool condition;
        public FormOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorType playerColor = ColorType.Red;

            if (radioButton1.Checked)
            {
                playerColor = ColorType.Red;
            }
            if (radioButton2.Checked)
            {
                playerColor = ColorType.Blue;
            }
            if (radioButton3.Checked)
            {
                playerColor = ColorType.Green;
            }

            ApplicationGame app = new ApplicationGame();
            app.Run(playerColor);
        }
    }
}