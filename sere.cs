using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    public class student
    {
        public string Name = "DeviMukepshene";
        public int age = 25;
        public int id = 01;
        public string gender = "Female";
    }
    internal class sere
    {
        public void SeritoFile()
        {
            student sobj = new student();
            FileStream fs = new FileStream("Student.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, sobj);
            fs.Close();
        }
        public void DeserialData()
        {
            FileStream fs = new FileStream("Student.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            student stu = (student)f.Deserialize(fs);
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.gender);


        }

        public static void Main()
        {
            sere obj = new sere();
            obj.SeritoFile();
            obj.DeserialData();
            Console.Read();
        }
    }
}
