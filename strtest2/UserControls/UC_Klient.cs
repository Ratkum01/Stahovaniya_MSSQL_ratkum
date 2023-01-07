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
    public partial class UC_Klient : UserControl
    {
        public UC_Klient()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UC_Klient_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbVidi.SelectedIndex = 0;
            SqlConnection conn = new SqlConnection ( "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT kod_rayona,kod_bank FROM Klient", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            da.Fill(table1);
            da.Fill(table2);
            comboBox1.DataSource= table1;
            comboBox1.DisplayMember = "kod_rayona";
            comboBox2.DataSource = table1;
            comboBox2.DisplayMember = "kod_bank";

        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Klient";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klient"], reader["fio"], reader["priznak_kli"], reader["kod_rayona"], reader["lic_schet"], reader["kod_bank"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                tbKodKlient.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                string kod_klient = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Klient WHERE kod_klient =" + kod_klient;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbKodKlient.Text = "";
                    tbFIO.Text = "";
                    comboBox3.Text = "";
                    comboBox1.Text = "";
                    tbLicShet.Text = "";
                    comboBox2.Text = "";


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
            int kod_klient = int.Parse(tbKodKlient.Text);
            string fio = tbFIO.Text;
            string priznak_kli = comboBox3.Text;
            int kod_rayona = int.Parse(comboBox1.Text);
            string lic_schet = tbLicShet.Text;
            int kod_bank = int.Parse(comboBox2.Text);
            string Query = "UPDATE Klient SET fio = '" + fio + "',priznak_kli = '" + priznak_kli + "',kod_rayona = '" + kod_rayona + "',lic_schet = '" + lic_schet + "',kod_bank ='" + kod_bank + "' WHERE kod_klient = '" + kod_klient + "' "; 
            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были ОБНОВЛЕНЫ");
            tbKodKlient.Text = "";
            tbFIO.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            tbLicShet.Text = "";
            comboBox2.Text = "";
            btShowData_Click(null, null);

        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_klient = int.Parse(tbKodKlient.Text);
            string fio = tbFIO.Text;
            string priznak_kli = comboBox3.Text;
            int kod_rayona = int.Parse(comboBox1.Text);
            string lic_schet = tbLicShet.Text;
            int kod_bank = int.Parse(comboBox2.Text);
            string Query = "INSERT INTO Klient (kod_klient,fio,priznak_kli,kod_rayona,lic_schet,kod_bank) VALUES('" + kod_klient + "','" + fio + "','" + priznak_kli + "','" + kod_rayona + "','" + lic_schet + "','" + kod_bank + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");
            tbKodKlient.Text = "";
            tbFIO.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            tbLicShet.Text = "";
            comboBox2.Text = "";
            btShowData_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_klient = int.Parse(tbKodKlient.Text);

            string Query = "DELETE FROM Klient WHERE kod_klient =" + kod_klient;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были УДАЛЕНЫ");
            tbKodKlient.Text = "";
            tbFIO.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            tbLicShet.Text = "";
            comboBox2.Text = "";
            btShowData_Click(null, null);
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_klient = int.Parse(tbKodKlient.Text);

            string Query = "SELECT * FROM Klient WHERE kod_klient = " + kod_klient;

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                tbFIO.Text = reader["fio"].ToString();
                comboBox3.Text = reader["priznak_kli"].ToString();
                comboBox1.Text = reader["kod_rayona"].ToString();
                tbLicShet.Text = reader["lic_schet"].ToString();
                comboBox2.Text = reader["kod_bank"].ToString();
             
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
            string Query = "SELECT * FROM Klient ";
            if (cbVidi.SelectedIndex == 0)
            {
                Query += " WHERE fio Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_klient = " + SeartchData;
                }
            }
            else
            {
                if (cbVidi.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_klient= " + SeartchData;
                }
                else if (cbVidi.SelectedIndex == 2)
                {
                    Query += " WHERE fio Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 3)
                {
                    Query += " WHERE priznak_kli Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 4)
                {
                    Query += " WHERE kod_rayona Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 5)
                {
                    Query += " WHERE lic_schet Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 6)
                {
                    Query += " WHERE kod_bank Like'%" + SeartchData + "%' ";
                }
              


            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klient"], reader["fio"], reader["priznak_kli"], reader["kod_rayona"], reader["lic_schet"], reader["kod_bank"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;
            string Query = "SELECT * FROM Klient WHERE fio Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klient"], reader["fio"], reader["priznak_kli"], reader["kod_rayona"], reader["lic_schet"], reader["kod_bank"], "Изменить", "Удалить");
            }

            con.Close();

        }

        private void cbVidi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
