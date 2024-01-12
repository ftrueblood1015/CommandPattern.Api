using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Domain.Entities.Mtg
{
    public class DeckCard : EntityBase
    {
        [Required]
        public long? DeckId { get; set; }

        [Required]
        public long? CardId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Deck? Deck { get; set; }

        public Card? Card { get; set; }
    }
}
