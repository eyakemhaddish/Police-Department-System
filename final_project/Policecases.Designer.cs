namespace final_project
{
    partial class Policecases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Policecases));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbpid = new System.Windows.Forms.ComboBox();
            this.cmbcid = new System.Windows.Forms.ComboBox();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.casesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policedbDataSet5 = new final_project.policedbDataSet5();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criminalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.casesTableAdapter = new final_project.policedbDataSet5TableAdapters.casesTableAdapter();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbsearch);
            this.panel1.Controls.Add(this.cmbpid);
            this.panel1.Controls.Add(this.cmbcid);
            this.panel1.Controls.Add(this.txtplace);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.cmbtype);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtdetail);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 510);
            this.panel1.TabIndex = 4;
            // 
            // cmbpid
            // 
            this.cmbpid.DisplayMember = "police_id";
            this.cmbpid.Enabled = false;
            this.cmbpid.FormattingEnabled = true;
            this.cmbpid.Location = new System.Drawing.Point(497, 111);
            this.cmbpid.Name = "cmbpid";
            this.cmbpid.Size = new System.Drawing.Size(49, 21);
            this.cmbpid.TabIndex = 14;
            this.cmbpid.ValueMember = "police_id";
            this.cmbpid.SelectedIndexChanged += new System.EventHandler(this.cmbpid_SelectedIndexChanged);
            // 
            // cmbcid
            // 
            this.cmbcid.DisplayMember = "criminal_id";
            this.cmbcid.Enabled = false;
            this.cmbcid.FormattingEnabled = true;
            this.cmbcid.Location = new System.Drawing.Point(497, 55);
            this.cmbcid.Name = "cmbcid";
            this.cmbcid.Size = new System.Drawing.Size(49, 21);
            this.cmbcid.TabIndex = 13;
            this.cmbcid.ValueMember = "criminal_id";
            this.cmbcid.SelectedIndexChanged += new System.EventHandler(this.cmbcid_SelectedIndexChanged);
            // 
            // txtplace
            // 
            this.txtplace.Enabled = false;
            this.txtplace.Location = new System.Drawing.Point(17, 149);
            this.txtplace.Multiline = true;
            this.txtplace.Name = "txtplace";
            this.txtplace.Size = new System.Drawing.Size(151, 32);
            this.txtplace.TabIndex = 12;
            this.txtplace.TextChanged += new System.EventHandler(this.txtplace_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(14, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Case Place";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(408, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Officer ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(408, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Criminal ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(19, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Case Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Case type";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(132, 213);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 7;
            // 
            // cmbtype
            // 
            this.cmbtype.DataSource = this.casesBindingSource;
            this.cmbtype.DisplayMember = "CaseType";
            this.cmbtype.Enabled = false;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(17, 83);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(121, 21);
            this.cmbtype.TabIndex = 5;
            this.cmbtype.ValueMember = "CaseType";
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // casesBindingSource
            // 
            this.casesBindingSource.DataMember = "cases";
            this.casesBindingSource.DataSource = this.policedbDataSet5;
            // 
            // policedbDataSet5
            // 
            this.policedbDataSet5.DataSetName = "policedbDataSet5";
            this.policedbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(199, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Case Detail";
            // 
            // txtdetail
            // 
            this.txtdetail.Enabled = false;
            this.txtdetail.Location = new System.Drawing.Point(202, 83);
            this.txtdetail.Multiline = true;
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(156, 63);
            this.txtdetail.TabIndex = 3;
            this.txtdetail.TextChanged += new System.EventHandler(this.txtdetail_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caseidDataGridViewTextBoxColumn,
            this.caseTypeDataGridViewTextBoxColumn,
            this.caseDetailDataGridViewTextBoxColumn,
            this.caseDateDataGridViewTextBoxColumn,
            this.casePlaceDataGridViewTextBoxColumn,
            this.criminalidDataGridViewTextBoxColumn,
            this.policeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.casesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // caseidDataGridViewTextBoxColumn
            // 
            this.caseidDataGridViewTextBoxColumn.DataPropertyName = "case_id";
            this.caseidDataGridViewTextBoxColumn.HeaderText = "case_id";
            this.caseidDataGridViewTextBoxColumn.Name = "caseidDataGridViewTextBoxColumn";
            this.caseidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseTypeDataGridViewTextBoxColumn
            // 
            this.caseTypeDataGridViewTextBoxColumn.DataPropertyName = "CaseType";
            this.caseTypeDataGridViewTextBoxColumn.HeaderText = "CaseType";
            this.caseTypeDataGridViewTextBoxColumn.Name = "caseTypeDataGridViewTextBoxColumn";
            this.caseTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseDetailDataGridViewTextBoxColumn
            // 
            this.caseDetailDataGridViewTextBoxColumn.DataPropertyName = "caseDetail";
            this.caseDetailDataGridViewTextBoxColumn.HeaderText = "caseDetail";
            this.caseDetailDataGridViewTextBoxColumn.Name = "caseDetailDataGridViewTextBoxColumn";
            this.caseDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseDateDataGridViewTextBoxColumn
            // 
            this.caseDateDataGridViewTextBoxColumn.DataPropertyName = "caseDate";
            this.caseDateDataGridViewTextBoxColumn.HeaderText = "caseDate";
            this.caseDateDataGridViewTextBoxColumn.Name = "caseDateDataGridViewTextBoxColumn";
            this.caseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casePlaceDataGridViewTextBoxColumn
            // 
            this.casePlaceDataGridViewTextBoxColumn.DataPropertyName = "casePlace";
            this.casePlaceDataGridViewTextBoxColumn.HeaderText = "casePlace";
            this.casePlaceDataGridViewTextBoxColumn.Name = "casePlaceDataGridViewTextBoxColumn";
            this.casePlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criminalidDataGridViewTextBoxColumn
            // 
            this.criminalidDataGridViewTextBoxColumn.DataPropertyName = "criminal_id";
            this.criminalidDataGridViewTextBoxColumn.HeaderText = "criminal_id";
            this.criminalidDataGridViewTextBoxColumn.Name = "criminalidDataGridViewTextBoxColumn";
            this.criminalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // policeidDataGridViewTextBoxColumn
            // 
            this.policeidDataGridViewTextBoxColumn.DataPropertyName = "police_id";
            this.policeidDataGridViewTextBoxColumn.HeaderText = "police_id";
            this.policeidDataGridViewTextBoxColumn.Name = "policeidDataGridViewTextBoxColumn";
            this.policeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(12, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 52);
            this.panel6.TabIndex = 27;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
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
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 295);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(66, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 26;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(12, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 52);
            this.panel4.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 20);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 52);
            this.panel2.TabIndex = 24;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
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
            // casesTableAdapter
            // 
            this.casesTableAdapter.ClearBeforeFill = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(564, 202);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 21);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(408, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Search";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Case ID",
            "Case Type ",
            "Case Detail",
            "Case Date",
            "Case Place",
            "Criminal ID",
            "Police ID"});
            this.cmbsearch.Location = new System.Drawing.Point(411, 202);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 21);
            this.cmbsearch.TabIndex = 33;
            this.cmbsearch.Text = "Search By";
            // 
            // Policecases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1016, 479);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Policecases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policecases";
            this.Load += new System.EventHandler(this.Policecases_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policedbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbpid;
        private System.Windows.Forms.ComboBox cmbcid;
        private System.Windows.Forms.TextBox txtplace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private policedbDataSet5 policedbDataSet5;
        private System.Windows.Forms.BindingSource casesBindingSource;
        private policedbDataSet5TableAdapters.casesTableAdapter casesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criminalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbsearch;
    }
}