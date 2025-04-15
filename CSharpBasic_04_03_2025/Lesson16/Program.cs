using System.Text;

namespace Lesson16;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.OutputEncoding.EncodingName);
        Console.WriteLine(Console.InputEncoding.EncodingName);

        Console.WriteLine(Console.OutputEncoding.EncodingName);
        Console.WriteLine(Console.InputEncoding.EncodingName);

        ReadFileContentWithStreamReader();
    }

    public static void ReadAllFileContent()
    {

        //string absoluteFilePath = @"D:/Projects/Hillel/HillelSchoolLessons/CSharpBasic_04_03_2025/Lesson16/files/data.txt";

        //Path.Combine("files", "data.txt");
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

    public static void ReadFileContentByLines()
    {
        string filePath = "./files/data.txt";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Файл не знайдено.");
        }
    }

    public static void ReadFileContentWithStreamReader()
    {
        string filePath = "./files/data.txt";

        using StreamReader reader = new StreamReader(filePath);

        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
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

    public static void ReadFileByChunks()
    {
        // The same.
        //Path.Combine("files", "data.txt");
        string filePath = "./files/data.txt";

        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            byte[] buffer = new byte[1024]; // Розмір чанку (1 КБ) 1024 byte == 1KB
            int bytesRead;

            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Обробка чанку (наприклад, запис у інший файл або обчислення хешу)

                string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine(content);
                Console.WriteLine("Next Chunk of 1024KB: ");
                Console.WriteLine();
            }
        }
    }

    public static void CreateFile(string fileName)
    {
        var path = Path.Combine("D:", fileName);
        if (File.Exists(path))
        {
            return;
        }

        // Creating file.
        using var fileStream = File.Create(path);

        // Writing to file.
        // Second parameter is optional, by default UTF8.
        using var writer = new StreamWriter(fileStream, Encoding.UTF8);

        writer.WriteLine("Hello File");
        writer.WriteLine("Created");
    }

    public static void CreateDirectory(string folderName)
    {
        var path = Path.Combine("D:", folderName);
        if (Directory.Exists(path))
        {
            return;
        }

        DirectoryInfo directoryInfo = Directory.CreateDirectory(path);

        Console.WriteLine($"Creation Time: {directoryInfo.CreationTime}");
    }

    public static void FileInfoExample()
    {
        var path = Path.Combine("files", "data.txt");

        try
        {
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Console.WriteLine($"Ім'я файлу: {fileInfo.Name}");
                Console.WriteLine($"Розмір файлу: {fileInfo.Length} байт");
                Console.WriteLine($"Дата створення: {fileInfo.CreationTime}");
                Console.WriteLine($"Дата останньої зміни: {fileInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("Файл не існує.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    public static void WriteBinaryData()
    {
        string filePath = "sample.bin";

        // Запис у бінарний файл
        byte[] dataToWrite = { 0x48, 0x65, 0x6C, 0x6C, 0x6F }; // "Hello" у байтах
        File.WriteAllBytes(filePath, dataToWrite);

        // Читання з бінарного файлу
        byte[] readData = File.ReadAllBytes(filePath);
        string content = Encoding.UTF8.GetString(readData);
        Console.WriteLine(content); // Виведе "Hello"
    }

}
