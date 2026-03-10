namespace PR_2_Arrays
{
    partial class PR_2_Arrays
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            lblTask1Result = new Label();
            btnTask1Calculate = new Button();
            txtTask1Input = new TextBox();
            lblTask1Prompt = new Label();
            tabPage2 = new TabPage();
            lblTask2Array = new Label();
            lblTask2Result = new Label();
            btnTask2Generate = new Button();
            txtTask2Size = new TextBox();
            lblTask2Prompt = new Label();
            tabPage3 = new TabPage();
            lblTask3Result = new Label();
            btnTask3Calculate = new Button();
            lblTask3Array = new Label();
            tabPage4 = new TabPage();
            lblTask4Result = new Label();
            btnTask4Reverse = new Button();
            txtTask4Input = new TextBox();
            lblTask4Prompt = new Label();
            tabPage5 = new TabPage();
            lblTask5Result = new Label();
            btnTask5Shift = new Button();
            txtTask5Input = new TextBox();
            lblTask5Prompt = new Label();
            tabPage6 = new TabPage();
            lblTask6Result = new Label();
            btnTask6Count = new Button();
            txtTask6Input = new TextBox();
            lblTask6Prompt = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Controls.Add(tabPage6);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(884, 511);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTask1Result);
            tabPage1.Controls.Add(btnTask1Calculate);
            tabPage1.Controls.Add(txtTask1Input);
            tabPage1.Controls.Add(lblTask1Prompt);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(876, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задача 1: Сумма элементов";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblTask1Result
            // 
            lblTask1Result.AutoSize = true;
            lblTask1Result.Location = new Point(20, 140);
            lblTask1Result.Name = "lblTask1Result";
            lblTask1Result.Size = new Size(0, 20);
            lblTask1Result.TabIndex = 3;
            // 
            // btnTask1Calculate
            // 
            btnTask1Calculate.Location = new Point(20, 90);
            btnTask1Calculate.Name = "btnTask1Calculate";
            btnTask1Calculate.Size = new Size(150, 35);
            btnTask1Calculate.TabIndex = 2;
            btnTask1Calculate.Text = "Вычислить сумму";
            btnTask1Calculate.UseVisualStyleBackColor = true;
            btnTask1Calculate.Click += btnTask1Calculate_Click;
            // 
            // txtTask1Input
            // 
            txtTask1Input.Location = new Point(20, 50);
            txtTask1Input.Name = "txtTask1Input";
            txtTask1Input.Size = new Size(400, 27);
            txtTask1Input.TabIndex = 1;
            // 
            // lblTask1Prompt
            // 
            lblTask1Prompt.AutoSize = true;
            lblTask1Prompt.Location = new Point(20, 20);
            lblTask1Prompt.Name = "lblTask1Prompt";
            lblTask1Prompt.Size = new Size(279, 20);
            lblTask1Prompt.TabIndex = 4;
            lblTask1Prompt.Text = "Введите 10 целых чисел через пробел:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblTask2Array);
            tabPage2.Controls.Add(lblTask2Result);
            tabPage2.Controls.Add(btnTask2Generate);
            tabPage2.Controls.Add(txtTask2Size);
            tabPage2.Controls.Add(lblTask2Prompt);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(876, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задача 2: Макс/Мин";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTask2Array
            // 
            lblTask2Array.AutoSize = true;
            lblTask2Array.Location = new Point(20, 140);
            lblTask2Array.Name = "lblTask2Array";
            lblTask2Array.Size = new Size(0, 20);
            lblTask2Array.TabIndex = 4;
            // 
            // lblTask2Result
            // 
            lblTask2Result.AutoSize = true;
            lblTask2Result.Location = new Point(20, 180);
            lblTask2Result.Name = "lblTask2Result";
            lblTask2Result.Size = new Size(0, 20);
            lblTask2Result.TabIndex = 3;
            // 
            // btnTask2Generate
            // 
            btnTask2Generate.Location = new Point(20, 90);
            btnTask2Generate.Name = "btnTask2Generate";
            btnTask2Generate.Size = new Size(150, 35);
            btnTask2Generate.TabIndex = 2;
            btnTask2Generate.Text = "Сгенерировать";
            btnTask2Generate.UseVisualStyleBackColor = true;
            btnTask2Generate.Click += btnTask2Generate_Click;
            // 
            // txtTask2Size
            // 
            txtTask2Size.Location = new Point(20, 50);
            txtTask2Size.Name = "txtTask2Size";
            txtTask2Size.Size = new Size(200, 27);
            txtTask2Size.TabIndex = 1;
            // 
            // lblTask2Prompt
            // 
            lblTask2Prompt.AutoSize = true;
            lblTask2Prompt.Location = new Point(20, 20);
            lblTask2Prompt.Name = "lblTask2Prompt";
            lblTask2Prompt.Size = new Size(201, 20);
            lblTask2Prompt.TabIndex = 5;
            lblTask2Prompt.Text = "Введите размер массива N:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblTask3Result);
            tabPage3.Controls.Add(btnTask3Calculate);
            tabPage3.Controls.Add(lblTask3Array);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(876, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задача 3: Четные/Нечетные";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTask3Result
            // 
            lblTask3Result.AutoSize = true;
            lblTask3Result.Location = new Point(20, 110);
            lblTask3Result.Name = "lblTask3Result";
            lblTask3Result.Size = new Size(0, 20);
            lblTask3Result.TabIndex = 2;
            // 
            // btnTask3Calculate
            // 
            btnTask3Calculate.Location = new Point(20, 60);
            btnTask3Calculate.Name = "btnTask3Calculate";
            btnTask3Calculate.Size = new Size(200, 35);
            btnTask3Calculate.TabIndex = 1;
            btnTask3Calculate.Text = "Подсчитать";
            btnTask3Calculate.UseVisualStyleBackColor = true;
            btnTask3Calculate.Click += btnTask3Calculate_Click;
            // 
            // lblTask3Array
            // 
            lblTask3Array.AutoSize = true;
            lblTask3Array.Location = new Point(20, 20);
            lblTask3Array.Name = "lblTask3Array";
            lblTask3Array.Size = new Size(0, 20);
            lblTask3Array.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblTask4Result);
            tabPage4.Controls.Add(btnTask4Reverse);
            tabPage4.Controls.Add(txtTask4Input);
            tabPage4.Controls.Add(lblTask4Prompt);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(876, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Задача 4: Реверс массива";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblTask4Result
            // 
            lblTask4Result.AutoSize = true;
            lblTask4Result.Location = new Point(20, 140);
            lblTask4Result.Name = "lblTask4Result";
            lblTask4Result.Size = new Size(0, 20);
            lblTask4Result.TabIndex = 3;
            // 
            // btnTask4Reverse
            // 
            btnTask4Reverse.Location = new Point(20, 90);
            btnTask4Reverse.Name = "btnTask4Reverse";
            btnTask4Reverse.Size = new Size(150, 35);
            btnTask4Reverse.TabIndex = 2;
            btnTask4Reverse.Text = "Реверс";
            btnTask4Reverse.UseVisualStyleBackColor = true;
            btnTask4Reverse.Click += btnTask4Reverse_Click;
            // 
            // txtTask4Input
            // 
            txtTask4Input.Location = new Point(20, 50);
            txtTask4Input.Name = "txtTask4Input";
            txtTask4Input.Size = new Size(300, 27);
            txtTask4Input.TabIndex = 1;
            // 
            // lblTask4Prompt
            // 
            lblTask4Prompt.AutoSize = true;
            lblTask4Prompt.Location = new Point(20, 20);
            lblTask4Prompt.Name = "lblTask4Prompt";
            lblTask4Prompt.Size = new Size(224, 20);
            lblTask4Prompt.TabIndex = 4;
            lblTask4Prompt.Text = "Введите 5 чисел через пробел:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lblTask5Result);
            tabPage5.Controls.Add(btnTask5Shift);
            tabPage5.Controls.Add(txtTask5Input);
            tabPage5.Controls.Add(lblTask5Prompt);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(876, 478);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Задача 5: Сдвиг вправо";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblTask5Result
            // 
            lblTask5Result.AutoSize = true;
            lblTask5Result.Location = new Point(20, 140);
            lblTask5Result.Name = "lblTask5Result";
            lblTask5Result.Size = new Size(0, 20);
            lblTask5Result.TabIndex = 3;
            // 
            // btnTask5Shift
            // 
            btnTask5Shift.Location = new Point(20, 90);
            btnTask5Shift.Name = "btnTask5Shift";
            btnTask5Shift.Size = new Size(150, 35);
            btnTask5Shift.TabIndex = 2;
            btnTask5Shift.Text = "Сдвинуть вправо";
            btnTask5Shift.UseVisualStyleBackColor = true;
            btnTask5Shift.Click += btnTask5Shift_Click;
            // 
            // txtTask5Input
            // 
            txtTask5Input.Location = new Point(20, 50);
            txtTask5Input.Name = "txtTask5Input";
            txtTask5Input.Size = new Size(400, 27);
            txtTask5Input.TabIndex = 1;
            // 
            // lblTask5Prompt
            // 
            lblTask5Prompt.AutoSize = true;
            lblTask5Prompt.Location = new Point(20, 20);
            lblTask5Prompt.Name = "lblTask5Prompt";
            lblTask5Prompt.Size = new Size(302, 20);
            lblTask5Prompt.TabIndex = 4;
            lblTask5Prompt.Text = "Введите элементы массива через пробел:";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lblTask6Result);
            tabPage6.Controls.Add(btnTask6Count);
            tabPage6.Controls.Add(txtTask6Input);
            tabPage6.Controls.Add(lblTask6Prompt);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(876, 478);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Задача 6: Подсчет дубликатов";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblTask6Result
            // 
            lblTask6Result.AutoSize = true;
            lblTask6Result.Location = new Point(20, 140);
            lblTask6Result.Name = "lblTask6Result";
            lblTask6Result.Size = new Size(0, 20);
            lblTask6Result.TabIndex = 3;
            // 
            // btnTask6Count
            // 
            btnTask6Count.Location = new Point(20, 90);
            btnTask6Count.Name = "btnTask6Count";
            btnTask6Count.Size = new Size(150, 35);
            btnTask6Count.TabIndex = 2;
            btnTask6Count.Text = "Подсчитать";
            btnTask6Count.UseVisualStyleBackColor = true;
            btnTask6Count.Click += btnTask6Count_Click;
            // 
            // txtTask6Input
            // 
            txtTask6Input.Location = new Point(20, 50);
            txtTask6Input.Name = "txtTask6Input";
            txtTask6Input.Size = new Size(400, 27);
            txtTask6Input.TabIndex = 1;
            // 
            // lblTask6Prompt
            // 
            lblTask6Prompt.AutoSize = true;
            lblTask6Prompt.Location = new Point(20, 20);
            lblTask6Prompt.Name = "lblTask6Prompt";
            lblTask6Prompt.Size = new Size(232, 20);
            lblTask6Prompt.TabIndex = 4;
            lblTask6Prompt.Text = "Введите 10 чисел через пробел:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Работа с массивами";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        
        // Task 1 controls
        private System.Windows.Forms.TextBox txtTask1Input;
        private System.Windows.Forms.Button btnTask1Calculate;
        private System.Windows.Forms.Label lblTask1Result;
        private System.Windows.Forms.Label lblTask1Prompt;
        
        // Task 2 controls
        private System.Windows.Forms.TextBox txtTask2Size;
        private System.Windows.Forms.Button btnTask2Generate;
        private System.Windows.Forms.Label lblTask2Result;
        private System.Windows.Forms.Label lblTask2Array;
        private System.Windows.Forms.Label lblTask2Prompt;
        
        // Task 3 controls
        private System.Windows.Forms.Button btnTask3Calculate;
        private System.Windows.Forms.Label lblTask3Result;
        private System.Windows.Forms.Label lblTask3Array;
        
        // Task 4 controls
        private System.Windows.Forms.TextBox txtTask4Input;
        private System.Windows.Forms.Button btnTask4Reverse;
        private System.Windows.Forms.Label lblTask4Result;
        private System.Windows.Forms.Label lblTask4Prompt;
        
        // Task 5 controls
        private System.Windows.Forms.TextBox txtTask5Input;
        private System.Windows.Forms.Button btnTask5Shift;
        private System.Windows.Forms.Label lblTask5Result;
        private System.Windows.Forms.Label lblTask5Prompt;
        
        // Task 6 controls
        private System.Windows.Forms.TextBox txtTask6Input;
        private System.Windows.Forms.Button btnTask6Count;
        private System.Windows.Forms.Label lblTask6Result;
        private System.Windows.Forms.Label lblTask6Prompt;
    }
}
