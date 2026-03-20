using System.Text;

namespace PR_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Задача 1: Книги\n");

            Book book1 = new Book { title = "Война и мир", pages = 1200 };
            Book book2 = new Book { title = "1984", pages = 300 };
            Book book3 = new Book { pages = 500 }; // title по умолчанию "Неизвестно"

            // Перехватываем вывод Console.WriteLine
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                book1.GetInfo();
                book2.GetInfo();
                book3.GetInfo();

                sb.Append(writer.ToString());
            }

            txtTask1.Text = sb.ToString();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Задача 2: Студенты\n");

            Student student1 = new Student(); 
            Student student2 = new Student("Мария");
            Student student3 = new Student("Алексей", 25); 

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                student1.PrintInfo();
                student2.PrintInfo();
                student3.PrintInfo();

                sb.Append(writer.ToString());
            }

            txtTask2.Text = sb.ToString();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Задача 3: Автомобили\n");

            Car car1 = new Car { brand = "Toyota", model = "Camry", year = 2020 };
            Car car2 = new Car { brand = "BMW", model = "X5", year = 2022 };
            Car car3 = new Car { brand = "Lada", model = "Vesta" }; // год по умолчанию 2000

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                car1.GetInfo();
                car2.GetInfo();
                car3.GetInfo();

                sb.Append(writer.ToString());
            }

            txtTask3.Text = sb.ToString();
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Задача 4: Треугольники\n");

            Triangle triangle1 = new Triangle(3, 4, 5); // Валидный
            Triangle triangle2 = new Triangle(1, 2, 4); // Невалидный

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                sb.AppendLine("Треугольник 1 (3, 4, 5):");
                triangle1.PrintSides();
                sb.AppendLine($"Существует: {triangle1.IsValid()}\n");

                sb.AppendLine("Треугольник 2 (1, 2, 4):");
                triangle2.PrintSides();
                sb.AppendLine($"Существует: {triangle2.IsValid()}");
            }

            txtTask4.Text = sb.ToString();
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Задача 5: Точка (Деконструкция)\n");

            Point point1 = new Point(10, 20);
            (int x, int y) = point1;  // деконструкция в две переменные

            sb.AppendLine($"Point1 координаты: X={x}, Y={y}");

            Point point2 = new Point(5, 7);
            (_, int y2) = point2;// деконструкция с игнорированием X

            sb.AppendLine($"Point2 координата Y: {y2}");

            txtTask5.Text = sb.ToString();
        }

        private void txtTask1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
