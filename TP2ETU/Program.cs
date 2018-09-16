using System.Windows.Forms;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormOptions formOptions = new FormOptions();
            formOptions.Activate();
            formOptions.Show();
            formOptions.Enabled = true;
            formOptions.Focus();
            formOptions.Visible = true;

            Application.Run(formOptions);
        }
    }
}