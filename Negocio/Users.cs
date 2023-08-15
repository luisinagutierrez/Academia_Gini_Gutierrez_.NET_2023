using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Users
    {
        public Datos.Users ValidateUser(string userName, string password)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.GetOne(userName, password);
                return ds;
            }
            finally
            {
                ds = null;
            }
        }
    }
}
