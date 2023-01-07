using System;
using System.CodeDom;
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
    public partial class UC_Object_strah : UserControl
    {
        public UC_Object_strah()
        {
            InitializeComponent();
        }

        private void UC_Object_strah_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbVidi.SelectedIndex = 0;
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Object_strah";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_object"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                tbKodObject.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string kod_object = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Object_strah WHERE kod_object =" + kod_object;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbKodObject.Text = "";
                    tbNaymenov.Text = "";


                    btShowData_Click(null, null);
                }
            }
        }

        private void updatButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_object = int.Parse(tbKodObject.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "UPDATE Object_strah SET naymenovanye = '" + naymenovanye + "' WHERE kod_object = '" + kod_object + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been UPDATE");
            tbKodObject.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);

        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_object = int.Parse(tbKodObject.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "INSERT INTO Object_strah (kod_object,naymenovanye) VALUES('" + kod_object + "','" + naymenovanye + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");
            tbKodObject.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_object = int.Parse(tbKodObject.Text);

            string Query = "DELETE FROM Object_strah WHERE kod_object =" + kod_object;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были УДАЛЕНЫ");
            tbKodObject.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_rayona = int.Parse(tbKodObject.Text);

            string Query = "SELECT * FROM Object_strah WHERE kod_object = " + kod_rayona;

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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Object_strah ";
            if (cbVidi.SelectedIndex == 0)
            {
                Query += " WHERE naymenovanye Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_object = " + SeartchData;
                }
            }
            else
            {
                if (cbVidi.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_object= " + SeartchData;
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
                dataGridView1.Rows.Add(reader["kod_object"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Object_strah WHERE naymenovanye Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_object"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();

        }
    }
    }
