namespace Nip_Napper;

public class NipNapper
{
    private int currentLayer;
    private int currentState;
    private Dictionary<int, string> texts;

    public NipNapper()
    {
        currentLayer = 1;
        currentState = 1;
        texts = new()
        {
            {1, @"AGLET må være et akronym,  men hvad står det for? Opdigt en forklaring til akronymet."},
            {2, @"En Aglet er en snørebåndsdup, tæl hvor mange der er på alle dine sko sammenlagt."},
            {3, @"Lad os stave Aglet i lande. Find et land der starter med A, G, L, E, og T."},
            {4, @"Hvis man bytter rundt på bogstaverne i ordet 'Aglet' kan man eksempelvis stave til 'Glat'. 
Hvilke andre ord kan du stave til med A, G, L, E, og T?"},
            {5, @"Aglet er et underligt ord. Hvor mange ord kan du finde der rimer på Aglet?"},
            {6, @"Løs denne rebus: 'kage -k -e + juletræ -ju -ræ' = "},
            {7, @"Hvor mange gange kan du finde ordet Aglet i dette wordpuzzle:
A	D	T	L	A
G	G	E	G	D
L	D	L	Y	Z
E	E	G	E	P
T	H	A	V	T"},
            {8, @"Find på en sang der indeholder ordet 'Aglet'"}
        };
    }

    public string[] GetFields()
    {
        switch (currentLayer)
        {
            case 1:
                return new[] {"1", "2", "3", "4"};
            default:
                switch (currentState)
                {
                    case 1:
                        return new[] {"1", "2", "5", "6"};
                    default:
                        return new[] {"3", "4", "7", "8"};
                }
        }
    }

    public string ChooseField(string field)
    {
        var num = int.Parse(field);
        switch (currentLayer)
        {
            case 1:
            case 2:
                FlipFlap(num);
                return "";
            default:
                return texts[num];
        }
    }

    private void FlipFlap(int count)
    {
        currentLayer++;
        currentState = (currentState + count) % 2;
    }
}