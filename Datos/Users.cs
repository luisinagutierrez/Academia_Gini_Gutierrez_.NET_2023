using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Users: Connection
    {
        public int Add(Entidades.Users item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Users (UserName, Password, Status, ChangePassword, IdPerson) VALUES (@UserName, @Password, @Status, @ChangePassword, @IdPerson)", Conn);
                comm.Parameters.AddWithValue("@UserName", item.UserName);
                comm.Parameters.AddWithValue("@Password", item.Password);
                comm.Parameters.AddWithValue("@Status", item.Status); 
                comm.Parameters.AddWithValue("@ChangePassword", item.ChangePassword); 
                comm.Parameters.AddWithValue("@IdPerson", item.IdPerson);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar usuario ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Users item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Users SET (UserName, Password, Status, ChangePassword, IdPerson) = (@UserName, @Password, @Status, @ChangePassword, @IdPerson) WHERE IdUser = @Id", Conn);
                comm.Parameters.AddWithValue("@UserName", item.UserName);
                comm.Parameters.AddWithValue("@Password", item.Password);
                comm.Parameters.AddWithValue("@Status", item.Status);
                comm.Parameters.AddWithValue("@ChangePassword", item.ChangePassword);
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
                Conn.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                Conn.Open();
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
                Conn.Close();
            }
        }
        public List<Entidades.Users> GetAll()
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Users", Conn);
                List<Entidades.Users> UsersList = new List<Entidades.Users>();
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                        objUsers.IdUser = Convert.ToInt32(oReader["IdUser"]);
                        objUsers.UserName = Convert.ToString(oReader["UserName"]);
                        objUsers.Password = Convert.ToString(oReader["Password"]);
                        objUsers.Status = Convert.ToBoolean(oReader["Status"]);
                        objUsers.ChangePassword = Convert.ToBoolean(oReader["Status"]);
                        objUsers.IdPerson = Convert.ToInt32(oReader["IdPerson"]);

                        // Agregamos el objeto a la coleccion de resultados
                        UsersList.Add(objUsers);
                        objUsers = null;
                    }
                    // Retornamos los valores encontrados
                    return UsersList;
                }
            }
            finally
            {
                // El Finally nos da siempre la oportunidad de liberar
                // la memoria utilizada por los objetos 
                objUsers = null;
            }
        }
        public Entidades.Users GetOne(string userName, string password)
        {
            Entidades.Users objUsers = new Entidades.Users();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Users WHERE @UserName = userName AND @Password = password", Conn);
                comm.Parameters.AddWithValue("@UserName", userName);
                comm.Parameters.AddWithValue("@Password", password);
                // Ejecutamos el comando y retornamos los valores
                SqlDataReader oReader = comm.ExecuteReader();    
                using (oReader)
                {
                    oReader.Read();
                    // Si existe algun valor, creamos el objeto y lo almacenamos en la colección
                    objUsers.IdUser = Convert.ToInt32(oReader["IdUser"]);
                    objUsers.UserName = Convert.ToString(oReader["UserName"]);
                    objUsers.Password = Convert.ToString(oReader["Password"]);
                    objUsers.Status = Convert.ToBoolean(oReader["Status"]);
                    objUsers.ChangePassword = Convert.ToBoolean(oReader["ChangePassword"]);
                    objUsers.IdPerson = Convert.ToInt32(oReader["IdPerson"]);


                    return objUsers;

                }
            }
            finally
            {
                // Finally nos da siempre la oportunidad de liberar memoria usada por los objetos 
                objUsers = null;
            }
        }

    }
}
