using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos { 
    public class Courses:Connection
    {
        public int Add(Entidades.Courses item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Courses (IdSubject, IdCommission, CalendarYear, Quota) VALUES (@IdSubject, @IdCommission, @CalendarYear, @Quota)", Conn);
                comm.Parameters.AddWithValue("@IdSubject", item.IdSubject);
                comm.Parameters.AddWithValue("@IdCommission", item.IdCommission);
                comm.Parameters.AddWithValue("@CalendarYear", item.CalendarYear);
                comm.Parameters.AddWithValue("@Quota", item.Quota);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar curso", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Courses item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Courses SET (IdSubject, IdCommission, CalendarYear, Quota) = (@IdSubject, @IdCommission, @CalendarYear, @Quota) WHERE IdCourse = @Id", Conn);
                comm.Parameters.AddWithValue("@IdSubject", item.IdSubject);
                comm.Parameters.AddWithValue("@IdCommission", item.IdCommission);
                comm.Parameters.AddWithValue("@CalendarYear", item.CalendarYear);
                comm.Parameters.AddWithValue("@Quota", item.Quota);
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
                SqlCommand comm = new SqlCommand("DELETE Courses WHERE IdCourse = @Id", Conn);

                comm.Parameters.AddWithValue("@IdCourses", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar curso ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
