// See https://aka.ms/new-console-template for more information

Program.PrintTest("this is a test", 't');
Program.PrintTest("how about this one", 'o');
Program.PrintTest("this is another demo", ' ');

static partial class Program {
    /// <summary>
    /// Returns the most frequent character in a given string.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>The most frequent character</returns>
    public static char? GetMostFrequentCharacterIgnoreCase(string input){
        Dictionary<char, int> characters = new();
        foreach(var character in input){
            if(characters.ContainsKey(character)){
                characters[character]++;
            }
            else{
                characters.Add(character, 1);
            }
        }

        return characters.OrderByDescending(x => x.Value).FirstOrDefault().Key;
    }

    public static void PrintTest(string input, char expectedCharacter){
        var result = Program.GetMostFrequentCharacterIgnoreCase(input);
        if(result == expectedCharacter){
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else{
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine($"Input string: '{input}' most frequent character: '{expectedCharacter}'");
    }
}

