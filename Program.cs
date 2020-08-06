using System;
using System.Collections.Generic;

namespace deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiley this is the top");
            Deck Royal = new Deck();
            Royal.shuffle();
            Card Mine = Royal.deal();
            Mine.showCard();
            Royal.shuffle();
            Royal.deal().showCard();
            Player Clinks = new Player("clinks");
            Clinks.draw(Royal).showCard();
            Console.WriteLine(Royal.cards.Count);
        }
    }
    class Card
    {
        public string stringVal;
        public string Suit;
        public int Val;
        public Card(string stringval, string suit, int val){
            stringVal=stringval;
            Suit = suit;
            Val = val;
        }
        public void showCard(){
            Console.WriteLine(this.stringVal+this.Suit+this.Val);
        }
    }
    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            this.reset();
        }
        public Card deal(){
            Card dealt = this.cards[0];
            this.cards.RemoveAt(0);
            return dealt;
        }
        public void reset(){
            cards = new List<Card>()
            {
                new Card("Ace", "Spades", 1),
                new Card("Two", "Spades", 2),
                new Card("Three", "Spades", 3),
                new Card("Four", "Spades", 4),
                new Card("Five", "Spades", 5),
                new Card("Six", "Spades", 6),
                new Card("Seven", "Spades", 7),
                new Card("Eight", "Spades", 8),
                new Card("Nine", "Spades", 9),
                new Card("Ten", "Spades", 10),
                new Card("Jack", "Spades", 11),
                new Card("Queen", "Spades", 12),
                new Card("King", "Spades", 13),
                new Card("Ace", "Clubs", 1),
                new Card("Two", "Clubs", 2),
                new Card("Three", "Clubs", 3),
                new Card("Four", "Clubs", 4),
                new Card("Five", "Clubs", 5),
                new Card("Six", "Clubs", 6),
                new Card("Seven", "Clubs", 7),
                new Card("Eight", "Clubs", 8),
                new Card("Nine", "Clubs", 9),
                new Card("Ten", "Clubs", 10),
                new Card("Jack", "Clubs", 11),
                new Card("Queen", "Clubs", 12),
                new Card("King", "Clubs", 13),
                new Card("Ace", "Hearts", 1),
                new Card("Two", "Hearts", 2),
                new Card("Three", "Hearts", 3),
                new Card("Four", "Hearts", 4),
                new Card("Five", "Hearts", 5),
                new Card("Six", "Hearts", 6),
                new Card("Seven", "Hearts", 7),
                new Card("Eight", "Hearts", 8),
                new Card("Nine", "Hearts", 9),
                new Card("Ten", "Hearts", 10),
                new Card("Jack", "Hearts", 11),
                new Card("Queen", "Hearts", 12),
                new Card("King", "Hearts", 13),
                new Card("Ace", "Diamonds", 1),
                new Card("Two", "Diamonds", 2),
                new Card("Three", "Diamonds", 3),
                new Card("Four", "Diamonds", 4),
                new Card("Five", "Diamonds", 5),
                new Card("Six", "Diamonds", 6),
                new Card("Seven", "Diamonds", 7),
                new Card("Eight", "Diamonds", 8),
                new Card("Nine", "Diamonds", 9),
                new Card("Ten", "Diamonds", 10),
                new Card("Jack", "Diamonds", 11),
                new Card("Queen", "Diamonds", 12),
                new Card("King", "Diamonds", 13),
            };
        }
        public void shuffle(){
            int n = this.cards.Count;
            Random rnd = new Random();
            while (n > 1) {  
                n--;  
                int k = rnd.Next(n + 1);  
                Card value = this.cards[k];  
                this.cards[k] = this.cards[n];  
                this.cards[n] = value;  
            }
        }
    }
    class Player
    {
        public string name;
        public List<Card> hand;

        public Player(string Name){
            name = Name;
            hand = new List<Card>();
        }
        public Card draw(Deck deck){
            Card drawn = deck.deal();
            this.hand.Add(drawn);
            return drawn;
        }
        public Card discard(int index){
            Card discardee = this.hand[index];
            this.hand.RemoveAt(index);
            return discardee;
        }
    }
}
