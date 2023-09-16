using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class StudentsRegistrations
    {
        public void UpdateMark(int idR,int mark) 
        {
            Datos.StudentsRegistrations ds;
            try
            {
                string condition;
                ds = new Datos.StudentsRegistrations();
                if (mark >= 4 && mark < 6)
                {
                    condition = "Regular";
                }
                else if (mark >= 6)
                {
                    condition = "Aprobado";
                }
                else
                {
                    condition = "Libre";
                }
                ds.UpdateMark(idR, mark, condition);

            }
            finally
            {
                ds = null;
            }
        }
        public List<Entidades.StudentsRegistrations> GetStudentsListRegByIdCourse(int idCourse) 
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                return ds.GetStudentsRegByIdCourse(idCourse);
            }
            finally
            {
                ds = null;
            }
        }
        public int GetStudentsRegByIdCourse(int idC)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                int cant = 0;
                foreach (Entidades.StudentsRegistrations c in ds.GetStudentsRegByIdCourse(idC))
                {
                    cant++;
                }
                if (cant == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            finally
            {
                ds = null;
            }
        }
        public List<Entidades.StudentsRegistrations> GetCoursesByIdPerson(int idStudent)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                return ds.GetCoursesByIdPerson(idStudent);
            }
            finally
            {
                ds = null;
            }
        }
        public void Add(int IdCourse, int idStudent)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                ds.Add(IdCourse, idStudent);
            }
            finally
            {
                ds = null;
            }
        }
        public int ValidateStudentsRegistrations(int IdRegistration, int IdStudent)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                int course = ds.ValidateStudentsRegistrations(IdRegistration, IdStudent);
                if (course != 0)
                {
                    ds.Delete(IdRegistration);
                }
                return course;
            }
            finally
            {
                ds = null;
            }

        }

        public bool GetStudentReg(int idStudent, int idCourse)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                if(ds.GetStudentReg(idStudent, idCourse) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                ds = null;
            }
        }
    }
}