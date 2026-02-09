using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreEF.Models
{

    // mediante decoraciones de mapping vamos indicando a que tabla o view apunta
    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [Column("HOSPITAL_COD")]
        public int IdHospital { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("TELEFONO")]
        public string Telefono { get; set; }
        [Column("NUM_CAMAS")]
        public int Camas { get; set; }

    }
}
