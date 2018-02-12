namespace Accounting
{
    partial class USC_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_inventory));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelbel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_itemdescription = new System.Windows.Forms.TextBox();
            this.textBox_itemname = new System.Windows.Forms.TextBox();
            this.Item_name = new System.Windows.Forms.Label();
            this.button_update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_reset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_create = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_deduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.expiry_date = new System.Windows.Forms.DateTimePicker();
            this.inventorylabel_id = new System.Windows.Forms.Label();
            this.textBox_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_stock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Item Expiry";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 436);
            this.dataGridView1.TabIndex = 136;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelbel
            // 
            this.labelbel.AutoSize = true;
            this.labelbel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelbel.Location = new System.Drawing.Point(10, 204);
            this.labelbel.Name = "labelbel";
            this.labelbel.Size = new System.Drawing.Size(127, 13);
            this.labelbel.TabIndex = 135;
            this.labelbel.Text = "Item Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Item Description";
            // 
            // textBox_itemdescription
            // 
            this.textBox_itemdescription.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemdescription.Location = new System.Drawing.Point(13, 149);
            this.textBox_itemdescription.Name = "textBox_itemdescription";
            this.textBox_itemdescription.Size = new System.Drawing.Size(240, 26);
            this.textBox_itemdescription.TabIndex = 130;
            // 
            // textBox_itemname
            // 
            this.textBox_itemname.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemname.Location = new System.Drawing.Point(13, 101);
            this.textBox_itemname.Name = "textBox_itemname";
            this.textBox_itemname.Size = new System.Drawing.Size(240, 26);
            this.textBox_itemname.TabIndex = 129;
            // 
            // Item_name
            // 
            this.Item_name.AutoSize = true;
            this.Item_name.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Item_name.Location = new System.Drawing.Point(10, 85);
            this.Item_name.Name = "Item_name";
            this.Item_name.Size = new System.Drawing.Size(79, 13);
            this.Item_name.TabIndex = 128;
            this.Item_name.Text = "Item Name";
            // 
            // button_update
            // 
            this.button_update.ActiveBorderThickness = 1;
            this.button_update.ActiveCornerRadius = 20;
            this.button_update.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_update.ActiveForecolor = System.Drawing.Color.White;
            this.button_update.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update.BackgroundImage")));
            this.button_update.ButtonText = "Update";
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_update.IdleBorderThickness = 1;
            this.button_update.IdleCornerRadius = 20;
            this.button_update.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_update.IdleForecolor = System.Drawing.Color.Black;
            this.button_update.IdleLineColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(101, 448);
            this.button_update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(76, 39);
            this.button_update.TabIndex = 142;
            this.button_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_reset
            // 
            this.button_reset.ActiveBorderThickness = 1;
            this.button_reset.ActiveCornerRadius = 20;
            this.button_reset.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_reset.ActiveForecolor = System.Drawing.Color.White;
            this.button_reset.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reset.BackgroundImage")));
            this.button_reset.ButtonText = "Reset";
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_reset.IdleBorderThickness = 1;
            this.button_reset.IdleCornerRadius = 20;
            this.button_reset.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_reset.IdleForecolor = System.Drawing.Color.Black;
            this.button_reset.IdleLineColor = System.Drawing.Color.Black;
            this.button_reset.Location = new System.Drawing.Point(187, 448);
            this.button_reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(76, 39);
            this.button_reset.TabIndex = 141;
            this.button_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_create
            // 
            this.button_create.ActiveBorderThickness = 1;
            this.button_create.ActiveCornerRadius = 20;
            this.button_create.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_create.ActiveForecolor = System.Drawing.Color.White;
            this.button_create.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_create.BackgroundImage")));
            this.button_create.ButtonText = "Create";
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_create.IdleBorderThickness = 1;
            this.button_create.IdleCornerRadius = 20;
            this.button_create.IdleFillColor = System.Drawing.Color.Transparent;
            this.button_create.IdleForecolor = System.Drawing.Color.Black;
            this.button_create.IdleLineColor = System.Drawing.Color.Black;
            this.button_create.Location = new System.Drawing.Point(15, 448);
            this.button_create.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(76, 39);
            this.button_create.TabIndex = 140;
            this.button_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_add
            // 
            this.button_add.ActiveBorderThickness = 1;
            this.button_add.ActiveCornerRadius = 20;
            this.button_add.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_add.ActiveForecolor = System.Drawing.Color.White;
            this.button_add.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_add.BackgroundImage")));
            this.button_add.ButtonText = "Add";
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Lucida Console", 9.25F);
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_add.IdleBorderThickness = 1;
            this.button_add.IdleCornerRadius = 20;
            this.button_add.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_add.IdleForecolor = System.Drawing.Color.Black;
            this.button_add.IdleLineColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(13, 233);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(59, 31);
            this.button_add.TabIndex = 143;
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_deduct
            // 
            this.button_deduct.ActiveBorderThickness = 1;
            this.button_deduct.ActiveCornerRadius = 20;
            this.button_deduct.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_deduct.ActiveForecolor = System.Drawing.Color.White;
            this.button_deduct.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_deduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_deduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_deduct.BackgroundImage")));
            this.button_deduct.ButtonText = "Deduct";
            this.button_deduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deduct.Font = new System.Drawing.Font("Lucida Console", 9.25F);
            this.button_deduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.button_deduct.IdleBorderThickness = 1;
            this.button_deduct.IdleCornerRadius = 20;
            this.button_deduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button_deduct.IdleForecolor = System.Drawing.Color.Black;
            this.button_deduct.IdleLineColor = System.Drawing.Color.Black;
            this.button_deduct.Location = new System.Drawing.Point(80, 233);
            this.button_deduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_deduct.Name = "button_deduct";
            this.button_deduct.Size = new System.Drawing.Size(65, 31);
            this.button_deduct.TabIndex = 144;
            this.button_deduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_deduct.Click += new System.EventHandler(this.button_deduct_Click);
            // 
            // expiry_date
            // 
            this.expiry_date.CustomFormat = "MMMM dd, yyyy";
            this.expiry_date.Font = new System.Drawing.Font("Arial", 12.25F);
            this.expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_date.Location = new System.Drawing.Point(13, 294);
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.Size = new System.Drawing.Size(240, 26);
            this.expiry_date.TabIndex = 145;
            // 
            // inventorylabel_id
            // 
            this.inventorylabel_id.AutoSize = true;
            this.inventorylabel_id.Location = new System.Drawing.Point(497, 54);
            this.inventorylabel_id.Name = "inventorylabel_id";
            this.inventorylabel_id.Size = new System.Drawing.Size(0, 13);
            this.inventorylabel_id.TabIndex = 146;
            // 
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.textBox_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox_search.BackgroundImage")));
            this.textBox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBox_search.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.Black;
            this.textBox_search.Icon = ((System.Drawing.Image)(resources.GetObject("textBox_search.Icon")));
            this.textBox_search.Location = new System.Drawing.Point(538, 43);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(328, 41);
            this.textBox_search.TabIndex = 147;
            this.textBox_search.text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 315;
            this.label1.Text = "INVENTORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(143, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 316;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 317;
            this.label5.Text = "label5";
            // 
            // button_stock
            // 
            this.button_stock.Activecolor = System.Drawing.Color.Teal;
            this.button_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.button_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stock.BorderRadius = 0;
            this.button_stock.ButtonText = "Stock in/out";
            this.button_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stock.DisabledColor = System.Drawing.Color.Gray;
            this.button_stock.Iconcolor = System.Drawing.Color.Transparent;
            this.button_stock.Iconimage = null;
            this.button_stock.Iconimage_right = null;
            this.button_stock.Iconimage_right_Selected = null;
            this.button_stock.Iconimage_Selected = null;
            this.button_stock.IconMarginLeft = 0;
            this.button_stock.IconMarginRight = 0;
            this.button_stock.IconRightVisible = true;
            this.button_stock.IconRightZoom = 0D;
            this.button_stock.IconVisible = true;
            this.button_stock.IconZoom = 70D;
            this.button_stock.IsTab = false;
            this.button_stock.Location = new System.Drawing.Point(408, 47);
            this.button_stock.Name = "button_stock";
            this.button_stock.Normalcolor = System.Drawing.Color.LightGray;
            this.button_stock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.button_stock.OnHoverTextColor = System.Drawing.Color.White;
            this.button_stock.selected = false;
            this.button_stock.Size = new System.Drawing.Size(106, 37);
            this.button_stock.TabIndex = 318;
            this.button_stock.Text = "Stock in/out";
            this.button_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_stock.Textcolor = System.Drawing.Color.Black;
            this.button_stock.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock.Click += new System.EventHandler(this.button_stock_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "View Inventory";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(286, 47);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(106, 37);
            this.bunifuFlatButton1.TabIndex = 319;
            this.bunifuFlatButton1.Text = "View Inventory";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // USC_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.button_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.inventorylabel_id);
            this.Controls.Add(this.expiry_date);
            this.Controls.Add(this.button_deduct);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelbel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_itemdescription);
            this.Controls.Add(this.textBox_itemname);
            this.Controls.Add(this.Item_name);
            this.Name = "USC_inventory";
            this.Size = new System.Drawing.Size(891, 552);
            this.Load += new System.EventHandler(this.USC_inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelbel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_itemdescription;
        private System.Windows.Forms.TextBox textBox_itemname;
        private System.Windows.Forms.Label Item_name;
        private Bunifu.Framework.UI.BunifuThinButton2 button_update;
        private Bunifu.Framework.UI.BunifuThinButton2 button_reset;
        private Bunifu.Framework.UI.BunifuThinButton2 button_create;
        private Bunifu.Framework.UI.BunifuThinButton2 button_add;
        private Bunifu.Framework.UI.BunifuThinButton2 button_deduct;
        private System.Windows.Forms.DateTimePicker expiry_date;
        private System.Windows.Forms.Label inventorylabel_id;
        private Bunifu.Framework.UI.BunifuTextbox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton button_stock;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
