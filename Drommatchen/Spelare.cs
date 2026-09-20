public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;
    private int _rating;
    private int _mål;
  

    // Properties — publik get, privat set
    public string Namn
    {
       get { return _namn; }
       private set { _namn = value; }// Skapa get och privat set för Namn
    }

    public int Nummer
    {
      get { return _nummer; }
      private set { _nummer = value; } // Skapa get och privat set för Nummer
    }

    public string Position
    {
      get { return _position; }
      private set { _position = value; } // Skapa get och privat set för Position
    }

    public int Rating
    {
      get { return _rating; }
      private set { _rating = value; } 
    }
    public int Mål
    {
        get { return _mål; }
        private set { _mål = value; }
    }

    // Konstruktor
    public Spelare(string namn, int nummer, string position, int rating, int mål)
    {
        _namn = namn;
        _nummer = nummer;
        _position = position;
        _rating = rating;
        _mål = mål;
    }
}
