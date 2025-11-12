using RPG;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;
namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RPG Game! Giving a preemptive warning for some body horror and possibly eldritch horror" +
                " themes so you have been warned. \n Type \"STOP\" if you ever want to exit the program." +
                " \n Type \"START\" to begin the game, or if you want to start a new game");

            UserInput.GetInputDefault();

            Intro.DisplayIntro();

        }
    }
    public class Character
        // base stats for characters
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public float Strength { get; set; }
        public float Resilience { get; set; }
        public float Agility { get; set; }
        public float Speed { get; set; }
        public float Power_generation { get; set; }
        public float Power { get; set; }
        public float Processing_power { get; set; }
        public float Encryption { get; set; }
        public Character(float strength, float resilience, float agility, float speed, float power_generation,
            float power, float processing_power, float encryption, string name, float health)
        {
            Strength = strength;
            Resilience = resilience;
            Agility = agility;
            Speed = speed;
            Power_generation = power_generation;
            Power = power;
            Processing_power = processing_power;
            Encryption = encryption;
            Name = name;
            Health = health;
        }
    
    }
    public class Inventory
        // currently unusued and all code within is placeholder code that may be semi functional
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
    public class Component
    // bases stats for components. Components and their stats will affect player and enemy stats.
    // Components will hopefully be defined here each as individual methods
    {
        public string ComponentName { get; set; }
        public float Structure { get; set; }
        public float Efficiency { get; set; }
        public float Durability { get; set; }
        public float Power_cosumption { get; set; }
        public float Weight { get; set; }
        public float Stat_mod1 { get; set; }
        public float Stat_mod2 { get; set; }

        public Component(string conponentName, float structure, float durability, float efficiency, float power_cosumption, float weight, float stat_mod1, float stat_mod2)
        {
            ComponentName = conponentName;
            Structure = structure;
            Efficiency = efficiency;
            Durability = durability;
            Power_cosumption = power_cosumption;
            Weight = weight;
            Stat_mod1 = stat_mod1;
            Stat_mod2 = stat_mod2;

        }
        public void SwordArm()
        {
            Component swordArm = new Component("Sword Arm", 100, 1, 90, 20, 15, 5, 3);
        }
        // It's not there yet but the end goal is to have a component defined along with an associated action.


        public void DisplayInfo()
        {
            Console.WriteLine($"Durability: {Durability}, Efficiency: {Efficiency}, Power Consumption: {Power_cosumption}, Weight: {Weight}, Stat Mod 1: {Stat_mod1}, Stat Mod 2: {Stat_mod2}");
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
    public class Encounter
    {

        public static void DisplayCombatOptions()
        {
            Console.WriteLine("What do you wish to activate?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Use Item");
        }
        public static void StartCombat(Character player, Character enemy)
        {
            
        }

        public static void 
        public int CombatTime(int Time, int Speed)
        {
            while (Time <100)
            {
                Time += Speed;
                if (Time >= 100)
                {
                    Time -=100 ;
                    return Time;
                }
            }
        }
    }
}

    
    


