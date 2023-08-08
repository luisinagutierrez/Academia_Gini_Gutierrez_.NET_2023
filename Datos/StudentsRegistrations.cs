using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class StudentsRegistrations:Connection
    {
        public int Add(Entidades.StudentsRegistrations item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO StudentsRegistrations (IdStudent, IdCourse, Condition, Mark) VALUES (@IdStudent, @IdCourse, @Condition, @Mark)", Conn);
                comm.Parameters.AddWithValue("@IdStudent", item.IdStudent);
                comm.Parameters.AddWithValue("@IdCourse", item.IdCourse);
                comm.Parameters.AddWithValue("@Condition", item.Condition);
                comm.Parameters.AddWithValue("@Mark", item.Mark);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar inscripcion ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.StudentsRegistrations item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE StudentsRegistrations SET (IdStudent, IdCourse, Condition, Mark) = (@IdStudent, @IdCourse, @Condition, @Mark) WHERE IdRegistration = @Id", Conn);
                comm.Parameters.AddWithValue("@IdStudent", item.IdStudent);
                comm.Parameters.AddWithValue("@IdCourse", item.IdCourse);
                comm.Parameters.AddWithValue("@Condition", item.Condition);
                comm.Parameters.AddWithValue("@Mark", item.Mark);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar plan ", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE StudentsRegistrations WHERE IdRegistration = @Id", Conn);

                comm.Parameters.AddWithValue("@IdRegistration", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar inscripcion ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
