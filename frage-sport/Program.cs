using System.Linq;

// Fn + F1 ger till gitIgnore

int points = 0;
Console.WriteLine("Välkomen till min league of legends frågesport!");

//------------------------------------------------------

// "!" betyder om inte

Console.WriteLine("Hur många Champions finns det?");
Console.WriteLine("a) 159  b) 168  c) 184");
string answer1 = Console.ReadLine();
string[] acceptable = ["a", "b", "c"];

while (!acceptable.Contains(answer1)){
    Console.WriteLine("Okänt Svar");
    answer1 = Console.ReadLine();
}

if (answer1 == "b") {
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadKey();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadKey();
}

// -----------------------------------------------------

Console.WriteLine("Hur många Champions finns det?"); //placeholder fråga
Console.WriteLine("a) 159  b) 168  c) 184"); //placeholder alternativ
string answer2 = Console.ReadLine();

while (!acceptable.Contains(answer2)){
    Console.WriteLine("Okänt Svar");
    answer2 = Console.ReadLine();
}

if (answer2 == "b") { //placeholder rätt svar
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadKey();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadKey();
}

// -----------------------------------------------------

Console.WriteLine("Hur många Champions finns det?"); //placeholder fråga
Console.WriteLine("a) 159  b) 168  c) 184"); // placeholder alternativ
string answer3 = Console.ReadLine();

while (!acceptable.Contains(answer3)){
    Console.WriteLine("Okänt Svar");
    answer3 = Console.ReadLine();
}

if (answer3 == "b") { //placeholder rätt svar
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadKey();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadKey();
}

// ------------------------------------------------------

Console.WriteLine("");
