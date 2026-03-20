namespace PR_6
{
    public class Book
    {
        public string title = "Неизвестно";
        public string author;
        public int year;

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {title}, Автор: {author}, Год: {year}");
        }
    }
}
