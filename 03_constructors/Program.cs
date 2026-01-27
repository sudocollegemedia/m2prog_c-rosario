namespace _03_constructors;
class Program

{

internal void run(string[] args)
    {
     QuizQuestion QuizQuestion = new QuizQuestion("haaq", "aaa");
     Quiz.VoegVraagToeOpIndex(2, "fish");

    }

static void Main(string[] args)
    {
        Program program = new Program();
        program.run(args);
    }

}