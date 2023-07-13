using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
	/// <summary>
	/// Represents a individual college student
	/// </summary>
	public class Student
	{
		/// <summary>
		/// The legal first name
		/// </summary>
		public string Firstname { get; set; }

		/// <summary>
		/// The legal last name
		/// </summary>
		public string Lastname { get; set; }

		/// <summary>
		/// The assiged school email address
		/// </summary>
		public string SchoolEmail { get; set; }

		/// <summary>
		/// The phone number
		/// </summary>
		public string PhoneNumber { get; set; }

		
		public Advisor AssignedAdvisor { get; set; }
	}
}
