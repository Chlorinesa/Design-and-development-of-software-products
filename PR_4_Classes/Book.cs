namespace PR_4_Classes
{
    public class Book
    {
        public string otitle = "Неизвестно";
        public string oauthor = "Неизвестен";
        public int oyear;

        public void GetInfo()
        {
            Console.WriteLine($"«{otitle}», {oauthor} ({oyear})");
        }
    }
}
