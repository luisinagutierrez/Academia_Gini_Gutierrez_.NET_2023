using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Validacion
    {
        static public bool vacios(List<String> campos)
        {
            foreach (var c in campos)
            {
                if (String.IsNullOrEmpty(c))      //si esta vacio devuelve un false
                {
                    return false;
                }
            }
            return true;
        }
    }
}
