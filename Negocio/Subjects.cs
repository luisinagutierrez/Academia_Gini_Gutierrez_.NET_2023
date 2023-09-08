using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Subjects
    {
        public List<Entidades.Subjects> GetAll()
        {
            Datos.Subjects ds;
            try
            {
                ds = new Datos.Subjects();
                return ds.GetAll();
            }
            finally
            {
               // ds = null;
            }
        }
        public void Add(int idP, string descrip, int ths, int whs)
        {
            Datos.Subjects ds;
            try
            {
                ds = new Datos.Subjects();
                ds.Add(idP, descrip, ths, whs);
            }
            finally
            {
                ds = null;
            }
        }
        public void Update(int idS, string descrip,int ths, int whs, int idP)
        {
            Datos.Subjects ds;
            try
            {
                ds = new Datos.Subjects();
                ds.Update(idS, descrip, ths, whs, idP);
            }
            finally
            {
                ds = null;
            }
        }
        public int UpdateSubject(int idS, string descrip, int ths, int whs, int idP)
        {
            Datos.Subjects ds;
            try
            {
                Entidades.Subjects sub = new Entidades.Subjects();
                ds = new Datos.Subjects();
                sub = ds.GetOne(idS);
                if (sub != null)
                {
                    this.Update(idS, descrip, ths, whs, idP);
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
            Datos.Subjects ds;
            try
            {
                Entidades.Subjects sub = new Entidades.Subjects();
                ds = new Datos.Subjects();
                sub = ds.GetOne(id);
                if (sub != null)
                {
                    ds.Delete(id);
                }
                else
                {
                    throw new Exception("No se puede eliminar el plan, ya que no existe");
                }
            }
            finally
            {
                ds = null;
            }
        }
    }
}
