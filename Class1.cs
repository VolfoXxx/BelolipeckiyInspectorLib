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
        string[] Name_of_Inspectors = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."};

        public string SetInspector(string fullname)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==1)
            {
                fullname = Name_of_Inspectors[0];
                Name_of_MainInspector = fullname;
                return Name_of_MainInspector;
            }
            else
            if(a==2)
            {
                fullname = Name_of_Inspectors[1];
                Name_of_MainInspector = fullname;
                return Name_of_MainInspector;
            }
            else
            if (a == 3)
            {
                fullname = Name_of_Inspectors[2];
                Name_of_MainInspector = fullname;
                return Name_of_MainInspector;
            }
            else
            if (a == 4)
            {
                fullname = Name_of_Inspectors[3];
                Name_of_MainInspector = fullname; ;
                return Name_of_MainInspector;
            }
            else
            {
                Console.WriteLine("Выбранно неверное число - ");
                return Convert.ToString(a);
            }
        }

        public string GetInspector()
        {
            return Name_of_MainInspector;
        }

        public string GetCarInspection()
        {
            return Name_of_Inspection;
        }

        public string GenerateNumber(int number, string symbol, int code)
        {
            Console.WriteLine("Введите автомобильный номер");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите автомобильные символы");
            symbol = Console.ReadLine();
            Console.WriteLine("Введите автомобильный регион");
            code = Convert.ToInt32(Console.ReadLine());

            string gen_num = $"{symbol.ToUpper() + number + " " + code}";
            return gen_num;
        }
        
        public string GetWorker()
        {
            string List_of_Inspectors = "";

            for (int i = 0; i < Name_of_Inspectors.Length; i++ )
            {
                List_of_Inspectors+=Name_of_Inspectors[i];
            }
            return List_of_Inspectors;
        }

        void AddWorker(string newworker)
        {
            Console.WriteLine("Введите ФИО сотрудника - ");
            newworker = Console.ReadLine();
            Array.Resize(ref Name_of_Inspectors, Name_of_Inspectors.Length + 1);
            Name_of_Inspectors[Name_of_Inspectors.Length - 1] = newworker;
        }

    }
}
