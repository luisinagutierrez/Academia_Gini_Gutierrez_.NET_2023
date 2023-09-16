using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidades;

namespace UIConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            User u = new User();
            u.Menu();
        }
    }
}
