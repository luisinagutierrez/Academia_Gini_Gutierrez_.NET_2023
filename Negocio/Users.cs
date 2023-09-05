using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Users
    {
        public int ValidateUser(string userName, string password)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                int idPerson = ds.GetIdPerson(userName, password);

                return idPerson;
            }
            finally
            {
                ds = null;
            }
        }
        //public List<Entidades.User> GetAll()
        //{
        //    Datos.User ds;
        //    try
        //    {
        //        ds = new Datos.User();
        //        return ds.GetAll();
        //    }
        //    finally
        //    {
        //        ds = null;
        //    }
        //}

    }
}
