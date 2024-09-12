using System.Linq;

// Fn + F1 ger till gitIgnore -> Visual Studio

int points = 0;
Console.Clear();
Console.WriteLine("Välkomen till min league of legends frågesport!");

//------------------------------------------------------

// "!" betyder om inte

Console.WriteLine("Hur många Champions finns det?");
Console.WriteLine("a) 159  b) 168  c) 184");
string answer1 = Console.ReadLine();
string[] acceptable = ["a", "b", "c"];

while (!acceptable.Contains(answer1)){
    Console.WriteLine("Okänt Svar. Försök igen");
    answer1 = Console.ReadLine();
}

if (answer1 == "b") {
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadLine();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadLine();
}

// -----------------------------------------------------

Console.Clear();
Console.WriteLine("Vem av dessa tre är en Yordel??");
Console.WriteLine("a) Tristana  b) Jhin  c) Vayne");
string answer2 = Console.ReadLine();

while (!acceptable.Contains(answer2)){
    Console.WriteLine("Okänt Svar. Försök igen");
    answer2 = Console.ReadLine();
}

if (answer2 == "a") {
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadLine();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadLine();
}

// -----------------------------------------------------

Console.Clear();
Console.WriteLine("Vem av dessa ÄR normalt spelat i Bot Lane?"); 
Console.WriteLine("a) K'Sante  b) Kha'Zix  c) Kai'Sa "); 
string answer3 = Console.ReadLine();

while (!acceptable.Contains(answer3)){
    Console.WriteLine("Okänt Svar. Försök igen");
    answer3 = Console.ReadLine();
}

if (answer3 == "c") { 
    points++;
    Console.WriteLine("Korrekt!");
    Console.ReadLine();
}
else {
    Console.WriteLine("Inkorrekt!");
    Console.ReadLine();
}

// ------------------------------------------------------

Console.Clear();
Console.WriteLine($"Du fick {points} poäng");

if (points == 0) {
    Console.WriteLine("Du har absolut ingen koll alls.");
} 
else if (points < 3) {
    Console.WriteLine("Du fick minst en rätt, yippie!");
}
else {
    Console.WriteLine("Du fick alla rätt! Gud vad bra du är på league :D");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta");
Console.ReadKey();
