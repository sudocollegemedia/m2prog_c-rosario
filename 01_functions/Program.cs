namespace _01_functions;

class Program
{
    private static readonly string[] questions = new string[]
    {
        "How many?",
        "How long do you think you'd survive in a zombie apocalypse?",
        "What secret conspiracy would you like to actually start letting other people know?",
        "If you can still remember, what are your funniest childhood memories?",
        "What would you do if you won a million dollars?",
        "What would you do if you won a million fishes?",
        "What's your favorite memory?"
    };

    internal static void Main(string[] args)
    {
        Program program = new Program();
        program.AskRandomQuestion();
    }

    internal void AskRandomQuestion()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, questions.Length);
        
        Console.WriteLine(questions[randomIndex]);
        string answer = Console.ReadLine();
        Console.WriteLine(answer);
    }
}

