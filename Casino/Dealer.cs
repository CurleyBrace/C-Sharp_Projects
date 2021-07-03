using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {   
        public string Name { get; set; }                                                         //Dealer's Name Property
        public Deck Deck { get; set; }                                                           //Dealer's Deck Property
        public int Balance { get; set; }                                                         //Dealer's Balance Property

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());                                                           //Assigning the Dealers Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");                      //Converting Card to Be Printable
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Tommy\Desktop\text.txt", true))  //Tracking the cards dealt and writing them to text
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);                                                                 //Removing the cards from the deck that have been dealt
        }
    }
}
