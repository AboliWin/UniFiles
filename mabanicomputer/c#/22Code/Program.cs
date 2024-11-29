int n;
int a;
int max;
int b, c;
int i;
int j;
do
{
    Console.Clear();
    Console.WriteLine("1) max 2 number ");
    Console.WriteLine("2) max 3 number ");
    Console.WriteLine("3) max n number ");
    Console.WriteLine("4) majmoe adad kochektar az 1 adad ");
    Console.WriteLine("5) factoriel 1 adad ");
    Console.WriteLine("6) maghsom alieh 1 adad ");
    Console.WriteLine("7) majmoe maghsom alieh 1 adad ");
    Console.WriteLine("8) tedad maghsom alieh 1 adad ");
    Console.WriteLine("9) aval bodan 1 adad ");
    Console.WriteLine("10) adad aval bain 1 ta 100 ");
    Console.WriteLine("11) adad aval bain 2 adad ");
    Console.WriteLine("12) maghsom alihe moshtarek 2 adad");
    Console.WriteLine("13) BMM 2 adad");
    Console.WriteLine("14) KMM 2 adad");
    Console.WriteLine("15) chap adad arayeh");
    Console.WriteLine("16) jame adad arayeh");
    Console.WriteLine("17) max adad arayeh");
    Console.WriteLine("18) tedad zoje va fard arayeh");
    Console.WriteLine("19) moratab sazi arayeh");
    Console.WriteLine("20) arayeh barax");
    Console.WriteLine("21) adad darr arayeh");
    Console.WriteLine("22) jame 2 adad dar arayeh");
    Console.WriteLine("please enter number menu :");

    n = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (n)
    {
        case 1:
            Console.Write("program max 2 number \n ---------------------\n");
            Console.Write("please enter number 1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter number 2 :");
            b = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (b > max)
            {
                max = b;
            }
            Console.WriteLine("max : {0}", max);

            Console.ReadKey();
            break;

        case 2:
            Console.Write("program max 3 number \n ---------------------\n");
            Console.Write("please enter number 1 :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter number 2 :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter number 3 :");
            c = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine("max : {0}", max);
            Console.ReadKey();
            break;

        case 3:
            Console.Write("program max n number \n ---------------------\n");
            Console.Write("please enter number :");
            max = 0;
            for (i = 1; i <= n; i++)
            {
                if (n > max)
                {
                    max = n;
                }
                Console.WriteLine("max : {0}", max);
            }
            Console.ReadKey();
            break;

        case 4:
            Console.Write("majmoe adad kochektar az 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 0;
            for (i = 1; i <= n; i++)
            {
                c = c + i;
            }
            Console.Write(c);
            Console.ReadKey();
            break;

        case 5:
            Console.Write("factoriel 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 1;
            for (i = 1; i <= n; i++)
            {
                c = c * i;
            }
            Console.Write(c);
            Console.ReadKey();
            break;

        case 6:
            Console.Write("maghsom alieh 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 1;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            break;

        case 7:
            Console.Write("majmoe maghsom alieh 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = c + i;
                }
                Console.WriteLine(c);
            }
            Console.ReadKey();
            break;

        case 8:
            Console.Write("tedad maghsom alieh 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
                Console.WriteLine(c);
            }
            Console.ReadKey();
            break;

        case 9:
            Console.Write("aval bodan 1 adad \n ---------------------\n");
            Console.Write("please enter number :");
            c = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                    if (c == 2)
                    {
                        Console.WriteLine("{0} adad aval hast");
                    }
                }
            }
            Console.ReadKey();
            break;

        case 10:
            Console.Write("adad aval bain 1 ta 100 \n ---------------------\n");
            c = 0;
            for (j = 1; j <= 100; j++)
            {
                for (i = 1; i <= 100; i++)
                {
                    if (j % i == 0)
                    {
                        c++;
                        if (c == 2)
                        {
                            Console.WriteLine(j);
                        }
                    }
                }
            }
            Console.ReadKey();
            break;
    }

} while (n != 0);