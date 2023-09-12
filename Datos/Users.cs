using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Datos
{
    public class Users : Connection
    {
        public void Add(int IdPerson, int Privilege, string UserName, string Password)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Users (UserName, Password, Status, ChangePassword, IdPerson, Privilege) VALUES (@UserName, @Password, 1, 0, @IdPerson, @Privilege) select @@identity", Conn);
                comm.Parameters.AddWithValue("@UserName", UserName);
                comm.Parameters.AddWithValue("@Password", Password);
                comm.Parameters.AddWithValue("@IdPerson", IdPerson);
                comm.Parameters.AddWithValue("@Privilege",Privilege);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar usuario ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Update(Entidades.Users item, int IdUser)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Users SET UserName = @UserName, Password = @Password, Status = @Status, ChangePassword = @ChangePassword, Privilege = @Privilege, IdPerson = @IdPerson WHERE IdUser = @IdUser", Conn);
                comm.Parameters.AddWithValue("@IdUser", IdUser);
                comm.Parameters.AddWithValue("@UserName", item.UserName);
                comm.Parameters.AddWithValue("@Password", item.Password);
                comm.Parameters.AddWithValue("@Status", item.Status);
                comm.Parameters.AddWithValue("@ChangePassword", item.ChangePassword);
                comm.Parameters.AddWithValue("@Privilege", item.Privilege);
                comm.Parameters.AddWithValue("@IdPerson", item.IdPerson);

                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar usuario ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Delete(int IdUser)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE Users WHERE IdUser = @IdUser", Conn);

                comm.Parameters.AddWithValue("@IdUser", IdUser);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar usuario ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public List<Entidades.Users> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Users", Conn);
                List<Entidades.Users> UsersList = new List<Entidades.Users>();
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Users objUsers = new Entidades.Users();
                        objUsers.IdUser = (int)oReader["IdUser"];
                        objUsers.Privilege = (int)oReader["Privilege"];
                        objUsers.UserName = (string)oReader["UserName"];
                        objUsers.Password = (string)oReader["Password"];
                        objUsers.Status = (bool)oReader["Status"];
                        objUsers.ChangePassword = (bool)oReader["Status"];
                        objUsers.IdPerson = (int)oReader["IdPerson"];
                        UsersList.Add(objUsers);
                        objUsers = null;
                    }
                    return UsersList;
                }
            }
            finally
            {
                //objUsers = null;
                this.Disconnect();
            }
        }
        public Entidades.Users GetOne(int IdUser)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE @IdUser = IdUser", Conn))
                {
                    comm.Parameters.AddWithValue("@IdUser", IdUser);

                    // Ejecutamos el comando y retornamos los valores
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                            objUsers.IdUser = (int)oReader["IdUser"];
                            objUsers.UserName = (string)oReader["UserName"];
                            objUsers.Privilege = (int)oReader["Privilege"];
                            objUsers.Password = (string)oReader["Password"];
                            objUsers.Status = (bool)oReader["Status"];
                            objUsers.ChangePassword = (bool)oReader["ChangePassword"];
                            objUsers.IdPerson = (int)oReader["IdPerson"];
                        }
                    }
                    return objUsers;
                }
            }
            finally
            {
                objUsers = null;
                this.Disconnect();
            }
        }
        public int GetPrivilege(string userName, string password)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT Privilege FROM Users WHERE UserName = @userName AND Password = @password", Conn))
                {
                    comm.Parameters.AddWithValue("@userName", userName);
                    comm.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objUsers.Privilege = (int)oReader["Privilege"];
                        }
                    }
                }
                return objUsers.Privilege;
            }
            finally
            {
                objUsers = null;
                this.Disconnect();
            }
        }
        public void  ChangePassword(string UserName, string Password)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Users SET Password = @Password, ChangePassword = 1 WHERE UserName = @UserName", Conn);
                comm.Parameters.AddWithValue("@UserName", UserName);
                comm.Parameters.AddWithValue("@Password", Password);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error: no se conecta " + Ex.Message);
            }
            finally
            {
                this.Disconnect();
            }
        }
        public int GetIdPerson(string UserName, string Password)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT IdPerson FROM Users WHERE UserName = @UserName AND Password = @Password", Conn))
                {
                    comm.Parameters.AddWithValue("@UserName", UserName);
                    comm.Parameters.AddWithValue("@Password", Password);
                    // Ejecutamos el comando y retornamos los valores
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objUsers.IdPerson = (int)oReader["IdPerson"];
                        }
                    }
                }
                return objUsers.IdPerson;
            }
            finally
            {
                // Finally nos da siempre la oportunidad de liberar memoria usada por los objetos 
                objUsers = null;
                this.Disconnect();
            }
        } 
        public Entidades.Users GetUserByIdPerson(int IdPerson)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE IdPerson = @IdPerson", Conn))
                {
                    comm.Parameters.AddWithValue("@IdPerson", IdPerson);
                    // Ejecutamos el comando y retornamos los valores
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objUsers.IdUser = (int)oReader["IdUser"];
                            objUsers.UserName = (string)oReader["UserName"];
                            objUsers.Privilege = (int)oReader["Privilege"];
                            objUsers.Password = (string)oReader["Password"];
                            objUsers.Status = (bool)oReader["Status"];
                            objUsers.ChangePassword = (bool)oReader["ChangePassword"];
                            objUsers.IdPerson = (int)oReader["IdPerson"];
                        }
                    }
                }
                return objUsers;
            }
            finally
            {
                // Finally nos da siempre la oportunidad de liberar memoria usada por los objetos 
                //objUsers = null;
                this.Disconnect();
            }
        }

        public Entidades.Users GetUserByUserName(string UserName, int IdPerson)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE UserName = @UserName AND IdPerson =@IdPerson", Conn))
                {
                    comm.Parameters.AddWithValue("@UserName", UserName);
                    comm.Parameters.AddWithValue("@IdPerson", IdPerson);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objUsers.IdUser = (int)oReader["IdUser"];
                            objUsers.UserName = (string)oReader["UserName"];
                            objUsers.Privilege = (int)oReader["Privilege"];
                            objUsers.Password = (string)oReader["Password"];
                            objUsers.Status = (bool)oReader["Status"];
                            objUsers.ChangePassword = (bool)oReader["ChangePassword"];
                            objUsers.IdPerson = (int)oReader["IdPerson"];
                        }
                    }
                }
                return objUsers;
            }
            finally
            {
                //objUsers = null;
                this.Disconnect();
            }
        }
    }
}
