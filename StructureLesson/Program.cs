using System;

namespace StructureLesson
{
    //структура, описывающая ученика
    struct Pupil
    {
        public int id;      //поле идентификатора
        public string name; //поле имени

        public Pupil (int n, string t) //конструктор структуры
        {
            id = n; 
            name = t; 
        }

        public void Show() //метод структуры
        {
            Console.WriteLine($"идентификатор ученика {name}: {id}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1;     //создание экземпляра структуры

            pupil1.name =  "Иванов И.И.";   //присваивание значений полям
            pupil1.id = 1032;
            pupil1.Show();                 //вызов метода структуры

            Console.WriteLine("____________________________________________");

            Pupil pupil2 = new Pupil(1033, "Петров П.П.");     //создание экземпляра структуры
            pupil2.Show();                 //вызов метода структуры

            Console.WriteLine("____________________________________________");

            pupil1 = pupil2;    //присваивание экземпляров структур
            pupil2.id = 1000;   //присваивание значения полю
            pupil1.Show();
            pupil2.Show();
        }
    }
}
