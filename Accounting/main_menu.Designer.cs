namespace Accounting
{
    partial class main_menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_credential = new System.Windows.Forms.Button();
            this.mainmenulabel_id = new System.Windows.Forms.Label();
            this.label_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_user = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_inventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_sales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_dentalchart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_patient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab_appoinment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.tab_credential);
            this.panel1.Controls.Add(this.mainmenulabel_id);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 552);
            this.panel1.TabIndex = 0;
            // 
            // tab_credential
            // 
            this.tab_credential.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab_credential.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_credential.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(211)))), ((int)(((byte)(223)))));
            this.tab_credential.Image = ((System.Drawing.Image)(resources.GetObject("tab_credential.Image")));
            this.tab_credential.Location = new System.Drawing.Point(145, 8);
            this.tab_credential.Name = "tab_credential";
            this.tab_credential.Size = new System.Drawing.Size(37, 36);
            this.tab_credential.TabIndex = 4;
            this.tab_credential.UseVisualStyleBackColor = true;
            this.tab_credential.Click += new System.EventHandler(this.tab_credential_Click_1);
            // 
            // mainmenulabel_id
            // 
            this.mainmenulabel_id.AutoSize = true;
            this.mainmenulabel_id.Location = new System.Drawing.Point(12, 43);
            this.mainmenulabel_id.Name = "mainmenulabel_id";
            this.mainmenulabel_id.Size = new System.Drawing.Size(35, 13);
            this.mainmenulabel_id.TabIndex = 0;
            this.mainmenulabel_id.Text = "label1";
            this.mainmenulabel_id.Click += new System.EventHandler(this.mainmenulabel_id_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 65);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(79, 15);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "--------";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 15);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Logged in as :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.tab_user);
            this.panel2.Controls.Add(this.tab_inventory);
            this.panel2.Controls.Add(this.tab_sales);
            this.panel2.Controls.Add(this.tab_dentalchart);
            this.panel2.Controls.Add(this.tab_patient);
            this.panel2.Controls.Add(this.tab_appoinment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 450);
            this.panel2.TabIndex = 0;
            // 
            // tab_user
            // 
            this.tab_user.Activecolor = System.Drawing.Color.Teal;
            this.tab_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_user.BorderRadius = 0;
            this.tab_user.ButtonText = "  User";
            this.tab_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_user.DisabledColor = System.Drawing.Color.Gray;
            this.tab_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_user.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_user.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_user.Iconimage")));
            this.tab_user.Iconimage_right = null;
            this.tab_user.Iconimage_right_Selected = null;
            this.tab_user.Iconimage_Selected = null;
            this.tab_user.IconMarginLeft = 0;
            this.tab_user.IconMarginRight = 0;
            this.tab_user.IconRightVisible = true;
            this.tab_user.IconRightZoom = 0D;
            this.tab_user.IconVisible = true;
            this.tab_user.IconZoom = 70D;
            this.tab_user.IsTab = false;
            this.tab_user.Location = new System.Drawing.Point(0, 265);
            this.tab_user.Name = "tab_user";
            this.tab_user.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_user.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_user.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_user.selected = false;
            this.tab_user.Size = new System.Drawing.Size(188, 53);
            this.tab_user.TabIndex = 7;
            this.tab_user.Text = "  User";
            this.tab_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_user.Textcolor = System.Drawing.Color.Black;
            this.tab_user.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_user.Click += new System.EventHandler(this.tab_user_Click);
            // 
            // tab_inventory
            // 
            this.tab_inventory.Activecolor = System.Drawing.Color.Teal;
            this.tab_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_inventory.BorderRadius = 0;
            this.tab_inventory.ButtonText = "  Inventory";
            this.tab_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_inventory.DisabledColor = System.Drawing.Color.Gray;
            this.tab_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_inventory.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_inventory.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_inventory.Iconimage")));
            this.tab_inventory.Iconimage_right = null;
            this.tab_inventory.Iconimage_right_Selected = null;
            this.tab_inventory.Iconimage_Selected = null;
            this.tab_inventory.IconMarginLeft = 0;
            this.tab_inventory.IconMarginRight = 0;
            this.tab_inventory.IconRightVisible = true;
            this.tab_inventory.IconRightZoom = 0D;
            this.tab_inventory.IconVisible = true;
            this.tab_inventory.IconZoom = 70D;
            this.tab_inventory.IsTab = false;
            this.tab_inventory.Location = new System.Drawing.Point(0, 212);
            this.tab_inventory.Name = "tab_inventory";
            this.tab_inventory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_inventory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_inventory.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_inventory.selected = false;
            this.tab_inventory.Size = new System.Drawing.Size(188, 53);
            this.tab_inventory.TabIndex = 6;
            this.tab_inventory.Text = "  Inventory";
            this.tab_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_inventory.Textcolor = System.Drawing.Color.Black;
            this.tab_inventory.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_inventory.Click += new System.EventHandler(this.tab_inventory_Click);
            // 
            // tab_sales
            // 
            this.tab_sales.Activecolor = System.Drawing.Color.Teal;
            this.tab_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_sales.BorderRadius = 0;
            this.tab_sales.ButtonText = "  Sales";
            this.tab_sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_sales.DisabledColor = System.Drawing.Color.Gray;
            this.tab_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_sales.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_sales.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_sales.Iconimage")));
            this.tab_sales.Iconimage_right = null;
            this.tab_sales.Iconimage_right_Selected = null;
            this.tab_sales.Iconimage_Selected = null;
            this.tab_sales.IconMarginLeft = 0;
            this.tab_sales.IconMarginRight = 0;
            this.tab_sales.IconRightVisible = true;
            this.tab_sales.IconRightZoom = 0D;
            this.tab_sales.IconVisible = true;
            this.tab_sales.IconZoom = 70D;
            this.tab_sales.IsTab = false;
            this.tab_sales.Location = new System.Drawing.Point(0, 159);
            this.tab_sales.Name = "tab_sales";
            this.tab_sales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_sales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_sales.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_sales.selected = false;
            this.tab_sales.Size = new System.Drawing.Size(188, 53);
            this.tab_sales.TabIndex = 3;
            this.tab_sales.Text = "  Sales";
            this.tab_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_sales.Textcolor = System.Drawing.Color.Black;
            this.tab_sales.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_sales.Click += new System.EventHandler(this.tab_sales_Click);
            // 
            // tab_dentalchart
            // 
            this.tab_dentalchart.Activecolor = System.Drawing.Color.Teal;
            this.tab_dentalchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_dentalchart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_dentalchart.BorderRadius = 0;
            this.tab_dentalchart.ButtonText = "  Dental Chart";
            this.tab_dentalchart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_dentalchart.DisabledColor = System.Drawing.Color.Gray;
            this.tab_dentalchart.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_dentalchart.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_dentalchart.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_dentalchart.Iconimage")));
            this.tab_dentalchart.Iconimage_right = null;
            this.tab_dentalchart.Iconimage_right_Selected = null;
            this.tab_dentalchart.Iconimage_Selected = null;
            this.tab_dentalchart.IconMarginLeft = 0;
            this.tab_dentalchart.IconMarginRight = 0;
            this.tab_dentalchart.IconRightVisible = true;
            this.tab_dentalchart.IconRightZoom = 0D;
            this.tab_dentalchart.IconVisible = true;
            this.tab_dentalchart.IconZoom = 70D;
            this.tab_dentalchart.IsTab = false;
            this.tab_dentalchart.Location = new System.Drawing.Point(0, 106);
            this.tab_dentalchart.Name = "tab_dentalchart";
            this.tab_dentalchart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_dentalchart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_dentalchart.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_dentalchart.selected = false;
            this.tab_dentalchart.Size = new System.Drawing.Size(188, 53);
            this.tab_dentalchart.TabIndex = 2;
            this.tab_dentalchart.Text = "  Dental Chart";
            this.tab_dentalchart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_dentalchart.Textcolor = System.Drawing.Color.Black;
            this.tab_dentalchart.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_dentalchart.Click += new System.EventHandler(this.tab_dentalchart_Click);
            // 
            // tab_patient
            // 
            this.tab_patient.Activecolor = System.Drawing.Color.Teal;
            this.tab_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_patient.BorderRadius = 0;
            this.tab_patient.ButtonText = "  Patient ";
            this.tab_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_patient.DisabledColor = System.Drawing.Color.Gray;
            this.tab_patient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_patient.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_patient.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_patient.Iconimage")));
            this.tab_patient.Iconimage_right = null;
            this.tab_patient.Iconimage_right_Selected = null;
            this.tab_patient.Iconimage_Selected = null;
            this.tab_patient.IconMarginLeft = 0;
            this.tab_patient.IconMarginRight = 0;
            this.tab_patient.IconRightVisible = true;
            this.tab_patient.IconRightZoom = 0D;
            this.tab_patient.IconVisible = true;
            this.tab_patient.IconZoom = 70D;
            this.tab_patient.IsTab = false;
            this.tab_patient.Location = new System.Drawing.Point(0, 53);
            this.tab_patient.Name = "tab_patient";
            this.tab_patient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_patient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_patient.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_patient.selected = false;
            this.tab_patient.Size = new System.Drawing.Size(188, 53);
            this.tab_patient.TabIndex = 1;
            this.tab_patient.Text = "  Patient ";
            this.tab_patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_patient.Textcolor = System.Drawing.Color.Black;
            this.tab_patient.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_patient.Click += new System.EventHandler(this.tab_patient_Click);
            // 
            // tab_appoinment
            // 
            this.tab_appoinment.Activecolor = System.Drawing.Color.Teal;
            this.tab_appoinment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_appoinment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_appoinment.BorderRadius = 0;
            this.tab_appoinment.ButtonText = "  Appointment";
            this.tab_appoinment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_appoinment.DisabledColor = System.Drawing.Color.Gray;
            this.tab_appoinment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_appoinment.Iconcolor = System.Drawing.Color.Transparent;
            this.tab_appoinment.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab_appoinment.Iconimage")));
            this.tab_appoinment.Iconimage_right = null;
            this.tab_appoinment.Iconimage_right_Selected = null;
            this.tab_appoinment.Iconimage_Selected = null;
            this.tab_appoinment.IconMarginLeft = 0;
            this.tab_appoinment.IconMarginRight = 0;
            this.tab_appoinment.IconRightVisible = true;
            this.tab_appoinment.IconRightZoom = 0D;
            this.tab_appoinment.IconVisible = true;
            this.tab_appoinment.IconZoom = 70D;
            this.tab_appoinment.IsTab = false;
            this.tab_appoinment.Location = new System.Drawing.Point(0, 0);
            this.tab_appoinment.Name = "tab_appoinment";
            this.tab_appoinment.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tab_appoinment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tab_appoinment.OnHoverTextColor = System.Drawing.Color.White;
            this.tab_appoinment.selected = false;
            this.tab_appoinment.Size = new System.Drawing.Size(188, 53);
            this.tab_appoinment.TabIndex = 0;
            this.tab_appoinment.Text = "  Appointment";
            this.tab_appoinment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_appoinment.Textcolor = System.Drawing.Color.Black;
            this.tab_appoinment.TextFont = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_appoinment.Click += new System.EventHandler(this.tab_appoinment_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 552);
            this.panel3.TabIndex = 1;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "main_menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton tab_appoinment;
        private Bunifu.Framework.UI.BunifuFlatButton tab_sales;
        private Bunifu.Framework.UI.BunifuFlatButton tab_dentalchart;
        private Bunifu.Framework.UI.BunifuFlatButton tab_patient;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_name;
        public System.Windows.Forms.Label mainmenulabel_id;
        private System.Windows.Forms.Button tab_credential;
        private Bunifu.Framework.UI.BunifuFlatButton tab_inventory;
        private Bunifu.Framework.UI.BunifuFlatButton tab_user;
    }
}