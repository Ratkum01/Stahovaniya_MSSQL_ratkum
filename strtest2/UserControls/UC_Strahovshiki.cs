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
    public partial class UC_Strahovshiki : UserControl
    {
        public UC_Strahovshiki()
        {
            InitializeComponent();
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Strahovshiki";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_strahovchika"], reader["fio"], reader["iin"], reader["voznagrazhdenye"], "Изменить", "Delte");
            }

            con.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_strahovchika = int.Parse(kod_strah_text.Text);
            string fio = fio_text_box.Text;
            int iin = int.Parse(iin_textbox.Text);
            int voznagrazhdenye = int.Parse(voznagrajdenye_text.Text);
            string Query = "INSERT INTO Strahovshiki (kod_strahovchika,fio, iin, voznagrazhdenye) VALUES('" + kod_strahovchika + "','" + fio + "','" + iin + "','" + voznagrazhdenye + "') ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been saved");
            kod_strah_text.Text = "";
            fio_text_box.Text = "";
            iin_textbox.Text = "";
            voznagrajdenye_text.Text = "";
            btShowData_Click(null, null);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Strahovshiki ";
            if (cbStrahovshiki.SelectedIndex == 0)
            {
                Query += " WHERE fio Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_strahovchika = " + SeartchData;
                }
            }
            else
            {
                if (cbStrahovshiki.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_strahovchika= " + SeartchData;
                }
                else if (cbStrahovshiki.SelectedIndex == 2)
                {
                    Query += " WHERE fio Like'%" + SeartchData + "%' ";
                }
                else if (cbStrahovshiki.SelectedIndex == 3)
                {
                    Query += " WHERE iin Like'%" + SeartchData + "%' ";
                }
                else if (cbStrahovshiki.SelectedIndex == 4)
                {
                    Query += " WHERE voznagrazhdenye Like'%" + SeartchData + "%' ";
                }
            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_strahovchika"], reader["fio"], reader["iin"], reader["voznagrazhdenye"], "Изменить", "Delte");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Strahovshiki WHERE fio Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_strahovchika"], reader["fio"], reader["iin"], reader["voznagrazhdenye"], "Изменить", "Delte");
            }

            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                kod_strah_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                string kod_strahovchika = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Strahovshiki WHERE kod_strahovchika =" + kod_strahovchika;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    kod_strah_text.Text = "";
                    fio_text_box.Text = "";
                    iin_textbox.Text = "";
                    voznagrajdenye_text.Text = "";

                    btShowData_Click(null, null);
                }
            }
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_strahovchika = int.Parse(kod_strah_text.Text);

            string Query = "SELECT * FROM Strahovshiki WHERE kod_strahovchika = " + kod_strahovchika;

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                fio_text_box.Text = reader["fio"].ToString();
                iin_textbox.Text = reader["iin"].ToString();
                voznagrajdenye_text.Text = reader["voznagrazhdenye"].ToString();
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
            int kod_strahovchika = int.Parse(kod_strah_text.Text);
            string fio = fio_text_box.Text;
            int iin = int.Parse(iin_textbox.Text);
            int voznagrazhdenye = int.Parse(voznagrajdenye_text.Text);
            string Query = "UPDATE Strahovshiki SET fio= '" + fio + "', iin = '" + iin + "',voznagrazhdenye= '" + voznagrazhdenye + "' WHERE kod_strahovchika = '" + kod_strahovchika + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been UPDATE");
            kod_strah_text.Text = "";
            fio_text_box.Text = "";
            iin_textbox.Text = "";
            voznagrajdenye_text.Text = "";
            btShowData_Click(null, null);

        }

       
            private void deleteButton_Click(object sender, EventArgs e)
            {
                //dataGridView1.Rows.Clear();
                string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                int kod_strahovchika = int.Parse(kod_strah_text.Text);

                string Query = "DELETE FROM Strahovshiki WHERE kod_strahovchika =" + kod_strahovchika;

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been DELETE");
                kod_strah_text.Text = "";
                fio_text_box.Text = "";
                iin_textbox.Text = "";
                voznagrajdenye_text.Text = "";

                btShowData_Click(null, null);
            }

        private void UC_Strahovshiki_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbStrahovshiki.SelectedIndex = 0;
        }

        private void cbStrahovshiki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
