namespace Accounting
{
    partial class USC_patient_medhist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_patient_medhist));
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.GDV_appointment = new System.Windows.Forms.DataGridView();
            this.DGV_dentaloperation = new System.Windows.Forms.DataGridView();
            this.DGV_invoice = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_searchmonth = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_searchday = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.GDV_appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dentaloperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // birth_date
            // 
            this.birth_date.CustomFormat = "MMMM dd, yyyy";
            this.birth_date.Font = new System.Drawing.Font("Arial", 12.25F);
            this.birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birth_date.Location = new System.Drawing.Point(29, 59);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(199, 26);
            this.birth_date.TabIndex = 137;
            // 
            // GDV_appointment
            // 
            this.GDV_appointment.BackgroundColor = System.Drawing.Color.White;
            this.GDV_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDV_appointment.Location = new System.Drawing.Point(29, 119);
            this.GDV_appointment.Name = "GDV_appointment";
            this.GDV_appointment.Size = new System.Drawing.Size(279, 295);
            this.GDV_appointment.TabIndex = 142;
            // 
            // DGV_dentaloperation
            // 
            this.DGV_dentaloperation.BackgroundColor = System.Drawing.Color.White;
            this.DGV_dentaloperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dentaloperation.Location = new System.Drawing.Point(304, 119);
            this.DGV_dentaloperation.Name = "DGV_dentaloperation";
            this.DGV_dentaloperation.Size = new System.Drawing.Size(279, 295);
            this.DGV_dentaloperation.TabIndex = 143;
            // 
            // DGV_invoice
            // 
            this.DGV_invoice.BackgroundColor = System.Drawing.Color.White;
            this.DGV_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_invoice.Location = new System.Drawing.Point(580, 119);
            this.DGV_invoice.Name = "DGV_invoice";
            this.DGV_invoice.Size = new System.Drawing.Size(279, 295);
            this.DGV_invoice.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Day Date";
            // 
            // combo_gender
            // 
            this.combo_gender.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "All Time",
            "January",
            "Febuary",
            "March",
            "April",
            "May ",
            "June",
            "July",
            "August",
            "September ",
            "October",
            "November ",
            "December"});
            this.combo_gender.Location = new System.Drawing.Point(392, 58);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(180, 27);
            this.combo_gender.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(389, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Month Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "Appointment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(301, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "Dental Operation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(577, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Invoice";
            // 
            // button_searchmonth
            // 
            this.button_searchmonth.ActiveBorderThickness = 1;
            this.button_searchmonth.ActiveCornerRadius = 20;
            this.button_searchmonth.ActiveFillColor = System.Drawing.Color.Aquamarine;
            this.button_searchmonth.ActiveForecolor = System.Drawing.Color.Black;
            this.button_searchmonth.ActiveLineColor = System.Drawing.Color.White;
            this.button_searchmonth.BackColor = System.Drawing.SystemColors.Control;
            this.button_searchmonth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchmonth.BackgroundImage")));
            this.button_searchmonth.ButtonText = "Search";
            this.button_searchmonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_searchmonth.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchmonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_searchmonth.IdleBorderThickness = 1;
            this.button_searchmonth.IdleCornerRadius = 20;
            this.button_searchmonth.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_searchmonth.IdleForecolor = System.Drawing.Color.Black;
            this.button_searchmonth.IdleLineColor = System.Drawing.Color.Black;
            this.button_searchmonth.Location = new System.Drawing.Point(580, 52);
            this.button_searchmonth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_searchmonth.Name = "button_searchmonth";
            this.button_searchmonth.Size = new System.Drawing.Size(75, 33);
            this.button_searchmonth.TabIndex = 151;
            this.button_searchmonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_searchday
            // 
            this.button_searchday.ActiveBorderThickness = 1;
            this.button_searchday.ActiveCornerRadius = 20;
            this.button_searchday.ActiveFillColor = System.Drawing.Color.Aquamarine;
            this.button_searchday.ActiveForecolor = System.Drawing.Color.Black;
            this.button_searchday.ActiveLineColor = System.Drawing.Color.White;
            this.button_searchday.BackColor = System.Drawing.SystemColors.Control;
            this.button_searchday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_searchday.BackgroundImage")));
            this.button_searchday.ButtonText = "Search";
            this.button_searchday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_searchday.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_searchday.IdleBorderThickness = 1;
            this.button_searchday.IdleCornerRadius = 20;
            this.button_searchday.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_searchday.IdleForecolor = System.Drawing.Color.Black;
            this.button_searchday.IdleLineColor = System.Drawing.Color.Black;
            this.button_searchday.Location = new System.Drawing.Point(232, 52);
            this.button_searchday.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_searchday.Name = "button_searchday";
            this.button_searchday.Size = new System.Drawing.Size(76, 33);
            this.button_searchday.TabIndex = 152;
            this.button_searchday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USC_patient_medhist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_searchday);
            this.Controls.Add(this.button_searchmonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_invoice);
            this.Controls.Add(this.DGV_dentaloperation);
            this.Controls.Add(this.GDV_appointment);
            this.Controls.Add(this.birth_date);
            this.Name = "USC_patient_medhist";
            this.Size = new System.Drawing.Size(891, 448);
            this.Load += new System.EventHandler(this.USC_patient_medhist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDV_appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dentaloperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.DataGridView GDV_appointment;
        private System.Windows.Forms.DataGridView DGV_dentaloperation;
        private System.Windows.Forms.DataGridView DGV_invoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 button_searchmonth;
        private Bunifu.Framework.UI.BunifuThinButton2 button_searchday;
    }
}
