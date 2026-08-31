/*
 * Student ID : 1690701287
 * Name       : Khumphaphan Boonsuk
 * Section    : 129B
 * No.        : NO.0
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;
            //////////////////////
            //ประกาศตัวแปรของบอสที่นี่//
            /////////////////////
            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////
            // BOSS NAME, RANK, LEVEL, HP, ATTACK POWER, CRIT MULTIPLIER, IS BOSS//
            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            /////////////////////////////////////////////////
            // DOUBLE CONVERSIONS :การแปลงชนิดข้อมูลเป็น double //
            ////////////////////////////////////////////////
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Double Division: HP Percent (no integer truncation) : การหารแบบ Double: เปอร์เซ็นต์ HP (ไม่มีการตัดเศษจำนวนเต็ม)//
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Attack Power as int (explicit cast) : ค่า Attack Power ให้อยู่ในรูปจำนวนเต็ม (การแปลงชนิดข้อมูลแบบ Explicit Cast)//
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////////////////////
            // cast vs convert for crit multiplier : เปรียบเทียบการ Cast กับการ Convert สำหรับค่า Crit Multiplier//
            //////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
            Console.WriteLine();
        }
    }
}
