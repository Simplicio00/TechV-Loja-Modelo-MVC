using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Usuario
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario {get;set;}
        

        [Required]
        public bool Status { get; set; }


        [Required]
        [StringLength(30)]
        public string Nome {get;set;}



        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        public string Email {get;set;}



        [Required]
        [StringLength(30)]
        public string Senha {get;set;}



        [Required]
        [StringLength(50)]
        public string CEP { get; set; }


        [Required]
        public int CanalId { get; set; }

        [ForeignKey("CanalId")]
        public virtual Canal.Canal CanalIdNavigation { get; set; }



        public virtual ICollection<Historico.HistoricoCompra> Historico { get; set; }



    }
}