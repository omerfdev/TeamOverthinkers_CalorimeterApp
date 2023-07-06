using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Categories : BaseEntity
	{
		public Categories()
		{
			Foods = new HashSet<Foods>();
		}
		public string CategoryName { get; set; }
		public string? CategoryDescription { get; set; }
		public string? ImagePath { get; set; }
		public ICollection<Foods>? Foods { get; set; }
		public CategoryDetails? CategoryDetails { get; set; }

	}
}
