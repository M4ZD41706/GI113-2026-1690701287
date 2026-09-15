/*
 * Student ID : 1690701287
 * Name       : Kumphaphan Boonsuk
 * Section    : 129B
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//โค้ดนี้ตั้งค่าการเข้ารหัสของคอนโซลเป็น UTF-8 เพื่อให้สามารถแสดงอักขระพิเศษได้อย่างถูกต้อง
        // ---- const: 1 ประกาศค่าคงที่ ----
        const double BasePower = 9000.0;

        // ---- var: 2+ vars, including string/char, คอมไพเลอร์เดาชนิดข้อมูลให้เอง ----
        var unitName = "Areus, Radiant Vanguard";   // inferred as string
        var gradeSymbol = 'G';                       // inferred as char (Grade marker)

        // ---- ประกาศ "ชนิดข้อมูลที่เหลือ" ----
        int shieldValue = 10000;
        float criticalMultiplier = 1.5f;
        bool isRideDeck = true;

        // ---- การแปลงชนิดข้อมูล: int -> double, no cast token used ----
        double shieldAsDouble = shieldValue;

        // ---- cast vs Convert.ToInt32 — ต้องใช้ตัวแปรตัวเดียวกันทดสอบทั้งสองวิธี ไม่ใช่สร้างตัวแปรคนละตัวแยกกัน ----
        double driveCheckRaw = 275.8;
        int driveCheckCast = (int)driveCheckRaw;                 // truncates  -> 275
        int driveCheckConverted = Convert.ToInt32(driveCheckRaw); // rounds     -> 276
 
        // ---- output: interpolation only, custom layout, camelCase/PascalCase throughout ----
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine($"║  {unitName}");
        Console.WriteLine("╠══════════════════════════════════════╣");
        Console.WriteLine($"║ Grade              : {gradeSymbol}");
        Console.WriteLine($"║ In Ride Deck       : {isRideDeck}");
        Console.WriteLine($"║ Base Power         : {BasePower}");
        Console.WriteLine($"║ Critical Multiplier: {criticalMultiplier}");
        Console.WriteLine($"║ Shield Value       : {shieldValue}");
        Console.WriteLine($"║ Shield (as double) : {shieldAsDouble}   <- implicit int->double");
        Console.WriteLine("╠══════════════════════════════════════╣");
        Console.WriteLine($"║ Drive Check Raw       : {driveCheckRaw}");
        Console.WriteLine($"║ Drive Check (cast)    : {driveCheckCast}");
        Console.WriteLine($"║ Drive Check (Convert) : {driveCheckConverted}");
        Console.WriteLine("╚══════════════════════════════════════╝");
        }
    }
}
