using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023,09,02);
            Credit cre = new Credit();
            String t = cre.fio;
            String[] words = t.Split(new char[] { ' ', ',' });
            Console.WriteLine("Запоните данные:");

            Console.Write("Введите номер каарты:");
            try
            {
                string n = cre.Number= Convert.ToString(Console.ReadLine());
                if(n.Length!=16)
                {
                    throw new Exception("Неверно введён номер карты");
                }
            }
            catch(Exception s)
            {
                Console.WriteLine(s.Message);
            }

            Console.Write("Введите ФИО владельца:");
            try
            {
                string f = cre.Fio = Convert.ToString(Console.ReadLine());
                if(words!=3)
                {
                    throw new Exception("Неверно введено ФИО");
                }
            }
            catch(Exception f)
            {
                Console.WriteLine(f.Message);
            }

            Console.Write("Введите CVC:");
            try
            {
                string c = cre.Cvc = Convert.ToString(Console.ReadLine());
                if(c.Length==3)
                {
                    throw new Exception("Неверно введено cvc");
                }
            }
            catch(Exception c)
            {
                Console.WriteLine(c.Message);
            }

            Console.Write("Введите дату окончания работы карты:");
            try
            {
                string d = cre.Date = Convert.ToString(Console.ReadLine());
                if(d >= dt)
                {
                    throw new Exception("Неверно введена дата");
                }
               
            }
            catch(Exception d)
            {
                Console.WriteLine(d.Message);
            }

            cre.printcredit();
        }
    }
    class Credit
    {
        public void printcredit()
        {
            Console.WriteLine($"Номер карты: {number}");
            Console.WriteLine($"ФИО владельца: {fio}");
            Console.WriteLine($"CVC: {cvc}");
            Console.WriteLine($"Дата завершения работы карты: {date}");
        }
        public string number = "0000000000000000";
        public string fio = "F I O";
        public string cvc = "000";
        public string date = "01.01.2000";

        public string Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
        public string Fio
        {
            set
            {
                fio = value;
            }
            get
            {
                return fio;
            }
        }
        public string Cvc
        {
            set
            {
                cvc = value;
            }
            get
            {
                return cvc;
            }
        }
        public string Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
    }
}