namespace PR_6
{
    public partial class Form1 : Form
    {
        private Book? currentBook;
        private BankAccount? currentAccount;
        private Point point1;
        private Point point2;
        private bool pointsInitialized = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Задача 1 - книга
        private void btnBookCreate_Click(object? sender, EventArgs e)
        {
            currentBook = new Book
            {
                title = txtBookTitle.Text,
                author = txtBookAuthor.Text,
                year = int.Parse(txtBookYear.Text)
            };

            txtBookOutput.Text = "Книга создана!\n";
            txtBookOutput.Text += $"Название: {currentBook.title}\n";
            txtBookOutput.Text += $"Автор: {currentBook.author}\n";
            txtBookOutput.Text += $"Год: {currentBook.year}\n";
        }

        private void btnBookDisplay_Click(object? sender, EventArgs e)
        {
            if (currentBook == null)
            {
                txtBookOutput.Text = "Сначала создайте книгу!";
                return;
            }

            txtBookOutput.Text = " DisplayInfo() \n";
            currentBook.DisplayInfo();
            txtBookOutput.Text += $"Название: {currentBook.title}, Автор: {currentBook.author}, Год: {currentBook.year}\n\n";
            txtBookOutput.Text += " Поля по отдельности \n";
            txtBookOutput.Text += $"title = {currentBook.title}\n";
            txtBookOutput.Text += $"author = {currentBook.author}\n";
            txtBookOutput.Text += $"year = {currentBook.year}\n";
        }

        // Задача 2 - Банк
        private void btnAccountCreate_Click(object? sender, EventArgs e)
        {
            currentAccount = new BankAccount
            {
                accountNumber = txtAccountNumber.Text,
                balance = 0
            };

            txtAccountOutput.Text = $"Счет создан!\nНомер: {currentAccount.accountNumber}\nБаланс: {currentAccount.balance}\n";
        }

        private void btnDeposit_Click(object? sender, EventArgs e)
        {
            if (currentAccount == null)
            {
                txtAccountOutput.Text = "Сначала создайте счет!";
                return;
            }

            double amount = double.Parse(txtDepositAmount.Text);
            currentAccount.Deposit(amount);
            txtAccountOutput.Text += $"[Console] Внесено {amount}. Текущий баланс: {currentAccount.balance}\n";
        }

        private void btnWithdraw_Click(object? sender, EventArgs e)
        {
            if (currentAccount == null)
            {
                txtAccountOutput.Text = "Сначала создайте счет!";
                return;
            }

            double amount = double.Parse(txtWithdrawAmount.Text);
            currentAccount.Withdraw(amount);
            txtAccountOutput.Text += $"[Console] {currentAccount.balance}\n";
        }

        // Задача 3 - Точка
        private void btnPointCreate_Click(object? sender, EventArgs e)
        {
            // Точка 1: с использованием new
            point1 = new Point
            {
                X = int.Parse(txtPoint1X.Text),
                Y = int.Parse(txtPoint1Y.Text)
            };

            // Точка 2: без new, просто объявление
            point2 = new Point();
            point2.X = int.Parse(txtPoint2X.Text);
            point2.Y = int.Parse(txtPoint2Y.Text);

            pointsInitialized = true;
            txtPointOutput.Text = "Точки созданы!\n";
            txtPointOutput.Text += $"Точка 1 (new): X={point1.X}, Y={point1.Y}\n";
            txtPointOutput.Text += $"Точка 2 (без new): X={point2.X}, Y={point2.Y}\n";
        }

        private void btnPointPrint_Click(object? sender, EventArgs e)
        {
            if (!pointsInitialized)
            {
                txtPointOutput.Text = "Сначала создайте точки!";
                return;
            }

            txtPointOutput.Text = "PrintCoordinates()\n";
            txtPointOutput.Text += "Точка 1: ";
            point1.PrintCoordinates();
            txtPointOutput.Text += $"Точка: ({point1.X}, {point1.Y})\n";
            txtPointOutput.Text += "Точка 2: ";
            point2.PrintCoordinates();
            txtPointOutput.Text += $"Точка: ({point2.X}, {point2.Y})\n";
        }

        private void btnPointMove_Click(object? sender, EventArgs e)
        {
            if (!pointsInitialized)
            {
                txtPointOutput.Text = "Сначала создайте точки!";
                return;
            }

            int deltaX = int.Parse(txtMoveDeltaX.Text);
            int deltaY = int.Parse(txtMoveDeltaY.Text);

            txtPointOutput.Text = "Move() для точки 1 \n";
            txtPointOutput.Text += $"До: ({point1.X}, {point1.Y})\n";
            point1.Move(deltaX, deltaY);
            txtPointOutput.Text += $"После Move({deltaX}, {deltaY}): ({point1.X}, {point1.Y})\n";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
