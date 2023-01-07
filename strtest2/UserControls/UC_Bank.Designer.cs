namespace strtest2.UserControls
{
    partial class UC_Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bank));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKodBank = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fetch = new System.Windows.Forms.Button();
            this.updatButton = new System.Windows.Forms.Button();
            this.kk = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbNaymenov = new System.Windows.Forms.TextBox();
            this.pK = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.btShowData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // tbKodBank
            // 
            this.tbKodBank.Location = new System.Drawing.Point(189, 44);
            this.tbKodBank.Name = "tbKodBank";
            this.tbKodBank.Size = new System.Drawing.Size(89, 27);
            this.tbKodBank.TabIndex = 75;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(507, 12);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(310, 29);
            this.SearchBox.TabIndex = 72;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.Location = new System.Drawing.Point(815, -1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 42);
            this.searchButton.TabIndex = 73;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cbBank
            // 
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Items.AddRange(new object[] {
            "Все",
            "Код Банка",
            "Наименование",
            "Адресс"});
            this.cbBank.Location = new System.Drawing.Point(358, 13);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(143, 28);
            this.cbBank.TabIndex = 74;
            this.cbBank.SelectedIndexChanged += new System.EventHandler(this.cbBank_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(244, 281);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 27);
            this.deleteButton.TabIndex = 71;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.Location = new System.Drawing.Point(284, 44);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(54, 27);
            this.fetch.TabIndex = 70;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // updatButton
            // 
            this.updatButton.BackColor = System.Drawing.Color.Lime;
            this.updatButton.Location = new System.Drawing.Point(58, 281);
            this.updatButton.Name = "updatButton";
            this.updatButton.Size = new System.Drawing.Size(94, 27);
            this.updatButton.TabIndex = 69;
            this.updatButton.Text = "Update";
            this.updatButton.UseVisualStyleBackColor = false;
            this.updatButton.Click += new System.EventHandler(this.updatButton_Click);
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Location = new System.Drawing.Point(89, 44);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(80, 20);
            this.kk.TabIndex = 65;
            this.kk.Text = "Код Банка";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(148, 281);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 27);
            this.save.TabIndex = 64;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(189, 103);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(149, 27);
            this.tbAdress.TabIndex = 63;
            // 
            // tbNaymenov
            // 
            this.tbNaymenov.Location = new System.Drawing.Point(189, 73);
            this.tbNaymenov.Name = "tbNaymenov";
            this.tbNaymenov.Size = new System.Drawing.Size(149, 27);
            this.tbNaymenov.TabIndex = 62;
            // 
            // pK
            // 
            this.pK.AutoSize = true;
            this.pK.Location = new System.Drawing.Point(111, 103);
            this.pK.Name = "pK";
            this.pK.Size = new System.Drawing.Size(58, 20);
            this.pK.TabIndex = 61;
            this.pK.Text = "Адресс";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(53, 73);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(116, 20);
            this.fio.TabIndex = 60;
            this.fio.Text = "Наименование";
            // 
            // btShowData
            // 
            this.btShowData.Location = new System.Drawing.Point(65, 12);
            this.btShowData.Name = "btShowData";
            this.btShowData.Size = new System.Drawing.Size(280, 29);
            this.btShowData.TabIndex = 59;
            this.btShowData.Text = "SHOW DB";
            this.btShowData.UseVisualStyleBackColor = true;
            this.btShowData.Click += new System.EventHandler(this.btShowData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(358, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(588, 433);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код банка";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адресс";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
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
            this.Column6.HeaderText = "Delete";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 90;
            // 
            // UC_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbKodBank);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cbBank);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.updatButton);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbNaymenov);
            this.Controls.Add(this.pK);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btShowData);
            this.Name = "UC_Bank";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_Bank_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox tbKodBank;
        private TextBox SearchBox;
        private Button searchButton;
        private ComboBox cbBank;
        private Button deleteButton;
        private Button fetch;
        private Button updatButton;
        private Label kk;
        private Button save;
        private TextBox tbAdress;
        private TextBox tbNaymenov;
        private Label pK;
        private Label fio;
        private Button btShowData;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column6;
    }
}
