using System.ComponentModel.DataAnnotations;

namespace Tourism.Models;

public class Destination
{
    public int Id { get; set; }

    [Required, StringLength(80)]
    public string Name { get; set; } = "";

    [Required]
    public Region Region { get; set; }   // <-- uses the enum above

    [Required, StringLength(40)]
    public string Category { get; set; } = "";

    [Range(0,5)]
    public double Rating { get; set; }

    public bool IsPopular { get; set; }

    [StringLength(500)]
    public string Description { get; set; } = "";

    public string ImageUrl { get; set; } = "/img/placeholder-landscape.svg";
}
