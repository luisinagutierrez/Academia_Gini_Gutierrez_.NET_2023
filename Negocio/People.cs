using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class People
    {
        public void Add(Entidades.People item)
        {
            Datos.People ds;
            try
            {
                ds = new Datos.People();
                ds.Add(item);
            }
            finally
            {
                ds = null;
            }
        }
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
        public List<Entidades.People> GetAll()
        {
            Datos.People ds;
            try
            {
                ds = new Datos.People();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }

    }
}
