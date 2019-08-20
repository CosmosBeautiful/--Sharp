using System;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil_1 = new ExcelentPupil();
            Pupil pupil_2 = new GoodPupil();

            ClassRoom classRoom = new ClassRoom(new Pupil[] { pupil_1, pupil_2 });

            Console.WriteLine("Study");
            classRoom.Study();
            
            Console.WriteLine("Read");
            classRoom.Read();

            Console.ReadKey();
        }
    }
}

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс, представляющий учебный класс ClassRoom.  
//Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.