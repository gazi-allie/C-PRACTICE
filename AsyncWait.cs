// // // using System;
// // // using System.Threading.Tasks;
// // // public class PlyerPf
// // // {
// // //     public string Username { get; set; }
// // //     public int Level { get; set; }

// // // }


// // // class Program
// // // {
// // //     static async Task Main()
// // //     {
// // //         Console.WriteLine("----------Game menue___");
// // // Console.WriteLine("Fetching player profile...\n");
// // // Task<PlyerPf> playerProfileTask = FetchPlayerProfileAsync("Gamer123");
// // //         while (playerProfileTask.IsCompleted == false)
// // //         {
// // //             Console.WriteLine("Loading...");
// // //             await Task.Delay(500);
// // //         }

// // //         PlyerPf profile = await playerProfileTask;
// // //         Console.WriteLine($"Welcome back, {profile.Username}! You are currently at level {profile.Level}.");
// // //     }

// // //     static async Task<PlyerPf> FetchPlayerProfileAsync(string username)
// // //     {
// // //         await Task.Delay(1000);
// // //         return new PlyerPf { Username = username, Level = 5 };
// // //     }
// // // }

// // //  Generics book<T>  T == type 
// // // / this is the type where we did not know what type of data is in the class or method it will only know when it runs the code 
// // using System;
// // using System.Security.Cryptography.X509Certificates;
// // using System.Threading.Tasks;


// // public class LootBox<T>
// // {
// //     private T _hiddenLoot;
// //     public bool IsOpened { get; private set; }=false;
// //     public LootBox(T loot)
// //     {
// //         _hiddenLoot = loot;
// //     }
// //     public async Task<T> Open()
// //     {
// //         if (IsOpened)
// //         {
// //             throw new InvalidOperationException("Loot box is already opened!");
// //         }
// //         Console.WriteLine("Opening loot box...");
// //         await Task.Delay(3000);

// //         IsOpened = true;    
// //         Console.WriteLine("Loot box opened! Revealing loot...");
// //         return _hiddenLoot;
// //     }
// // }
// // class Program
// // {
    

// //     static void PrintAnything<T>(T item)
// //     {
// //         Console.WriteLine($" you gave me a {item.GetType().Name} with value of : {item}");
// //     }


// // static void Main()
// // {
// //     PrintAnything(42);
// //     PrintAnything("Hello, World!");
// //     PrintAnything(3.14);
// //     PrintAnything(23.3434334);

// //     LootBox<string> weaponBox = new LootBox<string>("Excalibur Sword");
// //     LootBox<int> goldBox = new LootBox<int>(1000);
// //     int gold = goldBox.Open().Result;
// //     Console.WriteLine($"You received {gold} gold!");
// //      string weapon = weaponBox.Open().Result;
// //     Console.WriteLine($"You received the {weapon}!");

// // }

// // }

// using System;

// // RULE 1: Must be a static class!
// // Standard naming convention is to add "Extensions" to the name.
// public static class StringExtensions
// {
//     // RULE 2: Must be a static method!
//     // RULE 3: The 'this string' tells C# to attach this to ALL strings everywhere!
//     public static bool IsCapitalized(this string text)
//     {
//         if (string.IsNullOrEmpty(text)) return false;
        
//         // Check if the first letter matches its uppercase version
//         return text[0] == char.ToUpper(text[0]);
//     }

//     // Let's make another one that counts words!
//     public static int WordCount(this string text)
//     {
//         // Split the string by spaces, and count how many pieces there are
//         return text.Split(' ').Length;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string myName = "Arthur";
//         string sentence = "The quick brown fox jumps over the lazy dog";

//         // LOOK AT THIS MAGIC! 
//         // It looks like Microsoft wrote these methods!
//         bool isCap = myName.IsCapitalized(); 
//         int count = sentence.WordCount();

//         Console.WriteLine($"Is '{myName}' capitalized? {isCap}");
//         Console.WriteLine($"The sentence has {count} words.");
//     }
// }

// // string builder 
using System;
using System.Text; // REQUIRED!

class Program
{
    static void Main()
    {
        Console.WriteLine("Building a massive string...");

        // 1. Create the empty Whiteboard
        StringBuilder myWhiteboard = new StringBuilder();

        // 2. We can safely loop 10,000 times without crashing the memory!
        for (int i = 0; i < 10000; i++)
        {
            myWhiteboard.Append("A"); // Instantly writes to the whiteboard
        }

        // 3. When we are 100% finished, we take a picture of the whiteboard 
        // and convert it into a final, locked String (Stone Tablet).
        string finalResult = myWhiteboard.ToString();

        Console.WriteLine($"Finished! The string is {finalResult.Length} characters long.");
    }
}