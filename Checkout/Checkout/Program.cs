using System;

namespace Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkout = new Checkout();
            var run = true;

            Console.WriteLine("SKU  Price  Offer");
            Console.WriteLine(" A      50  3 for 130");
            Console.WriteLine(" B      30  2 for 45");
            Console.WriteLine(" C      20");
            Console.WriteLine(" D      15");
            Console.WriteLine();
            Console.WriteLine("Press T for total.");

            do
            {
                Console.WriteLine();

                var action = Console.ReadLine();
                var actionUpper = action?.ToUpper();

                switch (actionUpper)
                {
                    case "A":
                    case "B":
                    case "C":
                    case "D":
                        checkout.Scan(actionUpper);
                        break;
                    case "T":
                        Console.WriteLine($"Your total is: £{checkout.GetTotalPrice()}");
                        break;
                    case "X":
                        run = false;
                        break;
                }

            } while (run);
        }
    }
}
