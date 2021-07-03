using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Random random = new Random();
                List<Card> tempList = new List<Card>();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }
    }
}
