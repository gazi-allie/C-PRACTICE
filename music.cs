// using System;
// using System.Threading;

// public class Appconfig
// {
//     public static bool IsDarkMode { get; set; }
//     public static int Volume { get; set; }
//     public static string Language { get; set; }

//     static Appconfig()
//     {
//        Console.WriteLine("Initializing Appconfig...");
//        Console.WriteLine("[SYSTEM ]searching for boot hard drive user setting -----.......");
        
//         Thread.Sleep(2000);

//         IsDarkMode = true;
//         Volume = 75;
//         Language = "English";
//         Console.WriteLine("Appconfig initialized successfully.\n");

//     }

// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Appconfig Settings:");
//         Console.WriteLine($"Dark Mode: {Appconfig.IsDarkMode}");
//         Console.WriteLine($"Volume: {Appconfig.Volume}");
//         Console.WriteLine($"Language: {Appconfig.Language}\n"); 
//         Console.WriteLine("User opens Spotify App...");
//         Console.WriteLine("Loading Home Screen...\n");

//         // --- FIRST ACCESS ---
//         // The moment we type "AppConfig.", C# pauses, checks if the static constructor 
//         // has ever been run, and runs it right now before continuing.
//         Console.WriteLine($"[HOME SCREEN] Theme is Dark Mode: {Appconfig.IsDarkMode}\n");

        
//         Console.WriteLine("User clicks on 'Your Library'...");
//         // --- SECOND ACCESS ---
//         // C# knows the static constructor already ran. It skips it! Lightning fast!
//         Console.WriteLine($"[LIBRARY SCREEN] Volume set to: {Appconfig.Volume}%\n");


//         Console.WriteLine("User clicks on 'Settings'...");
//         // --- THIRD ACCESS ---
//         // Skipped again! Lightning fast!
       
//         Console.WriteLine($"[SETTINGS SCREEN] App Language: {Appconfig.Language}\n");
//      Car myCar = new Car();
//         myCar.Color = "Red";
//         Car myCar2= myCar;
//         myCar2.Color = "Blue";
//         Console.WriteLine($"My car color is: {myCar.Color}"); // Output: My car color is: Blue
//         Console.WriteLine($"My car2 color is: {myCar2.Color}"); // Output: My car2 color is: Blue
//     }


// }
// public class Car
// {
//     public string Color { get; set; }
// }