namespace Seven_Dwarfs;

// En reaktion der tilkalder en anden karakter.
// En reaktion der får en karakter til at forsvinde, hvilket fjerne den fra listen.

public interface Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house);
    public void IsLast();
}

public class Doc : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Grumpy:
                Console.WriteLine("Doc thinks that Grumpy is making everyone sad, and asks him to smile for a change.");
                break;
            case Happy:
                Console.WriteLine("Doc's work gets distracted by Happy who starts reading jokes from a notebook.");
                break;
            case Sneezy:
                Console.WriteLine("Doc is tired of Sneezy's sneezing, and prescribes him some medicine against hay fever.");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Doc takes notes of who showed up to the meeting. This will be used for next quarter's salary negotiation.");
    }
}

public class Grumpy : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("Grumpy wants to be the leader and challenges Doc to an arm wrestling competition.");
                break;
            case Happy:
                Console.WriteLine("Grumpy's bad day suddenly gets worse as Happy starts joking about his beard.");
                break;
            case Sneezy:
                Console.WriteLine("Grumpy is tired of Sneezy's sneezing and starts yelling at him.");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf there is no one left to piss off Grumpy. For the first time in his life, he smiles.");
    }
}

public class Happy : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("Happy begs Doc for some diamonds to fund his next stand-up show.");
                break;
            case Grumpy:
                Console.WriteLine("Happy can see that Grumpy is having a bad day, and tries to lighten the mood with some jokes.");
                break;
            case Sneezy:
                Console.WriteLine("Happy has been filling Sneezy's pillow with hay as a prank. He can't stop laughing as Sneezy sneezes.");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Happy takes out his notebook and starts writing down jokes for his next stand-up show.");
    }
}

public class Sneezy : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("Sneezy tries to ask Doc for something, but is interrupted by himself sneezing.");
                break;
            case Grumpy:
                Console.WriteLine("Sneezy does not want to bother Grumpy, and tries to stop himself from sneezing. Grumpy thinks that Sneezy is just making funny faces at him.");
                break;
            case Happy:
                Console.WriteLine("Sneezy has had enough of Happy making jokes at his expense. He sneezes extra hard into Happys face.");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Sneezy gets into a sneezing fit, and sneezes so hard, that the roof gets blown off the house.");
    }
}

/*
public class Bashful : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("");
                break;
            case Grumpy:
                Console.WriteLine("");
                break;
            case Happy:
                Console.WriteLine("");
                break;
            case Sneezy:
                Console.WriteLine("");
                break;
            case Sleepy:
                Console.WriteLine("");
                break;
            case Dopey:
                Console.WriteLine("");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Bashful becomes embarrassed for showing up late and hides in the corner.");
    }
}

public class Sleepy : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("");
                break;
            case Grumpy:
                Console.WriteLine("");
                break;
            case Happy:
                Console.WriteLine("");
                break;
            case Sneezy:
                Console.WriteLine("");
                break;
            case Bashful:
                Console.WriteLine("");
                break;
            case Dopey:
                Console.WriteLine("");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Sleepy falls asleep... What a surprise :O");
    }
}

public class Dopey : Dwarf
{
    public void ReactTo(Dwarf nextDwarf, House house)
    {
        switch (nextDwarf)
        {
            case Doc:
                Console.WriteLine("");
                break;
            case Grumpy:
                Console.WriteLine("");
                break;
            case Happy:
                Console.WriteLine("");
                break;
            case Sneezy:
                Console.WriteLine("");
                break;
            case Bashful:
                Console.WriteLine("");
                break;
            case Sleepy:
                Console.WriteLine("");
                break;
        }
    }

    public void IsLast()
    {
        Console.WriteLine("As the last dwarf Dopey starts breakdancing, but slips and falls.");
    }
}
*/