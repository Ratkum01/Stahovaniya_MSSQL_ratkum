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
    public partial class UC_Perechislenie : UserControl
    {
        public UC_Perechislenie()
        {
            InitializeComponent();
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Perechislenie";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klienta"], reader["nomer_dogovor"], reader["summa"], reader["kod_bank"], reader["god_mesyac_day"], "Изменить", "Удалить");
            }

            con.Close();
        }
    
        private void UC_Perechislenie_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbVidi.SelectedIndex = 0;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT kod_klient FROM Klient", conn);
            SqlCommand cma = new SqlCommand("SELECT nomer_dogovor FROM Dogovor", conn);
            SqlCommand cmb = new SqlCommand("SELECT kod_bank FROM Bank", conn);
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();

            SqlDataAdapter aa = new SqlDataAdapter();
            aa.SelectCommand = cma;
            DataTable table2 = new DataTable();

            SqlDataAdapter ba = new SqlDataAdapter();
            ba.SelectCommand = cmb;
            DataTable table3 = new DataTable();

            da.Fill(table1);
            aa.Fill(table2);
            ba.Fill(table3);


            cbKodKlienta.DataSource = table1;
            cbKodKlienta.DisplayMember = "kod_klient";
           cbND.DataSource = table2;
           cbND.DisplayMember = "nomer_dogovor";
            cbKodBank.DataSource = table3;
           cbKodBank.DisplayMember = "kod_bank";
      
        }
  
        private void fetch_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_klienta = int.Parse(cbKodKlienta.Text);
            string Query = "SELECT * FROM Perechislenie WHERE kod_klienta = " + kod_klienta;
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                cbND.Text = reader["nomer_dogovor"].ToString();
                tbSummaPer.Text = reader["summa"].ToString();
                cbKodBank.Text = reader["kod_bank"].ToString();
                dtDataZ.Text = reader["god_mesyac_day"].ToString();


            }
            else
                MessageBox.Show(" NOO ");

            con.Close();

        }
    
        private void updatButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int kod_klienta = int.Parse(cbKodKlienta.Text);
            int nomer_dogovor = int.Parse(cbND.Text);
            double summa = double.Parse(tbSummaPer.Text);
            int kod_bank = int.Parse(cbKodBank.Text);
            string god_mesyac_day = dtDataZ.Text;

            string Query = "UPDATE Perechislenie SET nomer_dogovor = '" + nomer_dogovor + "',summa = '" + summa + "',kod_bank = '" + kod_bank + "',god_mesyac_day = '" + god_mesyac_day + "'WHERE kod_klienta = '" + kod_klienta + "' ";
            // string Quera = ("UPDATE  Klient SET kod_klient");
            //string Querb = ("UPDATE  Dogovor SET nomer_dogovor");
            //string Querd = ("UPDATE  Bank SET kod_bank");

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Данные были ОБНОВЛЕНЫ");

            cbKodKlienta.Text = "";
            cbND.Text = "";
            tbSummaPer.Text = "";
            cbKodBank.Text = "";
            dtDataZ.Text = "";
            btShowData_Click(null, null);

        }
        /*
kod_klienta
nomer_dogovor
summa
kod_bank
god_mesyac_day

cbKodKlienta.Text = "";
cbND.Text = "";
tbSummaPer.Text = "";
cbKodBank.Text = "";
dtDataPer.Text = "";
*/
        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int kod_klienta = int.Parse(cbKodKlienta.Text);
            int nomer_dogovor = int.Parse(cbND.Text);
            double summa = double.Parse(tbSummaPer.Text);
            int kod_bank = int.Parse(cbKodBank.Text);
            string god_mesyac_day = dtDataZ.Text;
            string Query = "INSERT INTO Perechislenie (kod_klienta,nomer_dogovor,summa,kod_bank,god_mesyac_day) VALUES('" + kod_klienta + "','" + nomer_dogovor + "','" + summa + "','" + kod_bank + "','" + god_mesyac_day + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");

            cbKodKlienta.Text = "";
            cbND.Text = "";
            tbSummaPer.Text = "";
            cbKodBank.Text = "";
            dtDataZ.Text = "";
            btShowData_Click(null, null);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int kod_klienta = int.Parse(cbKodKlienta.Text);

            string Query = "DELETE FROM Perechislenie WHERE kod_klienta =" + kod_klienta;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были УДАЛЕНЫ");
            cbKodKlienta.Text = "";
            cbND.Text = "";
            tbSummaPer.Text = "";
            cbKodBank.Text = "";
            dtDataZ.Text = "";
            btShowData_Click(null, null);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==  5 && e.RowIndex > -1)
            {
                cbKodKlienta.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                string kod_klienta = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();

                    string Query = "DELETE FROM Perechislenie WHERE kod_klienta =" + kod_klienta;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    cbKodKlienta.Text = "";
                    cbND.Text = "";
                    tbSummaPer.Text = "";
                    cbKodBank.Text = "";
                    dtDataZ.Text = "";
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
            string Query = "SELECT * FROM Perechislenie ";
            if (cbVidi.SelectedIndex == 0)
            {
                Query += " WHERE summa Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR kod_klienta = " + SeartchData;
                }
            }
            else
            {
                if (cbVidi.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE kod_klienta Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 2)
                {
                    Query += " WHERE nomer_dogovor Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 3)
                {
                    Query += " WHERE summa Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 4)
                {
                    Query += " WHERE kod_bank Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 5)
                {
                    Query += " WHERE god_mesyac_day Like'%" + SeartchData + "%' ";
                }
                
            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klienta"], reader["nomer_dogovor"], reader["summa"], reader["kod_bank"], reader["god_mesyac_day"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;

            string Query = "SELECT * FROM Perechislenie WHERE summa Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["kod_klienta"], reader["nomer_dogovor"], reader["summa"], reader["kod_bank"], reader["god_mesyac_day"], "Изменить", "Удалить");

            }

            con.Close();

        }
    }
}
