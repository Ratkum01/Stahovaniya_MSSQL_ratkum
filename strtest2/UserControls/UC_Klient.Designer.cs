namespace strtest2.UserControls
{
    partial class UC_Klient
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Klient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKodKlient = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cbVidi = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fetch = new System.Windows.Forms.Button();
            this.updatButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.voznag = new System.Windows.Forms.Label();
            this.kod_strah = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.iin = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.btShowData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLicShet = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // tbKodKlient
            // 
            this.tbKodKlient.Location = new System.Drawing.Point(171, 64);
            this.tbKodKlient.Name = "tbKodKlient";
            this.tbKodKlient.Size = new System.Drawing.Size(89, 27);
            this.tbKodKlient.TabIndex = 53;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(489, 26);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(310, 28);
            this.SearchBox.TabIndex = 50;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.Location = new System.Drawing.Point(805, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 28);
            this.searchButton.TabIndex = 51;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cbVidi
            // 
            this.cbVidi.FormattingEnabled = true;
            this.cbVidi.Items.AddRange(new object[] {
            "Все",
            "Код клиента",
            "ФИО",
            "Признак клиента",
            "Код района",
            "Лицевой счет",
            "Код банка"});
            this.cbVidi.Location = new System.Drawing.Point(340, 26);
            this.cbVidi.Name = "cbVidi";
            this.cbVidi.Size = new System.Drawing.Size(143, 28);
            this.cbVidi.TabIndex = 52;
            this.cbVidi.SelectedIndexChanged += new System.EventHandler(this.cbVidi_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(226, 281);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 27);
            this.deleteButton.TabIndex = 49;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.Location = new System.Drawing.Point(266, 64);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(54, 27);
            this.fetch.TabIndex = 48;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // updatButton
            // 
            this.updatButton.BackColor = System.Drawing.Color.Lime;
            this.updatButton.Location = new System.Drawing.Point(40, 281);
            this.updatButton.Name = "updatButton";
            this.updatButton.Size = new System.Drawing.Size(94, 27);
            this.updatButton.TabIndex = 47;
            this.updatButton.Text = "Update";
            this.updatButton.UseVisualStyleBackColor = false;
            this.updatButton.Click += new System.EventHandler(this.updatButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(340, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 433);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код клиента";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Признак клиента";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код района";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Лицевой счет";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Код банк";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Изменить";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Удалить";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 90;
            // 
            // voznag
            // 
            this.voznag.AutoSize = true;
            this.voznag.Location = new System.Drawing.Point(71, 170);
            this.voznag.Name = "voznag";
            this.voznag.Size = new System.Drawing.Size(91, 20);
            this.voznag.TabIndex = 44;
            this.voznag.Text = "Код района";
            // 
            // kod_strah
            // 
            this.kod_strah.AutoSize = true;
            this.kod_strah.Location = new System.Drawing.Point(66, 67);
            this.kod_strah.Name = "kod_strah";
            this.kod_strah.Size = new System.Drawing.Size(96, 20);
            this.kod_strah.TabIndex = 43;
            this.kod_strah.Text = "Код Клиента";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(130, 281);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 27);
            this.save.TabIndex = 42;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(171, 97);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(149, 27);
            this.tbFIO.TabIndex = 40;
            // 
            // iin
            // 
            this.iin.AutoSize = true;
            this.iin.Location = new System.Drawing.Point(37, 137);
            this.iin.Name = "iin";
            this.iin.Size = new System.Drawing.Size(128, 20);
            this.iin.TabIndex = 39;
            this.iin.Text = "Признак клиента";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(130, 104);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(42, 20);
            this.fio.TabIndex = 38;
            this.fio.Text = "ФИО";
            // 
            // btShowData
            // 
            this.btShowData.Location = new System.Drawing.Point(40, 25);
            this.btShowData.Name = "btShowData";
            this.btShowData.Size = new System.Drawing.Size(280, 29);
            this.btShowData.TabIndex = 37;
            this.btShowData.Text = "SHOW DB";
            this.btShowData.UseVisualStyleBackColor = true;
            this.btShowData.Click += new System.EventHandler(this.btShowData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Лицевой счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Код банка";
            // 
            // tbLicShet
            // 
            this.tbLicShet.Location = new System.Drawing.Point(171, 193);
            this.tbLicShet.Name = "tbLicShet";
            this.tbLicShet.Size = new System.Drawing.Size(149, 27);
            this.tbLicShet.TabIndex = 57;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 28);
            this.comboBox1.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 226);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 28);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "физ",
            "юр"});
            this.comboBox3.Location = new System.Drawing.Point(171, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 28);
            this.comboBox3.TabIndex = 61;
            // 
            // UC_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbLicShet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbKodKlient);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cbVidi);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.updatButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voznag);
            this.Controls.Add(this.kod_strah);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.iin);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btShowData);
            this.Name = "UC_Klient";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbKodKlient;
        private TextBox SearchBox;
        private Button searchButton;
        private ComboBox cbVidi;
        private Button deleteButton;
        private Button fetch;
        private Button updatButton;
        private DataGridView dataGridView1;
        private Label voznag;
        private Label kod_strah;
        private Button save;
        private TextBox tbFIO;
        private Label iin;
        private Label fio;
        private Button btShowData;
        private Label label1;
        private Label label2;
        private TextBox tbLicShet;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column6;
    }
}
