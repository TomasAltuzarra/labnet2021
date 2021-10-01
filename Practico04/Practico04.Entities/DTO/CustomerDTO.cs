using System.ComponentModel.DataAnnotations;

namespace Practico04.Entities.DTO
{
    public class CustomerDto
    {
        [Key]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(5)]
        [Display(Name = "Cliente ID")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(40)]
        [Display(Name = "Empresa")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Display(Name = "Nombre")]
        public string ContactName { get; set; }

        [StringLength(30)]
        [Display(Name = "Titulo")]
        public string ContactTitle { get; set; }

        /*[StringLength(60)]
        [Display(Name = "Direccion")]
        public string Address { get; set; }*/

        [StringLength(15)]
        [Display(Name = "Ciudad")]
        public string City { get; set; }

        /*[StringLength(15)]
        public string Region { get; set; }*/

        /*[StringLength(10)]
        [Display(Name = "Código postal")]
        public string PostalCode { get; set; }*/

        [StringLength(15)]
        [Display(Name = "País")]
        public string Country { get; set; }

        [StringLength(24)]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }

        /*[StringLength(24)]
        public string Fax { get; set; }*/
    }
}
