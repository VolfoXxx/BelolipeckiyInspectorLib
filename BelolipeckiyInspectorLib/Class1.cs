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
        string Name_of_MainInspector;
        string[] Name_of_Inspectors = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };

        public FunctionInsp() => Name_of_MainInspector = Name_of_Inspectors[Name_of_Inspectors.Length - 1];

        public string SetInspector(string fullname)
        {
            string List_of_Inspectors = "";

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                        //Создаётся цикл для создания списка сотрудников в массиве
            {
                List_of_Inspectors += Name_of_Inspectors[i];
            }

            Console.WriteLine($"Выберите ФИО инспектора из представленных {List_of_Inspectors}") ;
            fullname = Console.ReadLine();

            for (int i = 0; i < Name_of_Inspectors.Length; i++)                                          //Объявляется цикл для перебора нужного элемента массива
            {
                if (Name_of_Inspectors[i] == fullname)
                {
                    Name_of_MainInspector = Name_of_Inspectors[i];
                }
            }
            Console.WriteLine($"Главный инспектор - {Name_of_MainInspector}");
            return Name_of_MainInspector;
        }

        public string GetInspector()
        {
            Console.WriteLine($"Главный инспектор - {Name_of_MainInspector}");
            return Name_of_MainInspector;
        }

        public string GetCarInspection()
        {
            Console.WriteLine($"Название инспекции - {Name_of_Inspection}");
            return Name_of_Inspection;
        }

        public string GenerateNumber(int number, string symbol, int code)
        {
            string gen_num = $"{symbol + "" +  number + "/" + code}";
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