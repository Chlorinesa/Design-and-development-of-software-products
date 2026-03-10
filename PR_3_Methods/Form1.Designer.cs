namespace PR_3_Methods
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
            tabDiscount = new TabPage();
            lblDiscountResult = new Label();
            btnCalculateDiscount = new Button();
            txtPurchaseAmount = new TextBox();
            lblPurchaseAmount = new Label();
            tabPassword = new TabPage();
            lblPasswordStrength = new Label();
            btnCheckPassword = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            tabThermometer = new TabPage();
            lblTemperatureResult = new Label();
            btnFahrenheitToCelsius = new Button();
            btnCelsiusToFahrenheit = new Button();
            txtTemperature = new TextBox();
            lblTemperature = new Label();
            tabControl.SuspendLayout();
            tabDiscount.SuspendLayout();
            tabPassword.SuspendLayout();
            tabThermometer.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabDiscount);
            tabControl.Controls.Add(tabPassword);
            tabControl.Controls.Add(tabThermometer);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabDiscount
            // 
            tabDiscount.Controls.Add(lblDiscountResult);
            tabDiscount.Controls.Add(btnCalculateDiscount);
            tabDiscount.Controls.Add(txtPurchaseAmount);
            tabDiscount.Controls.Add(lblPurchaseAmount);
            tabDiscount.Location = new Point(4, 29);
            tabDiscount.Name = "tabDiscount";
            tabDiscount.Padding = new Padding(20);
            tabDiscount.Size = new Size(792, 417);
            tabDiscount.TabIndex = 0;
            tabDiscount.Text = "Калькулятор скидок";
            tabDiscount.UseVisualStyleBackColor = true;
            tabDiscount.Click += tabDiscount_Click;
            // 
            // lblDiscountResult
            // 
            lblDiscountResult.AutoSize = true;
            lblDiscountResult.Location = new Point(40, 160);
            lblDiscountResult.Name = "lblDiscountResult";
            lblDiscountResult.Size = new Size(0, 20);
            lblDiscountResult.TabIndex = 0;
            // 
            // btnCalculateDiscount
            // 
            btnCalculateDiscount.Location = new Point(23, 109);
            btnCalculateDiscount.Name = "btnCalculateDiscount";
            btnCalculateDiscount.Size = new Size(150, 35);
            btnCalculateDiscount.TabIndex = 1;
            btnCalculateDiscount.Text = "Рассчитать скидку";
            btnCalculateDiscount.Click += btnCalculateDiscount_Click;
            // 
            // txtPurchaseAmount
            // 
            txtPurchaseAmount.Location = new Point(23, 63);
            txtPurchaseAmount.Name = "txtPurchaseAmount";
            txtPurchaseAmount.Size = new Size(200, 27);
            txtPurchaseAmount.TabIndex = 2;
            // 
            // lblPurchaseAmount
            // 
            lblPurchaseAmount.AutoSize = true;
            lblPurchaseAmount.Location = new Point(40, 40);
            lblPurchaseAmount.Name = "lblPurchaseAmount";
            lblPurchaseAmount.Size = new Size(158, 20);
            lblPurchaseAmount.TabIndex = 3;
            lblPurchaseAmount.Text = "Сумма покупки (руб):";
            // 
            // tabPassword
            // 
            tabPassword.Controls.Add(lblPasswordStrength);
            tabPassword.Controls.Add(btnCheckPassword);
            tabPassword.Controls.Add(txtPassword);
            tabPassword.Controls.Add(lblPassword);
            tabPassword.Location = new Point(4, 29);
            tabPassword.Name = "tabPassword";
            tabPassword.Padding = new Padding(20);
            tabPassword.Size = new Size(792, 417);
            tabPassword.TabIndex = 1;
            tabPassword.Text = "Проверка пароля";
            tabPassword.UseVisualStyleBackColor = true;
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Location = new Point(40, 160);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.Size = new Size(0, 20);
            lblPasswordStrength.TabIndex = 0;
            // 
            // btnCheckPassword
            // 
            btnCheckPassword.Location = new Point(20, 122);
            btnCheckPassword.Name = "btnCheckPassword";
            btnCheckPassword.Size = new Size(150, 35);
            btnCheckPassword.TabIndex = 1;
            btnCheckPassword.Text = "Проверить пароль";
            btnCheckPassword.Click += btnCheckPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль:";
            //
            // tabThermometer
            //
            tabThermometer.Controls.Add(lblTemperatureResult);
            tabThermometer.Controls.Add(btnFahrenheitToCelsius);
            tabThermometer.Controls.Add(btnCelsiusToFahrenheit);
            tabThermometer.Controls.Add(txtTemperature);
            tabThermometer.Controls.Add(lblTemperature);
            tabThermometer.Location = new Point(4, 29);
            tabThermometer.Name = "tabThermometer";
            tabThermometer.Padding = new Padding(20);
            tabThermometer.Size = new Size(792, 417);
            tabThermometer.TabIndex = 2;
            tabThermometer.Text = "Термометр";
            tabThermometer.UseVisualStyleBackColor = true;
            //
            // lblTemperatureResult
            //
            lblTemperatureResult.AutoSize = true;
            lblTemperatureResult.Location = new Point(20, 230);
            lblTemperatureResult.Name = "lblTemperatureResult";
            lblTemperatureResult.Size = new Size(0, 20);
            lblTemperatureResult.TabIndex = 0;
            //
            // btnFahrenheitToCelsius
            //
            btnFahrenheitToCelsius.Location = new Point(20, 175);
            btnFahrenheitToCelsius.Name = "btnFahrenheitToCelsius";
            btnFahrenheitToCelsius.Size = new Size(150, 35);
            btnFahrenheitToCelsius.TabIndex = 1;
            btnFahrenheitToCelsius.Text = "F → C";
            btnFahrenheitToCelsius.Click += btnFahrenheitToCelsius_Click;
            //
            // btnCelsiusToFahrenheit
            //
            btnCelsiusToFahrenheit.Location = new Point(20, 120);
            btnCelsiusToFahrenheit.Name = "btnCelsiusToFahrenheit";
            btnCelsiusToFahrenheit.Size = new Size(150, 35);
            btnCelsiusToFahrenheit.TabIndex = 2;
            btnCelsiusToFahrenheit.Text = "C → F";
            btnCelsiusToFahrenheit.Click += btnCelsiusToFahrenheit_Click;
            //
            // txtTemperature
            //
            txtTemperature.Location = new Point(20, 75);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(200, 27);
            txtTemperature.TabIndex = 3;
            //
            // lblTemperature
            //
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(20, 40);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(103, 20);
            lblTemperature.TabIndex = 4;
            lblTemperature.Text = "Температура:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Методы в Windows Forms";
            tabControl.ResumeLayout(false);
            tabDiscount.ResumeLayout(false);
            tabDiscount.PerformLayout();
            tabPassword.ResumeLayout(false);
            tabPassword.PerformLayout();
            tabThermometer.ResumeLayout(false);
            tabThermometer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabDiscount;
        private TabPage tabPassword;
        private TabPage tabThermometer;

        // Task 1 Controls
        private Label lblPurchaseAmount;
        private TextBox txtPurchaseAmount;
        private Button btnCalculateDiscount;
        private Label lblDiscountResult;

        // Task 2 Controls
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCheckPassword;
        private Label lblPasswordStrength;

        // Task 3 Controls
        private Label lblTemperature;
        private TextBox txtTemperature;
        private Button btnCelsiusToFahrenheit;
        private Button btnFahrenheitToCelsius;
        private Label lblTemperatureResult;
    }
}
