using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // быстрый коммент ctrl + shift + /

            /*Console.WriteLine("Hello World!");
            string YourName = Console.ReadLine();
            Console.WriteLine($"Hello {YourName}");*/



            /*int age = 12;
            double height = 75.1;
            Console.WriteLine("Рост {0} и вес {1}", age, height);*/


            // конвертация так как метод ReadLine записывает в string
            /*Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);*/


            // инкремент
            /*int x = 5;
            int x1 = x++;
            Console.WriteLine(x);
            Console.WriteLine(x1);*/

            // 1 способ условия
            /*            Console.WriteLine("Enter Y or N");
                        string key = Console.ReadLine();
                        if (key == "Y")
                        {
                            Console.WriteLine("You entered Y");
                        }
                        else if  (key == "N")
                        {
                            Console.WriteLine("You entered N");
                        }
                        else
                            Console.WriteLine("You entered None");*/

            // 2 способ условия
            /*Console.WriteLine("Enter Y or N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("You entered Y");
                    break;
                case "N":
                    Console.WriteLine("You entered N");
                    break;
                default:
                    Console.WriteLine("You entered None");
                    break;
            }*/

            // -----------------------------------------------------

            //1

            /*            int a, b, c, d = 1;
                        string s;
                        s = Console.ReadLine();
                        a = Convert.ToInt32(s);
                        s = Console.ReadLine();
                        b = Convert.ToInt32(s);
                        s = Console.ReadLine();
                        c = Convert.ToInt32(s);
                        d *= a + b + c;
                        a += d;
                        c = d - a;
                        int k = 2 * b + c;
                        Console.WriteLine("Values: " + a + "," + c + "," + d + "," + k);*/

            //2

            /*            int Dlina = 9;
                        double Shirina = 7.5;
                        int Visota = 5;
                        double Result = Dlina * Shirina * Visota;
                        Console.WriteLine(Result);
                        Console.ReadLine();*/

            //5

            /*            double s;
                        double Cena, Rast, Rasx;

                        Console.WriteLine("Расстояние до дачи");
                        Rast = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Расход топлива");
                        Rasx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Цена литра бензина");
                        Cena = Convert.ToDouble(Console.ReadLine());
                        s = Rasx / 100 * Rast * Cena;
                        Console.WriteLine(s * 2);*/


            //7


            /*            Console.WriteLine("Введите сумму вклада");
                        double Vklad = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Срок вклада");
                        int TimeVklad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Процентная ставка");
                        double Stavka = Convert.ToDouble(Console.ReadLine());

                        double dohod = Vklad / 100 * Stavka / 365 * TimeVklad;
                        double result = Vklad + dohod;

                        Console.WriteLine($"Доход {dohod}");
                        Console.WriteLine($"Сумма по окончанию срока вклада {result}");
                        Console.ReadLine(); */

            //9

/*            double Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Num + "0");*/

            // -------------------------------------------------------------------

            /*            Console.WriteLine("Введите число больше 5 и меньше 10");
                        double Nasvay = Convert.ToDouble(Console.ReadLine());

                        if (Nasvay > 5 && Nasvay < 10) 
                        {
                            Console.WriteLine("Число больше пяти и меньше десяти");
                        }
                        else
                        {
                            Console.WriteLine("Число не входит в диапазон");
                            Console.ReadKey
                                ();
                        }*/

            /*            Console.WriteLine("Введите сумму вклада");
                        double Vklad = Convert.ToDouble(Console.ReadLine());
                        if (Vklad < 100)
                        {
                            Vklad += Vklad * 0.05;
                        }
                        else if (Vklad <= 200)
                        {
                            Vklad += Vklad * 0.07;
                        }
                        else
                        {
                            Vklad += Vklad * 0.1;
                        }
                        Vklad += Vklad * 0.15;
                        Console.WriteLine($"Сумма вклада после начисления процентов: {Vklad}");
                        Console.ReadKey();*/

            //10 --------------------------------------------------------------------------------

            /*Console.Write("Введите значение выражений: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double B = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double C = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double P = A + B + C;
            double Formula1 = Math.Sqrt((P / 2 * (P / 2 - A) * (P / 2 - B) * (P / 2 - C)));

            Console.WriteLine(Formula1);*/

            //8 ---------------------------------------------------------------------------

            /* Console.WriteLine("Введите время в минутах");
             double Hours = Convert.ToDouble(Console.ReadLine());
             Hours = Hours / 60;
             int Hours1 = (int)Hours;
             double Minutes = (Hours - (int)Hours) * 60;
             Console.WriteLine($"Часы: {Hours1} Минуты {Minutes}");
            */




        }
    }
}
