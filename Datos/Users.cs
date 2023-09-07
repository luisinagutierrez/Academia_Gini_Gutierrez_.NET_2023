using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Users : Connection
    {
        public int Add(Entidades.Users item)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Users (UserName, Password, Status, ChangePassword, IdPerson, Privilege) VALUES (@UserName, @Password, @Status, @ChangePassword, @IdPerson, @Privilege) seelct @@identity", Conn);
                comm.Parameters.AddWithValue("@UserName", item.UserName);
                comm.Parameters.AddWithValue("@Password", item.Password);
                comm.Parameters.AddWithValue("@Status", item.Status);
                comm.Parameters.AddWithValue("@ChangePassword", item.ChangePassword);
                comm.Parameters.AddWithValue("@IdPerson", item.IdPerson);
                comm.Parameters.AddWithValue("@Privilege", item.Privilege);
                return comm.ExecuteNonQuery();
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

        public void Update(Entidades.Users item)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Users SET (UserName, Password, Status, ChangePassword, Privilege, IdPerson) = (@UserName, @Password, @Status, @ChangePassword, @Privilege,@IdPerson) WHERE IdUser = @IdUser", Conn);
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

        public void Delete(int id)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE Users WHERE IdUser = @Id", Conn);

                comm.Parameters.AddWithValue("@IdUser", id);
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
            Entidades.Users objUsers = new Entidades.Users();
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
                objUsers = null;
                this.Disconnect();
            }
        }
 
        
        public Entidades.Users GetOne(int id)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);
  
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();
                    // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                    objUsers.IdUser = (int)oReader["IdUser"];
                    objUsers.UserName = (string)oReader["UserName"];
                    objUsers.Privilege = (int)oReader["Privilege"];
                    objUsers.Password = (string)oReader["Password"];
                    objUsers.Status = (bool)oReader["Status"];
                    objUsers.ChangePassword = (bool)oReader["ChangePassword"];
                    objUsers.IdPerson = (int)oReader["IdPerson"];

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
                SqlCommand comm = new SqlCommand("SELECT privilege FROM Users WHERE UserName = @userName AND Password = @password", Conn);
                comm.Parameters.AddWithValue("@UserName", userName);
                comm.Parameters.AddWithValue("@Password", password);
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();
                    // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                   objUsers.Privilege = (int)oReader["Privilege"];
                    if (oReader["Privilege"]  == DBNull.Value)
                    {
                        return -1;
                    }
                    else 
                    {
                        objUsers.Privilege = (int)oReader["Privilege"];
                        return objUsers.Privilege;
                    }
                        

                }
            }
            finally
            {
                // Finally nos da siempre la oportunidad de liberar memoria usada por los objetos 
                objUsers = null;
                this.Disconnect();
            }
        }

        public void ChangePassword(string nom, string pass)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE User SET Password = @pass, ChangePassword = 1 WHERE UserName = @nom", Conn);
                comm.Parameters.AddWithValue("@UserName", nom);
                comm.Parameters.AddWithValue("@Password", pass);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar usuario ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public int GetIdPerson(string nom, string pass)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT IdPerson FROM Users WHERE UserName = @nom AND Password = @pass", Conn);
                comm.Parameters.AddWithValue("@UserName", nom);
                comm.Parameters.AddWithValue("@Password", pass);
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();
                    // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                    objUsers.IdPerson = (int)oReader["IdPerson"];
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
    }
}
