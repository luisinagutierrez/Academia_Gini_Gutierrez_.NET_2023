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

    }
}
