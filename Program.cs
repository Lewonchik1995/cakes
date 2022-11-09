namespace cakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            categories.CreateCategoriesBase();
            Thread.Sleep(1000);
            prices.CreateDataBase();
            Thread.Sleep(1000);
            Console.Clear();

            order.MainMenu();
        }
    }
}