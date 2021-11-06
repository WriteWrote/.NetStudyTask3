using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task3.Comparers;

namespace Task3.Forms
{
    public partial class Form1 : Form
    {
        private readonly String filename = "D:\\XXX\\WorkingFiles\\C#_2021\\Task3\\Task3\\Recources\\DiskC.txt";
        private IDisk _disk;

        private IDisk _temp;

        private Convertor _convertor;

        public Form1()
        {
            InitializeComponent();

            _disk = new CD("emptyCD");
            _temp = new CD("temporarySorting");
            _convertor = new Convertor();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _temp = _convertor.ReadFromFileToCdDisk(filename);
            display(_temp);
        }

        private void displayTempParams()
        {
            label12.Text = "Количество: " + _temp.getRecordedFiles().Count().ToString();
            int time = 0;
            double size = 0;
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                time += file.GetTime();
                size += file.GetSize();
            }

            label13.Text = "Длительность: " + time.ToString();
            label14.Text = "Размер: " + size.ToString();
        }

        private void display(IDisk disk)
        {
            dataGridView1.Rows.Clear();
            foreach (MusicFile file in disk.getRecordedFiles())
            {
                dataGridView1.Rows.Add(file.ToDataGridRow());
            }

            displayTempParams();
        }

        private void button_filepick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            _disk = _convertor.ReadFromFileToCdDisk(filename);

            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..." + _disk.getName();
            label7.Text = "Размер диска: " + _disk.getCapacity();
            label8.Text = "Кол-во свободной памяти: " + _disk.getEmptySpace();

            DialogResult result = MessageBox.Show(
                "Open file for editing?",
                "Editing or recording",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                _temp = _disk;
                display(_temp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _convertor.WriteToFileFromDisk(_temp, _disk);

            DialogResult result = MessageBox.Show(
                "Показать содержимое?",
                "Файл сохранен",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                display(_disk);
            }
            else
                display(_temp);
        }

        private void button_ConfirmSorting_Click(object sender, EventArgs e)
        {
            //ToDo: адаптировать к сортировке компьютерного ХДД и съемного диска
            _disk = new CD(_disk.getFullName(), _disk.getCapacity(), _temp.getRecordedFiles());
            _temp = new CD("temporarySorting");
            display(_disk);
        }

        private void button_backToHDD_Click(object sender, EventArgs e)
        {
            //ToDO: make possible to redact and see the content of new disks along the computer HDD
            _temp = _convertor.ReadFromFileToCdDisk(filename);
            display(_temp);
        }

        private void button_AZ_name_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new AZ_NameComparer());
            ;
            display(_temp);
        }

        private void button_ZA_name_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new ZA_NameComparer());
            display(_temp);
        }

        private void button_downsize_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new DecreasingSizeComparer());
            display(_temp);
        }

        private void button_upsize_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new IncreasingSizeComparer());
            display(_temp);
        }

        private void button_downtime_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new DecreasingTimeComparer());
            display(_temp);
        }

        private void button_uptime_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new IncreasingTimeComparer());
            display(_temp);
        }

        private void button_AZ_author_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new AZ_AuthorComparer());
            display(_temp);
        }

        private void button_ZA_author_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new ZA_AuthorComparer());
            display(_temp);
        }

        private void button_AZ_genre_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new AZ_GenreComparer());
            display(_temp);
        }

        private void button_ZA_genre_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new ZA_GenreComparer());
            display(_temp);
        }

        private void button_AZ_collection_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new AZ_CollectionComparer());
            display(_temp);
        }

        private void button_ZA_collection_Click(object sender, EventArgs e)
        {
            _temp.getRecordedFiles().Sort(new ZA_CollectionComparer());
            display(_temp);
        }

        private void button_findName_Click(object sender, EventArgs e)
        {
            string substring = textBox_name.Text.ToLower();

            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetName().ToLower().Contains(substring))
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string substring = textBox_author.Text.ToLower();

            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetAuthor().ToLower().Contains(substring))
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }

        private void button_findCollection_Click(object sender, EventArgs e)
        {
            string substring = textBox_collection.Text.ToLower();

            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetCollection().ToLower().Contains(substring))
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }

        private void button_findGenre_Click(object sender, EventArgs e)
        {
            string substring = textBox_genre.Text.ToLower();

            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetGenre().ToLower().Contains(substring))
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }

        private void button_sortTime_Click(object sender, EventArgs e)
        {
            int maxTime = Int32.MaxValue;
            if (!"".Equals(textBox_maxTime.Text))
                maxTime = Convert.ToInt32(textBox_maxTime.Text);
            int minTime = -1;
            if (!"".Equals(textBox_minTime.Text))
                minTime = Convert.ToInt32(textBox_minTime.Text);


            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetTime() >= minTime && file.GetTime() <= maxTime)
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }

        private void button_sortSize_Click(object sender, EventArgs e)
        {
            int maxSize = Int32.MaxValue;
            if (!"".Equals(textBox_maxTime.Text))
                maxSize = Convert.ToInt32(textBox_maxTime.Text);
            int minSize = -1;
            if (!"".Equals(textBox_minTime.Text))
                minSize = Convert.ToInt32(textBox_minTime.Text);


            List<MusicFile> pickedFiles = new List<MusicFile>();
            foreach (MusicFile file in _temp.getRecordedFiles())
            {
                if (file.GetSize() >= minSize && file.GetSize() <= maxSize)
                    pickedFiles.Add(file);
            }

            _temp.getRecordedFiles().Clear();
            _temp.RecordFiles(pickedFiles);
            display(_temp);
        }
    }
}