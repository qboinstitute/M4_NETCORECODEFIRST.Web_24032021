using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M4_NETCORECODEFIRST.Web.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° Camiseta")]
        public int Dorsal { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "Fec.Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        [Display(Name = "Correo")]
        [Column(TypeName = "nvarchar(100)")]
        [DataType(DataType.EmailAddress)]
        public string EmailPlayer { get; set; }
        public int SoccerPositionId { get; set; }
        public virtual SoccerPosition SoccerPosition { get; set; }

        public virtual List<Team> Team { get; set; }

    }
}
