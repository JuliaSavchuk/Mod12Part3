namespace Mod12Part3
{
    internal class Task3
    {
        public static void Tass2()
        {
            Console.Write("Введіть шлях до папки: ");
            string folderPath = Console.ReadLine();

            Console.Write("Введіть маску для пошуку файлів для видалення (наприклад, *.txt): ");
            string searchPattern = Console.ReadLine();

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);
                Console.WriteLine("Видаляємо файли:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                    File.Delete(file);
                }

                Console.WriteLine("Видаляємо підпапки:");
                string[] directories = Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories);
                foreach (string directory in directories)
                {
                    Console.WriteLine(directory);
                    Directory.Delete(directory, true);
                }
            }
            else
            {
                Console.WriteLine("Папка не знайдена.");
            }
        }
    }
}
