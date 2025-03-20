using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JETC20250320.Models;

public partial class User
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nombre")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    [Display(Name = "Correo electronico")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [Display(Name = "Contraseña")]
    public string PasswordHash { get; set; } = null!;

    [Required(ErrorMessage = "El rol es obligatorio.")]
    [Display(Name = "Rol")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("PasswordHash", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;

}
