namespace cakes
{
    internal class prices
    {
        public int Id;
        public string Name;
        public int Price;

        public static List<prices> dataBase = new List<prices>();

        private static void AddToDataBase(int id, string Name, int Price)
        {
            prices newData = new();
            newData.Id = id;
            newData.Name = Name;
            newData.Price = Price;

            dataBase.Add(newData);
        }

        private static void DataBase()
        { 
            AddToDataBase(4, "Круг", 500);
            AddToDataBase(4, "Квадрат", 500);
            AddToDataBase(4, "Прямоугольник", 500);
            AddToDataBase(4, "Сердечко", 700);
            AddToDataBase(5, "Маленький (Диаметр - 16см, 8 порций)", 1000);
            AddToDataBase(5, "Обычный (Диаметр - 18см, 10 порций)", 1000);
            AddToDataBase(5, "Большой (Диаметр 28см, 24 порции)", 2000);
            AddToDataBase(6, "Ванильный", 100);
            AddToDataBase(6, "Шоколадный", 100);
            AddToDataBase(6, "Карамельный", 150);
            AddToDataBase(6, "Ягодный", 200);
            AddToDataBase(6, "Кокосовый", 250);
            AddToDataBase(7, "1 корж", 200);
            AddToDataBase(7, "2 коржа", 400);
            AddToDataBase(7, "3 коржа", 600);
            AddToDataBase(7, "4 коржа", 800);
            AddToDataBase(8, "Шоколад", 100);
            AddToDataBase(8, "Крем", 100);
            AddToDataBase(8, "Бизе", 150);
            AddToDataBase(8, "Драже", 150);
            AddToDataBase(8, "Ягоды", 200);
            AddToDataBase(9, "Шоколадная", 100);
            AddToDataBase(9, "Кремовая", 150);
            AddToDataBase(9, "Ягодная", 150);
        }

        public static void CreateDataBase()
        {
            DataBase();
            Console.WriteLine("База цен добавлена!");
        }
    }
}
