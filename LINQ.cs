// using System;
// using System.Collections.Generic;
// using System.Diagnostics.Tracing;
// using System.Linq;
// using System.Net.NetworkInformation;
// // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// // List<int> even= new List<int>();

// // foreach(int num in numbers)
// // {
// //     if (num%2==0){
// //         even.Add(num);
// //             }


// // }
// // for (int i=0; i<even.Count; i++)
// // {
// //     Console.WriteLine(even[i]);
// // }
// // List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18,19,20 };

// // List<int> odd= numbers2.Where(num=> num%2 != 0).ToList();
// // foreach(int num in odd)
// // {
// //     Console.WriteLine(num);
// // }
// // // class Program
// // // {
// // //     for(int i=0; i<even.Count; i++)
// // //     {
// // //         Console.WriteLine(even[i]);
// // //     }
// // // }

// public class Rectangle
// {
//     public int Height { get; set; }
//     public int Width { get; set; }

//     public int Area => Height * Width;
// }
// public class  BankAccount
// {
//     public string AccountNumber{get;}
//     public decimal Balance {get; set;}

//     public BankAccount(string newAccountNumber)
//     {
//         AccountNumber = newAccountNumber;
//         Balance =0;
//     }
// }
// public class RpgParty
// {
//     private Dictionary< string, string> _players= new Dictionary<string, string>();

//     public string this[string role]
//     {
//         get
//         {
//             if (_players.ContainsKey(role))
//             {
//                 return _players[role];
//             }
//             else
//             {
//                 return $"No player assigned to the {role} role.";
//             }
//         }
//         set
//         {
//             _players[role] = value;
//         }
//     }
// }
// public class HighScoreBoard
// {
//     private Dictionary<string, int>_scores= new Dictionary<string, int>();
//     public int this[string playerName]
//     {
//         get
//         {
//             if(_scores.ContainsKey(playerName))
//             {
//                 return _scores[playerName];
//             }
//             else
//             {
//                 return 0;
//             }
//         }
//         set{
//             _scores[playerName]= value;
//         }
//     }
   
//             }
   
// class Program
// {

//     // Three completely separate systems!
//     static void SoundSiren() => Console.WriteLine("WEE-WOO WEE-WOO!");
//     static void LockDoors() => Console.WriteLine("*CLANK* Doors locked.");
//     static void CallPolice() => Console.WriteLine("Dialing 911...");
//        static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     public static void Main(string[] args)

//     {
//         Action redAlertButton = null;

//         // 2. MULTICASTING: We "Subscribe" all three methods to the button!
//         redAlertButton += SoundSiren;
//         redAlertButton += LockDoors;
//         redAlertButton += CallPolice;

//         // 3. PRESS THE BUTTON!
//         Console.WriteLine("--- PRESSING RED ALERT ---");
        
//         // This ONE line of code fires all three methods instantly!
//         redAlertButton();

//  Func<int, int, int> addFunc;

//  addFunc = Add;
//  int result = addFunc(5, 10);
//  Console.WriteLine($"The result of adding 5 and 10 is: {result}");

//         HighScoreBoard board = new HighScoreBoard();

//         board["Alice"] = 1500;
//         board["Bob"] = 2000;
//         Console.WriteLine($"Alice's score: {board["Alice"]}");
//         Console.WriteLine($"Bob's score: {board["Bob"]}");
//         RpgParty myParty = new RpgParty();
//         myParty["Tank"] = "Alice";
//         myParty["Healer"] = "Bob";
//      Console.WriteLine($"Our tank is {myParty["Tank"]}.");
//         Console.WriteLine($"Our archer is {myParty["Archer"]}.");
//         Console.WriteLine($"Our healer is {myParty["Healer"]}.");
//          BankAccount myAccount = new BankAccount("cljld df90990");
//          myAccount.Balance=5000;
//         // myAccount.AccountNumber="cljld df90dfd990";


//         Rectangle rect1 = new Rectangle { Height = 2, Width = 3 };
//         List<Rectangle> rectangles = new List<Rectangle>
//         {
//             new Rectangle { Height = 2, Width = 3 },
//             new Rectangle { Height = 4, Width = 5 },
//             new Rectangle { Height = 1, Width = 6 }
//         };

//         var areas = rectangles.Select(rect => rect.Area).ToList();

//         foreach (var area in areas)
//         {
//             Console.WriteLine($"Area: {area}");
//         }
//     }

       
// }