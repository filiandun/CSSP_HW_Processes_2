using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounterExecutor
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1(string[] args)
        {
            InitializeComponent();

            this.GetCount(args);
        }

        private async void GetCount(string[] args)
        {
            if (args.Length == 4)
            {
                try
                {
                    string pathToFile = args[0];
                    string searchWord = args[1];

                    bool findOption = bool.Parse(args[2]);
                    bool wordCaseOption = bool.Parse(args[3]);

                    string[] lines = File.ReadAllLines(pathToFile);

                    if (findOption)
                    {
                        await this.SubstringSearch(lines, searchWord, wordCaseOption ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                    }
                    else if (!findOption)
                    {
                        await this.FullStringSearch(lines, searchWord, wordCaseOption ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(fe.Message, "Ошибка, связанная с преобразованием аргументов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.wordCountLabel.Text = "Что-то сломалось.";
            }
        }

        private async Task SubstringSearch(string[] lines, string searchWord, StringComparison stringComparison)
        {
            int count = 0;

            foreach (string line in lines)
            {
                int index = line.IndexOf(searchWord, stringComparison);

                while (index != -1)
                {
                    count++;
                    this.wordCountLabel.Text = $"Совпадений найдено: {count}";
                    await Task.Delay(this.random.Next(50, 500));

                    index = line.IndexOf(searchWord, index + searchWord.Length, stringComparison);
                }
            }

            this.wordCountLabel.Text = $"Совпадений найдено: {count}";
        }

        private async Task FullStringSearch(string[] lines, string searchWord, StringComparison stringComparison)
        {
            int count = 0;

            if (stringComparison == StringComparison.Ordinal)
            {
                foreach (string line in lines)
                {
                    if (line.Contains(searchWord))
                    {
                        count++;
                        this.wordCountLabel.Text = $"Совпадений найдено: {count}";
                        await Task.Delay(this.random.Next(50, 500));
                    }
                }
            }
            else if (stringComparison == StringComparison.OrdinalIgnoreCase)
            {
                foreach (string line in lines)
                {
                    if (line.ToLower().Contains(searchWord.ToLower()))
                    {
                        count++;
                        this.wordCountLabel.Text = $"Совпадений найдено: {count}";
                        await Task.Delay(this.random.Next(50, 500));
                    }
                }
            }

            this.wordCountLabel.Text = $"Совпадений найдено: {count}";
        }
    }
}
