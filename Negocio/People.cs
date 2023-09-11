using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.Arm;
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
        public int UpdatePeople(int idP, int fileId, string name, string surname, string address, string email, DateTime birthDate, string telephone, int idPlan)
        {
            Datos.People ds;
            try
            {
                Entidades.People p = new Entidades.People();
                ds = new Datos.People();
                p = ds.GetOne(idP);
                if (p != null)
                {
                    this.Update(idP, fileId, name, surname, address, email, birthDate, telephone, idPlan);
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
        public void Update(int idP, int fileId, string name, string surname, string address, string email, DateTime birthDate, string telephone, int idPlan)
        {
            Datos.People ds;
            try
            {
                ds = new Datos.People();
                ds.Update(idP, fileId, name, surname, address, email, birthDate, telephone, idPlan);
            }
            finally
            {
                ds = null;
            }
        }

        //public void UpdatePeople(int idP, int fileId, string name, string surname, string address, string email, DateTime birthDate, string telephone, int idPlan)
        //{
        //    Datos.People ds;
        //    try
        //    {
        //        ds = new Datos.People();
        //        ds.Update(idP, fileId, name, surname, address, email, birthDate, telephone, idPlan);
        //    }
        //    finally
        //    {
        //        ds = null;
        //    }
        //}
        public void Delete(int id)
        {
            Datos.People ds;
            try
            {
                ds = new Datos.People();
                ds.Delete(id);
            }
            finally
            {
                ds = null;
            }
        }

    }
}
