// // using System;
// // using System.Drawing;

// // public struct Point3D{
// //     public float X{get;set;}
// //     public float Y{get;set;}
// //     public float Z{get;set;}

// //     public Point3D(float x, float y, float z){
// //         X = x;
// //         Y = y;
// //         Z = z;
// //     }
    
// // }
// // class Program
// // {
// //     public static void Main(string[] args)
// //     {
// //         Point3D point1 = new Point3D(1.0f, 2.0f, 3.0f);
// //         Console.WriteLine($"Point1: X={point1.X}, Y={point1.Y}, Z={point1.Z}");
        
// //         Point3D point2 = point1; // Copying the struct
// //         point2.X = 4.0f;
// //         point2.Y=4.5f; // Modifying point2 does not affect point1
        
// //         Console.WriteLine($"Point2: X={point2.X}, Y={point2.Y}, Z={point2.Z}");
// //         Console.WriteLine($"Point1 after modification: X={point1.X}, Y={point1.Y}, Z={point1.Z}");
// //     }
// // }

// using System;
// public enum CoffeSize
// {
//     small ,
//     medium,
//     large
    
// }
// public class CoffeeOrder
// {
//     public CoffeSize  Size {get;set;}
//     public decimal Price{ get; private set;}
//     public CoffeeOrder(CoffeSize requestsize)
//     {
//         Size = requestsize;
//         ClculatePrice();}
//         public void ClculatePrice(){
            
//         switch(Size)
//         {
//             case CoffeSize.small:
//                 Price = 2.50m;
//                 break;
//             case CoffeSize.medium:
//                 Price = 3.50m;
//                 break;
//             case CoffeSize.large:
//                 Price = 4.50m;
//                 break;
//         }
//     }
// }
// public struct RGBcolor
// {
//     public int R { get; set; }
//     public int G { get; set; }
//     public int B { get; set; }

//     public RGBcolor(int r, int g, int b)
//     {
//         R = r;
//         G = g;
//         B = b;
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         CoffeeOrder order1 = new CoffeeOrder(CoffeSize.medium);
//         Console.WriteLine($"Order1: Size={order1.Size}, Price={order1.Price}");
       
//         CoffeeOrder order2 = new CoffeeOrder(CoffeSize.large);
//         Console.WriteLine($"Order2: Size={order2.Size}, Price={order2.Price}");

//         RGBcolor pureRed = new RGBcolor(255,0,0);
//         RGBcolor mycolor = pureRed;
//         mycolor.B=128;
//         Console.WriteLine($"Pure red blure value is :{pureRed.B}");
//         Console.WriteLine($"My color blure value is :{mycolor.B}");
//         Console.WriteLine($"My color: R={mycolor.R}, G={mycolor.G}, B={mycolor.B}");
//     }
// }

