using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PagedList;

namespace AOE_Accounting_of_Employees_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            load();

        }
        public static string connString = ConfigurationManager.AppSettings.Get("DBMySQL");
        MySqlConnection conn = new MySqlConnection(connString);

        public void load()
        {
            try
            {
                conn.Open();
                string quarry = "select id_employeer, fio, date, sex.name, position.name from employeer inner join sex on employeer.id_sex=sex.id_sex inner join position on employeer.id_position=position.id;";
                MySqlCommand cmd = new MySqlCommand(quarry, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Full name";
                dataGridView1.Columns[2].HeaderText = "Date";
                dataGridView1.Columns[3].HeaderText = "Sex";
                dataGridView1.Columns[4].HeaderText = "Position";
                conn.Close();
            }
            catch
            {
                MessageBox.Show("DB not found","Attention");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
                load();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            conn.Open();
            string delete = "delete from employeer where id_employeer=" + dataGridView1.CurrentRow.Cells[0].Value;
            MySqlCommand cmd = new MySqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            load();
        }

        private void update_data(object sender, EventArgs e)
        {
            load();
        }

        public void Edit_Click(object sender, EventArgs e)
        {
            DB.edit = true;
            DB.number = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DB.fullname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DB.Date = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DB.SEX = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DB.Position = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Add f = new Add();
            f.ShowDialog();
                load();
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object row_header = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (row_header == null || !row_header.Equals((e.RowIndex + 1).ToString()))
            {
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = ((e.RowIndex + 1).ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void prewiewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void fastPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
