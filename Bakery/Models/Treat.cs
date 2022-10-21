using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Treat
  {
		public Treat()
		{
			this.JoinEntities = new HashSet<TreatCategory>();
		}
		public int TreatId { get; set; }
		public string Name { get; set; }
		public string Ingredients { get; set; }
		public int Rating {get; set;}
    public virtual ApplicationUser User { get; set; }
		public virtual ICollection<TreatCategory> JoinEntities { get; set; }
  }
}