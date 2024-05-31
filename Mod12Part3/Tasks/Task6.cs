namespace Mod12Part3
{
    internal class Task6
    {
        public static void Tass3()
        {
            Console.Write("Введіть шлях для відображення: ");
            string folderPath = Console.ReadLine();

            if (Directory.Exists(folderPath))
            {
                DisplayDirectory(folderPath, 0);
            }
            else
            {
                Console.WriteLine("Папка не знайдена.");
            }
        }

        static void DisplayDirectory(string path, int indentLevel)
        {
            string indent = new string(' ', indentLevel * 2);

            //файли
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine($"{indent}{Path.GetFileName(file)}");
            }

            //підпапки
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                Console.WriteLine($"{indent}{Path.GetFileName(directory)}");
                DisplayDirectory(directory, indentLevel + 1);
            }
        }
    }
}
