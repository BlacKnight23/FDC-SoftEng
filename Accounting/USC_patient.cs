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
    public partial class USC_patient : UserControl
    {
        MySqlConnection conn;
        MySqlDataAdapter adp;
        DataTable dt;

        private static USC_patient _instance;

        public static USC_patient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_patient();
                return _instance;
            }
        }
        public USC_patient()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=fdc;Uid=root; ");
        }

        private void USC_patient_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

      

        private void tab_patientinfo_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(USC_patient_info.Instance))
            {
                panel1.Controls.Add(USC_patient_info.Instance);
                USC_patient_info.Instance.Dock = DockStyle.Fill;
                USC_patient_info.Instance.BringToFront();
            }
            else
                USC_patient_info.Instance.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(USC_patient_dentalchart.Instance))
            {
                panel1.Controls.Add(USC_patient_dentalchart.Instance);
                USC_patient_dentalchart.Instance.Dock = DockStyle.Fill;
                USC_patient_dentalchart.Instance.BringToFront();
            }
            else
                USC_patient_dentalchart.Instance.BringToFront();
        }

        private void tab_medicalhist_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(USC_patient_medhist.Instance))
            {
                panel1.Controls.Add(USC_patient_medhist.Instance);
                USC_patient_medhist.Instance.Dock = DockStyle.Fill;
                USC_patient_medhist.Instance.BringToFront();
            }
            else
                USC_patient_medhist.Instance.BringToFront();
        }
    }
    }

