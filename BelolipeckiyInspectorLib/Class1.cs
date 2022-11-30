using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        string Name_of_Inspection = "Автоинспекция г. Чита";
        string Name_of_MainInspector = "Васильев В.И.";
        string[] Name_of_Inspectors = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };

        public string SetInspector()
        {
            string List_of_Inspectors = "";

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                        //Создаётся цикл для создания списка сотрудников в массиве
            {
                List_of_Inspectors += Name_of_Inspectors[i];
            }

            string fullname = "";
            Console.WriteLine($"Выберите ФИО инспектора из представленных {List_of_Inspectors}") ;
            string fullnameinsp = Console.ReadLine();

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                          //Объявляется цикл для перебора нужного элемента массива
            {
                if (Name_of_Inspectors[i] == fullnameinsp)
                {
                    Name_of_MainInspector.Remove(0);
                    Name_of_MainInspector = Name_of_Inspectors[i];
                }
            }
            Console.WriteLine($"Главный инспектор - {Name_of_MainInspector}");
            return Name_of_MainInspector;
        }

        public string GetInspector()
        {
            Name_of_MainInspector = Name_of_Inspectors[3];                                              //Выбирается необходимый объект массива
            Console.WriteLine($"Главный инспектор - {Name_of_MainInspector}");
            return Name_of_MainInspector;
        }

        public string GetCarInspection()
        {
            Console.WriteLine($"Название инспекции - {Name_of_Inspection}");
            return Name_of_Inspection;
        }

        public string GenerateNumber()
        {
            int number;
            string symbol = "";
            int code;

            Random rand = new Random();
            number = rand.Next(10, 99);                                                                 //Выбираются рандомные числа от 10 до 99
            int symbValue = rand.Next(0, 26);                                                          //Выбираются рандомные числа от 0 до 26
            char letter = Convert.ToChar(symbValue + 65);

            symbol = symbol + letter;

            code = 75;

            string gen_num = $"{symbol + number + "/" + code}";
            Console.WriteLine(gen_num);
            return gen_num;
        }

        public string GetWorker()
        {
            string List_of_Inspectors = "";

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                        //Создаётся цикл для создания списка сотрудников в массиве
            {
                List_of_Inspectors += Name_of_Inspectors[i];
            }
            Console.WriteLine(List_of_Inspectors);
            return List_of_Inspectors;
        }
        
        public void AddWorker()
        {
            Console.WriteLine("Введите имя инспектора");
            string member = Console.ReadLine();
            Array.Resize(ref Name_of_Inspectors, Name_of_Inspectors.Length + 1);                      //Расширение массива
            Name_of_Inspectors[Name_of_Inspectors.Length - 1] = member;

            string List_of_Inspectors = "";

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                        //Создаётся цикл для создания списка сотрудников в массиве
            {
                List_of_Inspectors += Name_of_Inspectors[i];
            }
            Console.WriteLine(List_of_Inspectors);
        }
    }
}