using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_practice
{
    public partial class DataTableForm : Form
    {
        private DatabaseService _dbService = new DatabaseService();
        public DataTableForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var adapter = _dbService.GetAllResultsAdapter();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv1.DataSource = dt;
            adapter.Dispose();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            DatabaseService dbS = new DatabaseService();
            dbS.ClearHistory();
            LoadHistory();
        }

        private void LoadHistory()
        {
            DatabaseService db = new DatabaseService();
            DataTable table = db.GetResults();
            dgv1.DataSource = table;
        }
    }
}
