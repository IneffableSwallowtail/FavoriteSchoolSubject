// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

string userInput;
for (bool end = false; end != true; )
{
    Console.WriteLine("What is your favorite subject in school?");
    userInput = Console.ReadLine().ToLower();
    switch (userInput)
    {
        case "science":
            Console.WriteLine("\nIf I were a tardigrade I'd move out from home\n" +
                                "Why live in the shrubbery when you could have a throne?\n" +
                                "Pressure wouldn't squash me and fire wouldn't burn\n" +
                                "These are the things that I never will learn\n" +
                                "—Cosmo Sheldrake, \"The Tardigrade Song\"\n");
            break;
        case "english":
            Console.WriteLine("\nAdjectives on the typewriter\n" +
                                "He moves his words like a prizefighter\n" +
                                "A frenzied pace of a mind inside a cell" +
                                "—CAKE, \"Shadow Stabbing\"");
            break;
        case "math":
            Console.WriteLine("\nWe're asymptotic, we're on it\n" +
                                "'til the end of linear time\n" +
                                "asymptotic, divided by the smallest, slimmest line\n" +
                                "—Louie Zong, \"Asymptotic\"\n");
            break;
        case "history":
            Console.WriteLine("\nCome gather 'round people wherever you roam\n" +
                                "and admit that the waters around you have grown\n" +
                                "and accept it that soon you'll be drenched to the bone\n" +
                                "if your time to you is worth saving\n" +
                                "and you'd better start swimming or you'll sink like a stone\n" +
                                "for the times they are a-changin'\n" +
                                "—Bob Dylan, \"The Times They are A-Changin'\n");
            break;
        case "art":
            Console.WriteLine("\nIf you want it, you can have it,\n" +
                                "Every color that you see, see, see\n" +
                                "If you want it, want it bad\n" +
                                "Then build yourself a technicolor masterpiece\n" +
                                "Masterpiece, masterpiece\n\n" +
                                "And many years from now\n" +
                                "The landlord will kick us out\n" +
                                "He'll cover all our sins\n" +
                                "He'll paint it white again\n" +
                                "Lewis Del Mar, \"Painting (Masterpiece)\"\n");
            break;
        default:
            Console.WriteLine("\nSubject not included.\n\n" +
                                "I ask for nothing\n" +
                                "But maybe I'm lying\n" +
                                "I don't know nothing\n" +
                                "But I know I'm trying\n" +
                                "—Lemon Demon, \"Ask for Nothing\"\n");
            break;
    }
    Console.WriteLine("Start over? yes/no");
    string restart = Console.ReadLine();
    if (restart == "yes")
        continue;
    else if (restart == "no")
        end = true;
    else
        end = true;
        break;
}