namespace sistem_audentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                const string usernamecorect = "pohus.tabita18@gmail.com";
                const string parolacorecta = "tabitapohusemanuela18";
                bool adevarat = false;
                while (!adevarat)
                {
                    Console.WriteLine("Introduceti username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Introduceti parola");
                    string parola = Console.ReadLine();
                    if (username == usernamecorect && parola == parolacorecta)
                    {
                        Console.WriteLine("Bine ai venit" + usernamecorect);
                        adevarat = true;
                    }

                    else
                    {
                        Console.WriteLine("Incorect");
                    }
                }
            }
        }
    }
}