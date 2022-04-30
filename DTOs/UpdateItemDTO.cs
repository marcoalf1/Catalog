using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record UpdateItemDTO
    {
        [Required]
        public String Name { get; init; }
        
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}