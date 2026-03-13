using System.Text;

namespace PR_4_Classes
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        private List<Visitor> visitors = new List<Visitor>();

        public Form1()
        {
            InitializeComponent();
            Visitor.totalVisitors = 0;
        }

        private void btnTask1Create_Click(object sender, EventArgs e)
        {
            string title = string.IsNullOrWhiteSpace(txtTask1Title.Text) ? "Неизвестно" : txtTask1Title.Text.Trim();
            string author = string.IsNullOrWhiteSpace(txtTask1Author.Text) ? "Неизвестен" : txtTask1Author.Text.Trim();
            int year = 0;
            int.TryParse(txtTask1Year.Text, out year);

            Book book = new Book();
            book.otitle = title;
            book.oauthor = author;
            book.oyear = year;
            books.Add(book);

            UpdateTask1Output();

            txtTask1Title.Clear();
            txtTask1Author.Clear();
            txtTask1Year.Clear();
            txtTask1Title.Focus();
        }

        private void btnTask1CreateDefault_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            books.Add(book);

            UpdateTask1Output();
        }

        private void UpdateTask1Output()
        {
            var output = new StringBuilder();
            output.AppendLine($"Всего книг создано: {books.Count}");
            output.AppendLine(new string('-', 50));

            for (int i = 0; i < books.Count; i++)
            {
                output.AppendLine($"Книга #{i + 1}:");
                output.AppendLine($"  «{books[i].otitle}», {books[i].oauthor} ({books[i].oyear})");
                output.AppendLine();
            }

            txtTask1Output.Text = output.ToString();
        }

        private void btnTask2Add_Click(object sender, EventArgs e)
        {
            string name = txtTask2Name.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя посетителя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTask2Name.Focus();
                return;
            }

            Visitor visitor = new Visitor(name);
            visitors.Add(visitor);

            lblTask2Total.Text = $"Всего посетителей: {Visitor.totalVisitors}";
            UpdateTask2Output();

            txtTask2Name.Clear();
            txtTask2Name.Focus();
        }

        private void txtTask2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTask2Add_Click(sender, e);
                e.Handled = true;
            }
        }

        private void UpdateTask2Output()
        {
            var output = new StringBuilder();
            output.AppendLine("Список посетителей:");
            output.AppendLine(new string('-', 50));

            for (int i = 0; i < visitors.Count; i++)
            {
                output.AppendLine($"{i + 1}. {visitors[i].name}");
            }

            txtTask2Output.Text = output.ToString();
        }

        private void tabTask1_Click(object sender, EventArgs e)
        {

        }
    }
}
