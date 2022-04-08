using Seven_Dwarfs;

var house = new House();

for (int i = 0; i < house.Room.Count; i++)
{
    house.ReadTheRoom();
    
    var current = house.Room[i];
    if (i + 1 < house.Room.Count) // more dwarfs in room
    {
        var next = house.Room[i + 1];
        current.ReactTo(next, house);
    }
    else // last dwarf in room
    {
        current.IsLast();
    }
}
