using System.Text;

namespace Lesson16;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static void ReadFileContent()
    {
        //string absoluteFilePath = @"D:/Projects/Hillel/HillelSchoolLessons/CSharpBasic_04_03_2025/Lesson16/files/data.txt";
        string relativeFilePath = @"./files/data.txt";

        try
        {
            string content = File.ReadAllText(relativeFilePath);
            Console.WriteLine("Зміст файлу:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Помилка вводу/виводу: {ex.Message}");
        }
    }

    public static void DisksInformation()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            Console.WriteLine($"Назва: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");

            if (drive.IsReady)
            {
                Console.WriteLine($"Об'єм диска: {drive.TotalSize}");
                Console.WriteLine($"Вільний простір: {drive.TotalFreeSpace}");
                Console.WriteLine($"Мітка диска: {drive.VolumeLabel}");
            }

            Console.WriteLine();
        }
    }

    public static void ReadFileByChuncks()
    {
        string filePath = "largefile.txt";

        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            byte[] buffer = new byte[1024]; // Розмір чанку (1 КБ) 1024 byte == 1KB
            int bytesRead;

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Обробка чанку (наприклад, запис у інший файл або обчислення хешу)

                string content = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                Console.WriteLine(content);
                // ...
            }
        }
    }
}
