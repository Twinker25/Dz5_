namespace Dz5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter number of task (1 - 4): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Magazine magazine1 = new Magazine();
                        Magazine magazine2 = new Magazine();
                        magazine1.Input();
                        Console.WriteLine();
                        magazine2.Input();
                        Console.WriteLine("\nShow info:");
                        magazine1.Show();
                        Console.WriteLine();
                        magazine2.Show();
                        Console.WriteLine();
                        magazine1 += 100;
                        magazine2 += 100;
                        Console.Write("\nWorkers of magazine 1: ");
                        magazine1.ShowWorkers();
                        Console.Write("\nWorkers of magazine 2: ");
                        magazine2.ShowWorkers();

                        if (magazine1 == magazine2)
                        {
                            Console.WriteLine("\nMagazines have equal workers.");
                        }

                        if (magazine1 > magazine2)
                        {
                            Console.WriteLine("\nMagazines 1 has higher workers than Magazines 2.");
                        }

                        else if (magazine1 < magazine2)
                        {
                            Console.WriteLine("\nMagazines 2 has higher workers than Magazines 1.");
                        }

                        if (magazine1 != magazine2)
                        {
                            Console.WriteLine("\nMagazines have different workers.");
                        }

                        if (magazine1.Equals(magazine2))
                        {
                            Console.WriteLine("\nMagazines are the equal.");
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Error! Try again!");
                        break;
                }
            } while (choice < 1 || choice > 3);
        }
    }
}