using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Classes.Canal
{
	public class Canal
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CanalId { get; set; }


		public virtual ICollection<CanalUser> CanalUser { get; set; }
		public virtual ICollection<Usuario.Usuario> Usuario { get; set; }
	}
}
