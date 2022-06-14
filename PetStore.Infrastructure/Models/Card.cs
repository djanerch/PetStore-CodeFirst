using System;
using System.ComponentModel.DataAnnotations;
using PetStore.Common;

namespace PetStore.Infrastructure.Models
{
    public class Card
    {
        public Card()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(Validation.CARD_NUMBER_LEN)]
        public string CardNumber { get; set; }
        [Required]
        [MaxLength(Validation.CARD_CVV_LEN)]
        public string CVV { get; set; }
    }
}
