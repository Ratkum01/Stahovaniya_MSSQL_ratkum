using strtest2;
using strtest2.UserControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace strtest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        /* private void OpenChildForm(Form childForm, object btnSender)
         {
             if (activeForm != null)
             {
                 activeForm.Close();
             }
             ActivateButton(btnSender);
             activeForm = childForm;
             childForm.TopLavel = false;
             childForm.FormBorderStyle = FormBorderStyle.None;
             childForm.Dock = DockStyle.Fill;
             this.panelDesk

         }*/
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           UC_Klient us = new UC_Klient();
            addUserControl(us);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UC_Object_strah us = new UC_Object_strah();
            addUserControl(us);
        }

        private void strahovshikiButton_Click(object sender, EventArgs e)
        {
            UC_Strahovshiki us = new UC_Strahovshiki();
            addUserControl(us);
        }

        private void bankButton_Click(object sender, EventArgs e)
        {
            UC_Bank us = new UC_Bank();
            addUserControl(us);
        }

        private void perechislenieButton_Click(object sender, EventArgs e)
        {
            UC_Perechislenie us = new UC_Perechislenie();
            addUserControl(us);
        }

        private void dogovorButton_Click(object sender, EventArgs e)
        {
            UC_Dogovor us = new UC_Dogovor();
            addUserControl(us);
        }

        private void rayonButoon_Click(object sender, EventArgs e)
        {
            UC_Rayon us = new UC_Rayon();
            addUserControl(us);
        }

        private void vidi_strahovanyaButton_Click(object sender, EventArgs e)
        {
            UC_Vidi_strahovanya us = new UC_Vidi_strahovanya();
            addUserControl(us);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UC_Home us = new UC_Home();
            addUserControl(us);

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    } }


