Random rnd = new Random();
int r;
string input = "";

Slime Slime = new Slime();
Player Player = new Player();

Console.WriteLine("A wild Slime has appeared!");
Console.WriteLine($"{Player.name} ({Player.hp} health) vs {Slime.name} ({Slime.hp} health)");
Console.WriteLine("\nPress any key to continue");
Console.ReadLine();
Console.WriteLine("Player starts!");
Console.WriteLine("\nWhat would you like to do?");
Console.WriteLine("Type '1' to Attack or '2' to Defend");
input = Console.ReadLine().ToLower();
if (input == "1") {
    Console.WriteLine("You attack!");
    r = rnd.Next(3);
    if (r == 0) {
        Console.WriteLine("Slime defended!");
        Console.WriteLine("Slime lost 10 HP");
        Slime.hp-=10;
    }
    else {
        Console.WriteLine("Slime lost 15 HP");
        Slime.hp-=15;
    }
}
else if (input == "2") {
    Console.WriteLine("You try to defend!");
    r = rnd.Next(3);
    if (r == 0) {
        Console.WriteLine("You failed to defend");
        Console.WriteLine("You lost 5 HP");
        Player.hp-=10;
    }
    else {
        Console.WriteLine("You defended");
        Console.WriteLine("You lost 5 HP");
        Player.hp-=5;
    }
}
else {
    Console.WriteLine("You did nothing");
}

Console.ReadLine();
