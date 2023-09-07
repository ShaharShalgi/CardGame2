using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top;
        Random rnd = new Random();


        public Deck() 
        {
             top = 0;
            Card[] cards = new Card[52];
            
            
            int index = 0;
            for (int i = 1;  i <= 4; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    cards[index] = new Card(j, i);
                        index++;

                }
            }
        }
        public Card Peek() { return null; }
        public void Shuffle() 
        {
        for(int i = 0; i < cards.Length; i++)
            {

                int j = rnd.Next(i, cards.Length);
                swap(i, j);
            }
        }
        public Card Deal() 
        {
            Card c = cards[top];
            top++;
            return c;
        }

        public void Reset() { top = 0; }
        private void swap(int i, int j)
        {
            Card c = cards[j];
            cards[j] = cards[i];
            cards[i] = c;

        }
    }
}
