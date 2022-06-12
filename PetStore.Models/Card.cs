using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PetStore.Common;

namespace PetStore.Models
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
