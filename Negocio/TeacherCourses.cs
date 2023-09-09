using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TeacherCourses
    {
        public int GetTeacherCoursesByIdCourse(int idC)
        {
            Datos.TeacherCourses ds;
            try
            {
                ds = new Datos.TeacherCourses();
                int cant = 0;
                foreach (Entidades.TeacherCourses c in ds.GetTeacherCoursesByIdCourse(idC))
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

    }
}
