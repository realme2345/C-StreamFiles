using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StreamFilesPrograms
{/// <summary>
/// Serialisation and Deserialisation
/// </summary>
    class BinarySerialization
    {
        //Binary Serialisation Method
        public static void Serialisation()//this method is used for serialisation
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            Person person = new Person();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, person);
        }
        public static void Deserialisation()//this method used for deserialisation
        {
            string path = @"D:\git\C#StreamFiles\C-StreamFiles\StreamFilesPrograms\Sample.txt";
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Person person=(Person)formatter.Deserialize(fileStream);
            Console.WriteLine($"Person:{person.Name}    Id :{ person.Id}");
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; } = "Raja";
        public int Id { get; set; } = 152507;
    }
}
