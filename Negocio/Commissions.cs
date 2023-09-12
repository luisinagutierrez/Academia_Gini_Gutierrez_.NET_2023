using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Commissions
    {
        public List<Entidades.Commissions> GetAll()
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }

        public void Add(int idP, string descrip, int year)
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                ds.Add(idP, descrip, year);
            }
            finally
            {
                ds = null;
            }
        }

        public int Update(int idC, string descrip, int y, int idP)
        {
            Datos.Commissions ds;
            try
            {
                Entidades.Commissions com = new Entidades.Commissions();
                ds = new Datos.Commissions();
                com = ds.GetOne(idC);
                if (com.IdCommission != 0)
                {
                    ds.Update(idC, descrip, y, idP);
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
            Datos.Commissions ds;
            try
            {
                Entidades.Commissions com = new Entidades.Commissions();
                ds = new Datos.Commissions();
                ds.Delete(id);
            }
            finally
            {
                ds = null;
            }
        }
        public Entidades.Commissions GetOne(int id)
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                Entidades.Commissions com = ds.GetOne(id);
                return com;
            }
            finally
            {
                ds = null;
            }

        }

        public int GetCommissionsByIdPlan(int idP)
        {
            Datos.Commissions ds;
            try
            {
                ds = new Datos.Commissions();
                int cant = 0;
                foreach (Entidades.Commissions c in ds.GetCommissionByIdPlan(idP))
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


    