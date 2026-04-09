// // // // using System;

// // // // public class VendingMachine
// // // // {
// // // //     // 1. THE HIDDEN DATA (Inside the steel box)
// // // //     private int _cansOfSoda = 10;
// // // //     private decimal _moneyInside = 0m;

// // // //     // 2. THE PUBLIC GATEWAY (The Coin Slot)
// // // //     public void InsertCoin(decimal coinAmount)
// // // //     {
// // // //         // We set the rules! Only accept valid coins.
// // // //         if (coinAmount > 0) 
// // // //         {
// // // //             _moneyInside += coinAmount;
// // // //             Console.WriteLine($"Accepted ${coinAmount}. Total: ${_moneyInside}");
// // // //         }
// // // //         else
// // // //         {
// // // //             Console.WriteLine("Machine spits out invalid coin.");
// // // //         }
// // // //     }

// // // //     // 3. THE PUBLIC GATEWAY (The Soda Button)
// // // //     public void PressButton()
// // // //     {
// // // //         // We set the rules! They can only get a soda if they paid and we have stock.
// // // //         if (_moneyInside >= 1.50m && _cansOfSoda > 0)
// // // //         {
// // // //             _cansOfSoda -= 1;        // Give soda
// // // //             _moneyInside -= 1.50m;   // Take money
// // // //             Console.WriteLine("Ka-chunk! Here is your soda.");
// // // //         }
// // // //         else
// // // //         {
// // // //             Console.WriteLine("Not enough money, or out of stock.");
// // // //         }
// // // //     }
// // // // }

// // // // class Program
// // // // {
// // // //     static void Main()
// // // //     {
// // // //         VendingMachine machine = new VendingMachine();

// // // //         // The user CANNOT touch _moneyInside directly. 
// // // //         // They MUST use the public gateway we provided:
// // // //         machine.InsertCoin(1.00m);
// // // //         machine.InsertCoin(0.50m);
// // // //         machine.InsertCoin(0.50m);
        
// // // //         machine.PressButton();
// // // //     }
// // // // }
// // // using System;
// // // using System.Diagnostics;
// // // public class Enemy
// // // {
// // //     public int Health { get; set; }
// // //     public int Damage { get; set; }

    
// // //   public void TakeDamage(int amount)
// // //     {
// // //         Health -= amount;
// // //         Console.WriteLine($"Enemy takes {amount} damage. Remaining health: {Health}");
// // //     }
// // // }
// // // public class Goblin : Enemy
// // // {
// // //     public void StealGold()
// // //     {
// // //         Console.WriteLine("The goblin steals 100 pieces of gold!");
// // //     }
// // // }
// // // public class Animal
// // // {
// // //     public void Breathe()=> Console.WriteLine("the animal is breathinh oxygen");
// // // }

// // // class Mammal : Animal
// // // {
// // //     public void GiveMilk()=> Console.WriteLine("the cow gives milk");
// // // }
// // // class Cow: Mammal
// // // {
// // //     public void Mow()=> Console.WriteLine("the cow is mooing");
// // // }

// // // public class Vegetable
// // // {
// // //     public string Color { get; set; }
// // //     public Vegetable(string color)
// // //     {
// // //         Color = color;
// // //         Console.WriteLine($"A {Color} vegetable is created.");
// // //     }
// // // }

// // // public class Hak : Vegetable
// // // {
// // //     public int Pieces { get; set; }
// // //     public Hak(string color, int pieces) : base(color)
// // //     {
// // //         Pieces = pieces;
// // //         Console.WriteLine($"The hak is cut into {Pieces} pieces.");
// // //     }
// // // }

// // // class Program
// // // {
// // // static void Main()
// // //     {
// // //         Goblin myGoblin = new Goblin();
// // //         myGoblin.Health = 100;
// // //         myGoblin.Damage = 15;

// // //         Console.WriteLine($"Goblin Health: {myGoblin.Health}");
// // //         Console.WriteLine($"Goblin Damage: {myGoblin.Damage}");

// // //         myGoblin.TakeDamage(20);
// // //         myGoblin.StealGold();
// // //         Cow myCow = new Cow();
// // //         myCow.Breathe();        
// // //         myCow.GiveMilk();
// // //         myCow.Mow();
// // //           Hak myHak= new Hak("green", 5);



// // //     }
// // // }
// // using System;
// // using System.Runtime.CompilerServices;
// // using System.Security.Cryptography.X509Certificates;

// // public class Fighter
// // {
// //     public string Name {get; set;}
// //     private int _health;
// //     public int Health
// //     {
// //         get
// //         {
// //             return _health;
// //         }
// //         set
// //         {
// //             if (value < 0)
// //             {
// //                 _health = 0;
// //             }
// //             else
// //             {
// //                 _health = value;
// //             }
// //         }
// //     }
    

// //     public Fighter(string name, int health)
// //     {
// //         Name = name;
// //         Health = health;
// //     }
// //     public void TakeDamage(int amount)
// //     {
// //         Health -= amount;
// //         Console.WriteLine($"{Name} takes {amount} damage. Remaining health: {Health}");
// //     }
// //     public virtual void Attack(Fighter target)
// //     {
// //         Console.WriteLine($"{Name} attacks {target.Name}!");
// //         target.TakeDamage(10);
// //     }
// // }

    
// //     public class Warrior : Fighter
// // {
// //     // ROOM 1: The Constructor
// //     public Warrior(string name, int health) : base(name, health)
// //     {
// //         // This room is now empty! We just pass the data to the base and we are done.
// //     }
    
// //     // ROOM 2: The Attack Method (Sitting OUTSIDE the constructor, INSIDE the class)
// //     public override void Attack(Fighter target)
// //     {
// //         Console.WriteLine($"{Name} swings a mighty sword at {target.Name}!");
        
// //         // Dealing the 20 damage we asked for in the prompt!
// //         target.TakeDamage(20); 
// //     }
// // }
// // public class Mage: Fighter
// // {
// //     public Mage(string name, int health) : base(name, health)
// //     {
// //     }
// //     public override void Attack(Fighter target)
// //     {
// //         Console.WriteLine($"{Name} casts a fireball at {target.Name}!");
// //         target.TakeDamage(15);
// //     }
// //     public void Attack(Fighter target, string spellName)
// //     {
// //         if(spellName== "lightning")
// //         {
// //             Console.WriteLine($"{Name} casts a lightning bolt at {target.Name}!");
// //             target.TakeDamage(25);
// //         }
// //         else if(spellName == "ice")
// //         {
// //             Console.WriteLine($"{Name} casts an ice shard at {target.Name}!");
// //             target.TakeDamage(10);
// //         }
// //         else
// //         {
// //             Console.WriteLine($"{Name} casts {spellName} at {target.Name}!");
// //             target.TakeDamage(15);
// //         }   
// //         Console.WriteLine($"{Name} casts {spellName} at {target.Name}!");
// //         target.TakeDamage(15);
// //     }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Console.WriteLine("=== Welcome to the Arena! ===\n");

// //         // 1. Instantiating our Champions
// //         Warrior maximus = new Warrior("Maximus", 100);
// //         Mage merlin = new Mage("Merlin", 80);

// //         Console.WriteLine("\n--- LET THE BATTLE BEGIN ---\n");

// //         // 2. Maximus uses his Overridden Attack (20 damage)
// //         maximus.Attack(merlin);

// //         // 3. Merlin uses his Overloaded Attack (Lightning = 30 damage)
// //         merlin.Attack(maximus, "Lightning");

// //         // 4. Maximus attacks again
// //         maximus.Attack(merlin);

// //         // Let's do massive damage to Maximus to test your Encapsulation Gatekeeper!
// //         merlin.Attack(maximus, "Lightning");
// //         merlin.Attack(maximus, "Lightning");
// //         merlin.Attack(maximus, "Lightning"); // This should drop him below 0!

// //         Console.WriteLine("\n--- BATTLE OVER ---");
        
// //         // 5. Checking the final health. 
// //         // If your Encapsulation worked, Maximus will be exactly 0, not negative!
// //         Console.WriteLine($"{maximus.Name} Final Health: {maximus.Health}");
// //         Console.WriteLine($"{merlin.Name} Final Health: {merlin.Health}");
// //     }
// // }

// using System;
// using System.Security.Cryptography.X509Certificates;

// public class Person
// {
//     public string Name{get; set;}
//     private int _age;
//     public int Age
//     {
//         get
//         {
//             if (_age < 18)
//             {
//                 Console.WriteLine("Access denied. Age is below 18.");
//                 return -1; // Indicating access denied
//             }
//             else
//             {
//                 return _age;
//             }
//         }
//         set
//         {
//             if (value < 0)
//             {Console.WriteLine($"Invalid age.for {Name} Age cannot be negative.");
//                 throw new ArgumentException("Age cannot be negative.");
//                 // Console.WriteLine($"Invalid age.for {Name} Age cannot be negative.");
//                 // return ;
//             }
//             else
//             {
//                 _age = value;
//                 Console.WriteLine($"Age set to {_age} for {Name}.");
//             }
//         }

//     }
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age; 
//         // This will invoke the setter and apply validation
//     Console.WriteLine($"Person {name} created with age {age}.");
//     }
    
// }
// public class Voter:Person {
//     public Voter(string name , int age):base(name, age)
//     {
//         // Console.WriteLine($"Voter {name} created with age {age}.");
// }
// }
// class Program
// {
//     static void Main()
//     {
//         Voter voter1 = new Voter("Alice", 25); // Valid age
//         Voter voter2 = new Voter("Bob", 15);   // Invalid age, should trigger access denied
//         Voter voter3 = new Voter("Charlie", -5); // Invalid age, should trigger invalid age message
//     }
// }