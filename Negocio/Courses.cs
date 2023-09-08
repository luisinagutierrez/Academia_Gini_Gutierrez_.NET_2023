using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Courses
    {
        public List<Entidades.Courses> GetAll()
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }

        public List<Entidades.Courses> GetAvailableCourses()
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                return ds.GetAvailableCourses();
            }
            finally
            {
                ds = null;
            }
        }

        public int GetCoursesByIdSubject(int idS)
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                int cant = 0;
                foreach(Entidades.Courses c in ds.GetCoursesByIdSubject(idS))
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

        public int GetCoursesByIdCommission(int idC)
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                int cant = 0;
                foreach (Entidades.Courses c in ds.GetCoursesByIdCommission(idC))
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
