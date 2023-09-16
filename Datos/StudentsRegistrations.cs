using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace Datos
{
    public class StudentsRegistrations : Connection
    {
        public void Add(int IdCourse, int IdStudent)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO StudentsRegistrations (IdStudent, IdCourse, Condition, Mark) VALUES (@IdStudent, @IdCourse, 'inscripto', 0)", Conn);
                comm.Parameters.AddWithValue("@IdStudent", IdStudent);
                comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar inscripcion ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void UpdateMark(int IdRegistration,int Mark, string Condition)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE StudentsRegistrations SET Condition =@Condition,  Mark =@Mark  WHERE IdRegistration = @IdRegistration", Conn);
                comm.Parameters.AddWithValue("@IdRegistration", IdRegistration);
                comm.Parameters.AddWithValue("@Condition", Condition);
                comm.Parameters.AddWithValue("@Mark", Mark);

                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar la condicion del alumno ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Delete(int IdRegistration)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE StudentsRegistrations WHERE IdRegistration = @IdRegistration", Conn);

                comm.Parameters.AddWithValue("@IdRegistration", IdRegistration);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar inscripcion ", Ex);
                //throw HandledException; CORTA EL PROGRAMA SI LO DEJO PERO TAMPOCO ME DICE CUAL ES EL PROBLEMA 
            }
            finally
            {
                this.Disconnect();
            }
        }
        public List<Entidades.StudentsRegistrations> GetStudentsRegByIdCourse(int IdCourse)
        {

            try
            {
                this.Connect();

                SqlCommand comm = new SqlCommand("SELECT * FROM StudentsRegistrations WHERE IdCourse = @IdCourse", Conn);
                List<Entidades.StudentsRegistrations> StudentsRegistrationsList = new List<Entidades.StudentsRegistrations>();
                comm.Parameters.AddWithValue("@IdCourse", IdCourse);

                using (SqlDataReader oReader = comm.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                        objStudentsRegistrations.IdRegistration = (int)oReader["IdRegistration"];
                        objStudentsRegistrations.IdStudent = (int)oReader["IdStudent"];
                        objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        objStudentsRegistrations.Condition = (string)oReader["Condition"];
                        objStudentsRegistrations.Mark = (int)oReader["Mark"];

                        StudentsRegistrationsList.Add(objStudentsRegistrations);
                        objStudentsRegistrations = null;
                    }
                    return StudentsRegistrationsList;
                }
            }
            finally
            {
                //objCourses = null;
                this.Disconnect();
            }
        }
        public List<Entidades.StudentsRegistrations> GetCoursesByIdPerson(int IdStudent)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM StudentsRegistrations WHERE IdStudent = @IdStudent", Conn);
                List<Entidades.StudentsRegistrations> StudentsRegistrationsList = new List<Entidades.StudentsRegistrations>();
                comm.Parameters.AddWithValue("@IdStudent", IdStudent);

                using (SqlDataReader oReader = comm.ExecuteReader()) 
                {
                    while (oReader.Read())
                    {
                        Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                        objStudentsRegistrations.IdRegistration = (int)oReader["IdRegistration"];
                        objStudentsRegistrations.IdStudent = (int)oReader["IdStudent"];
                        objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        objStudentsRegistrations.Condition = (string)oReader["Condition"];
                        objStudentsRegistrations.Mark = (int)oReader["Mark"];

                        StudentsRegistrationsList.Add(objStudentsRegistrations);
                        objStudentsRegistrations = null;
                    }
                    return StudentsRegistrationsList;
                }
            }
            finally
            {
                //objCourses = null;
                this.Disconnect();
            }
        }
        public int ValidateStudentsRegistrations(int IdRegistration, int IdStudent)
        {
            Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT IdCourse FROM StudentsRegistrations WHERE @IdRegistration = IdRegistration AND IdStudent =@IdStudent ", Conn))
                {
                    comm.Parameters.AddWithValue("@IdStudent", IdStudent);
                    comm.Parameters.AddWithValue("@IdRegistration", IdRegistration);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        }
                    }
                    return objStudentsRegistrations.IdCourse;                                                  
                }
            }
            finally
            {
                objStudentsRegistrations = null;
                this.Disconnect();
            }
        }

        public int GetStudentReg(int IdStudent, int IdCourse)
        {
            Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT IdCourse FROM StudentsRegistrations WHERE IdCourse = @IdCourse AND IdStudent =@IdStudent ", Conn))
                {
                    comm.Parameters.AddWithValue("@IdStudent", IdStudent);
                    comm.Parameters.AddWithValue("@IdCourse", IdCourse);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        }
                    }
                    return objStudentsRegistrations.IdCourse;
                }
            }
            finally
            {
                objStudentsRegistrations = null;
                this.Disconnect();
            }
        }

        public List<Entidades.StudentsRegistrations> GetStudentRegByIdperson(int IdStudent)
        {
            List<Entidades.StudentsRegistrations> StudentRegistrationList = new List<Entidades.StudentsRegistrations>();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM StudentsRegistrations WHERE IdStudent =@IdStudent ", Conn))
                {
                    comm.Parameters.AddWithValue("@IdStudent", IdStudent);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                            objStudentsRegistrations.IdRegistration = (int)oReader["IdRegistration"];
                            objStudentsRegistrations.IdStudent = (int)oReader["IdStudent"];
                            objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                            objStudentsRegistrations.Condition = (string)oReader["Condition"];
                            objStudentsRegistrations.Mark = (int)oReader["Mark"];

                            StudentRegistrationList.Add(objStudentsRegistrations);
                            objStudentsRegistrations = null;
                        }
                    }
                    return StudentRegistrationList;
                }
            }
            finally
            {
                //objStudentsRegistrations = null;
                this.Disconnect();
            }
        }
    }
}

