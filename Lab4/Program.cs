/*
 * Student ID : 1690701287
 * Name       : Kumphaphan Bosnsuk
 * Section    : 129B
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|      NEW ADVENTURE       |");
            Console.WriteLine("+--------------------------+");// แค่แสดงข้อความต้อนรับผู้เล่น

            Console.Write("Enter your name: "); //การใช้ Console.Write เพื่อแสดงข้อความ "Enter your name: " โดยไม่ขึ้นบรรทัดใหม่ ,Console.WriteLine จะขึ้นบรรทัดใหม่หลังจากแสดงข้อความ
            string playerName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {playerName}, to the world of adventure!");

            //////////////////////
            //character creation//
            //////////////////////
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventure enters the dungeon. Luck: {luck}"); Console.WriteLine("Hello, World!");
            Console.WriteLine();

            //////////////////////
            //    Item  Shop    //
            //////////////////////
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      ITEM SHOP       |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("How Many My Potions?");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();

            //////////////////////
            //      Volume      //
            //////////////////////
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|     SET VOLUME        |");
            Console.WriteLine("+------------------------------+");
            Consoole.Write("Set volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine();

            //////////////////////
            //   New Save File  //
            //////////////////////
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|     NEW SAVE FILE      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save file name: ");
            string saveFileName = Console.ReadLine();
            Console.WriteLine($"Save file name: {saveFileName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
            Console.WriteLine();
        }
    }
}
