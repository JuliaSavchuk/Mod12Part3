namespace Mod12Part3
{
    internal class Task1
    {
        public static void Tass1()
        {
            Console.Write("Введіть шлях до папки: ");
            string folderPath = Console.ReadLine();

            Console.Write("Введіть маску для пошуку (наприклад, *.txt): ");
            string searchPattern = Console.ReadLine();

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);
                Console.WriteLine("Знайдені файли:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Папка не знайдена.");
            }
        }
    }
}
