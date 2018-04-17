using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AYD1_Practica3.Models
{
    public class TransferenciaModel
    {
        [Required]
        [Display(Name = "Cuenta destino")]
        [DataType(DataType.Text)]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "Monto a transferir")]
        [DataType(DataType.Text)]
        public string Balance { get; set; }
    }
}
