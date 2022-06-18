using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3._2
{
    internal class School
    {
        List<MusicalInstrument> Instrument = new List<MusicalInstrument>(); //список інструментів в школі
        Dictionary<MusicalInstrument, string> Belonging = new Dictionary<MusicalInstrument, string>();//словник для запису інструментів у яких є власник

        public void Menu()//меню програми
        {
            for (; ; )
            {
                Console.WriteLine("Iнформацiя про iнструменти в школi - 1 | Додати iнструмент - 2 | Знайти iнструмент - 3 | Вiддати iнструмент учню - 4 | Закрити програму - 5");
                string place = Console.ReadLine();
                switch (place)
                {
                    case "1":
                        GetInfo();
                        break;
                    case "2":
                        AddInstrument();
                        break;
                    case "3":
                        SortInstruments();
                        break;
                    case "4":
                        AssignInstrument();
                        break;                                            
                }
                if(place == "5")
                {
                    break;                    
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
        private void GetInfo()
        {
            Console.Clear();
            int WindCount = 0;//духові
            int StringCount = 0;//струнні
            int KeyboardCount = 0;//клавішні
            int ConditionCount = 0;//зламані
            int PercussionCount = 0;//ударні
            foreach (MusicalInstrument instrument in Instrument)
            {
                if(instrument.type == 1)
                {
                    WindCount++;
                }
                else if(instrument.type == 2)
                {
                    StringCount++;
                }
                else if(instrument.type == 3)
                {
                    KeyboardCount++;
                }
                else if(instrument.type == 4)
                {
                    PercussionCount++;  
                }
                if(instrument.condition == false)
                {
                    ConditionCount++;
                }
            }
            Console.WriteLine($"Всього в школi {Instrument.Count} iнструментiв");
            Console.WriteLine($"З них духових - {WindCount}, струнних - {StringCount}, клавiшних - {KeyboardCount}, ударних - {PercussionCount}");
            Console.WriteLine("Несправних iнструментiв - " + ConditionCount);
        }
        private void AddInstrument()//додавання інструменту
        {
            Console.WriteLine("Введiть назву iнструмента");
            string name = Console.ReadLine();  
            foreach (MusicalInstrument instrument in Instrument)//перевіряємо чи є вже інструмент з таким ім'ям
            {
                if (instrument.name == name)
                {
                    Console.WriteLine("Таке iм'я вже iснує даайте нове");
                    name = Console.ReadLine();
                    break;
                }
            }                            
            Console.WriteLine("Введiть тип iнструмента:");
            Console.WriteLine("Духовий - 1 | Струнний - 2 | Клавiшний - 3 | Ударний - 4");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Якщо iнстурмент справний введiть 1, якщо нi щось iнше");
            bool condition = (Console.ReadLine() == "1");
            bool belonging = false;//за замовчуванням інструмент нікому не належить
            Instrument.Add(new MusicalInstrument( name, type, condition, belonging));//додаємо в ліст новий інструмент
            Console.Clear();
            Console.WriteLine("Iнструмент додано");
        }
        private void SortInstruments()//пошук вбо сортування інструменту
        {
            Console.WriteLine("Вiдсортувати");
            Console.WriteLine("Духовi - 1 | Струннi - 2 | Клавiшнi - 3 | Ударнi - 4 | Мають власника - 5 | Несправнi - 6");
            int place = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (place == 1 | place == 2 | place == 3 | place == 4)
            {
                foreach (MusicalInstrument instrument in Instrument)//шукаємо інструменти з вказаними ознаками
                {
                    if (instrument.type == place)
                    {
                        Console.WriteLine($"Iнструмент: {instrument.name} ");
                    }
                }
            }
            else if (place == 5)
            {
                foreach (MusicalInstrument instrument in Instrument)
                {
                    if (instrument.belong == true)
                    {
                        Console.WriteLine($"Iнструмент: {instrument.name} та власник: {Belonging[instrument]}");//виводимо ім'я з словника
                    }
                }
            }
            else if (place == 6)
            {
                foreach (MusicalInstrument instrument in Instrument)
                {
                    if (instrument.condition == false)
                    {
                        Console.WriteLine($"Iнструмент: {instrument.name}");
                    }
                }
            }
        }
        private void AssignInstrument()//присвоєння інструмента учню
        {           
            Console.WriteLine("Ви хочете присвоїти новий - 1 чи вже iснуючий iнструмент - 2?");
            if(Console.ReadLine() == "1")
            {
                AddInstrument();
            }
            for (; ; )//цикл для перевірки чи цей інструмент вжей зайнятий
            {
                bool place = false;
                Console.WriteLine("Введiть назву iнструменту який хочете присвоїти");
                string name = Console.ReadLine();
                foreach (MusicalInstrument instrument in Instrument)
                {
                    if (instrument.belong == true)
                    {
                        Console.WriteLine("Цей iнстурмент вже зайнятий");                       
                        break;
                    }
                    else
                    {
                        place = true;
                    }
                }
                if(place)
                {
                    Console.WriteLine("Введіть iм'я та прiзвище учня");
                    string student = Console.ReadLine();
                    foreach (MusicalInstrument instrument in Instrument)
                    {
                        if (instrument.name == name)
                        {
                            instrument.belong = true;
                            Belonging.Add(instrument, student);//додаємо в словник
                            break;
                        }
                    }
                    break;
                }                
            }
        }
    }
}
