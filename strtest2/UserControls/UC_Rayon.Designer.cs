namespace strtest2.UserControls
{
    partial class UC_Rayon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Rayon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKodRayon = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cbVidi = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fetch = new System.Windows.Forms.Button();
            this.updatButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kk = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.tbNaymenov = new System.Windows.Forms.TextBox();
            this.fio = new System.Windows.Forms.Label();
            this.btShowData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // tbKodRayon
            // 
            this.tbKodRayon.Location = new System.Drawing.Point(202, 60);
            this.tbKodRayon.Name = "tbKodRayon";
            this.tbKodRayon.Size = new System.Drawing.Size(89, 27);
            this.tbKodRayon.TabIndex = 97;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(520, 22);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(310, 28);
            this.SearchBox.TabIndex = 94;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.Location = new System.Drawing.Point(836, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 29);
            this.searchButton.TabIndex = 95;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cbVidi
            // 
            this.cbVidi.FormattingEnabled = true;
            this.cbVidi.Items.AddRange(new object[] {
            "Все",
            "Код Района",
            "Наименование"});
            this.cbVidi.Location = new System.Drawing.Point(371, 22);
            this.cbVidi.Name = "cbVidi";
            this.cbVidi.Size = new System.Drawing.Size(143, 28);
            this.cbVidi.TabIndex = 96;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(257, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 27);
            this.deleteButton.TabIndex = 93;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.Location = new System.Drawing.Point(297, 60);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(54, 27);
            this.fetch.TabIndex = 92;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // updatButton
            // 
            this.updatButton.BackColor = System.Drawing.Color.Lime;
            this.updatButton.Location = new System.Drawing.Point(71, 277);
            this.updatButton.Name = "updatButton";
            this.updatButton.Size = new System.Drawing.Size(94, 27);
            this.updatButton.TabIndex = 91;
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
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(371, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 433);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код района";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Изменить";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delete";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 150;
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Location = new System.Drawing.Point(102, 60);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(90, 20);
            this.kk.TabIndex = 87;
            this.kk.Text = "Код Района";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(161, 277);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 27);
            this.save.TabIndex = 86;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tbNaymenov
            // 
            this.tbNaymenov.Location = new System.Drawing.Point(202, 89);
            this.tbNaymenov.Name = "tbNaymenov";
            this.tbNaymenov.Size = new System.Drawing.Size(149, 27);
            this.tbNaymenov.TabIndex = 84;
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(76, 89);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(116, 20);
            this.fio.TabIndex = 82;
            this.fio.Text = "Наименование";
            // 
            // btShowData
            // 
            this.btShowData.Location = new System.Drawing.Point(71, 22);
            this.btShowData.Name = "btShowData";
            this.btShowData.Size = new System.Drawing.Size(280, 29);
            this.btShowData.TabIndex = 81;
            this.btShowData.Text = "SHOW DB";
            this.btShowData.UseVisualStyleBackColor = true;
            this.btShowData.Click += new System.EventHandler(this.btShowData_Click);
            // 
            // UC_Rayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbKodRayon);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cbVidi);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.updatButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tbNaymenov);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btShowData);
            this.Name = "UC_Rayon";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_Rayon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox tbKodRayon;
        private TextBox SearchBox;
        private Button searchButton;
        private ComboBox cbVidi;
        private Button deleteButton;
        private Button fetch;
        private Button updatButton;
        private DataGridView dataGridView1;
        private Label kk;
        private Button save;
        private TextBox tbNaymenov;
        private Label fio;
        private Button btShowData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column6;
    }
}
