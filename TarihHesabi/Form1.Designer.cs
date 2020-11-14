namespace TarihHesabi
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxYil = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxGun = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAy = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(32, 35);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(302, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "İndirimsiz Tahliye Tarihi";
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(32, 79);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(302, 23);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.Text = "İndirimli Tahliye Tarihi";
            this.metroTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_KeyDown);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Eklenecek zaman:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "İndirim Oranı:";
            // 
            // metroTextBoxYil
            // 
            this.metroTextBoxYil.Location = new System.Drawing.Point(149, 112);
            this.metroTextBoxYil.Name = "metroTextBoxYil";
            this.metroTextBoxYil.Size = new System.Drawing.Size(46, 23);
            this.metroTextBoxYil.TabIndex = 7;
            this.metroTextBoxYil.Text = "0";
            this.metroTextBoxYil.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            this.metroTextBoxYil.Click += new System.EventHandler(this.metroTextBox3_Click);
            this.metroTextBoxYil.Enter += new System.EventHandler(this.metroTextBox3_TextChanged);
            this.metroTextBoxYil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_KeyDown);
            this.metroTextBoxYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZaman_KeyPress);
            // 
            // metroTextBoxGun
            // 
            this.metroTextBoxGun.Location = new System.Drawing.Point(279, 112);
            this.metroTextBoxGun.Name = "metroTextBoxGun";
            this.metroTextBoxGun.Size = new System.Drawing.Size(46, 23);
            this.metroTextBoxGun.TabIndex = 9;
            this.metroTextBoxGun.Text = "0";
            this.metroTextBoxGun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_KeyDown);
            this.metroTextBoxGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZaman_KeyPress);
            // 
            // metroTextBoxAy
            // 
            this.metroTextBoxAy.Location = new System.Drawing.Point(215, 112);
            this.metroTextBoxAy.Name = "metroTextBoxAy";
            this.metroTextBoxAy.Size = new System.Drawing.Size(46, 23);
            this.metroTextBoxAy.TabIndex = 8;
            this.metroTextBoxAy.Text = "0";
            this.metroTextBoxAy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_KeyDown);
            this.metroTextBoxAy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZaman_KeyPress);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "İndirimsiz",
            "1/2",
            "2/3",
            "3/4"});
            this.metroComboBox1.Location = new System.Drawing.Point(149, 148);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Cezaevi Giriş Tarihi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(23, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Müddet Hesabı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuç";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(149, 87);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(23, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Yıl";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(215, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(24, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Ay";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(279, 90);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(32, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Gün";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(414, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 291);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yıl";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ay";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gün";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T.C.Gün";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İ. Oranı";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İ.Süresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 352);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBoxGun);
            this.Controls.Add(this.metroTextBoxAy);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxYil);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxYil;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGun;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAy;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

