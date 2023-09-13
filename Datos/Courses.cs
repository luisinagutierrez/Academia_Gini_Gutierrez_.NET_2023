using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Courses : Connection
    {
        public void Add(int IdSubject, int IdCommission, int CalendarYear, int Quota)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Courses (IdSubject, IdCommission, CalendarYear, Quota, NumStudents) VALUES (@IdSubject, @IdCommission, @CalendarYear, @Quota, 0)", Conn);
                comm.Parameters.AddWithValue("@IdSubject", IdSubject);
                comm.Parameters.AddWithValue("@IdCommission", IdCommission);
                comm.Parameters.AddWithValue("@CalendarYear", CalendarYear);
                comm.Parameters.AddWithValue("@Quota", Quota);
                //comm.Parameters.AddWithValue("@NumStudents", item.NumStudents);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar curso", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Update(int IdCourse, int IdSubject, int IdCommission, int CalendarYear, int Quota)
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Courses SET IdSubject = @IdSubject, IdCommission = @IdCommission, CalendarYear = @CalendarYear, Quota = @Quota WHERE IdCourse = @IdCourse", Conn);
                comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                comm.Parameters.AddWithValue("@IdSubject", IdSubject);
                comm.Parameters.AddWithValue("@IdCommission", IdCommission);
                comm.Parameters.AddWithValue("@CalendarYear", CalendarYear);
                comm.Parameters.AddWithValue("@Quota", Quota);

                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar el curso", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Delete(int IdCourse)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE Courses WHERE IdCourse = @IdCourse", Conn);

                comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar curso ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
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
        public Entidades.Courses GetOne(int IdCourse)
        {
            Entidades.Courses objCourses = new Entidades.Courses();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE @IdCourse = IdCourse", Conn))
                {
                    comm.Parameters.AddWithValue("@IdCourse", IdCourse);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objCourses.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                            objCourses.IdSubject = Convert.ToInt32(oReader["IdSubject"]);
                            objCourses.IdCommission = Convert.ToInt32(oReader["IdCommission"]);
                            objCourses.CalendarYear = Convert.ToInt32(oReader["CalendarYear"]);
                            objCourses.Quota = Convert.ToInt32(oReader["Quota"]);
                            objCourses.NumStudents = Convert.ToInt32(oReader["NumStudents"]);
                        }

                    }
                }
                return objCourses;
            }
            finally
            {
                objCourses = null;
                this.Disconnect();

            }
        }
        public List<Entidades.Courses> GetAvailableCourses()
        {
            List<Entidades.Courses> CoursesList = new List<Entidades.Courses>();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE Quota > NumStudents", Conn))
                {

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
                    }
                }
                return CoursesList;

            }
            finally
            {
                //objCourses = null;
                this.Disconnect();
            }
        }
        public List<Entidades.Courses> GetCoursesByIdSubject(int IdSubject)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE IdSubject = @IdSubject", Conn);
                comm.Parameters.AddWithValue("@IdSubject", IdSubject);
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
        public List<Entidades.Courses> GetCoursesByIdCommission(int IdCommission)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE IdCommission = @IdCommission", Conn);
                comm.Parameters.AddWithValue("@IdCommission", IdCommission);
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
        public Entidades.Courses ValidateCourseAvailability(int IdCourse)
        {
            Entidades.Courses objCourses = new Entidades.Courses();
            try
            {
                using (SqlCommand comm = new SqlCommand("SELECT IdCourse FROM Courses WHERE @IdCourse = IdCourse and Quota > NumStudents", Conn))
                {
                    comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objCourses.IdCourse = (int)oReader["IdCourse"];
                        }
                    }
                }
                return objCourses;
            }
            finally
            {
                // objCourses = null;
                this.Disconnect();

            }
        }
        public void UpdateCourseAvailability(int IdCourse, int num)
        {
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("UPDATE Courses SET NumStudents = NumStudents + @num WHERE IdCourse = @IdCourse", Conn))
                {
                    comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                    comm.Parameters.AddWithValue("@num", num);
                    comm.ExecuteNonQuery();
                }
            }

            finally
            {
                this.Disconnect();
            }
        }
    }
}
