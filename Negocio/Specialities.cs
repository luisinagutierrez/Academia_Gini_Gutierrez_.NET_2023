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

        public Entidades.Specialities GetOne(int id)
        {
            Datos.Specialities ds;
            try
            {
                Entidades.Specialities sp = new Entidades.Specialities();
                ds = new Datos.Specialities();
                sp  = ds.GetOne(id);
                return sp; 
            }
            finally
            {
                ds = null;
            }
        }

        public int Delete(int idS)
        {
            Datos.Specialities ds;
            try
            {
                int rt = 0;
                Entidades.Specialities sp = new Entidades.Specialities();
                ds = new Datos.Specialities();
                sp = ds.GetOne(idS);
                if (sp.IdSpeciality != 0)
                {
                    ds.Delete(idS);
                    rt = 1;
                }
                return rt;

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

        public int Update(int id, string desp)
        {
            Datos.Specialities ds;
            try
            {
                int rt = 0;
                Entidades.Specialities sp = new Entidades.Specialities();
                ds = new Datos.Specialities();
                sp = ds.GetOne(id);
                if (sp.IdSpeciality != 0)
                {
                    ds.Update(id, desp);
                    rt = 1;
                }
                return rt;
            }
            finally
            {
                ds = null;
            }
        }
    }
}