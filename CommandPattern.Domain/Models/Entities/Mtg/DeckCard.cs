namespace CommandPattern.Domain.Models.Entities.Mtg
{
    public class DeckCard
    {
        public long? DeckId { get; set; }

        public long? CardId { get; set; }

        public int Quantity { get; set; }

        public Deck? Deck { get; set; }

        public Card? Card { get; set; }
    }
}
