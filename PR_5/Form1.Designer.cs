namespace PR_5
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtTask1 = new TextBox();
            btnTask1 = new Button();
            tabPage2 = new TabPage();
            txtTask2 = new TextBox();
            btnTask2 = new Button();
            tabPage3 = new TabPage();
            txtTask3 = new TextBox();
            btnTask3 = new Button();
            tabPage4 = new TabPage();
            txtTask4 = new TextBox();
            btnTask4 = new Button();
            tabPage5 = new TabPage();
            txtTask5 = new TextBox();
            btnTask5 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtTask1);
            tabPage1.Controls.Add(btnTask1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задача 1: Книга";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTask1
            // 
            txtTask1.Location = new System.Drawing.Point(7, 56);
            txtTask1.Margin = new Padding(3, 4, 3, 4);
            txtTask1.Multiline = true;
            txtTask1.Name = "txtTask1";
            txtTask1.ReadOnly = true;
            txtTask1.ScrollBars = ScrollBars.Vertical;
            txtTask1.Size = new Size(891, 497);
            txtTask1.TabIndex = 1;
            txtTask1.TextChanged += txtTask1_TextChanged;
            // 
            // btnTask1
            // 
            btnTask1.Location = new System.Drawing.Point(7, 8);
            btnTask1.Margin = new Padding(3, 4, 3, 4);
            btnTask1.Name = "btnTask1";
            btnTask1.Size = new Size(171, 40);
            btnTask1.TabIndex = 0;
            btnTask1.Text = "Выполнить";
            btnTask1.UseVisualStyleBackColor = true;
            btnTask1.Click += btnTask1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtTask2);
            tabPage2.Controls.Add(btnTask2);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задача 2: Студент";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTask2
            // 
            txtTask2.Location = new System.Drawing.Point(7, 56);
            txtTask2.Margin = new Padding(3, 4, 3, 4);
            txtTask2.Multiline = true;
            txtTask2.Name = "txtTask2";
            txtTask2.ReadOnly = true;
            txtTask2.ScrollBars = ScrollBars.Vertical;
            txtTask2.Size = new Size(891, 497);
            txtTask2.TabIndex = 1;
            // 
            // btnTask2
            // 
            btnTask2.Location = new System.Drawing.Point(7, 8);
            btnTask2.Margin = new Padding(3, 4, 3, 4);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(171, 40);
            btnTask2.TabIndex = 0;
            btnTask2.Text = "Выполнить";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtTask3);
            tabPage3.Controls.Add(btnTask3);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(906, 567);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задача 3: Автомобиль";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTask3
            // 
            txtTask3.Location = new System.Drawing.Point(7, 56);
            txtTask3.Margin = new Padding(3, 4, 3, 4);
            txtTask3.Multiline = true;
            txtTask3.Name = "txtTask3";
            txtTask3.ReadOnly = true;
            txtTask3.ScrollBars = ScrollBars.Vertical;
            txtTask3.Size = new Size(891, 497);
            txtTask3.TabIndex = 1;
            // 
            // btnTask3
            // 
            btnTask3.Location = new System.Drawing.Point(7, 8);
            btnTask3.Margin = new Padding(3, 4, 3, 4);
            btnTask3.Name = "btnTask3";
            btnTask3.Size = new Size(171, 40);
            btnTask3.TabIndex = 0;
            btnTask3.Text = "Выполнить";
            btnTask3.UseVisualStyleBackColor = true;
            btnTask3.Click += btnTask3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtTask4);
            tabPage4.Controls.Add(btnTask4);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(906, 567);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Задача 4: Треугольник";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtTask4
            // 
            txtTask4.Location = new System.Drawing.Point(7, 56);
            txtTask4.Margin = new Padding(3, 4, 3, 4);
            txtTask4.Multiline = true;
            txtTask4.Name = "txtTask4";
            txtTask4.ReadOnly = true;
            txtTask4.ScrollBars = ScrollBars.Vertical;
            txtTask4.Size = new Size(891, 497);
            txtTask4.TabIndex = 1;
            // 
            // btnTask4
            // 
            btnTask4.Location = new System.Drawing.Point(7, 8);
            btnTask4.Margin = new Padding(3, 4, 3, 4);
            btnTask4.Name = "btnTask4";
            btnTask4.Size = new Size(171, 40);
            btnTask4.TabIndex = 0;
            btnTask4.Text = "Выполнить";
            btnTask4.UseVisualStyleBackColor = true;
            btnTask4.Click += btnTask4_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txtTask5);
            tabPage5.Controls.Add(btnTask5);
            tabPage5.Location = new System.Drawing.Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(906, 567);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Задача 5: Точка";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtTask5
            // 
            txtTask5.Location = new System.Drawing.Point(7, 56);
            txtTask5.Margin = new Padding(3, 4, 3, 4);
            txtTask5.Multiline = true;
            txtTask5.Name = "txtTask5";
            txtTask5.ReadOnly = true;
            txtTask5.ScrollBars = ScrollBars.Vertical;
            txtTask5.Size = new Size(891, 497);
            txtTask5.TabIndex = 1;
            // 
            // btnTask5
            // 
            btnTask5.Location = new System.Drawing.Point(7, 8);
            btnTask5.Margin = new Padding(3, 4, 3, 4);
            btnTask5.Name = "btnTask5";
            btnTask5.Size = new Size(171, 40);
            btnTask5.TabIndex = 0;
            btnTask5.Text = "Выполнить";
            btnTask5.UseVisualStyleBackColor = true;
            btnTask5.Click += btnTask5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Практическая работа 5";
            tabControl1.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.TextBox txtTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.TextBox txtTask2;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.TextBox txtTask3;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.TextBox txtTask4;
        private System.Windows.Forms.Button btnTask5;
        private System.Windows.Forms.TextBox txtTask5;
    }
}
