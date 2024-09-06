// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("enter your name:");  //output
//string - sõne
string userName = Console.ReadLine();  //input


Console.WriteLine("Hello" + " "+ userName + "!");
//string interpolation

Console.WriteLine($"Hello {userName}  !");

