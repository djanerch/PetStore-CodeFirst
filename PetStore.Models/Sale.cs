using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using PetStore.Models.Enums;

namespace PetStore.Models
{
    public class Sale
    {
        public Sale()
        {
            Id = Guid.NewGuid().ToString();
            this.Pets = new HashSet<Pet>();
            this.Products = new HashSet<Product>();
            this.Services = new HashSet<Service>();
        }
        [Key]
        public string Id { get; set; }
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType PaymentType { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
