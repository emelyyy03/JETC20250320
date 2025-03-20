using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JETC20250320.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "País")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
