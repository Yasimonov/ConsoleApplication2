using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFile
{
    class Program
    {
        static void Main()
        {
            string FileName = Console.ReadLine();
            if (File.Exists(FileName))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(FileName))
                    {
                        String line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Произошла ошибка:");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ФАйл не может быть прочитан:");
                    Console.WriteLine(e.Message);
                }
            }
            else { Console.WriteLine("Файл не найден"); }
            Console.ReadLine();
        }
    }
}