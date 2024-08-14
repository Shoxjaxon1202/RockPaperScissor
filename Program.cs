using System.Diagnostics;

class Program
{
    public static void Main()
    {
        string command = "";
        int player = 0;
        int cpu = 0;
        key:
    while(player != 3 && cpu != 3)
    {
        System.Console.WriteLine("Please enter");
        System.Console.WriteLine("Rock , Paper , Scissors");
        command = Console.ReadLine()!;

        Random random = new Random();
        int randomNumber = random.Next(1,4);
        string output = "";
        switch(randomNumber)
        {
            case 1 : output = "Rock";
            break;
            case 2 : output = "Paper";
            break;
            case 3 : output = "Scissors";
            break;
        }

        System.Console.WriteLine(output);
        if(command == "Rock" || command == "Paper" || command == "Scissors")
        {
            if(command == "Rock" && randomNumber == 3)
            {
                player++;
                System.Console.WriteLine("Player " + player);
            }
            else if(command == "Paper" && randomNumber == 1)
            {
                player++;
                System.Console.WriteLine("Player " + player);

            }
            else if(command == "Scissors" && randomNumber == 2)
            {
                player++;
                System.Console.WriteLine("Player " + player);

            }
            else if(command == "Rock" && randomNumber == 2)
            {
                cpu++;
                System.Console.WriteLine("CPU " + cpu);
            }

            else if(command == "Paper" && randomNumber == 3)
            {
                cpu++;
                System.Console.WriteLine("CPU " + cpu);
            }
            else if(command == "Scissors" && randomNumber == 1)
            {
                cpu++;
                System.Console.WriteLine("CPU " + cpu);
            }
            else
            {
                System.Console.WriteLine("Same");
            }
            System.Console.WriteLine();
        }
    }

        if(player == 3)
        {
            System.Console.WriteLine("PLAYER WON!");
        }
        if(cpu == 3)
        {
            System.Console.WriteLine("CPU WON!");
        }
        
        System.Console.WriteLine();
        System.Console.Write("Qayta o'ynashni hohlaysizmi ha(key y) yo'q(n)");
        if(player == 3 || cpu == 3)
        {
            var key = Console.ReadKey();

            if (key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Return");
                System.Console.WriteLine();
                player = 0;
                cpu = 0;
                goto key;
            }
            else if(key.KeyChar == 'n' || key.KeyChar == 'N')
            {
                System.Console.WriteLine("\nI enjoyed playing with you.");
            }
            else
            {
                Console.WriteLine("\nGame finishing....");
            }
        }
    }
}