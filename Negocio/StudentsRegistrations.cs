using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class StudentsRegistrations
    {
        public void Delete(int id)
        {
            Datos.StudentsRegistrations ds;
            try
            {
                ds = new Datos.StudentsRegistrations();
                ds.Delete(id);
            }
            finally
            {
                ds = null;
            }
        }

        //public List<Entidades.StudentsRegistrations> GetAll()
        //{
        //    Datos.StudentsRegistrations ds;
        //    try
        //    {
        //        ds = new Datos.StudentsRegistrations();
        //        List<Entidades.StudentsRegistrations> RegistrationsList = ds.GetAll();
        //        return RegistrationsList;
        //    }
        //    finally
        //    {
        //        ds = null;
        //    }
        //}
    }
}
