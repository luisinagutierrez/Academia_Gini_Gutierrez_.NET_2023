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

    }
}
