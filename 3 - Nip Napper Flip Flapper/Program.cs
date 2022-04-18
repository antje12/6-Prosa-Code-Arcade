using Nip_Napper;

var game = new NipNapper();

var input = GetInput();
game.ChooseField(input);
input = GetInput();
game.ChooseField(input);
input = GetInput();
var output = game.ChooseField(input);

Console.WriteLine(output);

string GetInput()
{
    while (true)
    {
        Console.WriteLine("Choose a field:");
        var options = String.Join(", ", game.GetFields());
        Console.WriteLine(options);

        var input = Console.ReadLine();
        if (game.GetFields().Contains(input))
        {
            return input;
        }
    }
}