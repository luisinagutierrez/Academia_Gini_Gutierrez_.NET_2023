using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
