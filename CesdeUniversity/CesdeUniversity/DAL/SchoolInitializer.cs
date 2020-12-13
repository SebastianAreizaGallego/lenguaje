using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CesdeUniversity.Models;

namespace CesdeUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var students = new List<Estudiante>
            {
            new Estudiante{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Estudiante{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Estudiante{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Estudiante{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Estudiante{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();
            var courses = new List<Curso>
            {
            new Curso{CursoID=1050,Titulo="Chemistry",Creditos=3,},
            new Curso{CursoID=4022,Titulo="Microeconomics",Creditos=3,},
            new Curso{CursoID=4041,Titulo="Macroeconomics",Creditos=3,},
            new Curso{CursoID=1045,Titulo="Calculus",Creditos=4,},
            new Curso{CursoID=3141,Titulo="Trigonometry",Creditos=4,},
            new Curso{CursoID=2021,Titulo="Composition",Creditos=3,},
            new Curso{CursoID=2042,Titulo="Literature",Creditos=4,}
            };
            courses.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EstudianteID=1,CursoID=1050,Grado=Grado.A},
            new Enrollment{EstudianteID=1,CursoID=4022,Grado=Grado.C},
            new Enrollment{EstudianteID=1,CursoID=4041,Grado=Grado.B},
            new Enrollment{EstudianteID=2,CursoID=1045,Grado=Grado.B},
            new Enrollment{EstudianteID=2,CursoID=3141,Grado=Grado.F},
            new Enrollment{EstudianteID=2,CursoID=2021,Grado=Grado.F},
            new Enrollment{EstudianteID=3,CursoID=1050},
            new Enrollment{EstudianteID=4,CursoID=1050,},
            new Enrollment{EstudianteID=4,CursoID=4022,Grado=Grado.F},
            new Enrollment{EstudianteID=5,CursoID=4041,Grado=Grado.C},
            new Enrollment{EstudianteID=6,CursoID=1045},
            new Enrollment{EstudianteID=7,CursoID=3141,Grado=Grado.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}