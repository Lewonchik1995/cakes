namespace cakes
{
    internal class categories
    {

        public int Id;
        public string Name;

        public static List<prices> categoriesBase = new List<prices>();

        private static void AddToCategoriesBase(int id, string Name)
        {
            prices newCategory = new();
            newCategory.Id = id;
            newCategory.Name = Name;

            categoriesBase.Add(newCategory);
        }

        private static void CategoriesBase()
        {
            AddToCategoriesBase(4, "Форма торта");
            AddToCategoriesBase(5, "Размер торта");
            AddToCategoriesBase(6, "Вкус торта");
            AddToCategoriesBase(7, "Количество коржей");
            AddToCategoriesBase(8, "Глазурь");
            AddToCategoriesBase(9, "Декор");
            AddToCategoriesBase(10, "Конец заказа");
        }

        public static void CreateCategoriesBase()
        {
            CategoriesBase();
            Console.WriteLine("Категории добавлены!");
        }
    }
}
