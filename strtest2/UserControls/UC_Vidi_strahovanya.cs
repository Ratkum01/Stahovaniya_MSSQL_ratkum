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
    public partial class UC_Vidi_strahovanya : UserControl
    {
        public UC_Vidi_strahovanya()
        {
            InitializeComponent();
        }

        private void UC_Vidi_strahovanya_Load(object sender, EventArgs e)
        {

            btShowData_Click(null, null);
            cbVidiStrah.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                tbKodVidiSrtah.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string kod_vida_strah = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Vidi_strahovanya WHERE kod_vida_strah =" + kod_vida_strah;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbKodVidiSrtah.Text = "";
                    tbNaymenov.Text = "";


                    btShowData_Click(null, null);
                }
            }
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Vidi_strahovanya";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_vida_strah"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_vida_strah = int.Parse(tbKodVidiSrtah.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "INSERT INTO Vidi_strahovanya (kod_vida_strah,naymenovanye) VALUES('" + kod_vida_strah + "','" + naymenovanye + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");
            tbKodVidiSrtah.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void updatButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_vida_strah = int.Parse(tbKodVidiSrtah.Text);
            string naymenovanye = tbNaymenov.Text;
            string Query = "UPDATE Vidi_strahovanya SET naymenovanye = '" + naymenovanye + "' WHERE kod_vida_strah = '" + kod_vida_strah + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been UPDATE");
            tbKodVidiSrtah.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);

        }

        private void fetch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_vida_strah = int.Parse(tbKodVidiSrtah.Text);

            string Query = "SELECT * FROM Vidi_strahovanya WHERE kod_vida_strah = " + kod_vida_strah;

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_vida_strah = int.Parse(tbKodVidiSrtah.Text);

            string Query = "DELETE FROM Vidi_strahovanya WHERE kod_vida_strah =" + kod_vida_strah;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been DELETE");
            tbKodVidiSrtah.Text = "";
            tbNaymenov.Text = "";
            btShowData_Click(null, null);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Vidi_strahovanya ";
            if (cbVidiStrah.SelectedIndex == 0)
            {
                Query += " WHERE naymenovanye Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_vida_strah = " + SeartchData;
                }
            }
            else
            {
                if (cbVidiStrah.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_vida_strah= " + SeartchData;
                }
                else if (cbVidiStrah.SelectedIndex == 2)
                {
                    Query += " WHERE naymenovanye Like'%" + SeartchData + "%' ";
                }
                

            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_vida_strah"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Vidi_strahovanya WHERE naymenovanye Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_vida_strah"], reader["naymenovanye"], "Изменить", "Удалить");
            }

            con.Close();

        }

        private void tbNaymenov_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVidiStrah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbKodVidiSrtah_TextChanged(object sender, EventArgs e)
        {

        }

        private void kk_Click(object sender, EventArgs e)
        {

        }

        private void fio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
