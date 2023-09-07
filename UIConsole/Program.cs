using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;
using UI.Consola;

namespace UIConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            new User().Menu();
        }
    }

}
