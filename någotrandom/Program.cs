
string name = "";
string favoritecolor = "";
string age = "";
string levon = "";

Console.WriteLine("Hej! Vad heter du?");
name = Console.ReadLine();

Console.WriteLine($"Hej {name}, skriv din favoritfärg.");
favoritecolor = Console.ReadLine();

Console.WriteLine($"Okej så du din favoritfärg är {favoritecolor}. Men hur gammal är du?");
age = Console.ReadLine();

Console.WriteLine($"Beskriv Levon.");
levon = Console.ReadLine();

Console.WriteLine($"Det finns ingen chans att du heter {name} och att din favorit färg är {favoritecolor}.");
Console.WriteLine($"Det är helt sjukt att du är {age} och är såhär korkad!!!");
Console.WriteLine($"Ditt beskrivning om Levon var bra.");

Console.WriteLine("Tryck på Enter för att avsluta. :D");
Console.ReadLine();
