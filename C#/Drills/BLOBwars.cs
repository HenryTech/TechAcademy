using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BLOBStream
{
    [Serializable]
    public class MyObject
    {
        public int n1 = 0;
        public int n2 = 0;
        public String str = null;        
    } 
    class Program
    {
        static void Main(string[] args)
        {
            MyObject obj = new MyObject();
            obj.n1 = 1;
            obj.n2 = 24;
            obj.str = "Some words";

            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();

            Stream unpack = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            MyObject unpackedObj = (MyObject)formatter.Deserialize(unpack);
            unpack.Close();

            Console.WriteLine("n1: {0}", unpackedObj.n1);
            Console.WriteLine("n2: {0}", unpackedObj.n2);
            Console.WriteLine("str: {0}", unpackedObj.str);

        }
    }
}
