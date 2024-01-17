using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;
using System.Diagnostics;

/*
 * ЗАДАНИЕ 4
 * Разработайте приложение, которое умеет запускать дочерний процесс и передавать ему аргументы командной строки. 
 * В качестве аргументов должны быть путь к файлу и слово для поиска. Например, аргументы: 
 *  ■ E:\someFolder; 
 *  ■ bicycle. 
 * Дочерний процесс должен отобразить количество раз, сколько слово bicycle встречается в файле
 */

namespace FileSearchLauncher
{
    public partial class Form1 : Form
    {
        private Process process;

        public Form1()
        {
            InitializeComponent();

            this.filePathComboBox.Items.Add("D:\\IT\\Repositories CSSP\\CSSP_HW_Processes_2\\Велосипед.txt");
            this.fullFindRadioButton.Checked = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string filePath = this.filePathComboBox.Text;
            string searchWord = this.searchWordTextBox.Text;

            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(searchWord))
            {
                MessageBox.Show("Стоит заполнить все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string mainPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
                string daughterPath = Path.Combine(mainPath, "WordCounterExecutor", "bin", "Debug", "WordCounterExecutor.exe");

                this.process = new Process();
                this.process.StartInfo.FileName = daughterPath;
                this.process.StartInfo.Arguments = this.GetArguments();

                this.process.Start();
            }
            catch (Win32Exception w32e)
            {
                MessageBox.Show(w32e.Message, "Ошибка, связанная с запуском дочернего процесса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Data, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetArguments()
        {
            return $"\"{this.filePathComboBox.Text}\" \"{this.searchWordTextBox.Text}\" {(this.subFindRadioButton.Checked ? "true" : "false")} {(this.wordCaseCheckBox.Checked ? "true" : "false")}";
        }
    }
}
