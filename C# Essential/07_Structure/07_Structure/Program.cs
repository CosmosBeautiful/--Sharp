namespace Structure
{
    class Program
    {
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
            myStruct.field = "Белый";
            myStruct.connectedField = 70;
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
            myClass.field = "Черный";
            myClass.connectedField = 416;
        }

        static void Main(string[] args)
        {
            //Структура
            MyStruct myStruct; //Объект храниться на кучи.
            
            myStruct.change = "Не изменено";
            myStruct.field = null;
            myStruct.connectedField = 0;
            //Структура, без new. Должна быть проинициализирована пользователем, для дальшей работы с ней.
            StruktTaker(myStruct);


            //Класс
            MyClass myClass = new MyClass(); //Управляемая куча
            ClassTaker(myClass);

        }
    }
}

//Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
//В классе Program  создайте два  метода:  
//- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
//- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
//
//Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.
//Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.
//Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.

