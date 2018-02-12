namespace Accounting
{
    partial class USC_sales
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label Label51;
            System.Windows.Forms.Label Label49;
            System.Windows.Forms.Label Label48;
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PDtxt = new System.Windows.Forms.TextBox();
            this.TPtxt = new System.Windows.Forms.TextBox();
            this.chrgtxt = new System.Windows.Forms.TextBox();
            this.GTtxt = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_go = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dTP3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_patientname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_patientid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_invoiceno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_create = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_getdata = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            label9 = new System.Windows.Forms.Label();
            Label51 = new System.Windows.Forms.Label();
            Label49 = new System.Windows.Forms.Label();
            Label48 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.button_go.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(27, 111);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(77, 13);
            label9.TabIndex = 320;
            label9.Text = "Payment Due :";
            // 
            // Label51
            // 
            Label51.AutoSize = true;
            Label51.ForeColor = System.Drawing.Color.Black;
            Label51.Location = new System.Drawing.Point(27, 85);
            Label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label51.Name = "Label51";
            Label51.Size = new System.Drawing.Size(61, 13);
            Label51.TabIndex = 319;
            Label51.Text = "Total Paid :";
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.ForeColor = System.Drawing.Color.Black;
            Label49.Location = new System.Drawing.Point(28, 59);
            Label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label49.Name = "Label49";
            Label49.Size = new System.Drawing.Size(69, 13);
            Label49.TabIndex = 314;
            Label49.Text = "Grand Total :";
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.ForeColor = System.Drawing.Color.Black;
            Label48.Location = new System.Drawing.Point(28, 34);
            Label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label48.Name = "Label48";
            Label48.Size = new System.Drawing.Size(52, 13);
            Label48.TabIndex = 313;
            Label48.Text = "Charges :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.PDtxt);
            this.groupBox4.Controls.Add(label9);
            this.groupBox4.Controls.Add(this.TPtxt);
            this.groupBox4.Controls.Add(Label51);
            this.groupBox4.Controls.Add(this.chrgtxt);
            this.groupBox4.Controls.Add(this.GTtxt);
            this.groupBox4.Controls.Add(Label49);
            this.groupBox4.Controls.Add(Label48);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(579, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 225);
            this.groupBox4.TabIndex = 320;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Overall";
            // 
            // PDtxt
            // 
            this.PDtxt.Location = new System.Drawing.Point(122, 111);
            this.PDtxt.Name = "PDtxt";
            this.PDtxt.ReadOnly = true;
            this.PDtxt.Size = new System.Drawing.Size(84, 20);
            this.PDtxt.TabIndex = 9;
            this.PDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TPtxt
            // 
            this.TPtxt.Location = new System.Drawing.Point(122, 85);
            this.TPtxt.Name = "TPtxt";
            this.TPtxt.Size = new System.Drawing.Size(84, 20);
            this.TPtxt.TabIndex = 8;
            this.TPtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chrgtxt
            // 
            this.chrgtxt.Location = new System.Drawing.Point(122, 34);
            this.chrgtxt.Name = "chrgtxt";
            this.chrgtxt.ReadOnly = true;
            this.chrgtxt.Size = new System.Drawing.Size(84, 20);
            this.chrgtxt.TabIndex = 6;
            this.chrgtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GTtxt
            // 
            this.GTtxt.Location = new System.Drawing.Point(122, 59);
            this.GTtxt.Name = "GTtxt";
            this.GTtxt.ReadOnly = true;
            this.GTtxt.Size = new System.Drawing.Size(84, 20);
            this.GTtxt.TabIndex = 7;
            this.GTtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.button_create);
            this.Panel3.Controls.Add(this.button_getdata);
            this.Panel3.Controls.Add(this.button_save);
            this.Panel3.Controls.Add(this.button_update);
            this.Panel3.Controls.Add(this.button_delete);
            this.Panel3.Location = new System.Drawing.Point(579, 82);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(229, 126);
            this.Panel3.TabIndex = 319;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 225);
            this.dataGridView1.TabIndex = 318;
            // 
            // button_go
            // 
            this.button_go.Controls.Add(this.bunifuFlatButton5);
            this.button_go.Controls.Add(this.label7);
            this.button_go.Controls.Add(this.dTP3);
            this.button_go.Controls.Add(this.label6);
            this.button_go.Controls.Add(this.dTP2);
            this.button_go.Location = new System.Drawing.Point(37, 185);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(340, 84);
            this.button_go.TabIndex = 317;
            this.button_go.TabStop = false;
            this.button_go.Text = "Appointment Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "To:";
            // 
            // dTP3
            // 
            this.dTP3.CustomFormat = "dd/MMM/yyyy";
            this.dTP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP3.Location = new System.Drawing.Point(161, 48);
            this.dTP3.Name = "dTP3";
            this.dTP3.Size = new System.Drawing.Size(108, 21);
            this.dTP3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "From:";
            // 
            // dTP2
            // 
            this.dTP2.CustomFormat = "dd/MMM/yyyy";
            this.dTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(26, 48);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(108, 21);
            this.dTP2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_patientname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox_patientid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(274, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 86);
            this.groupBox2.TabIndex = 316;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Info";
            // 
            // textBox_patientname
            // 
            this.textBox_patientname.Location = new System.Drawing.Point(97, 53);
            this.textBox_patientname.Name = "textBox_patientname";
            this.textBox_patientname.Size = new System.Drawing.Size(179, 20);
            this.textBox_patientname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Patient Name:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_patientid
            // 
            this.textBox_patientid.Location = new System.Drawing.Point(97, 24);
            this.textBox_patientid.Name = "textBox_patientid";
            this.textBox_patientid.Size = new System.Drawing.Size(108, 20);
            this.textBox_patientid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Patient ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_invoicedate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_invoiceno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 86);
            this.groupBox1.TabIndex = 315;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Info";
            // 
            // textBox_invoicedate
            // 
            this.textBox_invoicedate.CustomFormat = "dd/MMM/yyyy";
            this.textBox_invoicedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textBox_invoicedate.Location = new System.Drawing.Point(89, 52);
            this.textBox_invoicedate.Name = "textBox_invoicedate";
            this.textBox_invoicedate.Size = new System.Drawing.Size(108, 21);
            this.textBox_invoicedate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = " Invoice Date:";
            // 
            // textBox_invoiceno
            // 
            this.textBox_invoiceno.Location = new System.Drawing.Point(89, 25);
            this.textBox_invoiceno.Name = "textBox_invoiceno";
            this.textBox_invoiceno.Size = new System.Drawing.Size(108, 20);
            this.textBox_invoiceno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = " Invoice No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 314;
            this.label1.Text = "SALES INVOICE";
            // 
            // button_create
            // 
            this.button_create.Activecolor = System.Drawing.Color.Teal;
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_create.BorderRadius = 0;
            this.button_create.ButtonText = "Create";
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.DisabledColor = System.Drawing.Color.Gray;
            this.button_create.Iconcolor = System.Drawing.Color.Transparent;
            this.button_create.Iconimage = null;
            this.button_create.Iconimage_right = null;
            this.button_create.Iconimage_right_Selected = null;
            this.button_create.Iconimage_Selected = null;
            this.button_create.IconMarginLeft = 0;
            this.button_create.IconMarginRight = 0;
            this.button_create.IconRightVisible = true;
            this.button_create.IconRightZoom = 0D;
            this.button_create.IconVisible = true;
            this.button_create.IconZoom = 70D;
            this.button_create.IsTab = false;
            this.button_create.Location = new System.Drawing.Point(11, 11);
            this.button_create.Name = "button_create";
            this.button_create.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_create.OnHovercolor = System.Drawing.Color.Teal;
            this.button_create.OnHoverTextColor = System.Drawing.Color.White;
            this.button_create.selected = false;
            this.button_create.Size = new System.Drawing.Size(76, 33);
            this.button_create.TabIndex = 319;
            this.button_create.Text = "Create";
            this.button_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_create.Textcolor = System.Drawing.Color.Black;
            this.button_create.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button_save
            // 
            this.button_save.Activecolor = System.Drawing.Color.Teal;
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.BorderRadius = 0;
            this.button_save.ButtonText = "Save";
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.DisabledColor = System.Drawing.Color.Gray;
            this.button_save.Iconcolor = System.Drawing.Color.Transparent;
            this.button_save.Iconimage = null;
            this.button_save.Iconimage_right = null;
            this.button_save.Iconimage_right_Selected = null;
            this.button_save.Iconimage_Selected = null;
            this.button_save.IconMarginLeft = 0;
            this.button_save.IconMarginRight = 0;
            this.button_save.IconRightVisible = true;
            this.button_save.IconRightZoom = 0D;
            this.button_save.IconVisible = true;
            this.button_save.IconZoom = 70D;
            this.button_save.IsTab = false;
            this.button_save.Location = new System.Drawing.Point(129, 10);
            this.button_save.Name = "button_save";
            this.button_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_save.OnHovercolor = System.Drawing.Color.Teal;
            this.button_save.OnHoverTextColor = System.Drawing.Color.White;
            this.button_save.selected = false;
            this.button_save.Size = new System.Drawing.Size(76, 33);
            this.button_save.TabIndex = 320;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_save.Textcolor = System.Drawing.Color.Black;
            this.button_save.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button_getdata
            // 
            this.button_getdata.Activecolor = System.Drawing.Color.Teal;
            this.button_getdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_getdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_getdata.BorderRadius = 0;
            this.button_getdata.ButtonText = "Get Data";
            this.button_getdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_getdata.DisabledColor = System.Drawing.Color.Gray;
            this.button_getdata.Iconcolor = System.Drawing.Color.Transparent;
            this.button_getdata.Iconimage = null;
            this.button_getdata.Iconimage_right = null;
            this.button_getdata.Iconimage_right_Selected = null;
            this.button_getdata.Iconimage_Selected = null;
            this.button_getdata.IconMarginLeft = 0;
            this.button_getdata.IconMarginRight = 0;
            this.button_getdata.IconRightVisible = true;
            this.button_getdata.IconRightZoom = 0D;
            this.button_getdata.IconVisible = true;
            this.button_getdata.IconZoom = 70D;
            this.button_getdata.IsTab = false;
            this.button_getdata.Location = new System.Drawing.Point(71, 88);
            this.button_getdata.Name = "button_getdata";
            this.button_getdata.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_getdata.OnHovercolor = System.Drawing.Color.Teal;
            this.button_getdata.OnHoverTextColor = System.Drawing.Color.White;
            this.button_getdata.selected = false;
            this.button_getdata.Size = new System.Drawing.Size(76, 33);
            this.button_getdata.TabIndex = 321;
            this.button_getdata.Text = "Get Data";
            this.button_getdata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_getdata.Textcolor = System.Drawing.Color.Black;
            this.button_getdata.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button_update
            // 
            this.button_update.Activecolor = System.Drawing.Color.Teal;
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update.BorderRadius = 0;
            this.button_update.ButtonText = "Update";
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.DisabledColor = System.Drawing.Color.Gray;
            this.button_update.Iconcolor = System.Drawing.Color.Transparent;
            this.button_update.Iconimage = null;
            this.button_update.Iconimage_right = null;
            this.button_update.Iconimage_right_Selected = null;
            this.button_update.Iconimage_Selected = null;
            this.button_update.IconMarginLeft = 0;
            this.button_update.IconMarginRight = 0;
            this.button_update.IconRightVisible = true;
            this.button_update.IconRightZoom = 0D;
            this.button_update.IconVisible = true;
            this.button_update.IconZoom = 70D;
            this.button_update.IsTab = false;
            this.button_update.Location = new System.Drawing.Point(11, 52);
            this.button_update.Name = "button_update";
            this.button_update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_update.OnHovercolor = System.Drawing.Color.Teal;
            this.button_update.OnHoverTextColor = System.Drawing.Color.White;
            this.button_update.selected = false;
            this.button_update.Size = new System.Drawing.Size(76, 33);
            this.button_update.TabIndex = 322;
            this.button_update.Text = "Update";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_update.Textcolor = System.Drawing.Color.Black;
            this.button_update.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button_delete
            // 
            this.button_delete.Activecolor = System.Drawing.Color.Teal;
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.BorderRadius = 0;
            this.button_delete.ButtonText = "Delete";
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.DisabledColor = System.Drawing.Color.Gray;
            this.button_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.button_delete.Iconimage = null;
            this.button_delete.Iconimage_right = null;
            this.button_delete.Iconimage_right_Selected = null;
            this.button_delete.Iconimage_Selected = null;
            this.button_delete.IconMarginLeft = 0;
            this.button_delete.IconMarginRight = 0;
            this.button_delete.IconRightVisible = true;
            this.button_delete.IconRightZoom = 0D;
            this.button_delete.IconVisible = true;
            this.button_delete.IconZoom = 70D;
            this.button_delete.IsTab = false;
            this.button_delete.Location = new System.Drawing.Point(129, 52);
            this.button_delete.Name = "button_delete";
            this.button_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.button_delete.OnHovercolor = System.Drawing.Color.Teal;
            this.button_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.button_delete.selected = false;
            this.button_delete.Size = new System.Drawing.Size(76, 33);
            this.button_delete.TabIndex = 323;
            this.button_delete.Text = "Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_delete.Textcolor = System.Drawing.Color.Black;
            this.button_delete.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Go";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(272, 48);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(56, 21);
            this.bunifuFlatButton5.TabIndex = 324;
            this.bunifuFlatButton5.Text = "Go";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // USC_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "USC_sales";
            this.Size = new System.Drawing.Size(891, 552);
            this.Load += new System.EventHandler(this.USC_sales_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.button_go.ResumeLayout(false);
            this.button_go.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox PDtxt;
        internal System.Windows.Forms.TextBox TPtxt;
        internal System.Windows.Forms.TextBox chrgtxt;
        internal System.Windows.Forms.TextBox GTtxt;
        internal System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox button_go;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTP3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_patientname;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_patientid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker textBox_invoicedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_invoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton button_create;
        private Bunifu.Framework.UI.BunifuFlatButton button_getdata;
        private Bunifu.Framework.UI.BunifuFlatButton button_save;
        private Bunifu.Framework.UI.BunifuFlatButton button_update;
        private Bunifu.Framework.UI.BunifuFlatButton button_delete;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
    }
}
