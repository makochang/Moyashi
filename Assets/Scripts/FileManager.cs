using System.IO;

public static class FileManager
{
    public static void WriteString(string path, string data)
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(data);
        writer.Close();
        StreamReader reader = new StreamReader(path);
        reader.ReadToEnd();
        reader.Close();
    }

    public static string ReadString(string path)
    {
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadLine();
            reader.Close();

            return data;
        }
        else
        {
            return "0";
        }
    }
}
