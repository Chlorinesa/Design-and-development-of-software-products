namespace PR_6
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
            tabPage1 = new TabPage();
            txtBookOutput = new TextBox();
            btnBookDisplay = new Button();
            btnBookCreate = new Button();
            txtBookYear = new TextBox();
            lblBookYear = new Label();
            txtBookAuthor = new TextBox();
            lblBookAuthor = new Label();
            txtBookTitle = new TextBox();
            lblBookTitle = new Label();
            tabPage2 = new TabPage();
            txtAccountOutput = new TextBox();
            btnWithdraw = new Button();
            txtWithdrawAmount = new TextBox();
            lblWithdrawAmount = new Label();
            btnDeposit = new Button();
            txtDepositAmount = new TextBox();
            lblDepositAmount = new Label();
            btnAccountCreate = new Button();
            txtAccountNumber = new TextBox();
            lblAccountNumber = new Label();
            tabPage3 = new TabPage();
            txtPointOutput = new TextBox();
            btnPointMove = new Button();
            txtMoveDeltaY = new TextBox();
            lblMoveDeltaY = new Label();
            txtMoveDeltaX = new TextBox();
            lblMoveDeltaX = new Label();
            btnPointPrint = new Button();
            btnPointCreate = new Button();
            txtPoint2Y = new TextBox();
            lblPoint2Y = new Label();
            txtPoint2X = new TextBox();
            lblPoint2X = new Label();
            txtPoint1Y = new TextBox();
            lblPoint1Y = new Label();
            txtPoint1X = new TextBox();
            lblPoint1X = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 550);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtBookOutput);
            tabPage1.Controls.Add(btnBookDisplay);
            tabPage1.Controls.Add(btnBookCreate);
            tabPage1.Controls.Add(txtBookYear);
            tabPage1.Controls.Add(lblBookYear);
            tabPage1.Controls.Add(txtBookAuthor);
            tabPage1.Controls.Add(lblBookAuthor);
            tabPage1.Controls.Add(txtBookTitle);
            tabPage1.Controls.Add(lblBookTitle);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(10);
            tabPage1.Size = new Size(892, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задача 1: Книга";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txtBookOutput
            // 
            txtBookOutput.Location = new System.Drawing.Point(20, 190);
            txtBookOutput.Multiline = true;
            txtBookOutput.Name = "txtBookOutput";
            txtBookOutput.ReadOnly = true;
            txtBookOutput.ScrollBars = ScrollBars.Vertical;
            txtBookOutput.Size = new Size(400, 250);
            txtBookOutput.TabIndex = 10;
            // 
            // btnBookDisplay
            // 
            btnBookDisplay.Location = new System.Drawing.Point(180, 140);
            btnBookDisplay.Name = "btnBookDisplay";
            btnBookDisplay.Size = new Size(150, 35);
            btnBookDisplay.TabIndex = 11;
            btnBookDisplay.Text = "Вывести info";
            btnBookDisplay.UseVisualStyleBackColor = true;
            btnBookDisplay.Click += btnBookDisplay_Click;
            // 
            // btnBookCreate
            // 
            btnBookCreate.Location = new System.Drawing.Point(20, 140);
            btnBookCreate.Name = "btnBookCreate";
            btnBookCreate.Size = new Size(150, 35);
            btnBookCreate.TabIndex = 12;
            btnBookCreate.Text = "Создать книгу";
            btnBookCreate.UseVisualStyleBackColor = true;
            btnBookCreate.Click += btnBookCreate_Click;
            // 
            // txtBookYear
            // 
            txtBookYear.Location = new System.Drawing.Point(120, 97);
            txtBookYear.Name = "txtBookYear";
            txtBookYear.Size = new Size(100, 27);
            txtBookYear.TabIndex = 13;
            txtBookYear.Text = "1967";
            // 
            // lblBookYear
            // 
            lblBookYear.AutoSize = true;
            lblBookYear.Location = new System.Drawing.Point(20, 100);
            lblBookYear.Name = "lblBookYear";
            lblBookYear.Size = new Size(36, 20);
            lblBookYear.TabIndex = 14;
            lblBookYear.Text = "Год:";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new System.Drawing.Point(120, 57);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(250, 27);
            txtBookAuthor.TabIndex = 15;
            txtBookAuthor.Text = "Михаил Булгаков";
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new System.Drawing.Point(20, 60);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(54, 20);
            lblBookAuthor.TabIndex = 16;
            lblBookAuthor.Text = "Автор:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new System.Drawing.Point(120, 17);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(250, 27);
            txtBookTitle.TabIndex = 17;
            txtBookTitle.Text = "Мастер и Маргарита";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new System.Drawing.Point(20, 20);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(80, 20);
            lblBookTitle.TabIndex = 18;
            lblBookTitle.Text = "Название:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtAccountOutput);
            tabPage2.Controls.Add(btnWithdraw);
            tabPage2.Controls.Add(txtWithdrawAmount);
            tabPage2.Controls.Add(lblWithdrawAmount);
            tabPage2.Controls.Add(btnDeposit);
            tabPage2.Controls.Add(txtDepositAmount);
            tabPage2.Controls.Add(lblDepositAmount);
            tabPage2.Controls.Add(btnAccountCreate);
            tabPage2.Controls.Add(txtAccountNumber);
            tabPage2.Controls.Add(lblAccountNumber);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(10);
            tabPage2.Size = new Size(892, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задача 2: Банк";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAccountOutput
            // 
            txtAccountOutput.Location = new System.Drawing.Point(20, 300);
            txtAccountOutput.Multiline = true;
            txtAccountOutput.Name = "txtAccountOutput";
            txtAccountOutput.ReadOnly = true;
            txtAccountOutput.ScrollBars = ScrollBars.Vertical;
            txtAccountOutput.Size = new Size(400, 180);
            txtAccountOutput.TabIndex = 10;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new System.Drawing.Point(20, 240);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(150, 35);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Снять";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Location = new System.Drawing.Point(150, 197);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(150, 27);
            txtWithdrawAmount.TabIndex = 12;
            txtWithdrawAmount.Text = "200";
            // 
            // lblWithdrawAmount
            // 
            lblWithdrawAmount.AutoSize = true;
            lblWithdrawAmount.Location = new System.Drawing.Point(20, 200);
            lblWithdrawAmount.Name = "lblWithdrawAmount";
            lblWithdrawAmount.Size = new Size(99, 20);
            lblWithdrawAmount.TabIndex = 13;
            lblWithdrawAmount.Text = "Снять сумму:";
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new System.Drawing.Point(20, 150);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(150, 35);
            btnDeposit.TabIndex = 14;
            btnDeposit.Text = "Внести";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new System.Drawing.Point(150, 107);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(150, 27);
            txtDepositAmount.TabIndex = 15;
            txtDepositAmount.Text = "500";
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Location = new System.Drawing.Point(20, 110);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(107, 20);
            lblDepositAmount.TabIndex = 16;
            lblDepositAmount.Text = "Внести сумму:";
            // 
            // btnAccountCreate
            // 
            btnAccountCreate.Location = new System.Drawing.Point(20, 60);
            btnAccountCreate.Name = "btnAccountCreate";
            btnAccountCreate.Size = new Size(150, 35);
            btnAccountCreate.TabIndex = 17;
            btnAccountCreate.Text = "Создать счет";
            btnAccountCreate.UseVisualStyleBackColor = true;
            btnAccountCreate.Click += btnAccountCreate_Click;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new System.Drawing.Point(150, 17);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(200, 27);
            txtAccountNumber.TabIndex = 18;
            txtAccountNumber.Text = "1234567890";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new System.Drawing.Point(20, 20);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(101, 20);
            lblAccountNumber.TabIndex = 19;
            lblAccountNumber.Text = "Номер счета:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtPointOutput);
            tabPage3.Controls.Add(btnPointMove);
            tabPage3.Controls.Add(txtMoveDeltaY);
            tabPage3.Controls.Add(lblMoveDeltaY);
            tabPage3.Controls.Add(txtMoveDeltaX);
            tabPage3.Controls.Add(lblMoveDeltaX);
            tabPage3.Controls.Add(btnPointPrint);
            tabPage3.Controls.Add(btnPointCreate);
            tabPage3.Controls.Add(txtPoint2Y);
            tabPage3.Controls.Add(lblPoint2Y);
            tabPage3.Controls.Add(txtPoint2X);
            tabPage3.Controls.Add(lblPoint2X);
            tabPage3.Controls.Add(txtPoint1Y);
            tabPage3.Controls.Add(lblPoint1Y);
            tabPage3.Controls.Add(txtPoint1X);
            tabPage3.Controls.Add(lblPoint1X);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(10);
            tabPage3.Size = new Size(892, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задача 3: Точка";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPointOutput
            // 
            txtPointOutput.Location = new System.Drawing.Point(20, 240);
            txtPointOutput.Multiline = true;
            txtPointOutput.Name = "txtPointOutput";
            txtPointOutput.ReadOnly = true;
            txtPointOutput.ScrollBars = ScrollBars.Vertical;
            txtPointOutput.Size = new Size(400, 200);
            txtPointOutput.TabIndex = 10;
            // 
            // btnPointMove
            // 
            btnPointMove.Location = new System.Drawing.Point(20, 190);
            btnPointMove.Name = "btnPointMove";
            btnPointMove.Size = new Size(150, 35);
            btnPointMove.TabIndex = 11;
            btnPointMove.Text = "Переместить";
            btnPointMove.UseVisualStyleBackColor = true;
            btnPointMove.Click += btnPointMove_Click;
            // 
            // txtMoveDeltaY
            // 
            txtMoveDeltaY.Location = new System.Drawing.Point(280, 147);
            txtMoveDeltaY.Name = "txtMoveDeltaY";
            txtMoveDeltaY.Size = new Size(80, 27);
            txtMoveDeltaY.TabIndex = 12;
            txtMoveDeltaY.Text = "-3";
            // 
            // lblMoveDeltaY
            // 
            lblMoveDeltaY.AutoSize = true;
            lblMoveDeltaY.Location = new System.Drawing.Point(200, 150);
            lblMoveDeltaY.Name = "lblMoveDeltaY";
            lblMoveDeltaY.Size = new Size(60, 20);
            lblMoveDeltaY.TabIndex = 13;
            lblMoveDeltaY.Text = "Delta Y:";
            // 
            // txtMoveDeltaX
            // 
            txtMoveDeltaX.Location = new System.Drawing.Point(100, 147);
            txtMoveDeltaX.Name = "txtMoveDeltaX";
            txtMoveDeltaX.Size = new Size(80, 27);
            txtMoveDeltaX.TabIndex = 14;
            txtMoveDeltaX.Text = "5";
            // 
            // lblMoveDeltaX
            // 
            lblMoveDeltaX.AutoSize = true;
            lblMoveDeltaX.Location = new System.Drawing.Point(20, 150);
            lblMoveDeltaX.Name = "lblMoveDeltaX";
            lblMoveDeltaX.Size = new Size(61, 20);
            lblMoveDeltaX.TabIndex = 15;
            lblMoveDeltaX.Text = "Delta X:";
            // 
            // btnPointPrint
            // 
            btnPointPrint.Location = new System.Drawing.Point(180, 100);
            btnPointPrint.Name = "btnPointPrint";
            btnPointPrint.Size = new Size(150, 35);
            btnPointPrint.TabIndex = 16;
            btnPointPrint.Text = "Вывести координаты";
            btnPointPrint.UseVisualStyleBackColor = true;
            btnPointPrint.Click += btnPointPrint_Click;
            // 
            // btnPointCreate
            // 
            btnPointCreate.Location = new System.Drawing.Point(20, 100);
            btnPointCreate.Name = "btnPointCreate";
            btnPointCreate.Size = new Size(150, 35);
            btnPointCreate.TabIndex = 17;
            btnPointCreate.Text = "Создать точки";
            btnPointCreate.UseVisualStyleBackColor = true;
            btnPointCreate.Click += btnPointCreate_Click;
            // 
            // txtPoint2Y
            // 
            txtPoint2Y.Location = new System.Drawing.Point(280, 57);
            txtPoint2Y.Name = "txtPoint2Y";
            txtPoint2Y.Size = new Size(80, 27);
            txtPoint2Y.TabIndex = 18;
            txtPoint2Y.Text = "0";
            // 
            // lblPoint2Y
            // 
            lblPoint2Y.AutoSize = true;
            lblPoint2Y.Location = new System.Drawing.Point(200, 60);
            lblPoint2Y.Name = "lblPoint2Y";
            lblPoint2Y.Size = new Size(76, 20);
            lblPoint2Y.TabIndex = 19;
            lblPoint2Y.Text = "Точка 2 Y:";
            // 
            // txtPoint2X
            // 
            txtPoint2X.Location = new System.Drawing.Point(100, 57);
            txtPoint2X.Name = "txtPoint2X";
            txtPoint2X.Size = new Size(80, 27);
            txtPoint2X.TabIndex = 20;
            txtPoint2X.Text = "0";
            // 
            // lblPoint2X
            // 
            lblPoint2X.AutoSize = true;
            lblPoint2X.Location = new System.Drawing.Point(20, 60);
            lblPoint2X.Name = "lblPoint2X";
            lblPoint2X.Size = new Size(77, 20);
            lblPoint2X.TabIndex = 21;
            lblPoint2X.Text = "Точка 2 X:";
            // 
            // txtPoint1Y
            // 
            txtPoint1Y.Location = new System.Drawing.Point(280, 17);
            txtPoint1Y.Name = "txtPoint1Y";
            txtPoint1Y.Size = new Size(80, 27);
            txtPoint1Y.TabIndex = 22;
            txtPoint1Y.Text = "0";
            // 
            // lblPoint1Y
            // 
            lblPoint1Y.AutoSize = true;
            lblPoint1Y.Location = new System.Drawing.Point(200, 20);
            lblPoint1Y.Name = "lblPoint1Y";
            lblPoint1Y.Size = new Size(76, 20);
            lblPoint1Y.TabIndex = 23;
            lblPoint1Y.Text = "Точка 1 Y:";
            // 
            // txtPoint1X
            // 
            txtPoint1X.Location = new System.Drawing.Point(100, 17);
            txtPoint1X.Name = "txtPoint1X";
            txtPoint1X.Size = new Size(80, 27);
            txtPoint1X.TabIndex = 24;
            txtPoint1X.Text = "0";
            // 
            // lblPoint1X
            // 
            lblPoint1X.AutoSize = true;
            lblPoint1X.Location = new System.Drawing.Point(20, 20);
            lblPoint1X.Name = "lblPoint1X";
            lblPoint1X.Size = new Size(77, 20);
            lblPoint1X.TabIndex = 25;
            lblPoint1X.Text = "Точка 1 X:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Практическая работа 6 - Классы и структуры";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        
        // Task 1 controls
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookYear;
        private System.Windows.Forms.TextBox txtBookYear;
        private System.Windows.Forms.Button btnBookCreate;
        private System.Windows.Forms.Button btnBookDisplay;
        private System.Windows.Forms.TextBox txtBookOutput;
        
        // Task 2 controls
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnAccountCreate;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAccountOutput;
        
        // Task 3 controls
        private System.Windows.Forms.Label lblPoint1X;
        private System.Windows.Forms.TextBox txtPoint1X;
        private System.Windows.Forms.Label lblPoint1Y;
        private System.Windows.Forms.TextBox txtPoint1Y;
        private System.Windows.Forms.Label lblPoint2X;
        private System.Windows.Forms.TextBox txtPoint2X;
        private System.Windows.Forms.Label lblPoint2Y;
        private System.Windows.Forms.TextBox txtPoint2Y;
        private System.Windows.Forms.Button btnPointCreate;
        private System.Windows.Forms.Button btnPointPrint;
        private System.Windows.Forms.Label lblMoveDeltaX;
        private System.Windows.Forms.TextBox txtMoveDeltaX;
        private System.Windows.Forms.Label lblMoveDeltaY;
        private System.Windows.Forms.TextBox txtMoveDeltaY;
        private System.Windows.Forms.Button btnPointMove;
        private System.Windows.Forms.TextBox txtPointOutput;
    }
}
