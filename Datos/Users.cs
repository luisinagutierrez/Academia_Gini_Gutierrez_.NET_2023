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
                SqlCommand comm = new SqlCommand("INSERT INTO People (UserName, Password, Status, ChangePassword, IdPerson) VALUES (@UserName, @Password, @Status, @ChangePassword, @IdPerson)", Conn);
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
                SqlCommand comm = new SqlCommand("UPDATE People SET (UserName, Password, Status, ChangePassword, IdPerson) = (@UserName, @Password, @Status, @ChangePassword, @IdPerson) WHERE IdUser = @Id", Conn);
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
    }
}
