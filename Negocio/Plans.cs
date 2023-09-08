using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Plans
    {
        public List<Entidades.Plans> GetAll()
        {
            Datos.Plans ds;
            try
            {
                ds = new Datos.Plans();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }

        public void Add(int id, string descrip)
        {
            Datos.Plans ds;
            try
            {
                ds = new Datos.Plans();
                ds.Add(id, descrip);
            }
            finally
            {
                ds = null;
            }
        }

        public Entidades.Plans GetOne(int id)
        {
            Datos.Plans ds;
            try
            {
                ds = new Datos.Plans();
                return ds.GetOne(id);
            }
            finally
            {
                ds = null;
            }
        }

        public void Update(int idP, string desp, int idS)
        {
            Datos.Plans ds;
            try
            {
                ds = new Datos.Plans();
                ds.Update(idP, desp, idS);
            }
            finally
            {
                ds = null;
            }
        }
        public int UpdatePlan(int idP, string desp, int idS)
        {
            Datos.Plans ds;
            try
            {
                Entidades.Plans pl = new Entidades.Plans();
                ds = new Datos.Plans();
                pl = ds.GetOne(idP);
                if (pl != null)
                {
                    this.Update(idP, desp, idS);
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
            Datos.Plans ds;
            try
            {
                Entidades.Plans pl = new Entidades.Plans();
                ds = new Datos.Plans();
                pl = ds.GetOne(id);
                if (pl != null)
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
