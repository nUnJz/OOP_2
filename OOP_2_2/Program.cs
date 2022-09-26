using System;

namespace OOP_2_2
{
    class Converter
    {
        public double usd;
        public double eur;
        public double rub;

        public Converter(double usd, double eur, double rub) //конструктор
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
    }
    class Program
    {
        static double Div(double k, long N) // k - курс валюти, N - кількість гривень для конвертації
        {
            return N / k;
        }
        static double Mult(double k, long N)
        {
            return N * k;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Converter c = new Converter(36.56, 36.07, 0.61); // екземпляр класу
            double k;
            long N;
            int v; // номер варіанту вибору
            double S; // сума до виплати після конвертації
            Console.Write("Виберіть один варіант конвертації грошей та натисніть відповідну цифру v =  \n" +
                          "UAH -> USD - 1 \n" +
                          "UAH -> EUR - 2 \n" +
                          "UAH -> RUB - 3 \n" +
                          " \n" +
                          "USD -> UAH - 4 \n" +
                          "EUR -> UAH - 5 \n" +
                          "RUB -> UAH - 6 \n" +
                          "");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введіть суму грошових одиниць, яку ви конвертуєте N = ");
            N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            if (v == 1)
            {
                k = c.usd;
                S = Div(k, N);
                Console.WriteLine("Сума до виплати в UDS: {0:f2}", S);
            }
            if (v == 2)
            {
                k = c.eur;
                S = Div(k, N);
                Console.WriteLine("Сума до виплати в EUR: {0:f2}", S);
            }
            if (v == 3)
            {
                k = c.rub;
                S = Div(k, N);
                Console.WriteLine("Сума до виплати в RUB: {0:f2}", S);
            }
            if (v == 4)
            {
                k = c.usd;
                S = Mult(k, N);
                Console.WriteLine("Сума до виплати в UAH: {0:f2}", S);
            }
            if (v == 5)
            {
                k = c.eur;
                S = Mult(k, N);
                Console.WriteLine("Сума до виплати в UAH: {0:f2}", S);
            }
            if (v == 6)
            {
                k = c.rub;
                S = Mult(k, N);
                Console.WriteLine("Сума до виплати в UAH: {0:f2}", S);
            }
            Console.ReadLine();
        }
    }
}