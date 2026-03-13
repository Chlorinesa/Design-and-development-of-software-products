namespace PR_4_Classes
{
    public class Visitor
    {
        public string name;
        public static int totalVisitors = 0;

        public Visitor(string name)
        {
            this.name = name;
            totalVisitors++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Посетитель: {name}");
        }

        public static void ShowTotalVisitors()
        {
            Console.WriteLine($"Всего посетителей: {totalVisitors}");
        }
    }
}
