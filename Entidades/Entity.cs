using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entity { 
        public Entity()
        {
            this.St = States.New;
        }
        private int _ID;
        public int ID { get { return _ID; } set { _ID = value; } }

        private States _St;
        public States St
        { get { return _St; } set { _St = value; } }

        public enum States
        {
            Delete,
            New,
            Update,
            NoUpdated
        }
    }
}

