namespace CommandPattern.Domain.Models.Entities.Mtg
{
    public class Deck
    {
        public long ThemeId { get; set; }

        public long GuildId { get; set; }

        public long FormatId { get; set; }

        public Decimal? WinRate { get; set; }

        public Theme? Theme { get; set; }

        public Guild? Guild { get; set; }

        public Format? Format { get; set; }
    }
}
