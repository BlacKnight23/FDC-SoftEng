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
    public partial class USC_dentalchart : UserControl
    {
        MySqlConnection conn;
        private static USC_dentalchart _instance;

        public static USC_dentalchart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_dentalchart();
                return _instance;
            }
        }
        public USC_dentalchart()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");


        }
        DataTable table = new DataTable();
        DataTable tablecheck = new DataTable();
        DataTable tablestag = new DataTable();
        private void USC_dentalchart_Load(object sender, EventArgs e)
        {
            panel_treatment.Hide();
            
           

            table.Columns.Add("Tooth Involved", typeof(string));
            table.Columns.Add("Charges", typeof(string));
            table.Columns.Add("Grand Total", typeof(string));
            table.Columns.Add("Total paid", typeof(string));

            dataGridView1.DataSource = table;

            tablecheck.Columns.Add("Tooth Involved", typeof(string));
            tablecheck.Columns.Add("Charges", typeof(string));
            tablecheck.Columns.Add("Grand Total", typeof(string));
            tablecheck.Columns.Add("Post Dated", typeof(string));
            tablecheck.Columns.Add("Check Number", typeof(string));

            dataGridViewCheck.DataSource = tablecheck;

            tablestag.Columns.Add("Tooth Involved", typeof(string));
            tablestag.Columns.Add("Charges", typeof(string));
            tablestag.Columns.Add("Grand Total", typeof(string));
            tablestag.Columns.Add("Total Paid", typeof(string));
            tablestag.Columns.Add("Payment Due", typeof(string));

            dataGridViewStag.DataSource = tablestag;


        }

        private void button_create_Click(object sender, EventArgs e)
        {
            panel_treatment.Show();
            button_finalize.Hide();
            button_update.Hide();
            button_remove.Hide();
            dataGridView1.Hide();
            dataGridViewCheck.Hide();
            dataGridViewStag.Hide();
            cashlabel.Hide();
            checklabel.Hide();
            staglabel.Hide();
            textBox_toothinv.Hide();
            toothinvolved.Hide();
            charges.Hide();
            textBox_Charges.Hide();
            grandtotal.Hide();
            textBox_grandtotal.Hide();
            textBox_totalpaidcash.Hide();
            textBox_totalpaidstag.Hide();
            totalpaid.Hide();
            textBox_Checknumber.Hide();
            checknumber.Hide();
            postdated.Hide();
            textBox_postdated.Hide();
            paymentdue.Hide();
            textBox_Paymentdue.Hide();
            button_add.Hide();
            button_addcheck.Hide();
            button_addstag.Hide();


        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {

         

            panel_treatment.Hide();
            showgrid();
            button_finalize.Show();

            table.Rows.Add(textBox_toothinv.Text, textBox_Charges.Text, textBox_grandtotal.Text, textBox_totalpaidcash.Text);
            dataGridView1.DataSource = table;
           



            /* int row = 

             dataGridView1["Tooth Involved", row].Value = textBox_toothinv.Text;
             dataGridView1["Charges", row].Value = textBox_Charges.Text;
             dataGridView1["Grand Total", row].Value = textBox_grandtotal.Text;
             dataGridView1["Total Paid", row].Value = textBox_totalpaidcash.Text;

             dataGridView1.Refresh();
             */


        }

        private void addData(String tooth, String charges, String grandtotal, String totalpaid)
        {


        }

        private void panel_treatment_Paint(object sender, PaintEventArgs e)
        {

        }

        public void reset()
        {
            U1.Checked = false;
            U2.Checked = false;
            U3.Checked = false;
            U4.Checked = false;
            U5.Checked = false;
            U6.Checked = false;
            U7.Checked = false;
            U8.Checked = false;
            U9.Checked = false;
            U10.Checked = false;
            U11.Checked = false;
            U12.Checked = false;
            U13.Checked = false;
            U14.Checked = false;
            U15.Checked = false;
            U16.Checked = false;
            L17.Checked = false;
            L18.Checked = false;
            L19.Checked = false;
            L20.Checked = false;
            L21.Checked = false;
            L22.Checked = false;
            L23.Checked = false;
            L24.Checked = false;
            L25.Checked = false;
            L26.Checked = false;
            L27.Checked = false;
            L28.Checked = false;
            L29.Checked = false;
            L30.Checked = false;
            L31.Checked = false;
            L32.Checked = false;

            textBox_toothinv.Text = "";
            textBox_Charges.Text = "";
            textBox_grandtotal.Text = "";
            textBox_totalpaidcash.Text = "";
            textBox_totalpaidstag.Text = "";
            textBox_postdated.Text = "";
            textBox_Checknumber.Text = "";
            textBox_Paymentdue.Text = "";





        }

        private void cashbut_Click(object sender, EventArgs e)
        {
            reset(); 

            button_add.Show();
            button_addcheck.Hide();
            button_addstag.Hide();


            dataGridView1.Show();
            dataGridViewCheck.Hide();
            dataGridViewStag.Hide();

            textBox_toothinv.Show();
            toothinvolved.Show();
            textBox_Charges.Show();
            charges.Show();
            textBox_grandtotal.Show();
            grandtotal.Show();
            totalpaid.Show();
            textBox_totalpaidcash.Show();
            textBox_totalpaidstag.Hide();
            postdated.Hide();
            textBox_postdated.Hide();
            paymentdue.Hide();
            checknumber.Hide();
            textBox_Paymentdue.Hide();
            textBox_Checknumber.Hide();

            
        }

        private void totalpaid_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkbut_Click(object sender, EventArgs e)
        {
            reset();

            button_add.Hide();
            button_addcheck.Show();
            button_addstag.Hide();

            dataGridView1.Hide();
            dataGridViewStag.Hide();
            dataGridViewCheck.Show();

            totalpaid.Hide();
            textBox_totalpaidcash.Hide();
            textBox_totalpaidstag.Hide();
            postdated.Show();
            textBox_postdated.Show();
            paymentdue.Hide();
            checknumber.Show();
            textBox_Paymentdue.Hide();
            textBox_Checknumber.Show();


        }

        private void stagbut_Click(object sender, EventArgs e)
        {
            reset();

            button_add.Hide();
            button_addcheck.Hide();
            button_addstag.Show();

            dataGridViewStag.Show();
            dataGridView1.Hide();
            dataGridViewCheck.Hide();

            totalpaid.Show();
            textBox_totalpaidcash.Hide();
            textBox_totalpaidstag.Show();
            postdated.Hide();
            textBox_postdated.Hide();
            paymentdue.Show();
            checknumber.Hide();
            textBox_Paymentdue.Show();
            textBox_Checknumber.Hide();
        }

        private void U8_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;


        }

        private void U1_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;

        }

        private void U2_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;

        }

        private void U3_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;

        }

        private void U4_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;

        }

        private void textBox_toothinv_TextChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

           
        }

        private void U5_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U6_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U7_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U9_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U10_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U11_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U12_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U13_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U14_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U15_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void U16_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L17_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L18_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L19_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L20_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L21_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L22_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L23_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L24_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L25_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L26_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L27_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L28_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L29_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L30_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L31_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void L32_CheckedChanged(object sender, EventArgs e)
        {
            String ClientString;
            ClientString = String.Empty;
            if (U1.Checked)
                ClientString = U1.Name;
            if (U2.Checked)
                ClientString += ", " + U2.Name;
            if (U3.Checked)
                ClientString += ", " + U3.Name;
            if (U4.Checked)
                ClientString += ", " + U4.Name;
            if (U5.Checked)
                ClientString += ", " + U5.Name;
            if (U6.Checked)
                ClientString += ", " + U6.Name;
            if (U7.Checked)
                ClientString += ", " + U7.Name;
            if (U8.Checked)
                ClientString += ", " + U8.Name;
            if (U9.Checked)
                ClientString += ", " + U9.Name;
            if (U10.Checked)
                ClientString += ", " + U10.Name;
            if (U11.Checked)
                ClientString += ", " + U11.Name;
            if (U12.Checked)
                ClientString += ", " + U12.Name;
            if (U13.Checked)
                ClientString += ", " + U13.Name;
            if (U14.Checked)
                ClientString += ", " + U14.Name;
            if (U15.Checked)
                ClientString += ", " + U15.Name;
            if (U16.Checked)
                ClientString += ", " + U16.Name;
            if (L32.Checked)
                ClientString += ", " + L32.Name;
            if (L31.Checked)
                ClientString += ", " + L31.Name;
            if (L30.Checked)
                ClientString += ", " + L30.Name;
            if (L29.Checked)
                ClientString += ", " + L29.Name;
            if (L28.Checked)
                ClientString += ", " + L28.Name;
            if (L27.Checked)
                ClientString += ", " + L27.Name;
            if (L26.Checked)
                ClientString += ", " + L26.Name;
            if (L25.Checked)
                ClientString += ", " + L25.Name;
            if (L24.Checked)
                ClientString += ", " + L24.Name;
            if (L23.Checked)
                ClientString += ", " + L23.Name;
            if (L22.Checked)
                ClientString += ", " + L22.Name;
            if (L21.Checked)
                ClientString += ", " + L21.Name;
            if (L20.Checked)
                ClientString += ", " + L20.Name;
            if (L19.Checked)
                ClientString += ", " + L19.Name;
            if (L18.Checked)
                ClientString += ", " + L18.Name;
            if (L17.Checked)
                ClientString += ", " + L17.Name;

            textBox_toothinv.Text = ClientString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
        }

        private void textBox_postdated_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void showgrid()
        {
            dataGridView1.Show();
            dataGridViewCheck.Show();
            dataGridViewStag.Show();
            cashlabel.Show();
            checklabel.Show();
            staglabel.Show();
        }

        private void button_addcheck_Click(object sender, EventArgs e)
        {
            panel_treatment.Hide();
            showgrid();
            button_finalize.Show();


            tablecheck.Rows.Add(textBox_toothinv.Text, textBox_Charges.Text, textBox_grandtotal.Text, textBox_postdated.Text, textBox_postdated.Text);
            dataGridViewCheck.DataSource = tablecheck;
        }

        private void button_addstag_Click(object sender, EventArgs e)
        {
            panel_treatment.Hide();
            showgrid();
            button_finalize.Show();


            tablestag.Rows.Add(textBox_toothinv.Text, textBox_Charges.Text, textBox_grandtotal.Text, textBox_postdated.Text, textBox_Paymentdue.Text);
            dataGridViewStag.DataSource = tablestag;
        }

        private void button_finalize_Click(object sender, EventArgs e)
        {
            conn.Open();


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                String queryx = "INSERT INTO dccash (dccash_toothinvolved, dccash_charges, dccash_grandtotal, dccash_totalpaid)" + " VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')";

                MySqlCommand com = new MySqlCommand(queryx, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);


                com.ExecuteNonQuery();
               
            }
            conn.Close();

        }
    }
}
