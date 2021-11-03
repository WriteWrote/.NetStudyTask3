using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button_filepick_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            // ToDo: make a better way to squeeze the name of the file
            label6.Text = "Выбрано: " + filename.Substring(0, 3) + "..."
                + filename.Substring(filename.Length-10, 6);

            String[] arr = fileText.Split('\n');
            
            String sizeOfDisk = fileText.Split('\n')[0].Trim().Split(' ')[0];
            String takenSpace = fileText.Split('\n')[0].Trim().Split(' ')[1];
            
            label7.Text = "Размер диска: " + sizeOfDisk;
            label8.Text = "Кол-во свободной памяти: " + (Convert.ToDouble(sizeOfDisk) - Convert.ToDouble(takenSpace)).ToString();
            
            // ToDo: insert converting to IDisk instance
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            //System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}