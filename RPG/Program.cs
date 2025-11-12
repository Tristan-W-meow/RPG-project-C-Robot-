using RPG;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG Game! Giving a preemptive warning for some body horror and possibly eldritch horror themes so you have been warned. \n Type \"STOP\" if you ever want to exit the program. \n Type \"START\" to begin the game, or if you want to start a new game");


            Intro.DisplayIntro();
            Character hero = new Character("Archer", 1, 100);

            Console.WriteLine(Component.swordArm.ComponentName);
        }
    }
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public Character(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        public void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}!");
            // Simple attack logic
            target.Health -= 10;
            Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
        }
    }
    public class Inventory
    {
        public List<string> Items { get; set; }
        public Inventory()
        {
            Items = new List<string>();
        }
        public void AddItem(string item)
        {
            Items.Add(item);
            Console.WriteLine($"{item} added to inventory.");
        }
        public void RemoveItem(string item)
        {
            if (Items.Remove(item))
            {
                Console.WriteLine($"{item} removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{item} not found in inventory.");
            }
        }
    }
    public class Anatomy
    {
    
    
    }

    public class Stats
    {
        public int strength { get; set; }
        public int resilience { get; set; }
        public int agility { get; set; }
        public int speed { get; set; }
        public int power_generation { get; set; }
        public int power { get; set; }
        public int processing_power { get; set; }
        public int encryption { get; set; }
        public  Stats(int strength, int resilience, int agility, int speed, int power_generation, int power, int processing_power, int encryption)
        {
            this.strength = strength;
            this.resilience = resilience;
            this.agility = agility;
            this.speed = speed;
            this.power_generation = power_generation;
            this.power = power;
            this.processing_power = processing_power;
            this.encryption = encryption;
        }

    }
    public class Component
    {
        public string ComponentName { get; set; }
        public int Efficiency { get; set; }
        public int Durability { get; set; }
        public int Power_cosumption { get; set; }
        public int Weight { get; set; }
        public int Stat_mod1 { get; set; }
        public int Stat_mod2 { get; set; }

        public Component(string conponentName, int durability, int efficiency, int power_cosumption, int weight, int stat_mod1, int stat_mod2)
        {
            ComponentName = conponentName;
            Efficiency = efficiency;
            Durability = durability;
            Power_cosumption = power_cosumption;
            Weight = weight;
            Stat_mod1 = stat_mod1;
            Stat_mod2 = stat_mod2;

        }

        public Component swordArm = new Component("Sword Arm", 100, 80, 20, 15, 5, 3);

        public void DisplayInfo()
        {
            Console.WriteLine($"Durability: {Durability}, Efficiency: {Efficiency}, Power Consumption: {Power_cosumption}, Weight: {Weight}, Stat Mod 1: {Stat_mod1}, Stat Mod 2: {Stat_mod2}");
        }

        public void SwordArm()
        {

        }

    }
    public class Intro
    {
        public static void StartGame()
        {
            Console.WriteLine("Welcome to the blackstone earth alpha version!");
            DisplayIntro();
        }
        public static void DisplayIntro() => Console.WriteLine("The cold, hard, black walls light up in front of you with white text. It reads: ”You are a human\r\n soon to be more in a world where the meaning of humanity has long since lost meaning. All\r\n that’s left is a fight to survive against an ever evolving onslaught of enemies. The sun has \r\nfaded, and the skies are eternally black with the only lights coming from beings that fight for \r\nresources on a long dead world like vultures fighting over the last scraps of food on a barren \r\nworld. In order to survive you must seek to give up your flesh for something greater. Choose a \r\npart to exchange for that which is ascended and be grateful for my kindness in allowing you to \r\nchoose how your blood is spilt one final time.”\r\n");
    }

    public class UserInput
    {
        public static void GetInputDefault()
        {
           string StrUserInput = Console.ReadLine();
            if (StrUserInput == null)
            {
                Console.WriteLine("Invalid input, please try again.");
                GetInputDefault();
            }
            else if (StrUserInput == "STOP")
            {
                Environment.Exit(0);
            }
            else if (StrUserInput == "START")
            {
                Intro.StartGame();
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                GetInputDefault();
            }
        }
    }
    public class 
 }

    
    


