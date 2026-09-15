/*
 * Student ID : 1690701287
 * Name       : Kumphapahn Boonsuk
 * Section    : 129B
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */
using System.Runtime.ConstrainedExecution;

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        { //=========================//
          //        Start          //
          //=======================// 
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|      NEW ADVENTURE       |");
            Console.WriteLine("+--------------------------+");// แค่แสดงข้อความต้อนรับผู้เล่น
            Console.Write("Enter your name: "); //การใช้ Console.Write เพื่อแสดงข้อความ "Enter your name: " โดยไม่ขึ้นบรรทัดใหม่ ,Console.WriteLine จะขึ้นบรรทัดใหม่หลังจากแสดงข้อความ
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}, to the world of adventure!"); // แสดงข้อความต้อนรับผู้เล่นโดยใช้ชื่อที่ผู้เล่นป้อนเข้ามา
            Console.WriteLine();
            Console.Write("Choose Difficulty Level (1-5): ");
            //แสดงข้อความให้ผู้เล่นเลือก(string)ระดับความยากของเกม โดยให้ผู้เล่นป้อนต��วเลขระหว่าง 1 ถึง 5
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficultyLevel}"); // แสดงข้อความยืนยันระดับความยากที่ผู้เล่นเลือก
            Console.WriteLine();
            //=========================//
            //        Item Shop       //
            //=======================// 
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|        ITEM SHOP         |");
            Console.WriteLine("+--------------------------+");// แสดงข้อความต้อนรับผู้เล่นเข้าสู่ร้านค้าไอเท็ม
            Console.WriteLine("How Many My Potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();

            //=========================//
            //        Rate Level      //
            //=======================// 
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|        RATE LEVEL        |");
            Console.WriteLine("+--------------------------+"); // แสดงข้อความต้อนรับผู้เล่นเข้าสู่หน้าการให้คะแนนระดับของเกม
            Console.WriteLine("Rate this Level (0.0 - 5.0): ");
            bool isvalid = double.TryParse(Console.ReadLine(), out double rating);
            Console.WriteLine($"Valid input: {isvalid}");
            Console.WriteLine($"Rating: {rating}");
            Console.WriteLine();
            //=================================//
            //        Character Creation      //
            //===============================//
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|        Character Creation        |");
            Console.WriteLine("+----------------------------------+"); // แสดงข้อความต้อนรับผู้เล่นเข้าสู่หน้าการสร้างตัวละคร
            Console.Write("Name your character: ");
            string charname = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool ClassValid = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting Luck (0.0-10.0): ");
            bool luckValid = float.TryParse(Console.ReadLine(), out float luckNum);
            Console.WriteLine($"\n{charname} The Class-{classNum} Adventurer enter the dungeon. Luck {luckNum}");
            Console.WriteLine();
        }
    }
}
