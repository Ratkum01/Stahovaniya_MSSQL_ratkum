namespace strtest2.UserControls
{
    partial class UC_Perechislenie
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
            this.cbND = new System.Windows.Forms.ComboBox();
            this.cbKodKlienta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.voznag = new System.Windows.Forms.Label();
            this.kk = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tbSummaPer = new System.Windows.Forms.TextBox();
            this.pK = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.btShowData = new System.Windows.Forms.Button();
            this.cbKodBank = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtDataZ = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbND
            // 
            this.cbND.FormattingEnabled = true;
            this.cbND.Items.AddRange(new object[] {
            "Все",
            "Код Страховщика",
            "ФИО",
            "ИИН",
            "Вознаграждение %"});
            this.cbND.Location = new System.Drawing.Point(197, 76);
            this.cbND.Name = "cbND";
            this.cbND.Size = new System.Drawing.Size(150, 28);
            this.cbND.TabIndex = 124;
            // 
            // cbKodKlienta
            // 
            this.cbKodKlienta.FormattingEnabled = true;
            this.cbKodKlienta.Items.AddRange(new object[] {
            "Все",
            "Код Страховщика",
            "ФИО",
            "ИИН",
            "Вознаграждение %"});
            this.cbKodKlienta.Location = new System.Drawing.Point(199, 44);
            this.cbKodKlienta.Name = "cbKodKlienta";
            this.cbKodKlienta.Size = new System.Drawing.Size(89, 28);
            this.cbKodKlienta.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 122;
            this.label1.Text = "Дата перечисленеие";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(523, 15);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(310, 28);
            this.SearchBox.TabIndex = 118;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.Location = new System.Drawing.Point(839, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 28);
            this.searchButton.TabIndex = 119;
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
            "Номер договора",
            "Сумма перечисление ",
            "Код банка",
            "Дата перечисление"});
            this.cbVidi.Location = new System.Drawing.Point(374, 15);
            this.cbVidi.Name = "cbVidi";
            this.cbVidi.Size = new System.Drawing.Size(143, 28);
            this.cbVidi.TabIndex = 120;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(260, 270);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 27);
            this.deleteButton.TabIndex = 117;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.Location = new System.Drawing.Point(293, 47);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(54, 27);
            this.fetch.TabIndex = 116;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // updatButton
            // 
            this.updatButton.BackColor = System.Drawing.Color.Lime;
            this.updatButton.Location = new System.Drawing.Point(74, 270);
            this.updatButton.Name = "updatButton";
            this.updatButton.Size = new System.Drawing.Size(94, 27);
            this.updatButton.TabIndex = 115;
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
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(374, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 433);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код клиента";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер договора";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма перечисление";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код банка";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Дата перечисление";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Изменить";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delete";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 80;
            // 
            // voznag
            // 
            this.voznag.AutoSize = true;
            this.voznag.Location = new System.Drawing.Point(111, 136);
            this.voznag.Name = "voznag";
            this.voznag.Size = new System.Drawing.Size(80, 20);
            this.voznag.TabIndex = 112;
            this.voznag.Text = "Код банка";
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Location = new System.Drawing.Point(98, 47);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(94, 20);
            this.kk.TabIndex = 111;
            this.kk.Text = "Код клиента";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(164, 270);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 27);
            this.save.TabIndex = 110;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tbSummaPer
            // 
            this.tbSummaPer.Location = new System.Drawing.Point(198, 106);
            this.tbSummaPer.Name = "tbSummaPer";
            this.tbSummaPer.Size = new System.Drawing.Size(149, 27);
            this.tbSummaPer.TabIndex = 109;
            // 
            // pK
            // 
            this.pK.AutoSize = true;
            this.pK.Location = new System.Drawing.Point(31, 106);
            this.pK.Name = "pK";
            this.pK.Size = new System.Drawing.Size(161, 20);
            this.pK.TabIndex = 108;
            this.pK.Text = "Сумма Перечисление";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(62, 76);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(129, 20);
            this.fio.TabIndex = 107;
            this.fio.Text = "Номер Договора";
            // 
            // btShowData
            // 
            this.btShowData.Location = new System.Drawing.Point(74, 15);
            this.btShowData.Name = "btShowData";
            this.btShowData.Size = new System.Drawing.Size(280, 29);
            this.btShowData.TabIndex = 106;
            this.btShowData.Text = "SHOW DB";
            this.btShowData.UseVisualStyleBackColor = true;
            this.btShowData.Click += new System.EventHandler(this.btShowData_Click);
            // 
            // cbKodBank
            // 
            this.cbKodBank.FormattingEnabled = true;
            this.cbKodBank.Items.AddRange(new object[] {
            "Все",
            "Код Страховщика",
            "ФИО",
            "ИИН",
            "Вознаграждение %"});
            this.cbKodBank.Location = new System.Drawing.Point(197, 136);
            this.cbKodBank.Name = "cbKodBank";
            this.cbKodBank.Size = new System.Drawing.Size(150, 28);
            this.cbKodBank.TabIndex = 126;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::strtest2.Properties.Resources.dengi_z4njohp4z1pk_128;
            this.pictureBox1.Location = new System.Drawing.Point(152, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 146);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // dtDataZ
            // 
            this.dtDataZ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataZ.Location = new System.Drawing.Point(197, 171);
            this.dtDataZ.Name = "dtDataZ";
            this.dtDataZ.Size = new System.Drawing.Size(148, 27);
            this.dtDataZ.TabIndex = 128;
            // 
            // UC_Perechislenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.dtDataZ);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbKodBank);
            this.Controls.Add(this.cbND);
            this.Controls.Add(this.cbKodKlienta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cbVidi);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.updatButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voznag);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tbSummaPer);
            this.Controls.Add(this.pK);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btShowData);
            this.Name = "UC_Perechislenie";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_Perechislenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbND;
        private ComboBox cbKodKlienta;
        private Label label1;
        private TextBox SearchBox;
        private Button searchButton;
        private ComboBox cbVidi;
        private Button deleteButton;
        private Button fetch;
        private Button updatButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column6;
        private Label voznag;
        private Label kk;
        private Button save;
        private TextBox tbSummaPer;
        private Label pK;
        private Label fio;
        private Button btShowData;
        private ComboBox cbKodBank;
        private PictureBox pictureBox1;
        private DateTimePicker dtDataZ;
    }
}
