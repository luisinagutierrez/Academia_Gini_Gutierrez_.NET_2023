using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class TeacherCourses : Connection
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

        public List<Entidades.TeacherCourses> GetAll()
        {
            Entidades.TeacherCourses objTeacherCourses = new Entidades.TeacherCourses();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM TeacherCourses", Conn);
                List<Entidades.TeacherCourses> TeacherCoursesList = new List<Entidades.TeacherCourses>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        objTeacherCourses.IdDictation = Convert.ToInt32(oReader["IdDictation"]);
                        objTeacherCourses.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                        objTeacherCourses.IdTeacher = Convert.ToInt32(oReader["IdTeacher"]);
                        objTeacherCourses.Position = Convert.ToInt32(oReader["Position"]);

                        TeacherCoursesList.Add(objTeacherCourses);
                        objTeacherCourses = null;
                    }
                    return TeacherCoursesList;
                }
            }
            finally
            {
                objTeacherCourses = null;
            }
        }
        public Entidades.TeacherCourses GetOne(int id)
        {
            Entidades.TeacherCourses objTeacherCourses = new Entidades.TeacherCourses();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM TeacherCourses WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objTeacherCourses.IdDictation = Convert.ToInt32(oReader["IdDictation"]);
                    objTeacherCourses.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                    objTeacherCourses.IdTeacher = Convert.ToInt32(oReader["IdTeacher"]);
                    objTeacherCourses.Position = Convert.ToInt32(oReader["Position"]);


                    return objTeacherCourses;

                }
            }
            finally
            {
                objTeacherCourses = null;
            }
        }

        public List<Entidades.TeacherCourses> GetTeacherCoursesByIdCourse(int IdCourse)
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM TeacherCourses WHERE  IdCourse = @IdCourse", Conn);
                comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                List<Entidades.TeacherCourses> TeacherCoursesList = new List<Entidades.TeacherCourses>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                    while (oReader.Read())
                    {
                        Entidades.TeacherCourses objTeacherCourses = new Entidades.TeacherCourses();
                        objTeacherCourses.IdDictation = Convert.ToInt32(oReader["IdDictation"]);
                        objTeacherCourses.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                        objTeacherCourses.IdTeacher = Convert.ToInt32(oReader["IdTeacher"]);
                        objTeacherCourses.Position = Convert.ToInt32(oReader["Position"]);

                        TeacherCoursesList.Add(objTeacherCourses);
                        objTeacherCourses = null;
                    }
                return TeacherCoursesList;
            }

            finally
            {
                this.Disconnect();
            }
        }

    }
}


