using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Historico
{
    public class HistoricoCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistoricoCompra { get; set; }

        [Required]
        public DateTime DataEmissao { get; set; }

        [Required]
        public string Codigo {get;set;}
        
        [Required]
        public string Status {get;set;}

        [Required]
        public double Total { get; set; }




        [ForeignKey("IdUsuario")]
        public virtual Usuario.Usuario IdUsuarioNavigation { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        
        
        
        public virtual ICollection<Registro.Registro> Registros { get; set; }


    }
}