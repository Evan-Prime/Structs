using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        // PROGRAMMING:
        // 1) data -- stores things
        // 2) code -- does things (to/with data)
        
        // ENCAPSULATION:
        // 1) data -- structs, classes, ...
        // 2) code -- methods!

        //structs
        struct Vector2
        {
            // fields
            public int x;
            public int y;

            // ...
            
            // methods
            public int ManhattenLength()
            {
                //...
                return (x * y);
            }

            private void Test()
            {
                //...
            }
        }

        // player
        //static int x = 10; // position
        //static int y = 10; // position
        static Vector2 playerPosition;
        static int health = 100;
        static int shield = 100;
        static int lives = 3;
        static string name; // name

        // enemies
        static Vector2 enemy1Position;
        static Vector2 enemy2Position;
        static Vector2 enemy3Position;
        //...

        // ...or with arrays:

        // enemies
        static Vector2[] enemiesPosition = new Vector2[100];

        struct Weapon
        {
            // data
            public int strength;
            public int speed;
            public int durability;
            public string name;

            // code
            // ...
            // ...
            // ...
        }

        // weapons
        static Weapon sword;
        static Weapon bat;
        static Weapon gun;
        static Weapon knife;

        struct Spells
        {
            public string spellName;
            public int manaCost;
            public int damage;
            public int healing;
            public int range;

            public void Display()
            {
                Console.WriteLine("Spell name: " + spellName);
                Console.WriteLine("Mana Cost: " + manaCost);
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Healing: " + healing + " HP");
                Console.WriteLine("Range: " + range + "ft");
            }
        }

        static Spells fireSpell;
        static Spells lightSpell;
        static Spells iceSpell;
        static Spells darkSpell;

        static void Main(string[] args)
        {
            sword.strength = 50;
            sword.speed = 5;
            sword.durability = 50;
            sword.name = "xxxxxx";

            playerPosition.x = 10;
            playerPosition.y = 20;
            int temp = playerPosition.ManhattenLength();


            fireSpell.spellName = "Fire Ball";
            fireSpell.manaCost = 50;
            fireSpell.damage = 48;
            fireSpell.healing = 0;
            fireSpell.range = 150;

            lightSpell.spellName = "Healing Touch";
            lightSpell.manaCost = 10;
            lightSpell.damage = 0;
            lightSpell.healing = 20;
            lightSpell.range = 0;

            iceSpell.spellName = "Ice Knife";
            iceSpell.manaCost = 15;
            iceSpell.damage = 25;
            iceSpell.healing = 0;
            iceSpell.range = 0;

            darkSpell.spellName = "Summon Lesser Demon";
            darkSpell.manaCost = 200;
            darkSpell.damage = 0;
            darkSpell.healing = 0;
            darkSpell.range = 60;


            Console.WriteLine("Structs:");
            Console.WriteLine("--------");
            Console.WriteLine("");
            fireSpell.Display();
            Console.WriteLine("");
            lightSpell.Display();
            Console.WriteLine("");
            iceSpell.Display();
            Console.WriteLine("");
            darkSpell.Display();
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
