using Seven_Dwarfs;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Press ENTER to generate a new story.");
Console.WriteLine("Press Q to quit");
var input = Console.ReadKey().Key;

while (input != ConsoleKey.Q)
{
    Console.WriteLine("");
    var house = new House();
    
    for (int i = 0; i < house.Room.Count; )
    {
        house.ReadTheRoom();
    
        var current = house.Room[i];
        if (i + 1 < house.Room.Count) // more dwarfs in room
        {
            var next = house.Room[i + 1];
            var result = current.ReactTo(next, house);
            if (result)
            {
                i++;
            }
        }
        else // last dwarf in room
        {
            current.IsLast();
            i++;
        }
    
        Console.WriteLine();
    }
    
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Press ENTER to generate a new story.");
    Console.WriteLine("Press Q to quit");
    input = Console.ReadKey().Key;
}
