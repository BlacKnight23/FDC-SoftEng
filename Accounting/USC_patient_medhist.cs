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
    public partial class USC_patient_medhist : UserControl
    {
        MySqlConnection conn;

        private static USC_patient_medhist _instance;

        public static USC_patient_medhist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_patient_medhist();
                return _instance;
            }
        }
        public USC_patient_medhist()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void USC_patient_medhist_Load(object sender, EventArgs e)
        {

        }
    }
}
