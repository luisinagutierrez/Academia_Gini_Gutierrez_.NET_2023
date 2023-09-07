using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class Specialities
    {
        public void Add(string desc)
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                ds.Add(desc);
            }
            finally
            {
                ds = null;
            }
        }

        public void Update(int id, string desp)
        {
            Datos.Specialities ds;
            try
            {
                ds = new Datos.Specialities();
                ds.Update(id, desp);
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
                Entidades.Specialities sp = new Entidades.Specialities();
                ds = new Datos.Specialities();
                sp = ds.GetOne(id);
                if (sp != null)
                {
                    ds.Delete(id);
                }
                else
                {
                    throw new Exception("No se puede eliminar una especialidad que no existe");
                }
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

        public int UpdateSpeciality(int id, string desp)
        {
            Datos.Specialities ds;
            try
            {
                Entidades.Specialities sp = new Entidades.Specialities();
                ds = new Datos.Specialities();
                sp = ds.GetOne(id);
                if (sp != null)
                {
                    this.Update(id, desp);
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
    }
}