namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player shahar = new Player("Shahar");
            Deck deck = new Deck();
            deck.Shuffle();
            shahar.take(deck.Deal());
            shahar.take(deck.Deal());




        }
    }
}