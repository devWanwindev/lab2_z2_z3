using System;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main()
        {

            Console.WriteLine("ВВедите рубли и копейки кошелька 1:");
            string a_s1 = Console.ReadLine();
            string a_s2 = Console.ReadLine();
            if ((uint.TryParse(a_s1, out uint a1)) && (uint.TryParse(a_s2, out uint a2)))
            {
                Money a = new Money(a1, a2);
                Console.WriteLine("ВВедите рубли и копейки кошелька 2:");
                string b_s1 = Console.ReadLine();
                string b_s2 = Console.ReadLine();
                if ((uint.TryParse(b_s1, out uint b1)) && (uint.TryParse(b_s2, out uint b2)))
                {
                    Money b = new Money(b1, b2);
                    Console.WriteLine("ВВедите рубли и копейки кошелька 3:");
                    string c_s1 = Console.ReadLine();
                    string c_s2 = Console.ReadLine();
                    if ((uint.TryParse(c_s1, out uint c1)) && (uint.TryParse(c_s2, out uint c2)))
                    {
                        Money c = new Money(c1, c2);

                        Console.WriteLine("Деньги в кошельках:");
                        a.Print();
                        b.Print();
                        c.Print();

                        //Console.WriteLine("\nСравнение:");
                        //Console.WriteLine("У кого больше? (Денег):");
                        //Console.WriteLine($"a vs b: {Money.Srav(a, b)}");
                        //Console.WriteLine($"b vs c: {Money.Srav(b, c)}");

                        // Унарные операции:
                        Console.WriteLine("\nУнарные операции:");
                        a++;
                        Console.Write("a++: ");
                        a.Print();  //+рубль

                        b--;
                        Console.Write("b--: ");
                        b.Print();  //-копейка

                        // Операции приведения типа:
                        Console.WriteLine("\nперации приведения типа:");
                        uint rubles = a; //uint
                        Console.WriteLine($"uint a: {rubles}");

                        double kopeksFraction = (double)b; //double
                        Console.WriteLine($"double b: {kopeksFraction}");

                        // Бинарные операции:
                        Console.WriteLine("\nБинарные операции:");
                        Console.WriteLine("Сколько копеек вычесть из первого кошелька?");
                        string v_s1 = Console.ReadLine();
                        if (int.TryParse(v_s1, out int v)){
                            Money d = a - v;
                            Console.Write($"a - {v} копеек: ");
                            d.Print();  //вычет копеек
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода:");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода:");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода:");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода:");
            }

            

            


            

        }
    }
}
