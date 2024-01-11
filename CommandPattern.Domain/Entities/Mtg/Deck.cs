using System.ComponentModel.DataAnnotations;

namespace CommandPattern.Domain.Entities.Mtg
{
    public class Deck : EntityBase
    {
        [Required]
        public long ThemeId { get; set; }

        [Required]
        public long GuildId { get; set; }

        [Required]
        public long FormatId { get; set; }

        public Decimal? WinRate { get; set; }

        public Theme? Theme { get; set; }

        public Guild? Guild { get; set; }

        public Format? Format { get; set; }
    }
}
