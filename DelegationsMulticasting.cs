// using System;


// public class Player
// {
//     public string Name{ get; set; }
//     public int Health { get; private set; }=100;
//     public event Action onDeath;
//     public Player(string name)
//     {
//         Name = name;
//     }
//     public void TakeDamage(int damage)
//     {
//         Health -= damage;
//         Console.WriteLine($"{Name} takes {damage} damage. Health is now {Health}.");

//         if (Health <= 0)
//         {
//             Console.WriteLine($"{Name} has died.");
           
//         }
//         if (onDeath != null)
//         {
//             onDeath();
//         }
//     }
// }
// public class AudioSystem
// {
//     public void PlayDeathSound()
//     {
//         Console.WriteLine("Playing death sound...");
//     }
// }
// class Program
// {
//     // Three completely separate systems!
//     static void SoundSiren() => Console.WriteLine("WEE-WOO WEE-WOO!");
//     static void LockDoors() => Console.WriteLine("*CLANK* Doors locked.");
//     static void CallPolice() => Console.WriteLine("Dialing 911...");

//     static void Main()
//     {
//         Player hero = new Player("Arthur");
//         AudioSystem audio = new AudioSystem();
//         hero.onDeath += audio.PlayDeathSound;

//         // 3. THE SUBSCRIPTION
//         // The Audio System listens for the Player's death event.
        
//         // hero.onDeath = null; // 🚨 ERROR! You cannot use '=' on an event!
//         // hero.onDeath();      // 🚨 ERROR! You cannot trigger someone else's event!

//         // 4. THE TRIGGER
//         // We deal massive damage. The Player will hit 0 HP and trigger its OWN event!
//         hero.TakeDamage(150);

//         // 1. Create the button
//         Action redAlertButton = null;

//         // 2. MULTICASTING: We "Subscribe" all three methods to the button!
//         redAlertButton += SoundSiren;
//         redAlertButton += LockDoors;
//         redAlertButton += CallPolice;

//         // 3. PRESS THE BUTTON!
//         Console.WriteLine("--- PRESSING RED ALERT ---");
        
//         // This ONE line of code fires all three methods instantly!
//         redAlertButton(); 
        
//         // 4. UNSUBSCRIBING
//         // If the police arrive, we can remove them from the button using -=
//         redAlertButton -= CallPolice;
//     }
// }