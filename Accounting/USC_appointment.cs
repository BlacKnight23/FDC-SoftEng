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
            patn.Text = "";
            dtpkr.Text = "";
            shr.Text = "";
            sm.Text = "";
            ss.Text = "";
            ehr.Text = "";
            em.Text = "";
            es.Text = "";
            dctr_nm.Text = "";
        }

    
        void clear()
        {



        }

        private void details_Enter(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            ptn_pnl.Hide();
        }


        private void dct_ccl_Click(object sender, EventArgs e)
        {
            dctr_pnl.Hide();
        }

        private void trt_btn_Click(object sender, EventArgs e)
        {
            trmnt_pnl.Show();
        }

        private void trt_cncl_Click(object sender, EventArgs e)
        {
            trmnt_pnl.Hide();
        }

        private void add_ptn_Click(object sender, EventArgs e)
        {
            ptn_pnl.Show();
        }

        private void add_dtr_Click(object sender, EventArgs e)
        {
            dctr_pnl.Show();
        }

        private void AddS_Click(object sender, EventArgs e)
        {
            adschp.Show();
        }

        private void rsts_Click(object sender, EventArgs e)
        {
            adschp.Hide();
            Reset();
        }
    }
}
