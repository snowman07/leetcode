// See https://aka.ms/new-console-template for more information

//REFERENCE: https://www.youtube.com/watch?v=aLhAmimoQj8

//Console.WriteLine("Hello, World!");

using ListOfObjects;

List<Player> players = new List<Player>();

//Player player1 = new Player("First");
//Player player2 = new Player("Second");
//Player player3 = new Player("Third");

players.Add(new Player("First"));
players.Add(new Player("Second"));
players.Add(new Player("Third"));

foreach (Player p in players)
{
    //Console.WriteLine(p.username);

    //override ToString 
    Console.WriteLine(p);

}

