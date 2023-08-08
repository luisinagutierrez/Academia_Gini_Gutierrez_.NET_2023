using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Specialities : Connection
    {
        public int Add(Entidades.Specialities item)
        {
            try 
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Specialities (SpecialityDescription) VALUES (@SpecialityDescription)", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex) 
            {
                Exception HandledException = new Exception("Error al agregar especialidad", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Specialities item, int id)
        {
            try 
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Specialities SET SpecialityDescription = @SpecialityDescription WHERE IdSpeciality = @Id", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar especialidad", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE Specialities WHERE IdSpeciality = @Id", Conn);
     
                comm.Parameters.AddWithValue("@IdSpeciality", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar especialidad ", Ex);
                throw HandledException;
            }
            finally 
            { 
                Conn.Close();
            }
        }
    }
}