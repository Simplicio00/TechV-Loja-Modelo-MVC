using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Classes.Canal
{
	public class CanalUser
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdMessage { get; set; }

		[Required]
		public string Nome { get; set; }

		public string? Mensagem { get; set; }

		[Required]
		public int CanalId { get; set; }

		[ForeignKey("CanalId")]
		public virtual Canal CanalIdNavigation { get; set; }

	}
}
