using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class TeacherCourses:Connection
    {
        public int Add(Entidades.TeacherCourses item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO TeacherCourses (IdCourse, IdTeacher, Position) VALUES (@IdCourse, @IdTeacher, @Position)", Conn);
                comm.Parameters.AddWithValue("@IdCourse", item.IdCourse);
                comm.Parameters.AddWithValue("@IdTeacher", item.IdTeacher);
                comm.Parameters.AddWithValue("@Position", item.Position);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar dictado ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.TeacherCourses item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE TeacherCourses SET (IdCourse, IdTeacher, Position) = (@IdCourse, @IdTeacher, @Position) WHERE IdDictation = @Id", Conn);
                comm.Parameters.AddWithValue("@IdCourse", item.IdCourse);
                comm.Parameters.AddWithValue("@IdTeacher", item.IdTeacher);
                comm.Parameters.AddWithValue("@Position", item.Position);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar dictado ", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE TeacherCourses WHERE IdDictation = @Id", Conn);

                comm.Parameters.AddWithValue("@IdDictation", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar dictado ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
