﻿
using System.Drawing;

namespace Task3
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
            this.title = new System.Windows.Forms.Label();
            this.groupBox_name = new System.Windows.Forms.GroupBox();
            this.groupBox_author = new System.Windows.Forms.GroupBox();
            this.groupBox_genre = new System.Windows.Forms.GroupBox();
            this.groupBox_collection = new System.Windows.Forms.GroupBox();
            this.groupBox_size = new System.Windows.Forms.GroupBox();
            this.groupBox_timing = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.button_AZ_name = new System.Windows.Forms.Button();
            this.button_ZA_name = new System.Windows.Forms.Button();
            this.button_findName = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ZA_author = new System.Windows.Forms.Button();
            this.button_AZ_author = new System.Windows.Forms.Button();
            this.textBox_collection = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_ZA_collection = new System.Windows.Forms.Button();
            this.button_AZ_collection = new System.Windows.Forms.Button();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(297, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(308, 21);
            this.title.TabIndex = 0;
            this.title.Text = "Поиск по основному полю:";
            // 
            // groupBox_name
            // 
            this.groupBox_name.Location = new System.Drawing.Point(28, 387);
            this.groupBox_name.Name = "groupBox_name";
            this.groupBox_name.Size = new System.Drawing.Size(99, 252);
            this.groupBox_name.TabIndex = 1;
            this.groupBox_name.TabStop = false;
            this.groupBox_name.Text = "groupBox1";
            // 
            // groupBox_author
            // 
            this.groupBox_author.Location = new System.Drawing.Point(161, 387);
            this.groupBox_author.Name = "groupBox_author";
            this.groupBox_author.Size = new System.Drawing.Size(99, 252);
            this.groupBox_author.TabIndex = 2;
            this.groupBox_author.TabStop = false;
            this.groupBox_author.Text = "groupBox2";
            // 
            // groupBox_genre
            // 
            this.groupBox_genre.BackColor = System.Drawing.Color.Black;
            this.groupBox_genre.Location = new System.Drawing.Point(428, 387);
            this.groupBox_genre.Name = "groupBox_genre";
            this.groupBox_genre.Size = new System.Drawing.Size(99, 252);
            this.groupBox_genre.TabIndex = 4;
            this.groupBox_genre.TabStop = false;
            this.groupBox_genre.Text = "groupBox3";
            // 
            // groupBox_collection
            // 
            this.groupBox_collection.Location = new System.Drawing.Point(295, 387);
            this.groupBox_collection.Name = "groupBox_collection";
            this.groupBox_collection.Size = new System.Drawing.Size(99, 252);
            this.groupBox_collection.TabIndex = 3;
            this.groupBox_collection.TabStop = false;
            this.groupBox_collection.Text = "groupBox4";
            // 
            // groupBox_size
            // 
            this.groupBox_size.Location = new System.Drawing.Point(675, 387);
            this.groupBox_size.Name = "groupBox_size";
            this.groupBox_size.Size = new System.Drawing.Size(99, 252);
            this.groupBox_size.TabIndex = 6;
            this.groupBox_size.TabStop = false;
            this.groupBox_size.Text = "groupBox5";
            // 
            // groupBox_timing
            // 
            this.groupBox_timing.Location = new System.Drawing.Point(548, 387);
            this.groupBox_timing.Name = "groupBox_timing";
            this.groupBox_timing.Size = new System.Drawing.Size(99, 252);
            this.groupBox_timing.TabIndex = 5;
            this.groupBox_timing.TabStop = false;
            this.groupBox_timing.Text = "groupBox6";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(37, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(684, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(557, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(437, 37);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(104, 24);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(304, 37);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(104, 24);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(170, 37);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(104, 24);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
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
            // 
            // button_findName
            // 
            this.button_findName.BackColor = System.Drawing.Color.Black;
            this.button_findName.Location = new System.Drawing.Point(37, 222);
            this.button_findName.Name = "button_findName";
            this.button_findName.Size = new System.Drawing.Size(99, 25);
            this.button_findName.TabIndex = 15;
            this.button_findName.Text = "Find";
            this.button_findName.UseVisualStyleBackColor = false;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(37, 173);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(99, 22);
            this.textBox_name.TabIndex = 16;
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(170, 173);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(99, 22);
            this.textBox_author.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(170, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
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
            // 
            // textBox_collection
            // 
            this.textBox_collection.Location = new System.Drawing.Point(304, 173);
            this.textBox_collection.Name = "textBox_collection";
            this.textBox_collection.Size = new System.Drawing.Size(99, 22);
            this.textBox_collection.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(304, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 25);
            this.button4.TabIndex = 23;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = false;
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
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(437, 173);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(99, 22);
            this.textBox_genre.TabIndex = 28;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(437, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 25);
            this.button7.TabIndex = 27;
            this.button7.Text = "Find";
            this.button7.UseVisualStyleBackColor = false;
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
            // 
            // textBox_minTime
            // 
            this.textBox_minTime.Location = new System.Drawing.Point(617, 173);
            this.textBox_minTime.Name = "textBox_minTime";
            this.textBox_minTime.Size = new System.Drawing.Size(44, 22);
            this.textBox_minTime.TabIndex = 33;
            // 
            // textBox_maxTime
            // 
            this.textBox_maxTime.Location = new System.Drawing.Point(617, 222);
            this.textBox_maxTime.Name = "textBox_maxTime";
            this.textBox_maxTime.Size = new System.Drawing.Size(44, 22);
            this.textBox_maxTime.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(562, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(562, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(684, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(684, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Min";
            // 
            // textBox_maxSize
            // 
            this.textBox_maxSize.Location = new System.Drawing.Point(739, 222);
            this.textBox_maxSize.Name = "textBox_maxSize";
            this.textBox_maxSize.Size = new System.Drawing.Size(44, 22);
            this.textBox_maxSize.TabIndex = 38;
            // 
            // textBox_minSize
            // 
            this.textBox_minSize.Location = new System.Drawing.Point(739, 173);
            this.textBox_minSize.Name = "textBox_minSize";
            this.textBox_minSize.Size = new System.Drawing.Size(44, 22);
            this.textBox_minSize.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(891, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Выбрать диск для записи:";
            // 
            // button_filepick
            // 
            this.button_filepick.BackColor = System.Drawing.Color.Black;
            this.button_filepick.Location = new System.Drawing.Point(832, 50);
            this.button_filepick.Name = "button_filepick";
            this.button_filepick.Size = new System.Drawing.Size(311, 40);
            this.button_filepick.TabIndex = 43;
            this.button_filepick.Text = "Выбрать файл";
            this.button_filepick.UseVisualStyleBackColor = false;
            this.button_filepick.Click += new System.EventHandler(this.button_filepick_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(836, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Размер диска:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(836, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "Кол-во свободной памяти:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(903, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "Выбранные композиции:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(843, 515);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 31);
            this.label12.TabIndex = 54;
            this.label12.Text = "Количество:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(843, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 31);
            this.label13.TabIndex = 55;
            this.label13.Text = "Длительность:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(843, 601);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 31);
            this.label14.TabIndex = 56;
            this.label14.Text = "Размер:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(832, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 40);
            this.button2.TabIndex = 57;
            this.button2.Text = "Записать все подходящие";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(832, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 40);
            this.button3.TabIndex = 58;
            this.button3.Text = "Записать только выбранные композиции";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(836, 112);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.columnName, this.columnAuthor, this.columnCollection, this.columnGenre, this.columnTime, this.columnSize});
            this.dataGridView1.Location = new System.Drawing.Point(12, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 90);
            this.dataGridView1.TabIndex = 59;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnAuthor
            // 
            this.columnAuthor.HeaderText = "Author";
            this.columnAuthor.Name = "columnAuthor";
            // 
            // columnCollection
            // 
            this.columnCollection.HeaderText = "Collection";
            this.columnCollection.Name = "columnCollection";
            // 
            // columnGenre
            // 
            this.columnGenre.HeaderText = "Genre";
            this.columnGenre.Name = "columnGenre";
            // 
            // columnTime
            // 
            this.columnTime.HeaderText = "Time";
            this.columnTime.Name = "columnTime";
            // 
            // columnSize
            // 
            this.columnSize.HeaderText = "Size";
            this.columnSize.Name = "columnSize";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1186, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_ZA_genre);
            this.Controls.Add(this.button_AZ_genre);
            this.Controls.Add(this.textBox_collection);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_ZA_collection);
            this.Controls.Add(this.button_AZ_collection);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_ZA_author);
            this.Controls.Add(this.button_AZ_author);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_findName);
            this.Controls.Add(this.button_ZA_name);
            this.Controls.Add(this.button_AZ_name);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox_size);
            this.Controls.Add(this.groupBox_genre);
            this.Controls.Add(this.groupBox_timing);
            this.Controls.Add(this.groupBox_author);
            this.Controls.Add(this.groupBox_collection);
            this.Controls.Add(this.groupBox_name);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
        private System.Windows.Forms.GroupBox groupBox_name;
        private System.Windows.Forms.GroupBox groupBox_author;
        private System.Windows.Forms.GroupBox groupBox_genre;
        private System.Windows.Forms.GroupBox groupBox_collection;
        private System.Windows.Forms.GroupBox groupBox_size;
        private System.Windows.Forms.GroupBox groupBox_timing;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
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

