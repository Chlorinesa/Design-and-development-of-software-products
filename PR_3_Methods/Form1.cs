namespace PR_3_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Задача 1: Калькулятор скидок
        private int GetDiscountPercent(decimal amount)
        {
            if (amount < 1000)
                return 0;
            else if (amount >= 1000 && amount <= 5000)
                return 5;
            else
                return 10;
        }
        private decimal CalculateDiscountedAmount(decimal amount)
        {
            int discountPercent = GetDiscountPercent(amount);
            return amount - (amount * discountPercent / 100);
        }

        private void btnCalculateDiscount_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPurchaseAmount.Text, out decimal amount) && amount >= 0)
            {
                int discountPercent = GetDiscountPercent(amount);
                decimal finalAmount = CalculateDiscountedAmount(amount);

                lblDiscountResult.Text = $"Скидка: {discountPercent}%\n" +
                                        $"Итоговая сумма: {finalAmount:F2} руб.";
            }
            else
            {
                lblDiscountResult.Text = "Введите корректную сумму покупки!";
            }
        }

        #endregion

        #region Задача 2: Проверка пароля
        private bool CheckPasswordLength(string password)
        {
            return password.Length >= 8;
        }
        private bool CheckPasswordDigits(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }
        private string GetPasswordStrength(string password)
        {
            bool hasLength = CheckPasswordLength(password);
            bool hasDigits = CheckPasswordDigits(password);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);

            if (hasLength && hasDigits && hasUpper && hasLower)
                return "Надёжный";
            else if (hasLength && (hasDigits || hasUpper || hasLower))
                return "Средний";
            else
                return "Слабый";
        }
        private void ShowPasswordStrength(string password)
        {
            string strength = GetPasswordStrength(password);
            lblPasswordStrength.Text = $"Надежность пароля: {strength}";
        }

        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                lblPasswordStrength.Text = "Введите пароль!";
                return;
            }

            ShowPasswordStrength(password);
        }

        #endregion

        #region Задача 3: Термометр
        private decimal CelsiusToFahrenheit(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        private decimal FahrenheitToCelsius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTemperature.Text, out decimal celsius))
            {
                decimal fahrenheit = CelsiusToFahrenheit(celsius);
                lblTemperatureResult.Text = $"{celsius}°C = {fahrenheit:F2}°F";
            }
            else
            {
                lblTemperatureResult.Text = "Введите корректное значение температуры!";
            }
        }

        private void btnFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTemperature.Text, out decimal fahrenheit))
            {
                decimal celsius = FahrenheitToCelsius(fahrenheit);
                lblTemperatureResult.Text = $"{fahrenheit}°F = {celsius:F2}°C";
            }
            else
            {
                lblTemperatureResult.Text = "Введите корректное значение температуры!";
            }
        }

        #endregion

        private void tabDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}
