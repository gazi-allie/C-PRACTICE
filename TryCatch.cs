// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Voter voter1 = new Voter { Name = "Alice", Age = 25 };
//         Voter voter2 = new Voter { Name = "Bob", Age = 18 };

//         voter1.Vote();
//         voter2.Vote();
//             while(true){
//         Console.WriteLine("Please enter your age:");
//         string userInput = Console.ReadLine();

//         try
//         {
//             int age= int.Parse(userInput);
//             Console.WriteLine($"You entered age: {age}");
//             Voter voter = new Voter { Name = "User", Age = age };
//                 voter.Vote();
            
//             break;
//         }
//         catch(FormatException)
//          {
//             Console.WriteLine("Invalid input. Please enter a valid integer for age.");
//          }
//         catch(OverflowException)
//         {
//             Console.WriteLine("The number you entered is too large or too small for an int.");
//         }
//         catch(Exception ex)
//         {
//             Console.WriteLine($"An unexpected error occurred: {ex.Message}");
       
//     }
//     }}
        
// }
// public  class Voter
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public void Vote()
//     {
//         if (Age>= 20)
//         {
//             Console.WriteLine($"{Name} is eligible to vote.");
//         }
//         else
//         {
//             Console.WriteLine($"{Name} is not eligible to vote.");
//         }
//     }
// }
