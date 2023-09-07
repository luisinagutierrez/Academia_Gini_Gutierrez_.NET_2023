using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Users : Entity
    {
        int _idUser;
        string _userName;
        string _password;
        bool _status;
        bool _changePassword;
        int _privilege;
        int _idPerson;


        public int IdUser { get { return _idUser; } set { _idUser = value; } }
        public int Privilege { get { return _privilege; } set { _privilege = value; } }
        public string UserName { get { return _userName; } set { _userName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public bool Status { get { return _status; } set { _status = value; } } 
        public bool ChangePassword { get { return _changePassword; } set { _changePassword = value; } }
        public int IdPerson { get { return _idPerson; } set { _idPerson = value; } }

        public Users() { }

        public Users( int idUser, string userName, string password, bool status, bool changePassword, int idPerson, int privilege)
        {
            this.IdUser = idUser;
            this.UserName = userName;
            this.Password = password;
            this.Status = status;
            this.ChangePassword = changePassword;
            this.IdPerson = idPerson;
            Privilege = privilege;
        }
    }
}
