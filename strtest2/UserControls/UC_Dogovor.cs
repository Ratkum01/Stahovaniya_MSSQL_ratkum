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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace strtest2.UserControls
{
    public partial class UC_Dogovor : UserControl
    {
        public UC_Dogovor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "Select * from Dogovor";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["nomer_dogovor"], reader["kod_klienta"], reader["kod_vida_strahovanie"], reader["kod_object"], reader["kratkaya_harakter_object"], reader["nakoplennaya_summa"], reader["data_zakluychenie"], reader["kod_strahovsika"], reader["kol_object"], reader["razmer_mesc_vznos"], reader["srok_deystviya_dogovora"], reader["summa_strah_po_dogr"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void UC_Dogovor_Load(object sender, EventArgs e)
        {
            btShowData_Click(null, null);
            cbVidi.SelectedIndex = 0;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT kod_klienta,kod_vida_strahovanie,kod_object,kod_strahovsika FROM Dogovor", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
          /*  DataTable table5 = new DataTable();
            DataTable table6 = new DataTable();*/
            da.Fill(table1);
            da.Fill(table2);
            da.Fill(table3);
            da.Fill(table4);
          /*  da.Fill(table5);
            da.Fill(table6);*/
            cbKodKlient.DataSource = table1;
            cbKodKlient.DisplayMember = "kod_klienta";
            cbKVS.DataSource = table2;
            cbKVS.DisplayMember = "kod_vida_strahovanie";
            cbKO.DataSource = table3;
            cbKO.DisplayMember = "kod_object";
            cbKS.DataSource = table4;
            cbKS.DisplayMember = "kod_strahovsika";
           /* dtDataZ.DateTimePicker = table5;
            dtDataZ.DisplayMember = "data_zakluychenie";
            dtSrokDD.DataSource = table6;
            dtSrokDD.DisplayMember = "srok_deystviya_dogovora";*/
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int nomer_dogovor = int.Parse(tbNomerDogovor.Text);
            string Query = "SELECT * FROM Dogovor WHERE nomer_dogovor = " + nomer_dogovor;
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                cbKodKlient.Text = reader["kod_klienta"].ToString();
                cbKVS.Text = reader["kod_vida_strahovanie"].ToString();
                cbKO.Text = reader["kod_object"].ToString();
                tbKratkayaH.Text = reader["kratkaya_harakter_object"].ToString();
                tbNakopS.Text = reader["nakoplennaya_summa"].ToString();
                dtDataZ.Text = reader["data_zakluychenie"].ToString();
                cbKS.Text = reader["kod_strahovsika"].ToString();
                tbKolO.Text = reader["kol_object"].ToString();
                tbRazmMvz.Text = reader["razmer_mesc_vznos"].ToString();
                dtSrokDD.Text = reader["srok_deystviya_dogovora"].ToString();
                tbSummaSPD.Text = reader["summa_strah_po_dogr"].ToString();
             
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

            int nomer_dogovor = int.Parse(tbNomerDogovor.Text);
            int kod_klienta = int.Parse(cbKodKlient.Text);
            int kod_vida_strahovanie = int.Parse(cbKVS.Text);
            int kod_object = int.Parse(cbKO.Text);
            string kratkaya_harakter_object = tbKratkayaH.Text;
            double nakoplennaya_summa = double.Parse(tbNakopS.Text);
            string data_zakluychenie = dtDataZ.Text;
            int kod_strahovsika = int.Parse(cbKS.Text);
            int kol_object = int.Parse(tbKolO.Text);
            double razmer_mesc_vznos = double.Parse(tbRazmMvz.Text);
            string srok_deystviya_dogovora = dtSrokDD.Text;
            double summa_strah_po_dogr = double.Parse(tbSummaSPD.Text);

            string Query = "UPDATE Dogovor SET kod_klienta = '" + kod_klienta + "',kod_vida_strahovanie = '" + kod_vida_strahovanie + "',kod_object = '" + kod_object + "',kratkaya_harakter_object = '" + kratkaya_harakter_object + "',nakoplennaya_summa ='" + nakoplennaya_summa + "',data_zakluychenie = '" + data_zakluychenie + "',kod_strahovsika = '" + kod_strahovsika + "',kol_object = '" + kol_object + "',razmer_mesc_vznos = '" + razmer_mesc_vznos + "',srok_deystviya_dogovora = '" + srok_deystviya_dogovora + "',summa_strah_po_dogr = '" + summa_strah_po_dogr + "'WHERE nomer_dogovor = '" + nomer_dogovor + "' ";
            
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Данные были ОБНОВЛЕНЫ");

            tbNomerDogovor.Text = "";
            cbKodKlient.Text = "";
            cbKVS.Text = "";
            cbKO.Text = "";
            tbKratkayaH.Text = "";
            tbNakopS.Text = "";
            dtDataZ.Text = "";
            cbKS.Text = "";
            tbKolO.Text = "";
            tbRazmMvz.Text = "";
            dtSrokDD.Text = "";
            tbSummaSPD.Text = "";
            btShowData_Click(null, null);

        }

        private void save_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int nomer_dogovor = int.Parse(tbNomerDogovor.Text);
            int kod_klienta = int.Parse(cbKodKlient.Text);
            int kod_vida_strahovanie = int.Parse(cbKVS.Text);
            int kod_object = int.Parse(cbKO.Text);
            string kratkaya_harakter_object = tbKratkayaH.Text;
            double nakoplennaya_summa = double.Parse(tbNakopS.Text);
            string data_zakluychenie = dtDataZ.Text;
            int kod_strahovsika = int.Parse(cbKS.Text);
            int kol_object = int.Parse(tbKolO.Text);
            double razmer_mesc_vznos = double.Parse(tbRazmMvz.Text);
            string srok_deystviya_dogovora = dtSrokDD.Text;
            double summa_strah_po_dogr = double.Parse(tbSummaSPD.Text);
            string Query = "INSERT INTO Dogovor (nomer_dogovor,kod_klienta,kod_vida_strahovanie,kod_object,kratkaya_harakter_object,nakoplennaya_summa,data_zakluychenie,kod_strahovsika,kol_object,razmer_mesc_vznos,srok_deystviya_dogovora,summa_strah_po_dogr) VALUES('" + nomer_dogovor + "','" + kod_klienta + "','" + kod_vida_strahovanie + "','" + kod_object + "','" + kratkaya_harakter_object + "','" + nakoplennaya_summa + "','" + data_zakluychenie + "','" + kod_strahovsika + "','" + kol_object + "','" + razmer_mesc_vznos + "','" + srok_deystviya_dogovora + "','" + summa_strah_po_dogr + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");
            tbNomerDogovor.Text = "";
            cbKodKlient.Text = "";
            cbKVS.Text = "";
            cbKO.Text = "";
            tbKratkayaH.Text = "";
            tbNakopS.Text = "";
            dtDataZ.Text = "";
            cbKS.Text = "";
            tbKolO.Text = "";
            tbRazmMvz.Text = "";
            dtSrokDD.Text = "";
            btShowData_Click(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //dataGridView1.Rows.Clear();
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int nomer_dogovor = int.Parse(tbNomerDogovor.Text);

            string Query = "DELETE FROM Dogovor WHERE nomer_dogovor =" + nomer_dogovor;

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные были УДАЛЕНЫ");
            tbNomerDogovor.Text = "";
            cbKodKlient.Text = "";
            cbKVS.Text = "";
            cbKO.Text = "";
            tbKratkayaH.Text = "";
            tbNakopS.Text = "";
            dtDataZ.Text = "";
            cbKS.Text = "";
            tbKolO.Text = "";
            tbRazmMvz.Text = "";
            dtSrokDD.Text = "";
            btShowData_Click(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12 && e.RowIndex > -1)
            {
                tbNomerDogovor.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == 13 && e.RowIndex > -1)
            {
                string nomer_dogovor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Вы точно хотите удалить ? ", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dataGridView1.Rows.Clear();
                    string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    //int kod_strahovchika = int.Parse(kod_strah_text.Text);

                    string Query = "DELETE FROM Dogovor WHERE nomer_dogovor =" + nomer_dogovor;

                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные были удалены");
                    tbNomerDogovor.Text = "";
                    cbKodKlient.Text = "";
                    cbKVS.Text = "";
                    cbKO.Text = "";
                    tbKratkayaH.Text = "";
                    tbNakopS.Text = "";
                    dtDataZ.Text = "";
                    cbKS.Text = "";
                    tbKolO.Text = "";
                    tbRazmMvz.Text = "";
                    dtSrokDD.Text = "";
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
            string Query = "SELECT * FROM Dogovor ";
            if (cbVidi.SelectedIndex == 0)
            {
                Query += " WHERE kratkaya_harakter_object Like'%" + SeartchData + "%' ";
                if (int.TryParse(SeartchData, out _))
                {
                    Query += "OR nomer_dogovor = " + SeartchData;
                }
            }
            else
            {
                if (cbVidi.SelectedIndex == 1 && SeartchData.Length > 0)
                {
                    Query += " WHERE nomer_dogovor= " + SeartchData;
                }
                else if (cbVidi.SelectedIndex == 2)
                {
                    Query += " WHERE kod_klienta Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 3)
                {
                    Query += " WHERE kod_vida_strahovanie Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 4)
                {
                    Query += " WHERE kod_object Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 5)
                {
                    Query += " WHERE kratkaya_harakter_object Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 6)
                {
                    Query += " WHERE nakoplennaya_summa Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 7)
                {
                    Query += " WHERE data_zakluychenie Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 8)
                {
                    Query += " WHERE kod_strahovsika Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 9)
                {
                    Query += " WHERE kol_object Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 10)
                {
                    Query += " WHERE razmer_mesc_vznos Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 11)
                {
                    Query += " WHERE srok_deystviya_dogovora Like'%" + SeartchData + "%' ";
                }
                else if (cbVidi.SelectedIndex == 12)
                {
                    Query += " WHERE summa_strah_po_dogr Like'%" + SeartchData + "%' ";
                }


            }

            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["nomer_dogovor"], reader["kod_klienta"], reader["kod_vida_strahovanie"], reader["kod_object"], reader["kratkaya_harakter_object"], reader["nakoplennaya_summa"], reader["data_zakluychenie"], reader["kod_strahovsika"], reader["kol_object"], reader["razmer_mesc_vznos"], reader["srok_deystviya_dogovora"], reader["summa_strah_po_dogr"], "Изменить", "Удалить");
            }

            con.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-ESH2DG9;Initial Catalog=Strahovka;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string SeartchData = SearchBox.Text;

            string Query = "SELECT * FROM Dogovor WHERE kratkaya_harakter_object Like'%" + SeartchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["nomer_dogovor"], reader["kod_klienta"], reader["kod_vida_strahovanie"], reader["kod_object"], reader["kratkaya_harakter_object"], reader["nakoplennaya_summa"], reader["data_zakluychenie"], reader["kod_strahovsika"], reader["kol_object"], reader["razmer_mesc_vznos"], reader["srok_deystviya_dogovora"], reader["summa_strah_po_dogr"], "Изменить", "Удалить");

            }

            con.Close();

        }
    }
}
/*
 nomer_dogovor
kod_klienta
kod_vida_strahovanie
kod_object
kratkaya_harakter_object
nakoplennaya_summa
data_zakluychenie
kod_strahovsika
kol_object
razmer_mesc_vznos
srok_deystviya_dogovora
summa_strah_po_dogr

tbNomerDogovor
cbKodKlient.Text 
               cbKVS.Text 
                cbKO.Text
                tbKratkayaH.Text 
                tbNakopS.Text
                dtDataZ.Text
                cbKS.Text
                tbKolO.Text
                tbRazmMvz.Text
                dtSrokDD.Text
                tbSummaSPD.Text
 */