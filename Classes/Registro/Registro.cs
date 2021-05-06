using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Classes.Registro
{
	public class Registro
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdRegistro { get; set; }
		
		[Required]
		public string Produto { get; set; }


		[ForeignKey("IdHistoricoCompra")]
		public virtual Historico.HistoricoCompra IdHistoricoCompraNavigation { get; set; }


		[Required]
		public int IdHistoricoCompra { get; set; }


	}
}
