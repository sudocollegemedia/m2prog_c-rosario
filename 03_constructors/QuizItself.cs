namespace _03_constructors
{
    class QuizItself
{
    internal QuizQuestion[] vragen;
    internal QuizQuestionAntwoord[] ingevuldeAntwoorden;

    internal Quiz()
    {
        vragen = new QuizQuestion[aantalVragen];
    }
    

    internal void VoegVraagToeOpIndex(int index, QuizQuestion vraag) { 
        vragen[index] = vraag;
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        VoegVraagToeOpIndex(index, new QuizQuestion("What 1997 N64 video game, features James Bond and is named after the 1995 film ?", "Answer: GoldenEye"));
    }
}
}