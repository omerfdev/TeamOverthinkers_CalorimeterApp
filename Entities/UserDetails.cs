using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class UserDetails:BaseEntity
	{
		public int UserID { get; set; }
		public string Phone { get; set; }
		public DateTime BirthDate { get; set; }
		public decimal Heigth { get; set; }
		public decimal Weigth { get; set; }
		public bool Gender { get; set; }
		public bool IsAllergic { get; set; }
		public bool GlutenPreference { get; set; }
		public bool IsLactoseIntolerant { get; set; }
		public bool IsVegetarian { get; set; }
        public Users Users { get; set; }
    }
}
