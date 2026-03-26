using System;
using System.Threading;
using System.Data;

namespace OverthinkingCalculator;

class Program
{
    public static Random rnd = new();
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        Console.Title = "Overthinking Calculator";
        CoolTextShow("Hello!", 100);
        Thread.Sleep(500);
        CoolTextShowNOENTER("Welcome to", 100);
        CoolTextShow("...", 500);
        Thread.Sleep(1000);
        CoolTextShow("Overthinking calculator!!!", 50);
        Thread.Sleep(1000);

        Console.Clear();

        while (true)
        {
            System.Console.WriteLine("-- OVERTHINKING CALCULATOR --");
            System.Console.WriteLine("[1] - maths (+, -, *, /)");
            System.Console.WriteLine("[2] - cooler math (sin, cos, tan)");
            System.Console.WriteLine("[3] - extra math (Square Root, Modulo, Factorial, Rounding)");
            System.Console.WriteLine("[4] - exit (leaves a poor calculator alone)");
            System.Console.Write("Your choice: ");
            string? choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.Clear();
                    MathSolvs();
                    break;
                case "2":
                    Console.Clear();
                    MathT();
                    break;
                case "3":
                    Console.Clear();
                    MathExtra();
                    break;
                case "4":
                    CoolTextShowNOENTER("Bye bye!", 100);
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                default:
                    CoolTextShow("What are u doing?", 40);
                    Thread.Sleep(700);
                    CoolTextShowNOENTER("try again", 60);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
            }
        }
    }

    static void MathSolvs()
    {
        while (true)
        {
            System.Console.Write("wanna calculate? (Y/N) ");
            string? yn = Console.ReadLine()?.ToUpper();
            int rndForCoolWords = rnd.Next(1, 101);

            if (yn == "Y")
            {
                System.Console.Write("Pls, enter something: ");
                string? numtofind = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(numtofind) || System.Text.RegularExpressions.Regex.IsMatch(numtofind, @"[а-яА-Яa-zA-Z]"))
                {
                    TryingAndCatching("format");
                    continue;
                }
                try
                {
                    DataTable table = new();
                    var result = table.Compute(numtofind, "");
                    if (result == DBNull.Value || result.ToString().Contains("Infinity") || result.ToString().Contains("NaN"))
                    {
                        TryingAndCatching("zero");
                        continue;
                    }
                    ThinkingProcess("T"); // thinks hard
                    if (rndForCoolWords > 10)
                    {
                        System.Console.WriteLine();
                        CoolTextShow("Well, I've done smth", 100);
                        Thread.Sleep(1000);
                        CoolTextShowNOENTER("The result is: ", 150);
                        Thread.Sleep(1000);
                        Console.Write(result);
                    }
                    else
                    {
                        System.Console.WriteLine();
                        CoolTextShow("Well, I've done smth", 100);
                        Thread.Sleep(1000);
                        CoolTextShowNOENTER("The result is: ", 150);
                        Thread.Sleep(1000);
                        Console.Write("Hello World!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        CoolTextShow("ok, jk...", 100);
                        CoolTextShowNOENTER("The result is: ", 150);
                        Console.Write(result);
                    }

                }
                catch (Exception)
                {
                    TryingAndCatching("brainNotFound");
                    continue;
                }
            }
            else if (yn == "N")
            {
                CoolTextShow("uhmh, ok then bye i guess", 100);
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Press any button to continue......");
            Console.ReadKey();
            Console.Clear();
        }

    }
    static void MathT()
    {
        while (true)
        {
            double degrees;
            try
            {
                CoolTextShowNOENTER("Pls write ONE number (degrees): ", 50);
                degrees = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                TryingAndCatching("format");
                continue;
            }
            catch (OverflowException)
            {
                TryingAndCatching("overflow");
                continue;
            }
            catch (Exception)
            {
                TryingAndCatching("brainNotFound");
                continue;
            }

            double radians = degrees * (Math.PI / 180);
            ThinkingProcess("D");

            Console.Clear();

            Console.WriteLine("What you wanna do");
            System.Console.WriteLine("[1] - Sin");
            System.Console.WriteLine("[2] - Cos");
            System.Console.WriteLine("[3] - tan");
            System.Console.WriteLine("-----------");
            System.Console.WriteLine("[4] - cot");
            System.Console.WriteLine("[5] - Sec");
            System.Console.WriteLine("[6] - csc");
            System.Console.WriteLine("[0] - leave (goes back to menu)");
            System.Console.Write(">> ");
            string? choice_T = Console.ReadLine();
            double res = 0;
            string Operation_Name_T = "";

            switch (choice_T)
            {
                case "1":
                    res = Math.Sin(radians);
                    Operation_Name_T = "Sin";
                    break;
                case "2":
                    res = Math.Cos(radians);
                    Operation_Name_T = "Cos";
                    break;
                case "3":
                    res = Math.Tan(radians);
                    Operation_Name_T = "tan";
                    break;
                case "4":
                    res = 1.0 / Math.Tan(radians);
                    Operation_Name_T = "cot";
                    break;
                case "5":
                    res = 1.0 / Math.Cos(radians);
                    Operation_Name_T = "sec";
                    break;
                case "6":
                    res = 1.0 / Math.Sin(radians);
                    Operation_Name_T = "csc";
                    break;
                case "0":
                    Console.Clear();
                    return;
                default:
                    CoolTextShow("I don't know this... Try again", 100);
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            ThinkingProcess("T");
            res = Math.Round(res, 10);
            System.Console.WriteLine();
            CoolTextShow($"Weell, I've done something with {Operation_Name_T} of {degrees} degrees...", 50);
            Thread.Sleep(1000);
            CoolTextShowNOENTER("The result is: ", 50);
            System.Console.WriteLine(res);
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }
    static void MathExtra()
    {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("What u wanna do");
            System.Console.WriteLine("[1] - Square Root \u221A");
            System.Console.WriteLine("[2] - Power x\u00B2");
            System.Console.WriteLine("[3] - Logarithm (ln) \u33D2");
            System.Console.WriteLine("-------------");
            System.Console.WriteLine("[4] - Rounding \u2248");
            System.Console.WriteLine("[5] - Absolute |x|");
            System.Console.WriteLine("[6] - Random Number\uD83C\uDFB2");
            System.Console.WriteLine("[0] - leave (goes back to menu)");
            Console.Write(">> ");

            string? choice = Console.ReadLine();
            double num = 0;
            if (choice != "6" && choice != "0")
            {
                System.Console.Write("Enter a num to work with: ");
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    TryingAndCatching("format");
                    continue;
                }
                catch (OverflowException)
                {
                    TryingAndCatching("overflow");
                    continue;
                }
            }

            double resInExtraMath = 0;


            switch (choice)
            {
                case "1":
                    if (num < 0)
                    {
                        TryingAndCatching("zero");
                        continue;
                    }
                    resInExtraMath = Math.Sqrt(num);
                    break;
                case "2":
                    double Pow = 0;
                    System.Console.Write("Enter the power: ");
                    try
                    {
                        Pow = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        TryingAndCatching("format");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        TryingAndCatching("overflow");
                        continue;
                    }

                    resInExtraMath = Math.Pow(num, Pow);
                    ThinkingProcess("T");
                    break;
                case "3":
                    resInExtraMath = Math.Log(num);
                    break;
                case "4":
                    resInExtraMath = Math.Round(num);
                    break;
                case "5":
                    resInExtraMath = Math.Abs(num);
                    break;
                case "6":
                    System.Console.WriteLine();
                    System.Console.Write("Choose numbers from: ");
                    int numRND = 0;
                    int num2RND = 0;
                    try
                    {
                        numRND = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        TryingAndCatching("format");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        TryingAndCatching("overflow");
                        continue;
                    }

                    System.Console.Write("To: ");
                    try
                    {
                        num2RND = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        TryingAndCatching("format");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        TryingAndCatching("overflow");
                        continue;
                    }

                    if (numRND > num2RND)
                    {
                        CoolTextShow("Error: 'From' cant be greater than 'To'! Try again", 200);
                        Thread.Sleep(1000);
                        continue;
                    }

                    ThinkingProcess("T");
                    resInExtraMath = rnd.Next(numRND, num2RND);
                    break;
                case "0":
                    Console.Clear();
                    return;
                default:
                    CoolTextShow("I dont know this... Try again", 100);
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            if (choice != "0")
            {
                ThinkingProcess("D");
                System.Console.WriteLine();
                System.Console.WriteLine();
                CoolTextShow("Well, I've done something...", 100);
                CoolTextShowNOENTER("The result is: ", 100);
                Console.Write(resInExtraMath);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Press any button to continue......");
            Console.ReadKey();
            Console.Clear();
        }
    }
    static void ShowLoad(string text, int dots) // cool dots for thinking with text too
    {
        string[] frames = { ".  ", ".. ", "...", "   " };
        int frameIndex = 0;
        for (int i = 0; i < dots; i++)
        {
            Console.Write($"\r{text}{frames[frameIndex]}                       ");

            frameIndex = (frameIndex + 1) % frames.Length;
            Thread.Sleep(100);
        }

    }
    static void CoolTextShow(string textt, int speedMilliSeconds) // shows text cooler idk
    {
        foreach (var item in textt)
        {
            Console.Write(item);
            Thread.Sleep(speedMilliSeconds);
        }
        Console.WriteLine();
    }
    static void CoolTextShowNOENTER(string textt, int speedMilliSeconds) // shows text cooler, BUT NO EXTRA CONSOLE.WRITELINE() THERE
    {
        foreach (var item in textt)
        {
            Console.Write(item);
            Thread.Sleep(speedMilliSeconds);
        }
    }
    static void ThinkingProcess(string method) // calculator thinks (it doesn't think actually, it's just visual)
    {
        string[] thinks =
        {
                "wow omg what",
                "Thinking",
                "Processing",
                "Trying to understand"
            };
        string[] thinksOfNums =
        {
                "so many nums",
                "Thinking",
                "Asking CPU for help",
                "CPU didnt help, trying myself",
                "Processing"
            };

        if (method == "T")
        {
            foreach (var item in thinks)
            {
                ShowLoad(item, 15);
            }
        }
        else if (method == "D")
        {
            foreach (var items in thinksOfNums)
            {
                ShowLoad(items, 15);
            }
        }


        int randomJoke = rnd.Next(1, 101);
        if (randomJoke <= 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine();
            System.Console.WriteLine("ERROR: SYSTEM_CALCULATOR_BRAIN_COULDNT_SOLVE_IT");
            Thread.Sleep(50);
            System.Console.WriteLine("ERROR: SYSTEM_CALCULATOR_BRAIN_DELETING");
            Thread.Sleep(50);
            System.Console.WriteLine("ERROR: SYSTEM_CALCULATOR_MIMEMEMJDEDJKE");
            Thread.Sleep(50);
            System.Console.WriteLine("ERROR: SYSTEM_CALCULATOR_MEMORY_EMPTY");
            Thread.Sleep(50);
            System.Console.WriteLine("ERROR: SYSTEM_CALCULATOR_BOOM");
            Thread.Sleep(1500);
            Console.ResetColor();
            CoolTextShow("jk actually....", 150);
        }
        ShowLoad("Finalizing", 10);
    }
    static void TryingAndCatching(string ErrorText)
    {
        if (ErrorText == "zero")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            CoolTextShow("Error: this can cause some problems, pls try again", 100);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (ErrorText == "format")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            CoolTextShow("Error: type a number, not a text. Try again", 100);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (ErrorText == "overflow")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            CoolTextShow("Error: the num is too big. Try again", 100);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (ErrorText == "brainNotFound")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            CoolTextShow("SYSTEM ERROR: BRAIN NOT FOUND", 50);
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

}
