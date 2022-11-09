namespace cakes
{
    internal class order
    {
        static DateTime orderDateTime;
        static string fullOrder = "";
        static int fullPrice = 0;
        static List<prices> pricesByPosition = new List<prices>();
        static int QPosition = 3;
        static int idCategoryPrices = 4;
        static int position = Fix(3);

        public static void MainMenu()
        {
            position = 3;
            idCategoryPrices = 4;
            Console.Clear();
            Menu();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 9)
                    {
                        Console.Clear();
                        SuccessfulOrder();
                    }
                    else
                    {
                        position = 3;
                        AddToOrder();
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = Fix(position - 1);
                    idCategoryPrices = position + 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = Fix(position + 1);
                    idCategoryPrices = position + 1;
                }
                Console.Clear();
                Menu();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
        }

        private static void AddToOrder()
        {
            Console.Clear();
            SubMenu();
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            while (true)
            {
                if (key.Key == ConsoleKey.Escape)
                {
                    position = 3;
                    idCategoryPrices = 4;
                    MainMenu();
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    fullPrice = fullPrice + pricesByPosition[position - 3].Price;
                    fullOrder = fullOrder + pricesByPosition[position - 3].Name + " - " + pricesByPosition[position - 3].Price + "; ";
                                        
                    MainMenu();                    
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = Fix(position - 1);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position = Fix(position + 1);
                }
                Console.Clear();
                SubMenu();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
        }

        private static void SubMenu()
        {
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("---------------------------------------------");
            pricesByPosition.Clear();
            for (int i = 0; i < prices.dataBase.Count(); i++)
            {
                if (prices.dataBase[i].Id == idCategoryPrices)
                {
                    pricesByPosition.Add(prices.dataBase[i]);
                }
            }
            for (int j = 0; j < pricesByPosition.Count(); j++)
            {
                Console.WriteLine("  " + pricesByPosition[j].Name + " - " + pricesByPosition[j].Price);
            }
            QPosition = pricesByPosition.Count() + 2;
        }

        private static void Menu()
        {
            Console.WriteLine("Заказ тортов в ГЛАЗУРЬКА, торты на ваш выбор!");
            Console.WriteLine("Выберите параметр торта:");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < categories.categoriesBase.Count(); i++)
            {
                Console.WriteLine("  " + categories.categoriesBase[i].Name);
            }
            Console.WriteLine("\nЦена: " + fullPrice);
            Console.Write("Ваш торт: " + fullOrder);
            QPosition = categories.categoriesBase.Count() + 2;
        }

        private static int Fix(int position)
        {
            if (position < 3)
            {
                position = QPosition;
            }
            else if (position > QPosition)
            {
                position = 3;
            }
            return position;
        }

        static void SuccessfulOrder()
        {
            orderDateTime = DateTime.Now;
            string orderDateTimeToFile = "\nЗаказ от " + Convert.ToString(orderDateTime);
            string fullOrderToFile = "\n\tЗаказ: " + fullOrder;
            string fullPriceToFile = "\n\tЦена: " + Convert.ToString(fullPrice);

            File.AppendAllText("C:/Users/Алексей/Desktop/Основы алгоритмизации и программирования/С#/cakes/История заказов.txt", orderDateTimeToFile);
            File.AppendAllText("C:/Users/Алексей/Desktop/Основы алгоритмизации и программирования/С#/cakes/История заказов.txt", fullOrderToFile);
            File.AppendAllText("C:/Users/Алексей/Desktop/Основы алгоритмизации и программирования/С#/cakes/История заказов.txt", fullPriceToFile);

            Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите клавишу Escape");
            fullPrice = 0;
            fullOrder = "";
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
        }
    }
}
