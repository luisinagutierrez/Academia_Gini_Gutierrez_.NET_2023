using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
                foreach (Entidades.Courses c in ds.GetCoursesByIdSubject(idS))
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
                return cant;
            }
            finally
            {
                ds = null;
            }
        }
        public void Add(int idS, int idC, int cy, int q)
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                ds.Add(idS, idC, cy, q);
            }
            finally
            {
                ds = null;
            }
        }
        public int Update(int idC, int idS, int idCc, int cy, int q)
        {
            Datos.Courses ds;
            try
            {
                Entidades.Courses co = new Entidades.Courses();
                ds = new Datos.Courses();
                co = ds.GetOne(idC);
                if (co != null)
                {
                    ds.Update(idC, idS, idCc, cy, q);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                ds = null;
            }
        }
        public void Delete(int id)
        {
            Datos.Courses ds;
            try
            {
                Entidades.Courses cou = new Entidades.Courses();
                ds = new Datos.Courses();
                cou = ds.GetOne(id);
                if (cou != null)
                {
                    ds.Delete(id);
                }
                else
                {
                    throw new Exception("No se puede eliminar el curso, ya que no existe.");
                }
            }
            finally
            {
                ds = null;
            }
        }
        public void UpdateCourseAvailability(int IdCourse, int num)
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                ds.UpdateCourseAvailability(IdCourse, num);
            }
            finally
            {
                ds = null;
            }
        }
        public bool ValidateCourseAvailability(int idC)
        {
            Datos.Courses ds;
            bool flag = false;
            try
            {
                Entidades.Courses co = new Entidades.Courses();
                ds = new Datos.Courses();
                co = ds.ValidateCourseAvailability(idC);
                if (co != null)
                {
                    this.UpdateCourseAvailability(idC, 1);
                    flag = true;
                }
                return flag;
            }
            finally
            {
                ds = null;
            }
        }
        public Entidades.Courses GetOne(int id)
        {
            Datos.Courses ds;
            try
            {
                ds = new Datos.Courses();
                return ds.GetOne(id);
            }
            finally
            {
                ds = null;
            }
        }
    }
}


