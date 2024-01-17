namespace FileSearchLauncher
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullFindRadioButton = new System.Windows.Forms.RadioButton();
            this.subFindRadioButton = new System.Windows.Forms.RadioButton();
            this.wordCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.searchWordTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.filePathComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullFindRadioButton);
            this.groupBox1.Controls.Add(this.subFindRadioButton);
            this.groupBox1.Controls.Add(this.wordCaseCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.searchWordTextBox);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.filePathComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // fullFindRadioButton
            // 
            this.fullFindRadioButton.AutoSize = true;
            this.fullFindRadioButton.Location = new System.Drawing.Point(6, 104);
            this.fullFindRadioButton.Name = "fullFindRadioButton";
            this.fullFindRadioButton.Size = new System.Drawing.Size(144, 17);
            this.fullFindRadioButton.TabIndex = 9;
            this.fullFindRadioButton.TabStop = true;
            this.fullFindRadioButton.Text = "Полнотекстовый поиск";
            this.fullFindRadioButton.UseVisualStyleBackColor = true;
            // 
            // subFindRadioButton
            // 
            this.subFindRadioButton.AutoSize = true;
            this.subFindRadioButton.Location = new System.Drawing.Point(247, 104);
            this.subFindRadioButton.Name = "subFindRadioButton";
            this.subFindRadioButton.Size = new System.Drawing.Size(128, 17);
            this.subFindRadioButton.TabIndex = 8;
            this.subFindRadioButton.TabStop = true;
            this.subFindRadioButton.Text = "Поиск по подстроке";
            this.subFindRadioButton.UseVisualStyleBackColor = true;
            // 
            // wordCaseCheckBox
            // 
            this.wordCaseCheckBox.AutoSize = true;
            this.wordCaseCheckBox.Location = new System.Drawing.Point(6, 137);
            this.wordCaseCheckBox.Name = "wordCaseCheckBox";
            this.wordCaseCheckBox.Size = new System.Drawing.Size(141, 17);
            this.wordCaseCheckBox.TabIndex = 6;
            this.wordCaseCheckBox.Text = "Игнорировать регистр";
            this.wordCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите искомое слово";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите путь к файлу";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(242, 178);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(133, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // searchWordTextBox
            // 
            this.searchWordTextBox.Location = new System.Drawing.Point(6, 78);
            this.searchWordTextBox.Name = "searchWordTextBox";
            this.searchWordTextBox.Size = new System.Drawing.Size(369, 20);
            this.searchWordTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 177);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // filePathComboBox
            // 
            this.filePathComboBox.FormattingEnabled = true;
            this.filePathComboBox.Location = new System.Drawing.Point(6, 32);
            this.filePathComboBox.Name = "filePathComboBox";
            this.filePathComboBox.Size = new System.Drawing.Size(369, 21);
            this.filePathComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 224);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(430, 263);
            this.MinimumSize = new System.Drawing.Size(430, 263);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счётчик повторений слов в файле";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchWordTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox filePathComboBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox wordCaseCheckBox;
        private System.Windows.Forms.RadioButton fullFindRadioButton;
        private System.Windows.Forms.RadioButton subFindRadioButton;
    }
}

