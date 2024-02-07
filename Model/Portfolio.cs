using System;
using System.ComponentModel.DataAnnotations;
namespace WealthForgePro.Models;
public class Portfolio
{
    public int PortfolioID { get; set; }
    public int UserID { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Strategy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
