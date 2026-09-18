public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
       get { return _hemmalag; }
       private set { _hemmalag = value; } // get och privat set för Hemmalag 
    }

    public string Bortalag
    {
        get { return _bortalag; }
        private set { _bortalag = value; } // get och privat set för Bortalag
    }

    public string Datum
    {
        get { return _datum; }
        private set { _datum = value; } // get och privat set för Datum
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"{Hemmalag} vs {Bortalag} sänds den {Datum}"); // TODO
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
        
    {
        if (spelare.Namn == "Lionel Messi")
        {
            Console.WriteLine($"un cara messi un cara messi Mååål! {spelare.Nummer} - {spelare.Namn} gör mål! världerns bästa {spelare.Position} med en {spelare.Rating} visar varför han är värd dom siffrorna");

        }
        else if (spelare.Namn == "Luis Suarez")
        {
            Console.WriteLine($"GOLE GOLE GOALL! {spelare.Nummer} - {spelare.Namn} gör mål effektivt spel från den {spelare.Rating} - {spelare.Position}");
        }
        else if(spelare.Namn == "Neymar Jr")
        {
            Console.WriteLine($"The magician gör MÅÅLL! {spelare.Nummer} - {spelare.Namn} gör sitt första mål på matchen. {spelare.Position} med en underskattad {spelare.Rating}");
        }
        else
            Console.WriteLine($" MÅÅl! {spelare.Nummer} - {spelare.Namn} spelar som {spelare.Position} med en {spelare.Rating}");
    }
}
