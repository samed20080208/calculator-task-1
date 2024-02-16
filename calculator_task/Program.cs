sbyte secim1 = 1;
bool isWhileTrue1 = true;

while (isWhileTrue1)
{
    Console.Clear();

    switch (secim1)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

    Console.WriteLine("\t\t\tCalculator");

    switch (secim1)
    {
        case 0:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

    Console.WriteLine("\n\t\t\tExit Program");

    ConsoleKeyInfo kbKey = Console.ReadKey(true);

    switch (kbKey.Key)
    {
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            secim1++;
            if (secim1 > 1) secim1 = 0;
            break;
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            secim1--;
            if (secim1 < 0) secim1 = 1;
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            secim1++;
            if (secim1 > 1) secim1 = 0;
            break;
        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            secim1--;
            if (secim1 < 0) secim1 = 1;
            break;
        case ConsoleKey.Enter:
            sbyte secim2 = 0;

            switch (secim1)
            {
                case 1:
                    bool isWhileTrue2 = true;

                    while (isWhileTrue2)
                    {
                        Console.Clear();

                        switch (secim2)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        Console.WriteLine("\n\n\t\t\tExit");
                        switch (secim2)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            default:

                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        Console.WriteLine("\n\t\tToplama +");

                        switch (secim2)
                        {
                            case 2:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;

                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.White;

                                break;
                        }
                        Console.WriteLine("\n\t\tCixma -");

                        switch (secim2)
                        {
                            case 3:
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        Console.WriteLine("\n\t\tVurma *");

                        switch (secim2)
                        {
                            case 4:

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            default:

                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                        Console.WriteLine("\n\t\tBolme /");

                        ConsoleKeyInfo c2_key = Console.ReadKey(true);

                        switch (c2_key.Key)
                        {
                            case ConsoleKey.UpArrow:
                            case ConsoleKey.W:
                                secim2--;
                                if (secim2 < 0) secim2 = 4;
                                break;
                            case ConsoleKey.DownArrow:
                            case ConsoleKey.S:
                                secim2++;
                                if (secim2 > 4) secim2 = 0;
                                break;
                            case ConsoleKey.RightArrow:
                            case ConsoleKey.D:
                                secim2--;
                                if (secim2 < 0) secim2 = 4;
                                break;
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.A:
                                secim2++;
                                if (secim2 > 4) secim2 = 0;
                                break;
                            case ConsoleKey.Enter:
                                if (secim2 == 0)
                                {
                                    Thread.Sleep(1000);
                                    isWhileTrue2 = false;
                                    break;
                                }

                                double number1 = 0.0, number2 = 0.0, cavab = 0.0;
                                char isare = '=';

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("\n\n\t\tEded daxil edin: ");
                                double.TryParse(Console.ReadLine(), out number1);

                                Console.Write("\n\t\tEded daxil edin: ");
                                double.TryParse(Console.ReadLine(), out number2);

                                switch (secim2)
                                {
                                    case 1:
                                        cavab = number1 + number2;
                                        isare = '+';
                                        break;
                                    case 2:
                                        cavab = number1 - number2;
                                        isare = '-';
                                        break;
                                    case 3:
                                        cavab = number1 * number2;
                                        isare = '*';
                                        break;
                                    case 4:
                                        if (number1 == 0 || number2 == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\n\t\t\t0-a Bolmek Olmaz !");
                                            Thread.Sleep(1000);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            continue;
                                        }
                                        cavab = number1 / number2;
                                        isare = '/';
                                        break;
                                }

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n\n\t\t\t{number1} {isare} {number2} = {cavab}");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\n\n\n\t\tPress any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                    }
                    break;
                case 0:
                    Thread.Sleep(1500);
                    isWhileTrue1 = false;
                    break;
            }
            break;
    }
}