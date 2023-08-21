using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Specialities
    {
        public void Add(string item)
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                ds.Add(item);
            }
            finally
            {
                ds = null;
            }
        }

        public void Update(string item, int id )
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

        public List<Entidades.Specialities> GetAll()
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }
    }
}
