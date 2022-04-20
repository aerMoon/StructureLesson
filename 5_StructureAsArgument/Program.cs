using System;

namespace _5_StructureAsArgument
{
    struct MyStruct
    {
        public char[] name;
        public int code;
        public MyStruct(string t, int n)
        {
            name=t.ToCharArray();
            code=n;
        }
    }

    internal class Program
    {
        /// <summary>
        /// отображает значения полей экземпляра структуры переданного аргументом
        /// </summary>
        /// <param name="A"></param>
        static void Show (MyStruct A)
        {
            string txt = new string(A.name);
            Console.WriteLine($"символьный массив {txt}");
            Console.WriteLine($"числовое поле {A.code}");
        }

        /// <summary>
        /// метод записывает новые значения в поля экземпляра структуры 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="k"></param>
        /// <param name="s"></param>
        static void Maker(MyStruct A, ref MyStruct B, int k, char s)
        {
            Console.WriteLine($"первый аргумент:"); Show(A);
            Console.WriteLine($"второй аргумент:"); Show(B);    

            A.name[k] = B.name[k] = s;
            A.code++; B.code++;
            
            Console.WriteLine();

            Console.WriteLine($"первый аргумент:"); Show(A);
            Console.WriteLine($"второй аргумент:"); Show(B);
        }

        static void Main(string[] args)
        {
            MyStruct A = new MyStruct("структура 1", 100);
            MyStruct B = new MyStruct("структура 2", 200);

            Maker(A, ref B, 4, '*');

            Console.WriteLine("_____________________________________________");    
            Show(A);
            Show(B);    
        }
    }
}
