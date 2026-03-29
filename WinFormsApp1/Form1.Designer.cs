namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxStudent = new GroupBox();
            Класс = new TableLayoutPanel();
            sdas = new Label();
            textBoxSurname = new TextBox();
            fadf = new Label();
            textBoxName = new TextBox();
            asdad = new Label();
            textBoxMiddle = new TextBox();
            dasdsa = new Label();
            comboBoxClass = new ComboBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelCount = new Label();
            radioButtonHard = new RadioButton();
            radioButtonEasy = new RadioButton();
            numericUpDownCount = new NumericUpDown();
            buttonStart = new Button();
            groupBoxStudent.SuspendLayout();
            Класс.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(Класс);
            groupBoxStudent.Location = new Point(28, 23);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Size = new Size(400, 170);
            groupBoxStudent.TabIndex = 0;
            groupBoxStudent.TabStop = false;
            groupBoxStudent.Text = "Ученик";
            // 
            // Класс
            // 
            Класс.ColumnCount = 2;
            Класс.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.23858F));
            Класс.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.76142F));
            Класс.Controls.Add(sdas, 0, 0);
            Класс.Controls.Add(textBoxSurname, 1, 0);
            Класс.Controls.Add(fadf, 0, 1);
            Класс.Controls.Add(textBoxName, 1, 1);
            Класс.Controls.Add(asdad, 0, 2);
            Класс.Controls.Add(textBoxMiddle, 1, 2);
            Класс.Controls.Add(dasdsa, 0, 3);
            Класс.Controls.Add(comboBoxClass, 1, 3);
            Класс.Dock = DockStyle.Fill;
            Класс.Location = new Point(3, 19);
            Класс.Name = "Класс";
            Класс.RowCount = 4;
            Класс.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Класс.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Класс.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Класс.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Класс.Size = new Size(394, 148);
            Класс.TabIndex = 0;
            // 
            // sdas
            // 
            sdas.AutoSize = true;
            sdas.Location = new Point(3, 0);
            sdas.Name = "sdas";
            sdas.Size = new Size(58, 15);
            sdas.TabIndex = 0;
            sdas.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Dock = DockStyle.Fill;
            textBoxSurname.Location = new Point(197, 3);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(194, 23);
            textBoxSurname.TabIndex = 1;
            // 
            // fadf
            // 
            fadf.AutoSize = true;
            fadf.Location = new Point(3, 37);
            fadf.Name = "fadf";
            fadf.Size = new Size(31, 15);
            fadf.TabIndex = 2;
            fadf.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(197, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(194, 23);
            textBoxName.TabIndex = 3;
            // 
            // asdad
            // 
            asdad.AutoSize = true;
            asdad.Location = new Point(3, 74);
            asdad.Name = "asdad";
            asdad.Size = new Size(58, 15);
            asdad.TabIndex = 4;
            asdad.Text = "Отчество";
            // 
            // textBoxMiddle
            // 
            textBoxMiddle.Location = new Point(197, 77);
            textBoxMiddle.Name = "textBoxMiddle";
            textBoxMiddle.Size = new Size(192, 23);
            textBoxMiddle.TabIndex = 5;
            // 
            // dasdsa
            // 
            dasdsa.AutoSize = true;
            dasdsa.Location = new Point(3, 111);
            dasdsa.Name = "dasdsa";
            dasdsa.Size = new Size(39, 15);
            dasdsa.TabIndex = 6;
            dasdsa.Text = "Класс";
            // 
            // comboBoxClass
            // 
            comboBoxClass.Dock = DockStyle.Fill;
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" });
            comboBoxClass.Location = new Point(197, 114);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(194, 23);
            comboBoxClass.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(31, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 103);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "i";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.6804123F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.3195877F));
            tableLayoutPanel1.Controls.Add(labelCount, 0, 0);
            tableLayoutPanel1.Controls.Add(radioButtonHard, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButtonEasy, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownCount, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(388, 81);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(3, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(46, 15);
            labelCount.TabIndex = 0;
            labelCount.Text = "Кол-во";
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Location = new Point(3, 43);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(70, 19);
            radioButtonHard.TabIndex = 2;
            radioButtonHard.TabStop = true;
            radioButtonHard.Text = "Сложно";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Location = new Point(188, 43);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(66, 19);
            radioButtonEasy.TabIndex = 3;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Просто";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(188, 3);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(196, 23);
            numericUpDownCount.TabIndex = 1;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(28, 299);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(386, 43);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Создать задание";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxStudent);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            groupBoxStudent.ResumeLayout(false);
            Класс.ResumeLayout(false);
            Класс.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxStudent;
        private TableLayoutPanel Класс;
        private Label sdas;
        private TextBox textBoxSurname;
        private Label fadf;
        private TextBox textBoxName;
        private Label asdad;
        private TextBox textBoxMiddle;
        private Label dasdsa;
        private ComboBox comboBoxClass;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelCount;
        private NumericUpDown numericUpDownCount;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonEasy;
        private Button buttonStart;
    }
}
