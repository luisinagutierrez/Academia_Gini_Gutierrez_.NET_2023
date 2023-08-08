using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class People:Connection
    {
        public int Add(Entidades.People item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO People (Name, Surname, Address, Email, Telephone, BirthDate, FileId, PersonType, IdPlan) VALUES (@Name, @Surname, @Address, @Email, @Telephone, @BirthDate, @FileId, @PersonType, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@Name", item.Name);
                comm.Parameters.AddWithValue("@Surname", item.Surname);
                comm.Parameters.AddWithValue("@Address", item.Address);
                comm.Parameters.AddWithValue("@Email", item.Email);
                comm.Parameters.AddWithValue("@Telephone", item.Telephone);
                comm.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                comm.Parameters.AddWithValue("@FileId", item.FileId);
                comm.Parameters.AddWithValue("@PersonType", item.PersonType);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar persona ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.People item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE People SET (Name, Surname, Address, Email, Telephone, BirthDate, FileId, PersonType, IdPlan) = (@Name, @Surname, @Address, @Email, @Telephone, @BirthDate, @FileId, @PersonType, @IdPlan) WHERE IdPerson = @Id", Conn);
                comm.Parameters.AddWithValue("@Name", item.Name);
                comm.Parameters.AddWithValue("@Surname", item.Surname);
                comm.Parameters.AddWithValue("@Address", item.Address);
                comm.Parameters.AddWithValue("@Email", item.Email);
                comm.Parameters.AddWithValue("@Telephone", item.Telephone);
                comm.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                comm.Parameters.AddWithValue("@FileId", item.FileId);
                comm.Parameters.AddWithValue("@PersonType", item.PersonType);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar persona ", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE People WHERE IdPerson = @Id", Conn);

                comm.Parameters.AddWithValue("@IdPerson", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar persona ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
