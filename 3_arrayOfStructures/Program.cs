using System;

namespace _3_arrayOfStructures
{
    struct MyStruct //структура
    {
        public int code;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyStruct[] A = new MyStruct[10]; //массив объектов структур

            for (int i = 0; i < A.Length; i++)
            {
                A[i].code = 2*i+100; //запись в поле структуры
                Console.WriteLine(A[i].code);
            }
        }
    }
}
