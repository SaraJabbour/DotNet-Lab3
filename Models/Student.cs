using System.ComponentModel.DataAnnotations;

namespace DotNet_Lab3.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }
		public String Gender { get; set; }
	}
}
