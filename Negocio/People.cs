using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class People
    {
        public int GetPersonType(int id)
        {
            Datos.People ds;
            try
            {
                ds = new Datos.People();
                int typeP = ds.GetTypePerson(id);
                return typeP;
            }
            finally
            {
                ds = null;
            }
        }
    }
}
