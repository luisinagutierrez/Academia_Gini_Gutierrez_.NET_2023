using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Subjects:Connection
    {
        public int Add(Entidades.Subjects item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Subjects (SubjectDescription, WeeklyHours, TotalHours, IdPlan) VALUES (@SubjectDescription, @WeeklyHours, @TotalHours, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@SubjectDescription", item.SubjectDescription);
                comm.Parameters.AddWithValue("@WeeklyHours", item.WeeklyHours);
                comm.Parameters.AddWithValue("@TotalHours", item.TotalHours);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar materia ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Subjects item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Subjects SET (SubjectDescription, WeeklyHours, TotalHours, IdPlan) = (@SubjectDescription, @WeeklyHours, @TotalHours, @IdPlan) WHERE IdSubject = @Id", Conn);
                comm.Parameters.AddWithValue("@SubjectDescription", item.SubjectDescription);
                comm.Parameters.AddWithValue("@WeeklyHours", item.WeeklyHours);
                comm.Parameters.AddWithValue("@TotalHours", item.TotalHours);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar materia ", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE Subjects WHERE IdSubject = @Id", Conn);

                comm.Parameters.AddWithValue("@IdSubject", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar materia ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
