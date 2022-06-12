using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using PetStore.Common;
using PetStore.Models.Enums;

namespace PetStore.Models
{
    public class Client
    {
        public Client()
        {
            Id = Guid.NewGuid().ToString();
            Sales = new HashSet<Sale>();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(Validation.FIRSTNAME_LEN)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(Validation.LASTNAME_LEN)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [MaxLength(Validation.EMAIL_LEN)]
        public string Email { get; set; }
        [Required]
        [MaxLength(Validation.PHONENUMBER_LEN)]
        public string PhoneNumber { get; set; }
        [ForeignKey(nameof(Card))]
        public string CardId { get; set; }
        public Card Card { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
