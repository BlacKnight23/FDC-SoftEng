namespace Accounting
{
    partial class USC_appointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.Filter1 = new System.Windows.Forms.Label();
            this.Filter2 = new System.Windows.Forms.ComboBox();
            this.Schedule = new System.Windows.Forms.Button();
            this.Appointment = new System.Windows.Forms.Button();
            this.ViewBox1 = new System.Windows.Forms.DataGridView();
            this.details = new System.Windows.Forms.GroupBox();
            this.rst = new System.Windows.Forms.Button();
            this.CancelS = new System.Windows.Forms.Button();
            this.EditS = new System.Windows.Forms.Button();
            this.AddS = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.trm = new System.Windows.Forms.ComboBox();
            this.es = new System.Windows.Forms.ComboBox();
            this.em = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ehr = new System.Windows.Forms.ComboBox();
            this.ss = new System.Windows.Forms.ComboBox();
            this.sm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shr = new System.Windows.Forms.ComboBox();
            this.dtpkr = new System.Windows.Forms.DateTimePicker();
            this.patn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endt = new System.Windows.Forms.Label();
            this.startt = new System.Windows.Forms.Label();
            this.appdate = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox1)).BeginInit();
            this.details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "APPOINTMENT";
            // 
            // Filter1
            // 
            this.Filter1.AutoSize = true;
            this.Filter1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter1.Location = new System.Drawing.Point(381, 130);
            this.Filter1.Name = "Filter1";
            this.Filter1.Size = new System.Drawing.Size(70, 15);
            this.Filter1.TabIndex = 48;
            this.Filter1.Text = "Filter:";
            // 
            // Filter2
            // 
            this.Filter2.FormattingEnabled = true;
            this.Filter2.Location = new System.Drawing.Point(449, 127);
            this.Filter2.Name = "Filter2";
            this.Filter2.Size = new System.Drawing.Size(121, 21);
            this.Filter2.TabIndex = 49;
            // 
            // Schedule
            // 
            this.Schedule.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule.Location = new System.Drawing.Point(592, 125);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(132, 24);
            this.Schedule.TabIndex = 50;
            this.Schedule.Text = "All Schedules";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            this.Appointment.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment.Location = new System.Drawing.Point(730, 125);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(132, 24);
            this.Appointment.TabIndex = 51;
            this.Appointment.Text = "All Appointments";
            this.Appointment.UseVisualStyleBackColor = true;
            // 
            // ViewBox1
            // 
            this.ViewBox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewBox1.Location = new System.Drawing.Point(385, 176);
            this.ViewBox1.Name = "ViewBox1";
            this.ViewBox1.Size = new System.Drawing.Size(477, 322);
            this.ViewBox1.TabIndex = 52;
            // 
            // details
            // 
            this.details.Controls.Add(this.rst);
            this.details.Controls.Add(this.CancelS);
            this.details.Controls.Add(this.EditS);
            this.details.Controls.Add(this.AddS);
            this.details.Controls.Add(this.Add);
            this.details.Controls.Add(this.trm);
            this.details.Controls.Add(this.es);
            this.details.Controls.Add(this.em);
            this.details.Controls.Add(this.label7);
            this.details.Controls.Add(this.ehr);
            this.details.Controls.Add(this.ss);
            this.details.Controls.Add(this.sm);
            this.details.Controls.Add(this.label6);
            this.details.Controls.Add(this.shr);
            this.details.Controls.Add(this.dtpkr);
            this.details.Controls.Add(this.patn);
            this.details.Controls.Add(this.label5);
            this.details.Controls.Add(this.endt);
            this.details.Controls.Add(this.startt);
            this.details.Controls.Add(this.appdate);
            this.details.Controls.Add(this.patient);
            this.details.Location = new System.Drawing.Point(16, 176);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(354, 322);
            this.details.TabIndex = 53;
            this.details.TabStop = false;
            this.details.Text = "Appointent Details";
            this.details.Enter += new System.EventHandler(this.details_Enter);
            // 
            // rst
            // 
            this.rst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rst.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst.Location = new System.Drawing.Point(183, 255);
            this.rst.Name = "rst";
            this.rst.Size = new System.Drawing.Size(142, 20);
            this.rst.TabIndex = 57;
            this.rst.Text = "Reset";
            this.rst.UseVisualStyleBackColor = false;
            // 
            // CancelS
            // 
            this.CancelS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelS.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelS.Location = new System.Drawing.Point(183, 229);
            this.CancelS.Name = "CancelS";
            this.CancelS.Size = new System.Drawing.Size(142, 20);
            this.CancelS.TabIndex = 56;
            this.CancelS.Text = "Cancel Schedule";
            this.CancelS.UseVisualStyleBackColor = false;
            // 
            // EditS
            // 
            this.EditS.BackColor = System.Drawing.Color.Cyan;
            this.EditS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditS.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditS.Location = new System.Drawing.Point(30, 255);
            this.EditS.Name = "EditS";
            this.EditS.Size = new System.Drawing.Size(142, 20);
            this.EditS.TabIndex = 18;
            this.EditS.Text = "Edit Schedule";
            this.EditS.UseVisualStyleBackColor = false;
            // 
            // AddS
            // 
            this.AddS.BackColor = System.Drawing.Color.SpringGreen;
            this.AddS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddS.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddS.Location = new System.Drawing.Point(30, 229);
            this.AddS.Name = "AddS";
            this.AddS.Size = new System.Drawing.Size(142, 20);
            this.AddS.TabIndex = 17;
            this.AddS.Text = "Add Schedule";
            this.AddS.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(302, 46);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(41, 20);
            this.Add.TabIndex = 16;
            this.Add.Text = "...";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // trm
            // 
            this.trm.FormattingEnabled = true;
            this.trm.Location = new System.Drawing.Point(154, 174);
            this.trm.Name = "trm";
            this.trm.Size = new System.Drawing.Size(142, 21);
            this.trm.TabIndex = 15;
            // 
            // es
            // 
            this.es.FormattingEnabled = true;
            this.es.Location = new System.Drawing.Point(260, 141);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(36, 21);
            this.es.TabIndex = 14;
            // 
            // em
            // 
            this.em.FormattingEnabled = true;
            this.em.Location = new System.Drawing.Point(211, 141);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(36, 21);
            this.em.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // ehr
            // 
            this.ehr.FormattingEnabled = true;
            this.ehr.Location = new System.Drawing.Point(154, 141);
            this.ehr.Name = "ehr";
            this.ehr.Size = new System.Drawing.Size(36, 21);
            this.ehr.TabIndex = 11;
            // 
            // ss
            // 
            this.ss.FormattingEnabled = true;
            this.ss.Location = new System.Drawing.Point(260, 107);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(36, 21);
            this.ss.TabIndex = 10;
            // 
            // sm
            // 
            this.sm.FormattingEnabled = true;
            this.sm.Location = new System.Drawing.Point(211, 107);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(36, 21);
            this.sm.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // shr
            // 
            this.shr.FormattingEnabled = true;
            this.shr.Location = new System.Drawing.Point(154, 107);
            this.shr.Name = "shr";
            this.shr.Size = new System.Drawing.Size(36, 21);
            this.shr.TabIndex = 7;
            // 
            // dtpkr
            // 
            this.dtpkr.Location = new System.Drawing.Point(154, 77);
            this.dtpkr.Name = "dtpkr";
            this.dtpkr.Size = new System.Drawing.Size(142, 20);
            this.dtpkr.TabIndex = 6;
            this.dtpkr.Value = new System.DateTime(2018, 2, 10, 17, 31, 59, 0);
            // 
            // patn
            // 
            this.patn.Location = new System.Drawing.Point(154, 46);
            this.patn.Name = "patn";
            this.patn.Size = new System.Drawing.Size(142, 20);
            this.patn.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 11);
            this.label5.TabIndex = 4;
            this.label5.Text = "Treatment: ";
            // 
            // endt
            // 
            this.endt.AutoSize = true;
            this.endt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endt.Location = new System.Drawing.Point(24, 151);
            this.endt.Name = "endt";
            this.endt.Size = new System.Drawing.Size(89, 11);
            this.endt.TabIndex = 3;
            this.endt.Text = "Ending Time:";
            // 
            // startt
            // 
            this.startt.AutoSize = true;
            this.startt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startt.Location = new System.Drawing.Point(24, 119);
            this.startt.Name = "startt";
            this.startt.Size = new System.Drawing.Size(103, 11);
            this.startt.TabIndex = 2;
            this.startt.Text = "Starting Time:";
            // 
            // appdate
            // 
            this.appdate.AutoSize = true;
            this.appdate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdate.Location = new System.Drawing.Point(24, 85);
            this.appdate.Name = "appdate";
            this.appdate.Size = new System.Drawing.Size(124, 11);
            this.appdate.TabIndex = 1;
            this.appdate.Text = "Appointment Date:";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(25, 51);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(96, 11);
            this.patient.TabIndex = 0;
            this.patient.Text = "Patient Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 11);
            this.label8.TabIndex = 54;
            this.label8.Text = "Today:";
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(72, 137);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(0, 11);
            this.datetime.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(385, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 322);
            this.panel1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // USC_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.details);
            this.Controls.Add(this.ViewBox1);
            this.Controls.Add(this.Appointment);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.Filter2);
            this.Controls.Add(this.Filter1);
            this.Controls.Add(this.label1);
            this.Name = "USC_appointment";
            this.Size = new System.Drawing.Size(891, 552);
            this.Load += new System.EventHandler(this.USC_appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox1)).EndInit();
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Filter1;
        private System.Windows.Forms.ComboBox Filter2;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button Appointment;
        private System.Windows.Forms.DataGridView ViewBox1;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox trm;
        private System.Windows.Forms.ComboBox es;
        private System.Windows.Forms.ComboBox em;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ehr;
        private System.Windows.Forms.ComboBox ss;
        private System.Windows.Forms.ComboBox sm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox shr;
        private System.Windows.Forms.DateTimePicker dtpkr;
        private System.Windows.Forms.TextBox patn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label endt;
        private System.Windows.Forms.Label startt;
        private System.Windows.Forms.Label appdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Button rst;
        private System.Windows.Forms.Button CancelS;
        private System.Windows.Forms.Button EditS;
        private System.Windows.Forms.Button AddS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
