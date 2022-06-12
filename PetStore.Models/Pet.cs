using System;
using System.ComponentModel.DataAnnotations;
using PetStore.Common;
using PetStore.Models.Enums;

namespace PetStore.Models
{
    public class Pet
    {
        public Pet()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(Validation.NAME_LEN)]
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [MaxLength(Validation.BREED_LEN)]
        public string Breed { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        [MaxLength(Validation.DESCRIPTION_LEN)]
        public string Description { get; set; }
    }
}
