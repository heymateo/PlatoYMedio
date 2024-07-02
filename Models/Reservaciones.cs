using System;
using System.ComponentModel.DataAnnotations;

namespace TuProyecto.Models
{
    public class Reservaciones
    {
        [Key]
        public int IdReservacion { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido.")]
        [StringLength(20, ErrorMessage = "El nombre del cliente no puede tener más de 20 caracteres.")]
        [Display(Name = "Nombre del Cliente")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es requerido.")]
        [StringLength(20, ErrorMessage = "El apellido del cliente no puede tener más de 20 caracteres.")]
        [Display(Name = "Apellido del Cliente")]
        public string ApellidoCliente { get; set; }

        [Required(ErrorMessage = "El teléfono del cliente es requerido.")]
        [StringLength(8, ErrorMessage = "El teléfono del cliente debe tener exactamente 8 caracteres.", MinimumLength = 8)]
        [Display(Name = "Teléfono del Cliente")]
        public string TelefonoCliente { get; set; }

        [Required(ErrorMessage = "El email del cliente es requerido.")]
        [StringLength(125, ErrorMessage = "El email del cliente no puede tener más de 125 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        [Display(Name = "Email del Cliente")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "La dirección del cliente es requerida.")]
        [StringLength(50, ErrorMessage = "La dirección del cliente no puede tener más de 50 caracteres.")]
        [Display(Name = "Dirección del Cliente")]
        public string DireccionCliente { get; set; }

        [Required(ErrorMessage = "La fecha de la reservación es requerida.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Reservación")]
        public DateTime FechaReservacion { get; set; }

        [Required(ErrorMessage = "La hora de la reservación es requerida.")]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de Reservación")]
        public TimeSpan HoraReservacion { get; set; }

        [Required(ErrorMessage = "La cantidad de personas es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de personas debe ser mayor que cero.")]
        [Display(Name = "Cantidad de Personas")]
        public int CantidadPersonas { get; set; }

        [Required(ErrorMessage = "El número de mesa es requerido.")]
        [Range(1, 40, ErrorMessage = "El número de mesa debe estar entre 1 y 40.")]
        [Display(Name = "Número de Mesa")]
        public int NumeroMesa { get; set; }

        [Required(ErrorMessage = "El código de reserva es requerido.")]
        [Display(Name = "Código de Reserva")]
        public int CodigoReserva { get; set; }

        [Display(Name = "Cancelada")]
        public bool Cancelada { get; set; }
    }
}
