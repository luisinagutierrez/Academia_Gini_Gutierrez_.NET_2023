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
                SqlCommand comm = new SqlCommand("INSERT INTO Courses (IdSubject, IdCommission, CalendarYear, Quota, NumStudents) VALUES (@IdSubject, @IdCommission, @CalendarYear, @Quota, @numStudents)", Conn);
                comm.Parameters.AddWithValue("@IdSubject", item.IdSubject);
                comm.Parameters.AddWithValue("@IdCommission", item.IdCommission);
                comm.Parameters.AddWithValue("@CalendarYear", item.CalendarYear);
                comm.Parameters.AddWithValue("@Quota", item.Quota);
                comm.Parameters.AddWithValue("@NumStudents", item.NumStudents);
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
                comm.Parameters.AddWithValue("@NumStudents", item.NumStudents);
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

        public List<Entidades.Courses> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Courses", Conn);
                List<Entidades.Courses> CoursesList = new List<Entidades.Courses>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Courses objCourses = new Entidades.Courses();
                        objCourses.IdCourse = (int)oReader["IdCourse"];
                        objCourses.IdSubject = (int)oReader["IdSubject"];
                        objCourses.IdCommission = (int)oReader["IdCommission"];
                        objCourses.CalendarYear = (int)oReader["CalendarYear"];
                        objCourses.Quota = (int)oReader["Quota"];
                        objCourses.NumStudents = (int)oReader["NumStudents"];

                        CoursesList.Add(objCourses);
                        objCourses = null;
                    }
                    return CoursesList;
                }
            }
            finally
            {
                //objCourses = null;
                this.Disconnect();
            }
        }

        public Entidades.Courses GetOne(int id)
        {
            Entidades.Courses objCourses = new Entidades.Courses();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE @IdCourse = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objCourses.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                    objCourses.IdSubject = Convert.ToInt32(oReader["IdSubject"]);
                    objCourses.IdCommission = Convert.ToInt32(oReader["IdCommission"]);
                    objCourses.CalendarYear = Convert.ToInt32(oReader["CalendarYear"]);
                    objCourses.Quota = Convert.ToInt32(oReader["Quota"]);
                    objCourses.NumStudents = Convert.ToInt32(oReader["NumStudents"]);

                    

                    return objCourses;

                }
            }
            finally
            {
                objCourses = null;
            }
        }

        public List<Entidades.Courses> GetAvailableCourses()
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT Quota > NumStudents FROM Courses", Conn);
                List<Entidades.Courses> CoursesList = new List<Entidades.Courses>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Courses objCourses = new Entidades.Courses();
                        objCourses.IdCourse = (int)oReader["IdCourse"];
                        objCourses.IdSubject = (int)oReader["IdSubject"];
                        objCourses.IdCommission = (int)oReader["IdCommission"];
                        objCourses.CalendarYear = (int)oReader["CalendarYear"];
                        objCourses.Quota = (int)oReader["Quota"];
                        objCourses.NumStudents = (int)oReader["NumStudents"];

                        CoursesList.Add(objCourses);
                        objCourses = null;
                    }
                    return CoursesList;
                }
            }
            finally
            {
                //objCourses = null;
                this.Disconnect();
            }
        }
    }
}
