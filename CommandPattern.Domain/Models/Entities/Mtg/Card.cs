using System.ComponentModel.DataAnnotations;

namespace CommandPattern.Domain.Models.Entities.Mtg
{
    public class Card : EntityModelBase
    {
        public int? ConvertedManaCost { get; set; }

        public long SetId { get; set; }

        public long CardTypeId { get; set; }

        public long ColorIdentityId { get; set; }

        public long RarityId { get; set; }

        public long CardPurposeId { get; set; }

        public Set? Set { get; set; }

        public CardType? CardType { get; set; }

        public ColorIdentity? ColorIdentity { get; set; }

        public Rarity? Rarity { get; set; }

        public CardPurpose? CardPurpose { get; set; }
    }
}
