using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class CategoryDetails:BaseEntity
	{
        public int CategoryID { get; set; }
        public bool IsAllergen { get; set; }
        public bool IsGlutenFree  { get; set; }
        public bool HasLactose { get; set; }
        public bool IsVegaterian { get; set; }
        public Categories Categories { get; set; }
    }
}
