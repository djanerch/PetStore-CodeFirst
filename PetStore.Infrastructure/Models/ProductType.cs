using System.ComponentModel.DataAnnotations;

namespace PetStore.Infrastructure.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
