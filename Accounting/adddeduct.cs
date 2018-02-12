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
    public partial class adddeduct : Form
    {
        MySqlConnection conn;
        public string getid { get; set; }
        public string getopt { get; set; }
        public string getnm { get; set; }
        public adddeduct()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void adddeduct_Load(object sender, EventArgs e)

        {
            label1.Text = this.getid;
            label2.Text = this.getopt;
            label3.Text = this.getnm;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_noitem.Text == "")
            {
                MessageBox.Show("Please input the no. of items");
            }
            else
            {

                String idd = label1.Text;
                String optt = label2.Text;
                String nmm = label3.Text;
                String noo = textBox_noitem.Text;
                String desc = combo_description.Text;

                String query = "SELECT *FROM stock;";
               
                conn.Open();

                MySqlCommand com = new MySqlCommand(query, conn);
               
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
               


                    String query3 = "INSERT INTO stock(stock_inventory_id, stock_name, stock_value,stock_label,stock_description, stock_date) " +
                                   "VALUES('" + idd + "', '" + nmm + "', '" + noo + "','" + optt + "','" + desc + "',now())";


                    MySqlCommand comm = new MySqlCommand(query3, conn);
                    comm.ExecuteNonQuery();
                   
                 


                MessageBox.Show("Added Succesfully!");
                    this.Close();

                

            }


        }
    }

}
