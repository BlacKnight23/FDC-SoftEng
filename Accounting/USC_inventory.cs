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
    public partial class USC_inventory : UserControl
    {
        MySqlConnection conn;
        private static USC_inventory _instance;
        public USC_inventory()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root;password=root ");
        }
        public static USC_inventory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_inventory();
                return _instance;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void USC_inventory_Load(object sender, EventArgs e)
        {
            loadAll();
            label4.Hide();
            button_add.Hide();
            button_deduct.Hide();

            
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (textBox_itemname.Text == "" && textBox_itemdescription.Text == "" )
            {
                MessageBox.Show("Please input required fields.");
            }
            else
            {


                String item = textBox_itemname.Text;
                String query = "SELECT *FROM inventory WHERE item_name = '" + item + "'";
                conn.Open();

                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("Item Already Taken!");
                }
                else
                {


                    String query3 = "INSERT INTO inventory(item_name, item_description, item_quantity, item_expiry) " +
                                   "VALUES('" + textBox_itemname.Text + "', '" + textBox_itemdescription.Text + "', '" + label4.Text + "', '" + expiry_date.Value.ToString("yyyy-MM-dd") + "')";


                    MySqlCommand comm = new MySqlCommand(query3, conn);


                    comm.ExecuteNonQuery();
                    conn.Close();
                    loadAll();
                    MessageBox.Show("Created Successfully!");

                }

            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            inventorylabel_id.Text = "";
            textBox_itemname.Text = "";
            textBox_itemdescription.Text = "";
            label4.Text = "";
            expiry_date.Text = "";
            label4.Hide();
            button_add.Hide();
            button_deduct.Hide();
          

            textBox_itemname.Focus();

            button_create.Enabled = true;
        }
        private void loadAll()
        {
            string query = "SELECT * from inventory";

            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);   

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["item_id"].Visible = false;
            dataGridView1.Columns["item_name"].HeaderText = "Item Name";
            dataGridView1.Columns["item_description"].HeaderText = "Description";
            dataGridView1.Columns["item_quantity"].HeaderText = "Quantity";
            dataGridView1.Columns["item_expiry"].HeaderText = "Expiry Date";
        

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            label5.Text = "in";
            String nm = textBox_itemname.Text;
            String opt = label5.Text;
            String init = inventorylabel_id.Text;
            adddeduct aw = new adddeduct();
            aw.getnm = nm;
            aw.getopt = opt;
            aw.getid = init;
            aw.ShowDialog();
            loadAll();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            inventorylabel_id.Text = dataGridView1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            textBox_itemname.Text = dataGridView1.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
            textBox_itemdescription.Text = dataGridView1.Rows[e.RowIndex].Cells["item_description"].Value.ToString();
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells["item_quantity"].Value.ToString();
            expiry_date.Text = dataGridView1.Rows[e.RowIndex].Cells["item_expiry"].Value.ToString();
            label4.Show();
            button_add.Show();
            button_deduct.Show();

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {

                button_create.Hide();

            }




        }

        private void button_deduct_Click(object sender, EventArgs e)
        {
            label5.Text = "in";
            String opt = label5.Text;
            String init = inventorylabel_id.Text;
            adddeduct aw = new adddeduct();
            aw.getopt = opt;
            aw.getid = init;
            aw.ShowDialog();
            loadAll();

            
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            textBox_itemname.Hide();
            textBox_itemdescription.Hide();
            button_add.Hide();
            button_deduct.Hide();
            expiry_date.Hide();
            button_create.Hide();
            button_update.Hide();
            button_reset.Hide();
            label2.Hide();
            Item_name.Hide();
            labelbel.Hide();
            label3.Hide();

            string query = "SELECT * from stock";

            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["stock_id"].Visible = false;
            dataGridView1.Columns["stock_inventory_id"].Visible = false;
            dataGridView1.Columns["stock_label"].HeaderText = "In / out";
            dataGridView1.Columns["stock_name"].HeaderText = "Item Name ";
            dataGridView1.Columns["stock_value"].HeaderText = "No. Items";
            dataGridView1.Columns["stock_description"].HeaderText = "Reason";
            dataGridView1.Columns["stock_date"].HeaderText = "Date issued";

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            textBox_itemname.Show();
            textBox_itemdescription.Show();
            expiry_date.Show();
            button_create.Show();
            button_update.Show();
            button_reset.Show();
            label2.Show();
            Item_name.Show();
            labelbel.Show();
            label3.Show();
            loadAll();
        }
    }
}
