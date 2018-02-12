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
    public partial class USC_appointment : UserControl
    {
        MySqlConnection conn;
        private static USC_appointment _instance;

        public static USC_appointment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new USC_appointment();
                return _instance;
            }
        }

        public USC_appointment()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=accounting;Uid=root; ");
        }

        private void USC_appointment_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
        }
        private void loadAll()
        {

        }


        private void Reset()
        {
        }

    
        void clear()
        {



        }

        private void details_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }
    }
}
