namespace CommandPattern.Domain.Models.Entities.Mtg
{
    public class DeckCardTypeStats
    {
        public string DisplayName { get; set; }

        public double Percentage { get; set; }

        public DeckCardTypeStats(string displayName)
        {
            DisplayName = displayName;
        }

        private void SetPercentage(int totalCards, int purposeCards)
        {
            Percentage = purposeCards / totalCards;
        }
    }
}
