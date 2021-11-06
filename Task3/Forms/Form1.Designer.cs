
namespace Task3.Forms
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.button_AZ_name = new System.Windows.Forms.Button();
            this.button_ZA_name = new System.Windows.Forms.Button();
            this.button_findName = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.button_findAuthor = new System.Windows.Forms.Button();
            this.button_ZA_author = new System.Windows.Forms.Button();
            this.button_AZ_author = new System.Windows.Forms.Button();
            this.textBox_collection = new System.Windows.Forms.TextBox();
            this.button_findCollection = new System.Windows.Forms.Button();
            this.button_ZA_collection = new System.Windows.Forms.Button();
            this.button_AZ_collection = new System.Windows.Forms.Button();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.button_findGenre = new System.Windows.Forms.Button();
            this.button_ZA_genre = new System.Windows.Forms.Button();
            this.button_AZ_genre = new System.Windows.Forms.Button();
            this.button_uptime = new System.Windows.Forms.Button();
            this.button_downtime = new System.Windows.Forms.Button();
            this.button_upsize = new System.Windows.Forms.Button();
            this.button_downsize = new System.Windows.Forms.Button();
            this.textBox_minTime = new System.Windows.Forms.TextBox();
            this.textBox_maxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maxSize = new System.Windows.Forms.TextBox();
            this.textBox_minSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_filepick = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button_SaveAll = new System.Windows.Forms.Button();
            this.button_openDiskFiles = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ConfirmSorting = new System.Windows.Forms.Button();
            this.button_backToHDD = new System.Windows.Forms.Button();
            this.button_sortSize = new System.Windows.Forms.Button();
            this.button_sortTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(297, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(308, 21);
            this.title.TabIndex = 0;
            this.title.Text = "Поиск по основному полю:";
            // 
            // button_AZ_name
            // 
            this.button_AZ_name.BackColor = System.Drawing.Color.Black;
            this.button_AZ_name.Location = new System.Drawing.Point(37, 76);
            this.button_AZ_name.Name = "button_AZ_name";
            this.button_AZ_name.Size = new System.Drawing.Size(99, 25);
            this.button_AZ_name.TabIndex = 13;
            this.button_AZ_name.Text = "A - Z";
            this.button_AZ_name.UseVisualStyleBackColor = false;
            this.button_AZ_name.Click += new System.EventHandler(this.button_AZ_name_Click);
            // 
            // button_ZA_name
            // 
            this.button_ZA_name.BackColor = System.Drawing.Color.Black;
            this.button_ZA_name.Location = new System.Drawing.Point(37, 120);
            this.button_ZA_name.Name = "button_ZA_name";
            this.button_ZA_name.Size = new System.Drawing.Size(99, 25);
            this.button_ZA_name.TabIndex = 14;
            this.button_ZA_name.Text = "Z - A";
            this.button_ZA_name.UseVisualStyleBackColor = false;
            this.button_ZA_name.Click += new System.EventHandler(this.button_ZA_name_Click);
            // 
            // button_findName
            // 
            this.button_findName.BackColor = System.Drawing.Color.Black;
            this.button_findName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_findName.Location = new System.Drawing.Point(37, 222);
            this.button_findName.Name = "button_findName";
            this.button_findName.Size = new System.Drawing.Size(99, 25);
            this.button_findName.TabIndex = 15;
            this.button_findName.Text = "Find";
            this.button_findName.UseVisualStyleBackColor = false;
            this.button_findName.Click += new System.EventHandler(this.button_findName_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.Black;
            this.textBox_name.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_name.Location = new System.Drawing.Point(37, 173);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(99, 22);
            this.textBox_name.TabIndex = 16;
            // 
            // textBox_author
            // 
            this.textBox_author.BackColor = System.Drawing.Color.Black;
            this.textBox_author.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_author.Location = new System.Drawing.Point(170, 173);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(99, 22);
            this.textBox_author.TabIndex = 20;
            // 
            // button_findAuthor
            // 
            this.button_findAuthor.BackColor = System.Drawing.Color.Black;
            this.button_findAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_findAuthor.Location = new System.Drawing.Point(170, 222);
            this.button_findAuthor.Name = "button_findAuthor";
            this.button_findAuthor.Size = new System.Drawing.Size(99, 25);
            this.button_findAuthor.TabIndex = 19;
            this.button_findAuthor.Text = "Find";
            this.button_findAuthor.UseVisualStyleBackColor = false;
            this.button_findAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ZA_author
            // 
            this.button_ZA_author.BackColor = System.Drawing.Color.Black;
            this.button_ZA_author.Location = new System.Drawing.Point(170, 120);
            this.button_ZA_author.Name = "button_ZA_author";
            this.button_ZA_author.Size = new System.Drawing.Size(99, 25);
            this.button_ZA_author.TabIndex = 18;
            this.button_ZA_author.Text = "Z - A";
            this.button_ZA_author.UseVisualStyleBackColor = false;
            this.button_ZA_author.Click += new System.EventHandler(this.button_ZA_author_Click);
            // 
            // button_AZ_author
            // 
            this.button_AZ_author.BackColor = System.Drawing.Color.Black;
            this.button_AZ_author.Location = new System.Drawing.Point(170, 76);
            this.button_AZ_author.Name = "button_AZ_author";
            this.button_AZ_author.Size = new System.Drawing.Size(99, 25);
            this.button_AZ_author.TabIndex = 17;
            this.button_AZ_author.Text = "A - Z";
            this.button_AZ_author.UseVisualStyleBackColor = false;
            this.button_AZ_author.Click += new System.EventHandler(this.button_AZ_author_Click);
            // 
            // textBox_collection
            // 
            this.textBox_collection.BackColor = System.Drawing.Color.Black;
            this.textBox_collection.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_collection.Location = new System.Drawing.Point(304, 173);
            this.textBox_collection.Name = "textBox_collection";
            this.textBox_collection.Size = new System.Drawing.Size(99, 22);
            this.textBox_collection.TabIndex = 24;
            // 
            // button_findCollection
            // 
            this.button_findCollection.BackColor = System.Drawing.Color.Black;
            this.button_findCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_findCollection.Location = new System.Drawing.Point(304, 222);
            this.button_findCollection.Name = "button_findCollection";
            this.button_findCollection.Size = new System.Drawing.Size(99, 25);
            this.button_findCollection.TabIndex = 23;
            this.button_findCollection.Text = "Find";
            this.button_findCollection.UseVisualStyleBackColor = false;
            this.button_findCollection.Click += new System.EventHandler(this.button_findCollection_Click);
            // 
            // button_ZA_collection
            // 
            this.button_ZA_collection.BackColor = System.Drawing.Color.Black;
            this.button_ZA_collection.Location = new System.Drawing.Point(304, 120);
            this.button_ZA_collection.Name = "button_ZA_collection";
            this.button_ZA_collection.Size = new System.Drawing.Size(99, 25);
            this.button_ZA_collection.TabIndex = 22;
            this.button_ZA_collection.Text = "Z - A";
            this.button_ZA_collection.UseVisualStyleBackColor = false;
            this.button_ZA_collection.Click += new System.EventHandler(this.button_ZA_collection_Click);
            // 
            // button_AZ_collection
            // 
            this.button_AZ_collection.BackColor = System.Drawing.Color.Black;
            this.button_AZ_collection.Location = new System.Drawing.Point(304, 76);
            this.button_AZ_collection.Name = "button_AZ_collection";
            this.button_AZ_collection.Size = new System.Drawing.Size(99, 25);
            this.button_AZ_collection.TabIndex = 21;
            this.button_AZ_collection.Text = "A - Z";
            this.button_AZ_collection.UseVisualStyleBackColor = false;
            this.button_AZ_collection.Click += new System.EventHandler(this.button_AZ_collection_Click);
            // 
            // textBox_genre
            // 
            this.textBox_genre.BackColor = System.Drawing.Color.Black;
            this.textBox_genre.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_genre.Location = new System.Drawing.Point(437, 173);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(99, 22);
            this.textBox_genre.TabIndex = 28;
            // 
            // button_findGenre
            // 
            this.button_findGenre.BackColor = System.Drawing.Color.Black;
            this.button_findGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_findGenre.Location = new System.Drawing.Point(437, 222);
            this.button_findGenre.Name = "button_findGenre";
            this.button_findGenre.Size = new System.Drawing.Size(99, 25);
            this.button_findGenre.TabIndex = 27;
            this.button_findGenre.Text = "Find";
            this.button_findGenre.UseVisualStyleBackColor = false;
            this.button_findGenre.Click += new System.EventHandler(this.button_findGenre_Click);
            // 
            // button_ZA_genre
            // 
            this.button_ZA_genre.BackColor = System.Drawing.Color.Black;
            this.button_ZA_genre.Location = new System.Drawing.Point(437, 120);
            this.button_ZA_genre.Name = "button_ZA_genre";
            this.button_ZA_genre.Size = new System.Drawing.Size(99, 25);
            this.button_ZA_genre.TabIndex = 26;
            this.button_ZA_genre.Text = "Z - A";
            this.button_ZA_genre.UseVisualStyleBackColor = false;
            this.button_ZA_genre.Click += new System.EventHandler(this.button_ZA_genre_Click);
            // 
            // button_AZ_genre
            // 
            this.button_AZ_genre.BackColor = System.Drawing.Color.Black;
            this.button_AZ_genre.Location = new System.Drawing.Point(437, 76);
            this.button_AZ_genre.Name = "button_AZ_genre";
            this.button_AZ_genre.Size = new System.Drawing.Size(99, 25);
            this.button_AZ_genre.TabIndex = 25;
            this.button_AZ_genre.Text = "A - Z";
            this.button_AZ_genre.UseVisualStyleBackColor = false;
            this.button_AZ_genre.Click += new System.EventHandler(this.button_AZ_genre_Click);
            // 
            // button_uptime
            // 
            this.button_uptime.BackColor = System.Drawing.Color.Black;
            this.button_uptime.Location = new System.Drawing.Point(562, 120);
            this.button_uptime.Name = "button_uptime";
            this.button_uptime.Size = new System.Drawing.Size(99, 25);
            this.button_uptime.TabIndex = 30;
            this.button_uptime.Text = "inf - 0";
            this.button_uptime.UseVisualStyleBackColor = false;
            this.button_uptime.Click += new System.EventHandler(this.button_uptime_Click);
            // 
            // button_downtime
            // 
            this.button_downtime.BackColor = System.Drawing.Color.Black;
            this.button_downtime.Location = new System.Drawing.Point(562, 76);
            this.button_downtime.Name = "button_downtime";
            this.button_downtime.Size = new System.Drawing.Size(99, 25);
            this.button_downtime.TabIndex = 29;
            this.button_downtime.Text = "0 - inf";
            this.button_downtime.UseVisualStyleBackColor = false;
            this.button_downtime.Click += new System.EventHandler(this.button_downtime_Click);
            // 
            // button_upsize
            // 
            this.button_upsize.BackColor = System.Drawing.Color.Black;
            this.button_upsize.Location = new System.Drawing.Point(684, 120);
            this.button_upsize.Name = "button_upsize";
            this.button_upsize.Size = new System.Drawing.Size(99, 25);
            this.button_upsize.TabIndex = 32;
            this.button_upsize.Text = "inf - 0";
            this.button_upsize.UseVisualStyleBackColor = false;
            this.button_upsize.Click += new System.EventHandler(this.button_upsize_Click);
            // 
            // button_downsize
            // 
            this.button_downsize.BackColor = System.Drawing.Color.Black;
            this.button_downsize.Location = new System.Drawing.Point(684, 76);
            this.button_downsize.Name = "button_downsize";
            this.button_downsize.Size = new System.Drawing.Size(99, 25);
            this.button_downsize.TabIndex = 31;
            this.button_downsize.Text = "0 - inf";
            this.button_downsize.UseVisualStyleBackColor = false;
            this.button_downsize.Click += new System.EventHandler(this.button_downsize_Click);
            // 
            // textBox_minTime
            // 
            this.textBox_minTime.BackColor = System.Drawing.Color.Black;
            this.textBox_minTime.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_minTime.Location = new System.Drawing.Point(617, 162);
            this.textBox_minTime.Name = "textBox_minTime";
            this.textBox_minTime.Size = new System.Drawing.Size(44, 22);
            this.textBox_minTime.TabIndex = 33;
            // 
            // textBox_maxTime
            // 
            this.textBox_maxTime.BackColor = System.Drawing.Color.Black;
            this.textBox_maxTime.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_maxTime.Location = new System.Drawing.Point(617, 190);
            this.textBox_maxTime.Name = "textBox_maxTime";
            this.textBox_maxTime.Size = new System.Drawing.Size(44, 22);
            this.textBox_maxTime.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(562, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(562, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(684, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(684, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Min";
            // 
            // textBox_maxSize
            // 
            this.textBox_maxSize.BackColor = System.Drawing.Color.Black;
            this.textBox_maxSize.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_maxSize.Location = new System.Drawing.Point(739, 190);
            this.textBox_maxSize.Name = "textBox_maxSize";
            this.textBox_maxSize.Size = new System.Drawing.Size(44, 22);
            this.textBox_maxSize.TabIndex = 38;
            // 
            // textBox_minSize
            // 
            this.textBox_minSize.BackColor = System.Drawing.Color.Black;
            this.textBox_minSize.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_minSize.Location = new System.Drawing.Point(739, 162);
            this.textBox_minSize.Name = "textBox_minSize";
            this.textBox_minSize.Size = new System.Drawing.Size(44, 22);
            this.textBox_minSize.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(891, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Выбрать диск для записи:";
            // 
            // button_filepick
            // 
            this.button_filepick.BackColor = System.Drawing.Color.Black;
            this.button_filepick.Location = new System.Drawing.Point(832, 65);
            this.button_filepick.Name = "button_filepick";
            this.button_filepick.Size = new System.Drawing.Size(311, 40);
            this.button_filepick.TabIndex = 43;
            this.button_filepick.Text = "Выбрать файл";
            this.button_filepick.UseVisualStyleBackColor = false;
            this.button_filepick.Click += new System.EventHandler(this.button_filepick_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(836, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Размер диска:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(836, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "Кол-во свободной памяти:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(903, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "Выбрано на диске:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(843, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 31);
            this.label12.TabIndex = 54;
            this.label12.Text = "Количество:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(843, 574);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 31);
            this.label13.TabIndex = 55;
            this.label13.Text = "Длительность:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(843, 616);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 31);
            this.label14.TabIndex = 56;
            this.label14.Text = "Размер:";
            // 
            // button_SaveAll
            // 
            this.button_SaveAll.BackColor = System.Drawing.Color.Black;
            this.button_SaveAll.Location = new System.Drawing.Point(832, 249);
            this.button_SaveAll.Name = "button_SaveAll";
            this.button_SaveAll.Size = new System.Drawing.Size(311, 40);
            this.button_SaveAll.TabIndex = 57;
            this.button_SaveAll.Text = "Записать все подходящие";
            this.button_SaveAll.UseVisualStyleBackColor = false;
            this.button_SaveAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_openDiskFiles
            // 
            this.button_openDiskFiles.BackColor = System.Drawing.Color.Black;
            this.button_openDiskFiles.Location = new System.Drawing.Point(832, 308);
            this.button_openDiskFiles.Name = "button_openDiskFiles";
            this.button_openDiskFiles.Size = new System.Drawing.Size(311, 40);
            this.button_openDiskFiles.TabIndex = 58;
            this.button_openDiskFiles.Text = "Перейти к просмотру файлов диска";
            this.button_openDiskFiles.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(836, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "Выбрано:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.columnName, this.columnAuthor, this.columnCollection, this.columnGenre, this.columnTime, this.columnSize});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 381);
            this.dataGridView1.TabIndex = 59;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnAuthor
            // 
            this.columnAuthor.HeaderText = "Author";
            this.columnAuthor.Name = "columnAuthor";
            this.columnAuthor.ReadOnly = true;
            // 
            // columnCollection
            // 
            this.columnCollection.HeaderText = "Collection";
            this.columnCollection.Name = "columnCollection";
            this.columnCollection.ReadOnly = true;
            // 
            // columnGenre
            // 
            this.columnGenre.HeaderText = "Genre";
            this.columnGenre.Name = "columnGenre";
            this.columnGenre.ReadOnly = true;
            // 
            // columnTime
            // 
            this.columnTime.HeaderText = "Time";
            this.columnTime.Name = "columnTime";
            this.columnTime.ReadOnly = true;
            // 
            // columnSize
            // 
            this.columnSize.HeaderText = "Size";
            this.columnSize.Name = "columnSize";
            this.columnSize.ReadOnly = true;
            // 
            // button_ConfirmSorting
            // 
            this.button_ConfirmSorting.BackColor = System.Drawing.Color.Black;
            this.button_ConfirmSorting.Location = new System.Drawing.Point(832, 366);
            this.button_ConfirmSorting.Name = "button_ConfirmSorting";
            this.button_ConfirmSorting.Size = new System.Drawing.Size(311, 40);
            this.button_ConfirmSorting.TabIndex = 60;
            this.button_ConfirmSorting.Text = "Применить сортировку";
            this.button_ConfirmSorting.UseVisualStyleBackColor = false;
            this.button_ConfirmSorting.Click += new System.EventHandler(this.button_ConfirmSorting_Click);
            // 
            // button_backToHDD
            // 
            this.button_backToHDD.BackColor = System.Drawing.Color.Black;
            this.button_backToHDD.Location = new System.Drawing.Point(832, 427);
            this.button_backToHDD.Name = "button_backToHDD";
            this.button_backToHDD.Size = new System.Drawing.Size(311, 40);
            this.button_backToHDD.TabIndex = 61;
            this.button_backToHDD.Text = "Вернуться к просмотру файлов ХДД";
            this.button_backToHDD.UseVisualStyleBackColor = false;
            this.button_backToHDD.Click += new System.EventHandler(this.button_backToHDD_Click);
            // 
            // button_sortSize
            // 
            this.button_sortSize.BackColor = System.Drawing.Color.Black;
            this.button_sortSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sortSize.Location = new System.Drawing.Point(690, 222);
            this.button_sortSize.Name = "button_sortSize";
            this.button_sortSize.Size = new System.Drawing.Size(99, 25);
            this.button_sortSize.TabIndex = 63;
            this.button_sortSize.Text = "Sort";
            this.button_sortSize.UseVisualStyleBackColor = false;
            this.button_sortSize.Click += new System.EventHandler(this.button_sortSize_Click);
            // 
            // button_sortTime
            // 
            this.button_sortTime.BackColor = System.Drawing.Color.Black;
            this.button_sortTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sortTime.Location = new System.Drawing.Point(557, 222);
            this.button_sortTime.Name = "button_sortTime";
            this.button_sortTime.Size = new System.Drawing.Size(99, 25);
            this.button_sortTime.TabIndex = 62;
            this.button_sortTime.Text = "Sort";
            this.button_sortTime.UseVisualStyleBackColor = false;
            this.button_sortTime.Click += new System.EventHandler(this.button_sortTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1186, 663);
            this.Controls.Add(this.button_sortSize);
            this.Controls.Add(this.button_sortTime);
            this.Controls.Add(this.button_backToHDD);
            this.Controls.Add(this.button_ConfirmSorting);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_openDiskFiles);
            this.Controls.Add(this.button_SaveAll);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_filepick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_maxSize);
            this.Controls.Add(this.textBox_minSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_maxTime);
            this.Controls.Add(this.textBox_minTime);
            this.Controls.Add(this.button_upsize);
            this.Controls.Add(this.button_downsize);
            this.Controls.Add(this.button_uptime);
            this.Controls.Add(this.button_downtime);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.button_findGenre);
            this.Controls.Add(this.button_ZA_genre);
            this.Controls.Add(this.button_AZ_genre);
            this.Controls.Add(this.textBox_collection);
            this.Controls.Add(this.button_findCollection);
            this.Controls.Add(this.button_ZA_collection);
            this.Controls.Add(this.button_AZ_collection);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.button_findAuthor);
            this.Controls.Add(this.button_ZA_author);
            this.Controls.Add(this.button_AZ_author);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_findName);
            this.Controls.Add(this.button_ZA_name);
            this.Controls.Add(this.button_AZ_name);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_openDiskFiles;

        private System.Windows.Forms.Button button_sortTime;

        private System.Windows.Forms.Button button_sortSize;

        private System.Windows.Forms.Button button_findGenre;

        private System.Windows.Forms.Button button_findCollection;

        private System.Windows.Forms.Button button_findAuthor;

        private System.Windows.Forms.Button button_SaveAll;

        private System.Windows.Forms.Button button_backToHDD;

        private System.Windows.Forms.Button button_ConfirmSorting;

        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSize;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_filepick;
        private System.Windows.Forms.Label label_chosenFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_AZ_name;
        private System.Windows.Forms.Button button_ZA_name;
        private System.Windows.Forms.Button button_findName;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ZA_author;
        private System.Windows.Forms.Button button_AZ_author;
        private System.Windows.Forms.TextBox textBox_collection;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_ZA_collection;
        private System.Windows.Forms.Button button_AZ_collection;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button_ZA_genre;
        private System.Windows.Forms.Button button_AZ_genre;
        private System.Windows.Forms.Button button_uptime;
        private System.Windows.Forms.Button button_downtime;
        private System.Windows.Forms.Button button_upsize;
        private System.Windows.Forms.Button button_downsize;
        private System.Windows.Forms.TextBox textBox_minTime;
        private System.Windows.Forms.TextBox textBox_maxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maxSize;
        private System.Windows.Forms.TextBox textBox_minSize;

        #endregion
    }
}

