using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Accounting
{
    public partial class USC_patient_info : UserControl
    {
        MySqlConnection conn;
        MySqlDataAdapter adp;
        DataTable dt;

        private static USC_patient_info _instance;

        public static USC_patient_info Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_patient_info();
                return _instance;
            }
        }
        public USC_patient_info()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void USC_patient_info_Load(object sender, EventArgs e)
        {
            loadAll();
        }
        private void loadAll()
        {
            string query = "SELECT * from patient";

            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["patient_id"].Visible = false;
            dataGridView1.Columns["patient_firstname"].HeaderText = "Firstname";
            dataGridView1.Columns["patient_lastname"].HeaderText = "Lastname";

            //dataGridView1.Columns["patient_status"].HeaderText = "Year Started";
            dataGridView1.Columns["patient_address"].HeaderText = "Address";
            dataGridView1.Columns["patient_age"].HeaderText = "Age";
            dataGridView1.Columns["patient_gender"].HeaderText = "Gender";
            dataGridView1.Columns["patient_contact1"].HeaderText = "Contact 1";
            dataGridView1.Columns["patient_contact2"].HeaderText = "Contact 2";


            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text == " " || textBox_lastname.Text == " " || textBox_address.Text == " " || textBox_age.Text == " "
              || combo_gender.Text == " " || textBox_contact1.Text == " " || textBox_contact2.Text == " ")
            {
                MessageBox.Show("Please input required fields.");
            }
            else
            {
                String query6 = "INSERT INTO patient (patient_firstname, patient_lastname, patient_bdate, patient_address, patient_age, patient_gender, patient_contact1, patient_contact2) " +
                               "VALUES('" + textBox_firstname.Text + "', '" + textBox_lastname.Text + "', '" + birth_date.Value.ToString("yyyy-MM-dd") + "', '" + textBox_address.Text + "', '" + textBox_age.Text + "', '" + combo_gender.Text + "', '" + textBox_contact1.Text + "', '" + textBox_contact2.Text + "')";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query6, conn);


                comm.ExecuteNonQuery();
                conn.Close();
                loadAll();

            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            patientlabel_id.Text = "";
            textBox_firstname.Text = "";
            textBox_lastname.Text = "";
            birth_date.Text = "";
            textBox_address.Text = "";
            textBox_age.Text = "";
            combo_gender.Text = "";
            textBox_contact1.Text = "";
            textBox_contact2.Text = "";

            textBox_firstname.Focus();

            button_create.Show();
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientlabel_id.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_id"].Value.ToString();
            textBox_firstname.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_firstname"].Value.ToString();
            textBox_lastname.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_lastname"].Value.ToString();
            textBox_address.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_address"].Value.ToString();
            textBox_age.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_age"].Value.ToString();
            combo_gender.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_gender"].Value.ToString();
            textBox_contact1.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_contact1"].Value.ToString();
            textBox_contact2.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_contact2"].Value.ToString();

            //comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["patient_status"].Value.ToString();
            birth_date.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["patient_bdate"].Value.ToString());

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {

                button_create.Hide();

            }
        }

        private void textBox_search_OnTextChange(object sender, EventArgs e)
        {
            conn.Open();
            adp = new MySqlDataAdapter("SELECT * FROM patient WHERE patient_firstname like '" + textBox_search.Text + "%' OR patient_lastname like '" + textBox_search.Text + "%' OR patient_age like '" + textBox_search.Text + "%' OR patient_address like '" + textBox_search.Text + "%' OR patient_contact1 like '" + textBox_search + "%' OR patient_contact2 like '" + textBox_search + " %'", conn);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
    }
}
