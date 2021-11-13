using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_CA_1._2
{
    class DescriptorsOfThrows
    {
        int story = 0;
        public DescriptorsOfThrows()
        {
            Random random = new Random();
            random.Next(1, 4);
                
            switch (story)
            {
                case 1:
                Console.WriteLine($"The dice leave the hand like rats escaping flooding waters. They clunk to the table and roll as if they were a skipped stone on a silent lake revealing that you rolled a {" "}.");
                    break;
                case 2:
                Console.WriteLine($"Gravity wins the battle and your dice plummet off the table striking that floor and {" "} faces up.");
                    break;
                case 3:
                    Console.WriteLine($"You stare in horror as the dice fling straight into the chip bowl. Carefully removing chip by chip until your uncover your dice. The number {" "} peeks at you from it's salty grave.");
                    break;
                case 4:
                    Console.WriteLine($"Your dice clang into a glass ringing the room like a wedding champagne toast. They settle and you see {" "}.");
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine();
                    break;
            }
        }

        public void storie()
        {
            Random random = new Random();
            random.Next(1, 4);

            switch (story)
            {
                case 1:
                    Console.WriteLine($"The dice leave the hand like rats escaping flooding waters. They clunk to the table and roll as if they were a skipped stone on a silent lake revealing that you rolled a {" "}.");
                    break;
                case 2:
                    Console.WriteLine($"Gravity wins the battle and your dice plummet off the table striking that floor and {" "} faces up.");
                    break;
                case 3:
                    Console.WriteLine($"You stare in horror as the dice fling straight into the chip bowl. Carefully removing chip by chip until your uncover your dice. The number {" "} peeks at you from it's salty grave.");
                    break;
                case 4:
                    Console.WriteLine($"Your dice clang into a glass ringing the room like a wedding champagne toast. They settle and you see {" "}.");
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine();
                    break;
            }
            return;
        }

    }
}
