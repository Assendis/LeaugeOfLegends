using System;

namespace ConsoleApplication3
{
    interface Character
    {
        string Name
        {
            get;
            set;
        }

        int HealtyValue
        {
            get;
            set;
        }

        int PowerOfAttack
        {
            get;
            set;
        }

    }

    class Warrior : Character
    {
        public string Name { get; set; }
        public int HealtyValue { get; set; }
        public int PowerOfAttack { get; set; }

        public Warrior(string _name, int _healtyvalue, int _powerOfAttack)
        {
            Name = _name;
            HealtyValue = _healtyvalue;
            PowerOfAttack = _powerOfAttack;
        }

        public void PickAttackEquipment(int value)
        {
            PowerOfAttack += value;
        }

        public void PickHealthEquipment(int value)
        {
            HealtyValue += value;
        }


    }

    class Magician : Character
    {
        public string Name { get; set; }
        public int HealtyValue { get; set; }
        public int PowerOfAttack { get; set; }

        public Magician(string _name, int _healtyvalue, int _powerOfAttack)
        {
            Name = _name;
            HealtyValue = _healtyvalue;
            PowerOfAttack = _powerOfAttack;
        }

        public void PickHealthEquipment(int value)
        {
            HealtyValue += value;
        }


    }

    class Support : Character
    {
        public string Name { get; set; }
        public int HealtyValue { get; set; }
        public int PowerOfAttack { get; set; }

        public Support(string _name, int _healtyvalue, int _powerOfAttack)
        {
            Name = _name;
            HealtyValue = _healtyvalue;
            PowerOfAttack = _powerOfAttack;
        }

        public void PickAttackEquipment(int value)
        {
            PowerOfAttack += value;
        }


    }

    class Program
    {

        static void Main(string[] args)
        {
            string characterChoice = string.Empty;
            string healthEquipmentChoice = string.Empty;
            string attackEquipmentChoice = string.Empty;

            Console.WriteLine("Pick a character!");
            Console.WriteLine("Warrior: 1\nMagician: 2\nSupport: 3");
            characterChoice = Console.ReadLine();

            switch (characterChoice)
            {
                case "1":
                    Warrior warrior = new Warrior("Jack", 100, 50);
                    Console.WriteLine("Pick your health equipment!");
                    Console.WriteLine("Mavi büyü(+10 HP): 1");
                    Console.WriteLine("Yeşil büyü(+5 HP): 2");
                    healthEquipmentChoice = Console.ReadLine();

                    if (healthEquipmentChoice == "1")
                        warrior.PickHealthEquipment(10);
                    else if (healthEquipmentChoice == "2")
                        warrior.PickHealthEquipment(5);

                    Console.WriteLine("Pick your attack equipment!");
                    Console.WriteLine("Kılıç(+20 XP): 1");
                    Console.WriteLine("Silah(+50 XP): 2");
                    attackEquipmentChoice = Console.ReadLine();

                    if (attackEquipmentChoice == "1")
                        warrior.PickAttackEquipment(20);
                    else if (attackEquipmentChoice == "2")
                        warrior.PickAttackEquipment(50);

                    WriteCharacter("Savaşçı", warrior.Name, warrior.HealtyValue, warrior.PowerOfAttack);
                    break;

                case "2":
                    Magician magician = new Magician("Sofia", 65, 30);
                    Console.WriteLine("Pick your health equipment!");
                    Console.WriteLine("Mavi büyü(+50 HP): 1");
                    Console.WriteLine("Yeşil büyü(+30 HP): 2");
                    healthEquipmentChoice = Console.ReadLine();

                    if (healthEquipmentChoice == "1")
                        magician.PickHealthEquipment(50);
                    else if (healthEquipmentChoice == "2")
                        magician.PickHealthEquipment(30);

                    WriteCharacter("Büyücü", magician.Name, magician.HealtyValue, magician.PowerOfAttack);
                    break;

                case "3":
                    Support support = new Support("Omni", 80, 40);
                    Console.WriteLine("Pick your attack equipment!");
                    Console.WriteLine("Kılıç(+10 XP): 1");
                    Console.WriteLine("Silah(+20 XP): 2");
                    attackEquipmentChoice = Console.ReadLine();

                    if (attackEquipmentChoice == "1")
                        support.PickAttackEquipment(10);
                    else if (attackEquipmentChoice == "2")
                        support.PickAttackEquipment(20);

                    WriteCharacter("Destek", support.Name, support.HealtyValue, support.PowerOfAttack);
                    break;

                default:
                    break;
            }
        }

        public static void WriteCharacter(string tur, string name, int health, int attack)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Tip           : " + tur);
            Console.WriteLine("İsim          : " + name);
            Console.WriteLine("Sağlık Değeri : " + health);
            Console.WriteLine("Atak Gücü     : " + attack);
            Console.ReadKey();
        }

    }
}
