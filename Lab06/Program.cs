/*
 * Student ID : 1690701287
 * Name       : Kumphaphan Boonsuk
 * Section    : 129A
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dragon's Gate ===");
            Console.WriteLine("A fearsome Dragon Guardian blocks the gate.");
            Console.WriteLine();
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DEFEND");
            Console.WriteLine("ACTION 3: NEGOTIATE");
            Console.Write("Choose your action: ");

            bool choiceOk = int.TryParse(Console.ReadLine(), out int choice);

            if (!choiceOk || (choice != 1 && choice != 2 && choice != 3))
            {
                // อยู่ในเงื่อนไขที่ผู้เล่นเลือก action ไม่ถูกต้อง
                Console.WriteLine("Invalid action. Please choose 1, 2 or 3.");
            }
            else if (choice == 1)
            {
                // ก่อนเข้าสู่เงื่อนไข ATTACK branch
                Console.Write("Enter your attack power (1-100): ");
                bool powerOk = int.TryParse(Console.ReadLine(), out int power);

                if (!powerOk || power < 1 || power > 100)
                {
                    Console.WriteLine("Invalid attack power. It must be a whole number between 1 and 100.");
                }
                else if (power >= 50)
                {
                    // นี่คือเงื่อนไขที่ผู้เล่นสามารถเลือกเป้าหมายได้ 
                    Console.Write("Choose where to aim, H for Head or B for Body: ");
                    bool aimOk = char.TryParse(Console.ReadLine(), out char aim);

                    if (!aimOk || (aim != 'H' && aim != 'h' && aim != 'B' && aim != 'b'))
                    {
                        Console.WriteLine("Invalid aim. Please choose H or B.");
                    }
                    else if (aim == 'H' || aim == 'h')
                    {
                        if (power >= 80)
                        {
                            Console.WriteLine("Critical headshot! The Dragon Guardian collapses. You win!");
                        }
                        else
                        {
                            Console.WriteLine("You strike the head for solid damage. The Dragon roars in pain.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You strike the body. The Dragon staggers back but stays standing.");
                    }
                }
                else
                {
                    Console.WriteLine("Your attack is too weak. The Dragon breathes fire and scorches you badly.");
                }
            }
            else if (choice == 2)
            {
                // เงื่อนไข DEFEND branch
                Console.Write("Enter your shield durability (0.0-100.0): ");
                bool shieldOk = double.TryParse(Console.ReadLine(), out double shield);

                if (!shieldOk || shield < 0 || shield > 100)
                {
                    Console.WriteLine("Invalid shield durability. It must be a number between 0 and 100.");
                }
                else if (shield >= 70)
                {
                    Console.WriteLine("Your shield fully blocks the Dragon's claws. You take no damage.");
                }
                else if (shield >= 30 && shield < 70)
                {
                    Console.WriteLine("Your shield partially blocks the attack. You take some damage.");
                }
                else
                {
                    Console.WriteLine("Your shield shatters! The Dragon's claws hit you directly.");
                }
            }
            else
            {
                // เงื่อนไข NEGOTIATE branch
                Console.Write("Do you accept the Dragon's peace offer? (Y/N): ");
                bool answerOk = char.TryParse(Console.ReadLine(), out char answer);

                if (!answerOk)
                {
                    Console.WriteLine("Invalid answer. Please type Y or N.");
                }
                else if (answer == 'Y' || answer == 'y')
                {
                    Console.WriteLine("The Dragon accepts. You both walk away in peace.");
                }
                else if (answer == 'N' || answer == 'n')
                {
                    Console.WriteLine("The Dragon roars in anger and attacks you without warning!");
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please type Y or N.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== Game Over ===");

        }
    }
}
