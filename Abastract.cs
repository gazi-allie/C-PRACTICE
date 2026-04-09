// using System;

// public abstract class Shape
// {
//     public string Color{get;set;}
    
    
//     public void PrintColor(){
//         Console.WriteLine($"The color of the shape is {Color}");
//     }
//     public abstract void Draw();
// }

// public class Circle : Shape
// {
//     public double Radius { get; set; }
    
//     public override void Draw()
//     {
//         Console.WriteLine($"Drawing a circle with radius {Radius}");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Circle circle = new Circle();
//         circle.Color = "Red";
//         circle.Radius = 5.0;
        
//         circle.PrintColor();
//         circle.Draw();
//          Duck duck = new Duck();
//         duck.Fly(true);
//         duck.Swim(false);
//         Airplane Airplane = new Airplane();
//         Airplane.Swim(true);
//         Airplane.Fly(true); 
//         List<IFlayable> flyingObjects = new List<IFlayable>();
//         flyingObjects.Add(duck);
//         flyingObjects .Add(Airplane);
//          foreach(var obj in flyingObjects)
//         {
//             Console.WriteLine("Flying object: " + obj.GetType().Name);
//             obj.Fly(true);
//         }
//     }
// }
// public interface IFlayable
// {
//     void Fly(bool isFlying);

// }public interface ISwimmable
// {
//     void Swim(bool isSwimming);
// }
// public class Duck : IFlayable, ISwimmable
// {
//     public void Fly(bool isFlying)
//     {
//         if(isFlying)
//         {
//             Console.WriteLine("The duck is flying.");
//         }
//         else
//         {
//             Console.WriteLine("The duck is not flying.");
//         }
//     }
    
//     public void Swim(bool isSwimming)
//     {
//         if(isSwimming)
//         {
//             Console.WriteLine("The duck is swimming.");
//         }
//         else
//         {
//             Console.WriteLine("The duck is not swimming.");
//         }
//     }
// }public class Airplane : IFlayable, ISwimmable
// {
//     public void Fly(bool isFlying)
//     {
//         if(isFlying)
//         {
//             Console.WriteLine("The airplane is flying.");
//         }
//         else
//         {
//             Console.WriteLine("The airplane is not flying.");
//         }
//     }
//     public void Swim(bool isSwimming)
//     {
//         if(isSwimming)
//         {
//             Console.WriteLine("The airplane is swimming.");
//         }
//         else
//         {
//             Console.WriteLine("The airplane is not swimming.");
//         }
//     }   
// }
