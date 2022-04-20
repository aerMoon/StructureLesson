using System;

namespace _4_StructureToString
{
    struct MyStruct
    {
        public string name;
        public int code;
        public MyStruct(string name, int code)
        {
            this.name=name;
            this.code=code;
        }
        // переопределение метода ToString():
        public override string ToString()
        {
            string txt = $"экземпляр \"{name}\"\n" +
                $"содержит {code}\n";
            return txt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct A = new MyStruct("структура 1", 100);
            Console.WriteLine(A);
        }
    }
}
