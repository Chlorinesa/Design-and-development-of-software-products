namespace PR_4_Classes
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
            tabControl = new TabControl();
            tabTask1 = new TabPage();
            lblTask1Desc = new Label();
            btnTask1CreateDefault = new Button();
            btnTask1Create = new Button();
            txtTask1Output = new TextBox();
            txtTask1Year = new TextBox();
            txtTask1Author = new TextBox();
            txtTask1Title = new TextBox();
            lblTask1Year = new Label();
            lblTask1Author = new Label();
            lblTask1Title = new Label();
            lblTask1Header = new Label();
            tabTask2 = new TabPage();
            lblTask2Total = new Label();
            btnTask2Add = new Button();
            txtTask2Output = new TextBox();
            txtTask2Name = new TextBox();
            lblTask2Name = new Label();
            lblTask2Header = new Label();
            tabControl.SuspendLayout();
            tabTask1.SuspendLayout();
            tabTask2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTask1);
            tabControl.Controls.Add(tabTask2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(971, 667);
            tabControl.TabIndex = 0;
            // 
            // tabTask1
            // 
            tabTask1.Controls.Add(lblTask1Desc);
            tabTask1.Controls.Add(btnTask1CreateDefault);
            tabTask1.Controls.Add(btnTask1Create);
            tabTask1.Controls.Add(txtTask1Output);
            tabTask1.Controls.Add(txtTask1Year);
            tabTask1.Controls.Add(txtTask1Author);
            tabTask1.Controls.Add(txtTask1Title);
            tabTask1.Controls.Add(lblTask1Year);
            tabTask1.Controls.Add(lblTask1Author);
            tabTask1.Controls.Add(lblTask1Title);
            tabTask1.Controls.Add(lblTask1Header);
            tabTask1.Location = new Point(4, 29);
            tabTask1.Margin = new Padding(3, 4, 3, 4);
            tabTask1.Name = "tabTask1";
            tabTask1.Padding = new Padding(3, 4, 3, 4);
            tabTask1.Size = new Size(963, 634);
            tabTask1.TabIndex = 0;
            tabTask1.Text = "Задача 1: Книжная полка";
            tabTask1.UseVisualStyleBackColor = true;
            tabTask1.Click += tabTask1_Click;
            // 
            // lblTask1Desc
            // 
            lblTask1Desc.AutoSize = true;
            lblTask1Desc.ForeColor = Color.Gray;
            lblTask1Desc.Location = new Point(23, 140);
            lblTask1Desc.Name = "lblTask1Desc";
            lblTask1Desc.Size = new Size(531, 20);
            lblTask1Desc.TabIndex = 10;
            lblTask1Desc.Text = "Оставьте поля пустыми для создания книги со значениями по умолчанию";
            // 
            // btnTask1CreateDefault
            // 
            btnTask1CreateDefault.Location = new Point(480, 173);
            btnTask1CreateDefault.Margin = new Padding(3, 4, 3, 4);
            btnTask1CreateDefault.Name = "btnTask1CreateDefault";
            btnTask1CreateDefault.Size = new Size(297, 40);
            btnTask1CreateDefault.TabIndex = 9;
            btnTask1CreateDefault.Text = "Создать (значения по умолчанию)";
            btnTask1CreateDefault.UseVisualStyleBackColor = true;
            btnTask1CreateDefault.Click += btnTask1CreateDefault_Click;
            // 
            // btnTask1Create
            // 
            btnTask1Create.Location = new Point(251, 173);
            btnTask1Create.Margin = new Padding(3, 4, 3, 4);
            btnTask1Create.Name = "btnTask1Create";
            btnTask1Create.Size = new Size(206, 40);
            btnTask1Create.TabIndex = 8;
            btnTask1Create.Text = "Создать книгу";
            btnTask1Create.UseVisualStyleBackColor = true;
            btnTask1Create.Click += btnTask1Create_Click;
            // 
            // txtTask1Output
            // 
            txtTask1Output.Location = new Point(23, 240);
            txtTask1Output.Margin = new Padding(3, 4, 3, 4);
            txtTask1Output.Multiline = true;
            txtTask1Output.Name = "txtTask1Output";
            txtTask1Output.ReadOnly = true;
            txtTask1Output.ScrollBars = ScrollBars.Vertical;
            txtTask1Output.Size = new Size(914, 359);
            txtTask1Output.TabIndex = 7;
            // 
            // txtTask1Year
            // 
            txtTask1Year.Location = new Point(251, 100);
            txtTask1Year.Margin = new Padding(3, 4, 3, 4);
            txtTask1Year.Name = "txtTask1Year";
            txtTask1Year.Size = new Size(205, 27);
            txtTask1Year.TabIndex = 6;
            // 
            // txtTask1Author
            // 
            txtTask1Author.Location = new Point(251, 60);
            txtTask1Author.Margin = new Padding(3, 4, 3, 4);
            txtTask1Author.Name = "txtTask1Author";
            txtTask1Author.Size = new Size(434, 27);
            txtTask1Author.TabIndex = 5;
            // 
            // txtTask1Title
            // 
            txtTask1Title.Location = new Point(251, 20);
            txtTask1Title.Margin = new Padding(3, 4, 3, 4);
            txtTask1Title.Name = "txtTask1Title";
            txtTask1Title.Size = new Size(434, 27);
            txtTask1Title.TabIndex = 4;
            // 
            // lblTask1Year
            // 
            lblTask1Year.AutoSize = true;
            lblTask1Year.Location = new Point(23, 104);
            lblTask1Year.Name = "lblTask1Year";
            lblTask1Year.Size = new Size(98, 20);
            lblTask1Year.TabIndex = 3;
            lblTask1Year.Text = "Год издания:";
            // 
            // lblTask1Author
            // 
            lblTask1Author.AutoSize = true;
            lblTask1Author.Location = new Point(23, 64);
            lblTask1Author.Name = "lblTask1Author";
            lblTask1Author.Size = new Size(54, 20);
            lblTask1Author.TabIndex = 2;
            lblTask1Author.Text = "Автор:";
            // 
            // lblTask1Title
            // 
            lblTask1Title.AutoSize = true;
            lblTask1Title.Location = new Point(23, 24);
            lblTask1Title.Name = "lblTask1Title";
            lblTask1Title.Size = new Size(124, 20);
            lblTask1Title.TabIndex = 1;
            lblTask1Title.Text = "Название книги:";
            // 
            // lblTask1Header
            // 
            lblTask1Header.AutoSize = true;
            lblTask1Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTask1Header.Location = new Point(704, 24);
            lblTask1Header.Name = "lblTask1Header";
            lblTask1Header.Size = new Size(233, 28);
            lblTask1Header.TabIndex = 0;
            lblTask1Header.Text = "Книжная полка (Book)";
            // 
            // tabTask2
            // 
            tabTask2.Controls.Add(lblTask2Total);
            tabTask2.Controls.Add(btnTask2Add);
            tabTask2.Controls.Add(txtTask2Output);
            tabTask2.Controls.Add(txtTask2Name);
            tabTask2.Controls.Add(lblTask2Name);
            tabTask2.Controls.Add(lblTask2Header);
            tabTask2.Location = new Point(4, 29);
            tabTask2.Margin = new Padding(3, 4, 3, 4);
            tabTask2.Name = "tabTask2";
            tabTask2.Padding = new Padding(3, 4, 3, 4);
            tabTask2.Size = new Size(963, 634);
            tabTask2.TabIndex = 1;
            tabTask2.Text = "Задача 2: Умный счетчик";
            tabTask2.UseVisualStyleBackColor = true;
            // 
            // lblTask2Total
            // 
            lblTask2Total.AutoSize = true;
            lblTask2Total.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTask2Total.ForeColor = Color.DarkGreen;
            lblTask2Total.Location = new Point(23, 140);
            lblTask2Total.Name = "lblTask2Total";
            lblTask2Total.Size = new Size(183, 23);
            lblTask2Total.TabIndex = 10;
            lblTask2Total.Text = "Всего посетителей: 0";
            // 
            // btnTask2Add
            // 
            btnTask2Add.Location = new Point(480, 60);
            btnTask2Add.Margin = new Padding(3, 4, 3, 4);
            btnTask2Add.Name = "btnTask2Add";
            btnTask2Add.Size = new Size(206, 40);
            btnTask2Add.TabIndex = 9;
            btnTask2Add.Text = "Добавить посетителя";
            btnTask2Add.UseVisualStyleBackColor = true;
            btnTask2Add.Click += btnTask2Add_Click;
            // 
            // txtTask2Output
            // 
            txtTask2Output.Location = new Point(23, 187);
            txtTask2Output.Margin = new Padding(3, 4, 3, 4);
            txtTask2Output.Multiline = true;
            txtTask2Output.Name = "txtTask2Output";
            txtTask2Output.ReadOnly = true;
            txtTask2Output.ScrollBars = ScrollBars.Vertical;
            txtTask2Output.Size = new Size(914, 412);
            txtTask2Output.TabIndex = 8;
            // 
            // txtTask2Name
            // 
            txtTask2Name.Location = new Point(171, 63);
            txtTask2Name.Margin = new Padding(3, 4, 3, 4);
            txtTask2Name.Name = "txtTask2Name";
            txtTask2Name.PlaceholderText = "Введите имя посетителя";
            txtTask2Name.Size = new Size(285, 27);
            txtTask2Name.TabIndex = 7;
            txtTask2Name.KeyPress += txtTask2Name_KeyPress;
            // 
            // lblTask2Name
            // 
            lblTask2Name.AutoSize = true;
            lblTask2Name.Location = new Point(23, 67);
            lblTask2Name.Name = "lblTask2Name";
            lblTask2Name.Size = new Size(124, 20);
            lblTask2Name.TabIndex = 6;
            lblTask2Name.Text = "Имя посетителя:";
            // 
            // lblTask2Header
            // 
            lblTask2Header.AutoSize = true;
            lblTask2Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTask2Header.Location = new Point(23, 20);
            lblTask2Header.Name = "lblTask2Header";
            lblTask2Header.Size = new Size(246, 28);
            lblTask2Header.TabIndex = 4;
            lblTask2Header.Text = "Умный счетчик (Visitor)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 667);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PR_4_Classes - Работа с классами";
            tabControl.ResumeLayout(false);
            tabTask1.ResumeLayout(false);
            tabTask1.PerformLayout();
            tabTask2.ResumeLayout(false);
            tabTask2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTask1;
        private System.Windows.Forms.TabPage tabTask2;
        private System.Windows.Forms.Label lblTask1Header;
        private System.Windows.Forms.TextBox txtTask1Output;
        private System.Windows.Forms.TextBox txtTask1Year;
        private System.Windows.Forms.TextBox txtTask1Author;
        private System.Windows.Forms.TextBox txtTask1Title;
        private System.Windows.Forms.Label lblTask1Year;
        private System.Windows.Forms.Label lblTask1Author;
        private System.Windows.Forms.Label lblTask1Title;
        private System.Windows.Forms.Button btnTask1Create;
        private System.Windows.Forms.Button btnTask1CreateDefault;
        private System.Windows.Forms.Label lblTask1Desc;
        private System.Windows.Forms.Label lblTask2Header;
        private System.Windows.Forms.TextBox txtTask2Output;
        private System.Windows.Forms.TextBox txtTask2Name;
        private System.Windows.Forms.Label lblTask2Name;
        private System.Windows.Forms.Button btnTask2Add;
        private System.Windows.Forms.Label lblTask2Total;
    }
}
