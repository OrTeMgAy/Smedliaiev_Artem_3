//Створити об'єкт класу Коло, використовуючи класи Точка, Окружність.
//Методи: задання розмірів, зміна радіуса, визначення належності точки даного кола.


using lab_3;

Circle kolo = new Circle();

for (; ; )
{
    kolo.GetInfo();
    Console.WriteLine("Виберiть дiю:");
    Console.WriteLine("Задання параметрiв - 1 | Змiна радiусу - 2 | Перевiрка точки на належнiсть до кола - 3 | Завершити роботу - 4");
    string a = Console.ReadLine();
    if(a == "1")
    {
        kolo.Setting();
    }
    else if(a == "2")
    {
        kolo.RadiusChange();
    }
    else if (a == "3")
    {
        kolo.PointCheck();
    }
    else if(a == "4")
    {
        break;
    }
}
Console.ReadKey();


