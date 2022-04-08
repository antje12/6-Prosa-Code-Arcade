using Seven_Dwarfs;

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

Console.ReadLine();