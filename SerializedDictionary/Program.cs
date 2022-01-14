using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializedDictionary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Dictionary<string, string> dictionary = new Dictionary<string, string>()
            //{
            //    {"Space","Пространство" },{"Cherry","Вишня"},{"Blueberry","Голубика"},{"Sport","Спорт"},
            //    {"Air","Воздух" },{"Water","Вода"},{"Shirt","Короткий"},{"Long","Длинный"}
            //};
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key}\t - {item.Value}");
            //}
            //Console.WriteLine(" ");

            //BinaryFormatter formatter = new BinaryFormatter();//двоичное форматирование Dictionary
            //try
            //{
            //    using (Stream st = File.Create("dictionary.bin"))
            //    {
            //        formatter.Serialize(st, dictionary);
            //    }
            //    Console.WriteLine($"BinarySerialize successfully!");
            //    Dictionary<string, string> dic = null;
            //    using (Stream st = File.OpenRead("dictionary.bin"))
            //    {
            //        dic = (Dictionary<string, string>)formatter.Deserialize(st);
            //    }
            //    foreach (var item in dic)
            //    {
            //        Console.WriteLine($"{item.Key}\t - {item.Value}");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //XmlDictionary<string, string> dic = new XmlDictionary<string, string>()//попытка Xml-сериализации Dictionary(неудачная)
            //{
            //        {"Space","Пространство" },{"Cherry","Вишня"},{"Blueberry","Голубика"},{"Sport","Спорт"},
            //        {"Air","Воздух" },{"Water","Вода"},{"Shirt","Короткий"},{"Long","Длинный"}
            //};
            //MyXmlReader xmlReader=new MyXmlReader();//создала экземпляр MyXmlReader(наследованием XmlReader)
            //MyXmlWriter xmlWriter = new MyXmlWriter();//создала экземпляр MyXmlWriter(наследованием XmlWriter)
            //dic.ReadXml(xmlReader);//выбрасывает исключение
            //dic.WriteXml(xmlWriter);

            //Создание объекта, для работы с файлом
            //INIManager managerName = new INIManager(@"C:\Users\Asus\source\repos\SerializedDictionary1\SerializedDictionary\myHuman.ini");

            //Human human1 = new Human();
            //Human human2 = new Human();
            //Human human3 = new Human("Olga",25,3);
            //Console.WriteLine(human3.ToString());
            //Human[] human = {human1,human2,human3 };

            //NewHumanAttribute newHuman =new NewHumanAttribute(@"C:\Users\Asus\source\repos\SerializedDictionary1\SerializedDictionary\myHuman.ini");

            //foreach(var item in human)
            //{
            //    item.Age = newHuman.GetHumanAge();
            //    item.Name = newHuman.GetHumanName();
            //    item.Id = newHuman.GetHumanId();
            //}
            //foreach (var item in human)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // не уверена насколько целесообразно в данном контексте применять атрибут,если это не просто
            //прокачивание навыка
        }
    }   
        
}