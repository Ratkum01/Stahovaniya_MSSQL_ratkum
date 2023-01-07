using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strtest2.UserControls
{
    public partial class UC_Bank : UserControl
    {
        public UC_Bank()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                tbKodBank.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex ==4  && e.RowIndex > -1)
            {
                string kod_bank = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Bank WHERE kod_bank =" + kod_bank;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbKodBank.Text = "";
                    tbNaymenov.Text = "";
                    tbAdress.Text = "";
                    

                    btShowData_Click(null, null);
                }
            }
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Bank";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_bank"],  reader["naymenovanie"], reader["adress"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void updatButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_bank = int.Parse(tbKodBank.Text);
            string naymenovanie = tbNaymenov.Text;
            string adress = tbAdress.Text;
            string Query = "UPDATE Bank SET naymenovanie = '" + naymenovanie + "', adress= '" + adress + "' WHERE kod_bank = '" + kod_bank + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been UPDATE");
            tbKodBank.Text = "";
            tbNaymenov.Text = "";
            tbAdress.Text = "";
            btShowData_Click(null, null);
          
        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_bank = int.Parse(tbKodBank.Text);
            string naymenovanie = tbNaymenov.Text;
            string adress = tbAdress.Text;
            string Query = "INSERT INTO Bank (kod_bank,naymenovanie, adress) VALUES('" + kod_bank + "','" + naymenovanie + "','" + adress + "') ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");
            tbKodBank.Text = "";
            tbNaymenov.Text = "";
            tbAdress.Text = "";
            btShowData_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_bank = int.Parse(tbKodBank.Text);

            string Query = "DELETE FROM Bank WHERE kod_bank =" + kod_bank;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been DELETE");
            tbKodBank.Text = "";
            tbNaymenov.Text = "";
            tbAdress.Text = "";
            btShowData_Click(null, null);
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_bank = int.Parse(tbKodBank.Text);

            string Query = "SELECT * FROM Bank WHERE kod_bank = " + kod_bank;

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                tbNaymenov.Text = reader["naymenovanie"].ToString();
                tbAdress.Text = reader["adress"].ToString();
            }
            else
                MessageBox.Show(" NOO ");

            con.Close();

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Bank ";
            if (cbBank.SelectedIndex == 0)
            {
                Query += " WHERE naymenovanie Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_bank = " + SeartchData;
                }
            }
            else
            {
                if (cbBank.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_bank= " + SeartchData;
                }
                else if (cbBank.SelectedIndex == 2)
                {
                    Query += " WHERE naymenovanie Like'%" + SeartchData + "%' ";
                }
                else if (cbBank.SelectedIndex == 3)
                {
                    Query += " WHERE adress Like'%" + SeartchData + "%' ";
                }
                
            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_bank"], reader["naymenovanie"], reader["adress"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Bank WHERE naymenovanie Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_bank"], reader["naymenovanie"], reader["adress"], "Изменить", "Удалить");
            }

            con.Close();

        }
       

        private void cbBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_Bank_Load_1(object sender, EventArgs e)
        {

            btShowData_Click(null, null);
            cbBank.SelectedIndex = 0;
        }
    }
}
