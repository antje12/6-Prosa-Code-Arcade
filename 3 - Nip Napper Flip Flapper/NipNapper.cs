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
            {1, "Aglet 1"},
            {2, "Aglet 2"},
            {3, "Aglet 3"},
            {4, "Aglet 4"},
            {5, "Aglet 5"},
            {6, "Aglet 6"},
            {7, "Aglet 7"},
            {8, "Aglet 8"}
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