using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Player
    {
        private string name;
        Card[] hand;
       public string getName() { return name; }
        public Card[] getHand() { return hand;}
        public void setName(string name) { this.name = name;}
        public void setHand(Card[] hand) {  this.hand = hand;}
        public Player(string name) 
        {
        hand = new Card[5];
        }
        public void take(Card c) 
        {
        for(int i = 0; i < hand.Length; i++)
            {
                if (hand[i] == null)
                {
                    hand[i] = c;
                }
            }
        }
        public Card put(int i)
        {
            Card card = hand[i];
            hand[i] = null;
            return card;
        }

    }
}
