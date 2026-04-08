// // using System;

// // public class VendingMachine
// // {
// //     // 1. THE HIDDEN DATA (Inside the steel box)
// //     private int _cansOfSoda = 10;
// //     private decimal _moneyInside = 0m;

// //     // 2. THE PUBLIC GATEWAY (The Coin Slot)
// //     public void InsertCoin(decimal coinAmount)
// //     {
// //         // We set the rules! Only accept valid coins.
// //         if (coinAmount > 0) 
// //         {
// //             _moneyInside += coinAmount;
// //             Console.WriteLine($"Accepted ${coinAmount}. Total: ${_moneyInside}");
// //         }
// //         else
// //         {
// //             Console.WriteLine("Machine spits out invalid coin.");
// //         }
// //     }

// //     // 3. THE PUBLIC GATEWAY (The Soda Button)
// //     public void PressButton()
// //     {
// //         // We set the rules! They can only get a soda if they paid and we have stock.
// //         if (_moneyInside >= 1.50m && _cansOfSoda > 0)
// //         {
// //             _cansOfSoda -= 1;        // Give soda
// //             _moneyInside -= 1.50m;   // Take money
// //             Console.WriteLine("Ka-chunk! Here is your soda.");
// //         }
// //         else
// //         {
// //             Console.WriteLine("Not enough money, or out of stock.");
// //         }
// //     }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         VendingMachine machine = new VendingMachine();

// //         // The user CANNOT touch _moneyInside directly. 
// //         // They MUST use the public gateway we provided:
// //         machine.InsertCoin(1.00m);
// //         machine.InsertCoin(0.50m);
// //         machine.InsertCoin(0.50m);
        
// //         machine.PressButton();
// //     }
// // }
// using System;
// using System.Diagnostics;
// public class Enemy
// {
//     public int Health { get; set; }
//     public int Damage { get; set; }

    
//   public void TakeDamage(int amount)
//     {
//         Health -= amount;
//         Console.WriteLine($"Enemy takes {amount} damage. Remaining health: {Health}");
//     }
// }
// public class Goblin : Enemy
// {
//     public void StealGold()
//     {
//         Console.WriteLine("The goblin steals 100 pieces of gold!");
//     }
// }
// public class Animal
// {
//     public void Breathe()=> Console.WriteLine("the animal is breathinh oxygen");
// }

// class Mammal : Animal
// {
//     public void GiveMilk()=> Console.WriteLine("the cow gives milk");
// }
// class Cow: Mammal
// {
//     public void Mow()=> Console.WriteLine("the cow is mooing");
// }

// public class Vegetable
// {
//     public string Color { get; set; }
//     public Vegetable(string color)
//     {
//         Color = color;
//         Console.WriteLine($"A {Color} vegetable is created.");
//     }
// }

// public class Hak : Vegetable
// {
//     public int Pieces { get; set; }
//     public Hak(string color, int pieces) : base(color)
//     {
//         Pieces = pieces;
//         Console.WriteLine($"The hak is cut into {Pieces} pieces.");
//     }
// }

// class Program
// {
// static void Main()
//     {
//         Goblin myGoblin = new Goblin();
//         myGoblin.Health = 100;
//         myGoblin.Damage = 15;

//         Console.WriteLine($"Goblin Health: {myGoblin.Health}");
//         Console.WriteLine($"Goblin Damage: {myGoblin.Damage}");

//         myGoblin.TakeDamage(20);
//         myGoblin.StealGold();
//         Cow myCow = new Cow();
//         myCow.Breathe();        
//         myCow.GiveMilk();
//         myCow.Mow();
//           Hak myHak= new Hak("green", 5);



//     }
// }