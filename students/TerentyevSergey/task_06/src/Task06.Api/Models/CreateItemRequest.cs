using System.ComponentModel.DataAnnotations;

namespace Task06.Api.Models;

public class CreateItemRequest
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;
    
    [Range(0.01, 10000)]
    public decimal Price { get; set; }
}