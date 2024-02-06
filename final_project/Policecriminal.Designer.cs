namespace final_project
{
    partial class Policecriminal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Policecriminal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.criminalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminaladdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policedbDataSet7 = new final_project.policedbDataSet7();
            this.label10 = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.addbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.criminalsTableAdapter = new final_project.policedbDataSet7TableAdapters.criminalsTableAdapter();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSet7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbsearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.idlabel);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.delbtn);
            this.panel1.Controls.Add(this.editbtn);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtadd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(224, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 509);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criminalidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.criminaladdressDataGridViewTextBoxColumn,
            this.crimetypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.criminalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(281, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 237);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // criminalidDataGridViewTextBoxColumn
            // 
            this.criminalidDataGridViewTextBoxColumn.DataPropertyName = "criminal_id";
            this.criminalidDataGridViewTextBoxColumn.HeaderText = "criminal_id";
            this.criminalidDataGridViewTextBoxColumn.Name = "criminalidDataGridViewTextBoxColumn";
            this.criminalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criminaladdressDataGridViewTextBoxColumn
            // 
            this.criminaladdressDataGridViewTextBoxColumn.DataPropertyName = "criminal_address";
            this.criminaladdressDataGridViewTextBoxColumn.HeaderText = "criminal_address";
            this.criminaladdressDataGridViewTextBoxColumn.Name = "criminaladdressDataGridViewTextBoxColumn";
            this.criminaladdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crimetypeDataGridViewTextBoxColumn
            // 
            this.crimetypeDataGridViewTextBoxColumn.DataPropertyName = "crime_type";
            this.crimetypeDataGridViewTextBoxColumn.HeaderText = "crime_type";
            this.crimetypeDataGridViewTextBoxColumn.Name = "crimetypeDataGridViewTextBoxColumn";
            this.crimetypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criminalsBindingSource
            // 
            this.criminalsBindingSource.DataMember = "criminals";
            this.criminalsBindingSource.DataSource = this.policedbDataSet7;
            // 
            // policedbDataSet7
            // 
            this.policedbDataSet7.DataSetName = "policedbDataSet7";
            this.policedbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(439, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Criminal ID";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.idlabel.Location = new System.Drawing.Point(480, 103);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(22, 17);
            this.idlabel.TabIndex = 21;
            this.idlabel.Text = "ID";
            // 
            // addbtn
            // 
            this.addbtn.ActiveBorderThickness = 1;
            this.addbtn.ActiveCornerRadius = 20;
            this.addbtn.ActiveFillColor = System.Drawing.Color.DarkSeaGreen;
            this.addbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtn.BackgroundImage")));
            this.addbtn.ButtonText = "Add";
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.IdleBorderThickness = 1;
            this.addbtn.IdleCornerRadius = 20;
            this.addbtn.IdleFillColor = System.Drawing.Color.White;
            this.addbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addbtn.Location = new System.Drawing.Point(66, 323);
            this.addbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(111, 40);
            this.addbtn.TabIndex = 20;
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.ActiveBorderThickness = 1;
            this.delbtn.ActiveCornerRadius = 20;
            this.delbtn.ActiveFillColor = System.Drawing.Color.Red;
            this.delbtn.ActiveForecolor = System.Drawing.Color.White;
            this.delbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.delbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delbtn.BackgroundImage")));
            this.delbtn.ButtonText = "Delete";
            this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delbtn.IdleBorderThickness = 1;
            this.delbtn.IdleCornerRadius = 20;
            this.delbtn.IdleFillColor = System.Drawing.Color.White;
            this.delbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.delbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.delbtn.Location = new System.Drawing.Point(66, 390);
            this.delbtn.Margin = new System.Windows.Forms.Padding(5);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(111, 40);
            this.delbtn.TabIndex = 19;
            this.delbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.ActiveBorderThickness = 1;
            this.editbtn.ActiveCornerRadius = 20;
            this.editbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.editbtn.ActiveForecolor = System.Drawing.Color.White;
            this.editbtn.ActiveLineColor = System.Drawing.Color.SeaShell;
            this.editbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editbtn.BackgroundImage")));
            this.editbtn.ButtonText = "Edit";
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editbtn.IdleBorderThickness = 1;
            this.editbtn.IdleCornerRadius = 20;
            this.editbtn.IdleFillColor = System.Drawing.Color.White;
            this.editbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.editbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.editbtn.Location = new System.Drawing.Point(66, 251);
            this.editbtn.Margin = new System.Windows.Forms.Padding(5);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(111, 40);
            this.editbtn.TabIndex = 18;
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(28, 183);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 21);
            this.txtname.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(25, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Criminal Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(191, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Against Person",
            "Against Property",
            "Incholate Crime",
            "statuary Crime",
            "Financial Crime"});
            this.comboBox1.Location = new System.Drawing.Point(28, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(25, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Crime Type";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(194, 103);
            this.txtadd.Multiline = true;
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(213, 52);
            this.txtadd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manage Criminals";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(12, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 52);
            this.panel2.TabIndex = 35;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cases";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(12, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 52);
            this.panel6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Criminals";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(66, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(11, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 52);
            this.panel4.TabIndex = 36;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(610, 179);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 21);
            this.txtsearch.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(449, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Address",
            "Type"});
            this.cmbsearch.Location = new System.Drawing.Point(452, 179);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 21);
            this.cmbsearch.TabIndex = 27;
            this.cmbsearch.Text = "Search By";
            // 
            // Policecriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1016, 479);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Name = "Policecriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policecriminal";
            this.Load += new System.EventHandler(this.Policecriminal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSet7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label idlabel;
        private Bunifu.Framework.UI.BunifuThinButton2 addbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 delbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editbtn;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private policedbDataSet7 policedbDataSet7;
        private System.Windows.Forms.BindingSource criminalsBindingSource;
        private policedbDataSet7TableAdapters.criminalsTableAdapter criminalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn criminalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criminaladdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crimetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsearch;
    }
}