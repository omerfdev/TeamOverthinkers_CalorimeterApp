using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class UserDetails : BaseEntity
	{
		public int UserID { get; set; }
		public string? Phone { get; set; }
		public DateTime BirthDate { get; set; }
		public decimal Height { get; set; }
		public decimal Weight { get; set; }
		public bool? Gender { get; set; }
		[DefaultValue("false")]
		public bool IsAllergic { get; set; }
		[DefaultValue("false")]
		public bool GlutenPreference { get; set; }
		[DefaultValue("false")]
		public bool IsLactoseIntolerant { get; set; }
		[DefaultValue("false")]
		public bool IsVegetarian { get; set; }
		public Users? Users { get; set; }
	}
}
