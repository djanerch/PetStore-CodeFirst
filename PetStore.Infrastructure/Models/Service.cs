using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.Common;

namespace PetStore.Infrastructure.Models
{
    public class Service
    {
        public Service()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(Validation.SERVICE_TYPE_LEN)]
        public string ServiceType { get; set; }
        public decimal Price { get; set; }
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public Client Client { get; set; }
    }
}
