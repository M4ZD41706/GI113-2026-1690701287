/*
* Student ID : 1690701287
* Name       : Kumphaphan Boonsuk
* Section    : 129B
* No.        : 0
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {// Part A Lab 02
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();
            //Part B Lab 02
            // ==========================================
            // 1. CHARACTER CREATION & STAT DECLARATION
            // ==========================================

            // Character 1: Ixolot (Tank/Warrior)
            string char1Name = "Ixolot";
            int char1Hp = 2500;
            float char1AttackSpeed = 1.25f;       // float
            char char1Tier = 'S';                 // char
            bool char1IsShieldActive = true;       // bool

            // Character 2: Horpy (Elementalist Mage)
            string char2Name = "Horpy";
            int char2Mana = 850;
            double char2SpellPower = 345.85;      // double
            char char2Element = 'F';              // char ('F' = Fire)
            bool char2IsCasting = false;

            // Character 3: Mael (Shadow Assassin)
            string char3Name = "Mael";
            int char3Level = 60;
            float char3MoveSpeed = 4.85f;         // float
            double char3CritMultiplier = 2.75;    // double
            bool char3IsStealthed = true;

            // Character 4: Athena (Holy Paladin)
            string char4Name = "Athena";
            int char4Defense = 420;
            double char4HolyDamage = 189.40;      // double
            char char4Rank = 'A';                 // char
            bool char4IsAlive = true;


            // ==========================================
            // 2. DISPLAY STATS (STRING INTERPOLATION)
            // ==========================================

            Console.WriteLine($"=== CHARACTER 1: {char1Name} ===");
            Console.WriteLine($"HP: {char1Hp}");
            Console.WriteLine($"Attack Speed: {char1AttackSpeed} atk/s");
            Console.WriteLine($"Tier Rank: {char1Tier}");
            Console.WriteLine($"Shield Active: {char1IsShieldActive}");
            Console.WriteLine();

            Console.WriteLine($"=== CHARACTER 2: {char2Name} ===");
            Console.WriteLine($"Max Mana: {char2Mana}");
            Console.WriteLine($"Spell Power: {char2SpellPower} pts");
            Console.WriteLine($"Element Type: '{char2Element}'");
            Console.WriteLine($"Currently Casting: {char2IsCasting}");
            Console.WriteLine();

            Console.WriteLine($"=== CHARACTER 3: {char3Name} ===");
            Console.WriteLine($"Current Level: {char3Level}");
            Console.WriteLine($"Movement Speed: {char3MoveSpeed} m/s");
            Console.WriteLine($"Crit Multiplier: {char3CritMultiplier}x");
            Console.WriteLine($"Stealth Status: {char3IsStealthed}");
            Console.WriteLine();

            Console.WriteLine($"=== CHARACTER 4: {char4Name} ===");
            Console.WriteLine($"Base Defense: {char4Defense}");
            Console.WriteLine($"Holy Damage: {char4HolyDamage}");
            Console.WriteLine($"Guild Rank: {char4Rank}");
            Console.WriteLine($"Is Alive: {char4IsAlive}");
        }
    }
}