using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_practice
{
    public partial class LoadScreen : Form
    {
        private MainForm f;
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void toCalculateBtn_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new MainForm();
            }

            this.Hide();

            f.Show();
            f.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramm_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            this.Hide();
            aboutForm.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            string helpFilePath = Path.Combine(Application.StartupPath, "helpForm.chm");

            if (!File.Exists(helpFilePath))
            {
                MessageBox.Show("Файл справки не найден!");
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "hh.exe",
                    Arguments = $"\"{helpFilePath}\"",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
