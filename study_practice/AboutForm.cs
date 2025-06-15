using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_practice
{
    public partial class AboutForm : Form
    {
        LoadScreen f;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(f == null || f.IsDisposed)
            {
                f = new LoadScreen();
            }
            f.Show();

            this.Close();
        }
    }
}
