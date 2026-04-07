
// // Console.WriteLine("djkf");
// // Console.WriteLine("Enter your name: ");
// // string name1 = Console.ReadLine();
// // string friend2 = Console.ReadLine();

// // Console.WriteLine("Hello, " + name1);
// // Console.WriteLine($"Hello, {friend2}   and  {name1}!");
// // Console.WriteLine("hi " +name1 + " and " + friend2.Trim() + "!");
// // string friend3= "allie";
// // Console.WriteLine(friend3.Replace("allie", "allison"));
// // Console.WriteLine(friend3);
// // friend3 = friend3.Replace("allie", "gazii");
// // Console.WriteLine(friend3);


// // integerrs

// // int a =Console.ReadLine( );

// // int b =Console.ReadLine( );
// // int sum = a + b;
// // Console.WriteLine(sum);
// using System.Collections;
// using System.Xml.Schema;

// // int a = 3;
// // int b = 4; ;
// // int c = a + b;
// // if (a + b > 10)

// // // WRITE VS WRITE LINE 
// // {
// //     Console.WriteLine("the sum is greater than 10");
// // }
// // else
// // {
// //     Console.WriteLine("the sum is less than 10");
// // }

// // for (int i = 1; i <= 6; ++i)
// // {
// //     for (int j = 1; j <= i; ++j)
// //     {
// //         Console.Write("*");
// //     }
// //     Console.WriteLine();
// // }

// var names = new List<string> { "Alice", "Bob", "Charlie" };
// // foreach (var name in names)
// // {
// //     Console.WriteLine(name);
// // }
// // for (int i=0; i<names.Count; i++)
// // {
// //     Console.Write(names[i] + " the names are    ");
// // }
// // var numbers= new List<int> { 1, 2, 3, 4, 5 };
// // foreach (var number in numbers)
// // {
// //     Console.WriteLine($"({number})*({number})");
// //     Console.WriteLine(number*number);
// // }  names.Add("David");
// // foreach(var name in names ){
    
// //    if(names.Contains("Bob")) 
// //    {names.Remove("Bob");}
//     // Console.WriteLine($"Hello, {name.ToUpper()}!");}
// // Console.WriteLine($"The list contains {names.Count} names.");
// // Console.WriteLine($"The last one is {names[^1]} hurry!!.");
// // int [] scores = { 85, 92, 78, 90, 88 };
// List<int> scores =  [85, 92, 78, 90, 88 ];
// // foreach( int score in scores)
// // {
// //     int x= score * 10;
// //     Console.Write($" scores {score} * 10 = {x}  ");
// // }
// // for (int i=0; i<scores.Count; i++)
// // {
// //     if(scores[i] > 90)
// //     {
// //         Console.WriteLine($" scores {scores[i]} is greater than 90");
// //     }
// //     {
// //         Console.WriteLine($" scores {scores[i]} is less than 90");
// //     }
// //     Console.WriteLine($" scores {scores[i]} * 10 = {scores[i]*10}  ");
// // }
// IEnumerable<string> highScores = 
//     from score in scores
//     // where score > 90
//     orderby score descending
//     select $"score is {score}";
//      foreach (string i in highScores)
//      {
//         Console.WriteLine(i);
//      }
//      SortedList<string, int> studentScores = new SortedList<string, int>();
// studentScores.Add("gAlice", 85); 
// studentScores.Add("Bob", 92);
// studentScores.Add("Charlie", 78);
// foreach (KeyValuePair<string, int> entry in studentScores)
// {
//     Console.WriteLine($"Student: {entry.Key}, Score: {entry.Value}");
// }var scores2=scores.Where(s=>s>90).OrderByDescending(s=>s);
// foreach (var score in scores2)
// {
//     Console.WriteLine(score);
// }


//    var  p1 = new Person("gazii","allie",new DateOnly(2001,1,1));
//     var  p2= new Person("aamir","allie",new DateOnly(2001,1,1));
// List<Person> people = [p1,p2];
// Console.WriteLine(people.Count);
// foreach (var person in people)
// {
//     Console.WriteLine($"Name: {person.First} {person.Last}, Date of Birth: {person.DateOfBirth}");
// }
// public class Person (string first, string last, DateOnly DOB)
// {
//     public string First{ get; }= first;
//     public string Last{ get; }=last;
//     public DateOnly DateOfBirth{ get; }= DOB;
// }


