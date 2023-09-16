using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidades;

namespace UIConsole
{
    public class User
    {
        Negocio.Users _UsersN;

        public User()
        {
            _UsersN = new Negocio.Users();
        }

        public Negocio.Users UsersN { get { return _UsersN; } set { _UsersN = value; } }

        public void Menu()
        {
            int rta;
            do
            {
                Console.WriteLine(
                    "1– Listado General\n" +
                    "2– Consulta\n" +
                    "3– Add\n" +
                    "4- Update\n" +
                    "5- Delete\n" +
                    "6- Salir");
                rta = int.Parse(Console.ReadLine());

                switch (rta)
                {
                    case 1:
                        List();
                        break;
                    case 2:
                        GetOne();
                        break;
                    case 3:
                        Add();
                        break;
                    case 4:
                        Update();
                        break;
                    case 5:
                        Delete();
                        break;
                }

            } while (rta != 6);
        }

        public void List()
        {
            Console.Clear();
            foreach (Entidades.Users usr in _UsersN.GetAll())
            {
                ShowData(usr);
            }
        }

        public void GetOne()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario: ");
                int ID = int.Parse(Console.ReadLine());
                this.ShowData(UsersN.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("fe", "\nEl ID ingresado tiene que ser numérico.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void ShowData(Entidades.Users usr)
        {
            Console.WriteLine("Users: {0}", usr.IdUser);
            Console.WriteLine("\t\tNombre de Users: {0}", usr.UserName);
            Console.WriteLine("\t\tClave: {0}", usr.Password);
            Console.WriteLine("\t\tEstado: {0}", usr.Status);
            Console.WriteLine("\t\tContraseña cambiada: {0}", usr.ChangePassword);
            Console.WriteLine("\t\tPrivilegio: {0}", usr.Privilege);
            Console.WriteLine("\t\tIdPersona: {0}", usr.IdPerson);
            Console.WriteLine("");

        }

        public void Update()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del Users que va a actualizar: ");
                int ID = int.Parse(Console.ReadLine());
                Entidades.Users u = UsersN.GetOne(ID);
                Console.Write("Ingrese el nombre del usuario: ");
                u.UserName = Console.ReadLine();
                Console.Write("Ingrese la contraseña: ");
                u.Password = Console.ReadLine();
                u.ChangePassword = false;
                //u.St = Entity.States.Update;
                UsersN.Update(u);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEl ID ingresado tiene que ser numérico.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPresione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void Add()
        {
            try
            {
                Console.Clear();
                Entidades.Users u = new Entidades.Users();
                Console.Write("Ingrese el nombre del usuario: ");
                u.UserName = Console.ReadLine();
                Console.Write("Ingrese la contraseña: ");
                u.Password = Console.ReadLine();
                Console.Write("Ingrese su id de persona: ");
                u.IdPerson = int.Parse(Console.ReadLine());
                u.ChangePassword = false;
                //u.St = Entity.States.Update;
                //UsersN.Add(u);
                //Console.Write("\nID: {0}", u.ID);
            }

            finally
            {
                Console.WriteLine("\nPresione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        public void Delete()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del Users a borrar: ");
                int ID = int.Parse(Console.ReadLine());
                UsersN.Delete(ID);

            }
            catch (FormatException)
            {
                Console.WriteLine("\nEl ID ingresado tiene que ser numérico.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPresione una tecla para continuar.");
                Console.ReadKey();
            }
        }

    }
}