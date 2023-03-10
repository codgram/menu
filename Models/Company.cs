using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;


public class Company
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public bool IsDefault { get; set; }
}