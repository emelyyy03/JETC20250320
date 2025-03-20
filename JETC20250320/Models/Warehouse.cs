using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JETC20250320.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
