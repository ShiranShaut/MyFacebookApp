using System;

namespace MyFacebookApp
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}