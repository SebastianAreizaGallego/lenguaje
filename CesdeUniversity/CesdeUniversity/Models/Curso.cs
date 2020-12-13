using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CesdeUniversity.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}