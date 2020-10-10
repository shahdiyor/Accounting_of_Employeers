using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOE_Accounting_of_Employees_
{
    public partial class Add : Form
    {
        public static String connString = ConfigurationManager.AppSettings.Get("DBMySQL");
        MySqlConnection conn = new MySqlConnection(connString);
        public Add()
        {
            InitializeComponent();
            if (DB.edit == true)
            {
                this.Text = "Edit";
                num.Text = DB.number;
                fname.Text = DB.fullname;
                date.Text = DB.Date;
                button1.Text = "Save";
                add_sev.Hide();
            }
            else
            {
                button1.Text = "Add";
                this.Text = "Add";
                add_sev.Show(); 
            }
            load();
        }
        public void load()
        {
            conn.Open();
            string p = "Select * from position";
            MySqlCommand position = new MySqlCommand(p, conn);
            MySqlDataReader p_reader = position.ExecuteReader();
            DataTable table_1 = new DataTable();
            table_1.Load(p_reader);
            pos.DataSource = table_1;
            pos.DisplayMember = "name";
            string s = "Select * from sex";
            MySqlCommand id_sex = new MySqlCommand(s, conn);
            MySqlDataReader sex_reader = id_sex.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sex_reader);
            sex.DataSource = table;
            sex.DisplayMember = "name";
            conn.Close();
            pos.Text = DB.Position;
            sex.Text = DB.SEX;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( DB.edit == false)
            {
                conn.Open();
                string commText = "Insert into employeer(id_employeer,fio, date, id_position,id_sex) VALUES(@cod,@fio,@data_rozh,@job,@sex)";
                MySqlCommand cmd = new MySqlCommand(commText, conn);
                if (num.Text != "" && fname.Text != "" && pos.Text!="" && date.Text != "" && sex.Text!="")
                {
                    cmd.Parameters.AddWithValue("@cod", num.Text);
                    cmd.Parameters.AddWithValue("@fio", fname.Text);
                    cmd.Parameters.AddWithValue("@data_rozh", date.Text);
                    cmd.Parameters.AddWithValue("@job", pos.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@sex", sex.SelectedIndex + 1);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Добавить не удалось");
                    }
                   
                    if (add_sev.Checked == false)
                    {
                        Hide();
                    }
                    else
                    {
                        num.Clear();
                        fname.Clear();
                        date.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить все данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            else 
            {
                string s = DB.number;
                int i = Convert.ToInt32(s);
                conn.Open();
                string cm = "UPDATE employeer SET id_employeer=@cod, fio=@fio, date=@data_rozh, id_position=@job, id_sex=@pol WHERE id_employeer=" + i;
                MySqlCommand cmd = new MySqlCommand(cm, conn);
                if (num.Text!=""&& fname.Text != "" && pos.Text != "" && date.Text != "" && sex.Text!="")
                {
                    cmd.Parameters.AddWithValue("@cod", num.Text);
                    cmd.Parameters.AddWithValue("@fio", fname.Text);
                    cmd.Parameters.AddWithValue("@data_rozh", date.Text);
                    cmd.Parameters.AddWithValue("@job", pos.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@pol", sex.SelectedIndex + 1);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось сохранить");
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо заполнить все данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
                Hide();
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
