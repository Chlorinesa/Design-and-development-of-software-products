namespace PR_5
{
    public class Car
    {
        public string brand = "Unknown";
        public string model = "Unknown";
        public int year = 2000;

        public Car()
        {
        }

        public void GetInfo()
        {
            Console.WriteLine($"Автомобиль: {brand} {model}, год: {year}");
        }
    }
}
