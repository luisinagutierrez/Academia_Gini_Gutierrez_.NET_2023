using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Specialities
    {
        public int Add(Entidades.Specialities item)
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                return ds.Add(item);
            }
            finally
            {
                ds = null;
            }
        }

        public void Update(Entidades.Specialities item, int id )
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                ds.Update(item,id);
            }
            finally
            {
                ds = null;
            }
        }

        public void Delete(int id)
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                ds.Delete(id);
            }
            finally
            {
                ds = null;
            }
        }
    }
}
