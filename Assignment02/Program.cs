/*
 * Student ID : 169071287
 * Name       : Kumphaphan Boonsuk
 * Section    : 129B
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Config: วัสดุและอัตราแปลง (แก้ตรงนี้เพื่อเปลี่ยนวัสดุ/เรทของคุณเอง) =====
            const string MaterialName = "Iron";
            const double SmeltRate = 0.25; // Ore  -> Ingot (amount * SmeltRate)
            const double SalvageRate = 0.30; // Ingot -> Ore  (amount / SalvageRate)
            const double MaxBatch = 500;  // จำนวนสูงสุดต่อรอบ

            // SmeltRate < SalvageRate เสมอ ป้องกันบั๊กเสกวัตถุดิบจากอากาศ
            // (0.25 < 0.30 ผ่านกติกา)

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            char menu;
            bool menuParsed = char.TryParse(menuInput, out menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            double amount;
            bool amountParsed = double.TryParse(amountInput, out amount);

            // เงื่อนไข amount: parse ได้ && มากกว่า 0 && ไม่เกิน MaxBatch
            if (amountParsed && amount > 0 && amount <= MaxBatch)
            {
                // Nested if: เช็ค menu อยู่ข้างในเงื่อนไข amount ที่ผ่านแล้ว
                if (menuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                }
                else if (menuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("=> Error: Invalid menu. Please enter S (Smelt) or B (Breakdown).");
                }
            }
            else
                Console.WriteLine($"=> Error: Invalid amount. Must be a number greater than 0 and up to {MaxBatch:F2}.");
        }
    }
}