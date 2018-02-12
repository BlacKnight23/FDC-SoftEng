using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Accounting
{
    public partial class main_menu : Form
    {
        
        public string getusertype { get; set; }
        public string getuser { get; set; }

        public log_in form_login;

        MySqlConnection conn;
        public main_menu()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            label_name.Text = this.getusertype;
            mainmenulabel_id.Text = this.getuser;
            if(label_name.Text != "Admin")
            {
                tab_user.Hide();
            } 
            
        }

        private void tab_appoinment_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(USC_appointment.Instance))
            {
                panel3.Controls.Add(USC_appointment.Instance);
                USC_appointment.Instance.Dock = DockStyle.Fill;
                USC_appointment.Instance.BringToFront();
            }
            else
                USC_appointment.Instance.BringToFront();
        }
    

        private void tab_patient_Click(object sender, EventArgs e)
        {
        if (!panel3.Controls.Contains(USC_patient.Instance))
        {
            panel3.Controls.Add(USC_patient.Instance);
                USC_patient.Instance.Dock = DockStyle.Fill;
                USC_patient.Instance.BringToFront();
        }
        else
                USC_patient.Instance.BringToFront();
    }


        private void tab_dentalchart_Click(object sender, EventArgs e)
        {
        if (!panel3.Controls.Contains(USC_dentalchart.Instance))
        {
            panel3.Controls.Add(USC_dentalchart.Instance);
                USC_dentalchart.Instance.Dock = DockStyle.Fill;
                USC_dentalchart.Instance.BringToFront();
        }
        else
                USC_dentalchart.Instance.BringToFront();
         }


        private void tab_sales_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(USC_sales.Instance))
            {
                panel3.Controls.Add(USC_sales.Instance);
                USC_sales.Instance.Dock = DockStyle.Fill;
                USC_sales.Instance.BringToFront();
            }
            else
                USC_sales.Instance.BringToFront();
        }

        private void tab_users_Click(object sender, EventArgs e)
        {
            
        }

   

        private void mainmenulabel_id_Click(object sender, EventArgs e)
        {

        }

        private void tab_credential_Click_1(object sender, EventArgs e)
        {
            String usr = mainmenulabel_id.Text;

            string query = "SELECT * FROM user WHERE user_username = '" + usr + "'";

            conn.Open(); //open MySql connection
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                string firstname = dt.Rows[0]["user_firstname"].ToString();
                string lastname = dt.Rows[0][2].ToString();
                string ussr = dt.Rows[0][3].ToString();
                string user_type = dt.Rows[0][5].ToString();


                USC_credential form_credential = new USC_credential();
                form_credential.getussr = ussr;
                form_credential.form_mainmenu = this;

                form_credential.Show();


            }

            if (!panel3.Controls.Contains(USC_credential.Instance))
            {
                panel3.Controls.Add(USC_credential.Instance);
                USC_credential.Instance.Dock = DockStyle.Fill;
                USC_credential.Instance.BringToFront();
            }
            else
                USC_credential.Instance.BringToFront();
        }

        private void tab_inventory_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(USC_inventory.Instance))
            {
                panel3.Controls.Add(USC_inventory.Instance);
                USC_inventory.Instance.Dock = DockStyle.Fill;
                USC_inventory.Instance.BringToFront();
            }
            else
                USC_inventory.Instance.BringToFront();
        }

        private void tab_user_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(USC_user.Instance))
            {
                panel3.Controls.Add(USC_user.Instance);
                USC_user.Instance.Dock = DockStyle.Fill;
                USC_user.Instance.BringToFront();
            }
            else
                USC_user.Instance.BringToFront();
        }
    }
}
