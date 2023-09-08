using Entidades;
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
                int privilege = ds.GetPrivilege(userName, password);

                return privilege;
            }
            finally
            {
                ds = null;
            }
        }
        public List<Entidades.Users> GetAll()
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                return ds.GetAll();
            }
            finally
            {
                ds = null;
            }
        }
        public Entidades.Users GetOne(int ID)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                Entidades.Users user = ds.GetOne(ID);

                return user;
            }
            finally
            {
                ds = null;
            }

        }

        public int GetIdPerson(string nom, string pass)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                int IdPerson = ds.GetPrivilege(nom, pass);

                return IdPerson;
            }
            finally
            {
                ds = null;
            }
        }

        public void ChangePassword(string nom, string pass)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.ChangePassword(nom, pass);

            }
            finally
            {
                ds = null;
            }

        }
        public void Delete(int ID)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.Delete(ID);
            }
            finally
            {
                ds = null;
            }

        }

        public void Add(Entidades.Users item)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.Add(item);
            }
            finally
            {
                ds = null;
            }

        }
        public void Update(Entidades.Users item)
        {
            Datos.Users ds;
            try
            {
                ds = new Datos.Users();
                ds.Update(item);
            }
            finally
            {
                ds = null;
            }

        }

        //public void Save(Entidades.Users usuario)
        //{
        //    if (usuario.St == Entity.States.Delete)
        //    {
        //        this.Delete(usuario.ID);
        //    }
        //    else if (usuario.St == Entity.States.New)
        //    {
        //        this.Add(usuario);
        //    }
        //    else if (usuario.St == Entity.States.Update)
        //    {
        //        this.Update(usuario);
        //    }
        //}

    }
}
