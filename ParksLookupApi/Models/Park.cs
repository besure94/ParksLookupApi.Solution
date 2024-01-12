using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models
{
  public class Park
  {
    [Required]
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    [Range(1, 5)]
    public int Rating { get; set; }
  }
}