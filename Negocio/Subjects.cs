using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
