using System;
// public class Player
// {
//     public string Name;
//     public int health;
//     public void Greet()
//     {
//         Console.WriteLine($"Hello, {Name}! player health is  {health}");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Player player1 = new Player();
//         player1.Name = "Alice";
//         player1.health = 100;
//         Player plyer2 = new Player();
//         plyer2.Name = "Bob";
//         plyer2.health = 100;    

//   Dog dog1 = new Dog();
//         dog1.Name = "Buddy";
//         dog1.Age = 3;
//         Dog dog2 = new Dog();
//         dog2.Name = "Max";
//         dog2.Age = 5;    

//         dog1.Bark();
//             dog2.Bark();
//         player1.Greet();

//             plyer2.Greet();
//     }
// }

// public class Dog
// {
//     public string Name;
//     public int Age;
//     public void Bark()
//     {
//         Console.WriteLine($"Woof! My name is {Name} and I am {Age} years old.");
//     }
// }

public class Dog
{
    public string Name;
    public int Age;
    public void Bark()
    {
        Console.WriteLine($"Woof! My name is {Name} and I am {Age} years old.");
    }
    public void sit()
    {
        Console.WriteLine($"{Name} is sitting.");
    }
    public void fetch(string item)
    {
        Console.WriteLine($"{Name} is fetching the {item}.");
    }
}
class Program
{
    static void Main()
    {
        Dog dog1 = new Dog();
        dog1.Name = "Buddy";
        dog1.Age = 3;
        Dog dog2 = new Dog();
        dog2.Name = "Max";
        dog2.Age = 5;

        dog1.Bark();
        dog1.sit();
        dog2.fetch("ball");
        dog1.fetch("stick");
       Gamer gamer1 = new Gamer("Alice", 100);
       Gamer gamer2 = new Gamer("Bob", 100);    
       
         Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("To Kill a Mockingbird");
             Book book3 = new Book("1984");
             Console.WriteLine($"Book 1: '{book1.Title}' by {book1.Author}");
             Console.WriteLine($"Book 2: '{book2.Title}' by {book2.Author}");
             Console.WriteLine($"Book 3: '{book3.Title}' by {book3.Author}");
    }
}


public class Gamer
{
    public string Name{get; set;}
    public int Health{get; set;}

    public Gamer(string name, int health)
    {
        Name = name;
        Health = health;
         Console.WriteLine($"Gamer {Name} created with health {Health}.");
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
     public Book (string title, string author)
    {
        Title = title;
        Author = author;
        Console.WriteLine($"Book '{Title}' by {Author} created.");
    }
    public Book(string title)
    {
        Title = title;
        Author = "Unknown";
        //Console.WriteLine($"Book '{Title}' by {Author} created.");
    }
}