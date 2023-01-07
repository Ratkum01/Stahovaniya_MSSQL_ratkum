namespace strtest2.UserControls
{
    partial class UC_Strahovshiki
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
            this.btShowData = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cbStrahovshiki = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fetch = new System.Windows.Forms.Button();
            this.updatButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.voznagrajdenye_text = new System.Windows.Forms.TextBox();
            this.voznag = new System.Windows.Forms.Label();
            this.kod_strah = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.iin_textbox = new System.Windows.Forms.TextBox();
            this.fio_text_box = new System.Windows.Forms.TextBox();
            this.iin = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.kod_strah_text = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btShowData
            // 
            this.btShowData.Location = new System.Drawing.Point(15, 15);
            this.btShowData.Name = "btShowData";
            this.btShowData.Size = new System.Drawing.Size(280, 29);
            this.btShowData.TabIndex = 11;
            this.btShowData.Text = "SHOW DB";
            this.btShowData.UseVisualStyleBackColor = true;
            this.btShowData.Click += new System.EventHandler(this.btShowData_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(457, 16);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(310, 41);
            this.SearchBox.TabIndex = 32;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.Location = new System.Drawing.Point(765, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 42);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cbStrahovshiki
            // 
            this.cbStrahovshiki.FormattingEnabled = true;
            this.cbStrahovshiki.Items.AddRange(new object[] {
            "Все",
            "Код Страховщика",
            "ФИО",
            "ИИН",
            "Вознаграждение %"});
            this.cbStrahovshiki.Location = new System.Drawing.Point(308, 29);
            this.cbStrahovshiki.Name = "cbStrahovshiki";
            this.cbStrahovshiki.Size = new System.Drawing.Size(143, 28);
            this.cbStrahovshiki.TabIndex = 34;
            this.cbStrahovshiki.SelectedIndexChanged += new System.EventHandler(this.cbStrahovshiki_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(194, 284);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 27);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fetch
            // 
            this.fetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fetch.Location = new System.Drawing.Point(234, 67);
            this.fetch.Name = "fetch";
            this.fetch.Size = new System.Drawing.Size(54, 27);
            this.fetch.TabIndex = 30;
            this.fetch.Text = "Fetch";
            this.fetch.UseVisualStyleBackColor = false;
            this.fetch.Click += new System.EventHandler(this.fetch_Click);
            // 
            // updatButton
            // 
            this.updatButton.BackColor = System.Drawing.Color.Lime;
            this.updatButton.Location = new System.Drawing.Point(8, 284);
            this.updatButton.Name = "updatButton";
            this.updatButton.Size = new System.Drawing.Size(94, 27);
            this.updatButton.TabIndex = 29;
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
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(308, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 433);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код Страховщика";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
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
            this.Column3.HeaderText = "ИИН";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Вознаграждение %";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
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
            // voznagrajdenye_text
            // 
            this.voznagrajdenye_text.Location = new System.Drawing.Point(139, 192);
            this.voznagrajdenye_text.Name = "voznagrajdenye_text";
            this.voznagrajdenye_text.Size = new System.Drawing.Size(149, 27);
            this.voznagrajdenye_text.TabIndex = 27;
            // 
            // voznag
            // 
            this.voznag.AutoSize = true;
            this.voznag.Location = new System.Drawing.Point(8, 195);
            this.voznag.Name = "voznag";
            this.voznag.Size = new System.Drawing.Size(119, 20);
            this.voznag.TabIndex = 26;
            this.voznag.Text = "Voznagrajdeniye";
            // 
            // kod_strah
            // 
            this.kod_strah.AutoSize = true;
            this.kod_strah.Location = new System.Drawing.Point(39, 70);
            this.kod_strah.Name = "kod_strah";
            this.kod_strah.Size = new System.Drawing.Size(74, 20);
            this.kod_strah.TabIndex = 24;
            this.kod_strah.Text = "Kod Strah";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.Location = new System.Drawing.Point(98, 284);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 27);
            this.save.TabIndex = 23;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // iin_textbox
            // 
            this.iin_textbox.Location = new System.Drawing.Point(139, 147);
            this.iin_textbox.Name = "iin_textbox";
            this.iin_textbox.Size = new System.Drawing.Size(149, 27);
            this.iin_textbox.TabIndex = 22;
            // 
            // fio_text_box
            // 
            this.fio_text_box.Location = new System.Drawing.Point(139, 107);
            this.fio_text_box.Name = "fio_text_box";
            this.fio_text_box.Size = new System.Drawing.Size(149, 27);
            this.fio_text_box.TabIndex = 21;
            // 
            // iin
            // 
            this.iin.AutoSize = true;
            this.iin.Location = new System.Drawing.Point(85, 154);
            this.iin.Name = "iin";
            this.iin.Size = new System.Drawing.Size(28, 20);
            this.iin.TabIndex = 20;
            this.iin.Text = "IIN";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(85, 107);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(31, 20);
            this.fio.TabIndex = 19;
            this.fio.Text = "FIO";
            // 
            // kod_strah_text
            // 
            this.kod_strah_text.Location = new System.Drawing.Point(139, 63);
            this.kod_strah_text.Name = "kod_strah_text";
            this.kod_strah_text.Size = new System.Drawing.Size(89, 27);
            this.kod_strah_text.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::strtest2.Properties.Resources.meditsinskaya_strahovka_54wvtrbgcip0_128;
            this.pictureBox1.Location = new System.Drawing.Point(85, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Strahovshiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kod_strah_text);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cbStrahovshiki);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fetch);
            this.Controls.Add(this.updatButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voznagrajdenye_text);
            this.Controls.Add(this.voznag);
            this.Controls.Add(this.kod_strah);
            this.Controls.Add(this.save);
            this.Controls.Add(this.iin_textbox);
            this.Controls.Add(this.fio_text_box);
            this.Controls.Add(this.iin);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btShowData);
            this.Name = "UC_Strahovshiki";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_Strahovshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btShowData;
        private TextBox SearchBox;
        private Button searchButton;
        private ComboBox cbStrahovshiki;
        private Button deleteButton;
        private Button fetch;
        private Button updatButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column6;
        private TextBox voznagrajdenye_text;
        private Label voznag;
        private Label kod_strah;
        private Button save;
        private TextBox iin_textbox;
        private TextBox fio_text_box;
        private Label iin;
        private Label fio;
        private TextBox kod_strah_text;
        private PictureBox pictureBox1;
    }
}
