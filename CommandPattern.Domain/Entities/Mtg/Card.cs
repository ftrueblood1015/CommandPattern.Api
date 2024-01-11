using System.ComponentModel.DataAnnotations;

namespace CommandPattern.Domain.Entities.Mtg
{
    public class Card : EntityBase
    {
        [Required]
        public int? ConvertedManaCost { get; set; }

        [Required]
        public long SetId { get; set; }

        [Required]
        public long CardTypeId { get; set; }

        [Required]
        public long ColorIdentityId { get; set; }

        [Required]
        public long RarityId { get; set; }

        [Required]
        public long CardPurposeId { get; set; }

        public Set? Set {  get; set; }

        public CardType? CardType { get; set; }

        public ColorIdentity? ColorIdentity { get; set; }

        public Rarity? Rarity { get; set; }

        public CardPurpose? CardPurpose { get; set; }
    }
}
