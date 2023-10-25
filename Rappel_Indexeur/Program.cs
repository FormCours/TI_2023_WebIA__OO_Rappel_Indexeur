
ExempleIndexeur ei = new ExempleIndexeur();

string r1 = ei["mj"];
string r2 = ei["pnj"];
Console.WriteLine($"{r1}, {r2}");

class ExempleIndexeur
{
    private string player = "Pauline";
    private string pnj1 = "Julie";
    private string pnj2 = "Maud";
    private string mj = "Alexis";

    public string this[string clef]
    {
        get
        {
            switch (clef.ToLower())
            {
                case "joueur":
                    return player;
                case "mj":
                    return mj;
                case "pnj":
                    return (new Random()).Next(2) == 1 ? pnj1 : pnj2;
                default:
                    return "Un loup";
            }
        }
    }


    //public string get(string clef)
    //{
    //    switch (clef.ToLower())
    //    {
    //        case "joueur":
    //            return player;
    //        case "mj":
    //            return mj;
    //        case "pnj":
    //            return (new Random()).Next(2) == 1 ? pnj1 : pnj2;
    //        default:
    //            return "Un loup";
    //    }
    //}
}
