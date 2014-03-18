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
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Невозможно найти часть файла или каталога:");
                    Console.WriteLine(e.Message);
                }
                catch (DriveNotFoundException e)
                {
                    Console.WriteLine("Попытка доступа к недоступному диску или данным совместного пользования:");
                    Console.WriteLine(e.Message);
                }
                catch (EndOfStreamException e)
                {
                    Console.WriteLine("Попытка выполнить чтение за пределами потока:");
                    Console.WriteLine(e.Message);
                }
                catch (FileLoadException e)
                {
                    Console.WriteLine("Управляемая сборка найдена, но не может быть загружена:");
                    Console.WriteLine(e.Message);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Попытка доступа к файлу, не существуещему на диске:");
                    Console.WriteLine(e.Message);
                }
                catch (PathTooLongException e)
                {
                    Console.WriteLine("Путь или имя файла превышает максимальную длину, определенную системой:");
                    Console.WriteLine(e.Message);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Произошла ошибка ввода-вывода:");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Файл не может быть прочитан:");
                    Console.WriteLine(e.Message);
                }
            }
            else { Console.WriteLine("Файл не найден"); }
            Console.ReadLine();
        }
    }
}