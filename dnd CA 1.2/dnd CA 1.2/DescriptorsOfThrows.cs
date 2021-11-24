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
        public static string GenerateDescriptor(int randomNumberRolled)
        {
            Random random = new Random();
            int randomVariable = random.Next(1, 5);
            string outputString ="";
            switch (randomVariable)
            {
                case 1:
                    Console.WriteLine($"The dice leave the hand like rats escaping flooding waters. They clunk to the table and roll as if they were a skipped stone on a silent lake revealing that you rolled a {randomNumberRolled}.");
                    break;
                case 2:
                    Console.WriteLine($"Gravity wins the battle and your dice plummet off the table striking that floor and {randomNumberRolled} faces up.");
                    break;
                case 3:
                    Console.WriteLine($"You stare in horror as the dice fling straight into the chip bowl. Carefully removing chip by chip until your uncover your dice. The number {randomNumberRolled} peeks at you from it's salty grave.");
                    break;
                case 4:
                    Console.WriteLine($"Your dice clang into a glass ringing the room like a wedding champagne toast. They settle and you see {randomNumberRolled}.");
                    break;
                case 5:
                    Console.WriteLine($"A cold chill of regret creeps down your spine as you drop the dice at a poor angle. They find their resting place and reveal a {randomNumberRolled}.");
                    break;
                case 6:
                    Console.WriteLine($"A double puff exhale into your palms for luck. A squirm of the arm and a flick of the wrist send the dice to jet along the table landing on {randomNumberRolled}.");
                    break;
                    //case 7:
                    //    Console.WriteLine();
                    //    break;
                    //case 8:
                    //    Console.WriteLine();
                    //    break;
                    //case 9:
                    //    Console.WriteLine();
                    //    break;
                    //case 10:
                    //    Console.WriteLine();
                    //    break;
            }
            return outputString;
        }
    }
}
