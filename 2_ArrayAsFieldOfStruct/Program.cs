using System;

namespace _2_ArrayAsFieldOfStruct
{
    struct Word
    {
        public char[] symbols;  //ссылка на символьный массив

        public void Show()      //метод для отображения содержимого массива
        {
            foreach (char c in symbols)
            {
                Console.Write($"-{c}");
            }
            Console.WriteLine("-");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Word w1, w2;    // создание объектов структуры

            w1.symbols = new char[7];   //присвоение ссылки на массив полю
            for(int i = 0; i < 7; i++)  //заполнение массива
            {
                w1.symbols[i] = (char)('o'+ i);
            }

            Console.WriteLine("экземпляр w1:");
            w1.Show();  //вывод содержимого массива

            w2 = w1;    //присвоение экземпляров структуры

            Console.WriteLine("экземпляр w2:");
            w2.Show();  //содержимое массива второго объекта

            Console.WriteLine("\nмассив является ссылочным объектом, общим для w1 и w2:\n");

            //присваивание значений элементам массивов объектов структур
            w1.symbols[0] = '!';
            w2.symbols[w2.symbols.Length-1] = '#';

            Console.WriteLine("экземпляр w1:");
            w1.Show();  

            Console.WriteLine("экземпляр w2:");
            w2.Show();  

        }
    }
}
