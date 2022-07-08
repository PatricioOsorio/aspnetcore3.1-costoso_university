using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostosoUniversity.Models
{
  public class Course
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)] // Permite escribir la clave principal para el curso en lugar de hacer que la base de datos lo genere.
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
  }
}