using System;

namespace OOP_2_3
{
    class Employee
    {
        public string surname;
        public string name;
        public Employee(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }
    }
    class Program
    {
        static double Fin(double p, double k)
        {
            return p * (1 + k);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            // створення екземплярa класу
            Employee e = new Employee("Поліщук", "Валентина");
            Console.WriteLine($"{e.surname} {e.name}");
            Console.WriteLine();
            Console.Write("Введіть посаду співробітника: ");
            string str = Console.ReadLine();
            double p; // посадовий оклад співробітника
            double k; // коєфіцієнт доплати за стаж роботи
            int r; // кількість років стажу співробітника
            double S; // оклад співробітника
            double pz; // податковий збір 
            const double kp = 0.18; // коєфіцієнт податкового збору
            Console.Write("Введіть кількість років стажу r = ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введіть посадовий оклад співробітника p = ");
            p = Convert.ToDouble(Console.ReadLine());
            if (3 < r && r <= 10)
            {
                k = 0.1;
                S = Fin(p, k);
                pz = kp * S; // податковий збір
                Console.WriteLine("Оклад співробітника та податковий збір: {0:f2} {1:f2}", S, pz);
            }
            if (10 < r && r <= 20)
            {
                k = 0.2;
                S = Fin(p, k);
                pz = kp * S;
                Console.WriteLine("Оклад співробітника та податковий збір: {0:f2} {1:f2}", S, pz);
            }
            if (r > 20)
            {
                k = 0.3;
                S = Fin(p, k);
                pz = kp * S;
                Console.WriteLine("Оклад співробітника та податковий збір: {0:f2} {1:f2}", S, pz);
            }
            Console.ReadLine();
        }
    }
}