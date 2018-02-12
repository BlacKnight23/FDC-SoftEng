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
    public partial class USC_patient_dentalchart : UserControl
    {
        MySqlConnection conn;
        MySqlDataAdapter adp;
        DataTable dt;

        private static USC_patient_dentalchart _instance;

        public static USC_patient_dentalchart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_patient_dentalchart();
                return _instance;
            }
        }


        public USC_patient_dentalchart()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void USC_patient_dentalchart_Load(object sender, EventArgs e)
        {

        }

        private void button_view_Click(object sender, EventArgs e)
        {

         
        }
    }
}
