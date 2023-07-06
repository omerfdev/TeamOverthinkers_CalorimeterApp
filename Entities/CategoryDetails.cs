using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class CategoryDetails:BaseEntity
	{
        public int CategoryID { get; set; }
		[DefaultValue("false")]
		public bool IsAllergen { get; set; }
		[DefaultValue("false")] 
		public bool IsGlutenFree  { get; set; }
		[DefaultValue("false")] 
		public bool HasLactose { get; set; }
		[DefaultValue("false")] 
		public bool IsVegaterian { get; set; }
        public Categories? Categories { get; set; }
    }
}
