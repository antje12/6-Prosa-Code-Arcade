namespace Seven_Dwarfs;

public class House
{
    private List<Dwarf> Cast;
    public List<Dwarf> Room;
    
    public House()
    {
        Cast = new List<Dwarf>();
        Room = new List<Dwarf>();
        
        // populate cast
        Cast.Add(new Doc());
        Cast.Add(new Grumpy());
        Cast.Add(new Happy());
        Cast.Add(new Sneezy());
        //Cast.Add(new Bashful());
        //Cast.Add(new Sleepy());
        //Cast.Add(new Dopey());
        
        // shuffle cast
        Cast = Cast.OrderBy(x => Guid.NewGuid()).ToList();
        
        // put two dwarfs in same room
        Room.Add(Cast[0]);
        Cast.RemoveAt(0);
        Room.Add(Cast[0]);
        Cast.RemoveAt(0);
    }
    
    public void ReadTheRoom()
    {
        var names = Room.Select(x => x.GetType().Name).ToArray();
        Console.WriteLine("In the room we find: [{0}]", string.Join(", ", names));
    }

    public bool InTheRoom(Type name)
    {
        return Room.Any(x => x.GetType() == name);
    }

    public void AddToRoom(Type name)
    {
        var dwarf = Cast.FirstOrDefault(x => x.GetType() == name);
        if (dwarf != null)
        {
            Cast.Remove(dwarf);
            Room.Add(dwarf);
        }
    }

    public void RemoveFromRoom(Type name)
    {
        var dwarf = Room.FirstOrDefault(x => x.GetType() == name);
        if (dwarf != null)
        {
            Room.Remove(dwarf);
            Cast.Add(dwarf);
        }
    }
}