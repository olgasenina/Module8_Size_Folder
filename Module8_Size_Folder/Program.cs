using System;
using System.IO;

namespace Module8_Size_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к каталогу ");

            DirectoryInfo dirInfo = new DirectoryInfo(Console.ReadLine());

            try
            {
                Console.WriteLine($"Папка {dirInfo.Name} - размер {FolderSettings.SizeFolder(dirInfo)} байт");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Не удалось рассчитать размер: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
