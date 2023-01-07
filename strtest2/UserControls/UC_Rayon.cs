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
    public partial class UC_Rayon : UserControl
    {
        public UC_Rayon()
        {
            InitializeComponent();
        }

        private void UC_Rayon_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbVidi.SelectedIndex = 0;
        }


        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Rayon";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_rayona"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                tbKodRayon.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string kod_rayona = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Rayon WHERE kod_rayona =" + kod_rayona;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbKodRayon.Text = "";
                    tbNaymenov.Text = "";


                    btShowData_Click(null, null);
                }
            }
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Rayon ";
            if (cbVidi.SelectedIndex == 0)
            {
                Query += " WHERE naymenovanye Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_rayona = " + SeartchData;
                }
            }
            else
            {
                if (cbVidi.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_rayona= " + SeartchData;
                }
                else if (cbVidi.SelectedIndex == 2)
                {
                    Query += " WHERE naymenovanye Like'%" + SeartchData + "%' ";
                }


            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_rayona"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_rayona = int.Parse(tbKodRayon.Text);

            string Query = "SELECT * FROM Rayon WHERE kod_rayona = " + kod_rayona;

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                tbNaymenov.Text = reader["naymenovanye"].ToString();

            }
            else
                MessageBox.Show(" NOO ");

            con.Close();

        }

        private void updatButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_rayona = int.Parse(tbKodRayon.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "UPDATE Rayon SET naymenovanye = '" + naymenovanye + "' WHERE kod_rayona = '" + kod_rayona + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been UPDATE");
            tbKodRayon.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);

        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_rayona = int.Parse(tbKodRayon.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "INSERT INTO Rayon (kod_rayona,naymenovanye) VALUES('" + kod_rayona + "','" + naymenovanye + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");
            tbKodRayon.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_rayona = int.Parse(tbKodRayon.Text);

            string Query = "DELETE FROM Rayon WHERE kod_rayona =" + kod_rayona;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были УДАЛЕНЫ");
            tbKodRayon.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Rayon WHERE naymenovanye Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_rayona"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();

        }
    }
}
