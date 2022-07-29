using System;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class FileProvider
    {       
        public static void Replace(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static bool Exist(string fileName)
        {
            return File.Exists(fileName);
        }

        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        public static void Clear(string fileName)
        {
            File.Delete(fileName);
        }
    }
}
