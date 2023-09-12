using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        
        public int Update(int idP, string desp, int idS)
        {
            Datos.Plans ds;
            try
            {
                Entidades.Plans pl = new Entidades.Plans();
                ds = new Datos.Plans();
                pl = ds.GetOne(idP);
                if (pl.IdPlan != 0)
                {
                    ds.Update(idP, desp, idS); 
                }
                return pl.IdPlan;

            }
            finally
            {
                ds = null;
            }
        }
        public int Delete(int idP)
        {
            Datos.Plans ds;
            try
            {
                int rt = 0;
                Entidades.Plans pl = new Entidades.Plans();
                ds = new Datos.Plans();
                pl = ds.GetOne(idP);
                if (pl.IdPlan != 0)
                {
                    ds.Delete(idP);
                }
                return pl.IdPlan;

            }
            finally
            {
                ds = null;
            }
        }
        public int GetPlansByIdSpeciality(int idS)
        {
            Datos.Plans ds;
            try
            {
                ds = new Datos.Plans();
                int cant = 0;
                foreach (Entidades.Plans c in ds.GetPlansByIdSpeciality(idS))
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
    }
}
