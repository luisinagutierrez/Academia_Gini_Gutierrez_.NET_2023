using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
        public void Update(Entidades.StudentsRegistrations item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE StudentsRegistrations SET (IdStudent, IdCourse, Condition, Mark) = (@IdStudent, @IdCourse, @Condition, @Mark) WHERE IdRegistration = @Id", Conn);
                comm.Parameters.AddWithValue("@IdStudent", item.IdStudent);
                comm.Parameters.AddWithValue("@IdCourse", item.IdCourse);
                comm.Parameters.AddWithValue("@Condition", item.Condition);      // LA CONDICION NO SE TENDRÍA Q ACTUALIZAR DEPENDIENDO DE LA NOTA?
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
        public List<Entidades.StudentsRegistrations> GetAll()
        {

            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM StudentsRegistrations", Conn);
                List<Entidades.StudentsRegistrations> StudentsRegistrationsList = new List<Entidades.StudentsRegistrations>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                        objStudentsRegistrations.IdRegistration = Convert.ToInt32(oReader["IdRegistration"]);
                        objStudentsRegistrations.IdStudent = Convert.ToInt32(oReader["IdStudent"]);
                        objStudentsRegistrations.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                        objStudentsRegistrations.Condition = Convert.ToString(oReader["Condition"]);
                        objStudentsRegistrations.Mark = Convert.ToInt32(oReader["Mark"]);

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
        public List<Entidades.StudentsRegistrations> GetStudentsRegByIdCourse(int IdCourse)
        {
            //Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();

            try
            {
                this.Connect();

                SqlCommand comm = new SqlCommand("SELECT IdRegistration, IdStudent, IdCourse, Condition  FROM StudentsRegistrations WHERE IdCourse = @IdCourse", Conn);
                comm.Parameters.AddWithValue("@IdCourse", IdCourse);
                List<Entidades.StudentsRegistrations> StudentsRegistrationsList = new List<Entidades.StudentsRegistrations>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {

                        Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                        objStudentsRegistrations.IdRegistration = (int)oReader["IdRegistration"];
                        objStudentsRegistrations.IdStudent = (int)oReader["IdStudent"];
                        objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        objStudentsRegistrations.Condition = (string)oReader["Condition"];

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
                SqlCommand comm = new SqlCommand("SELECT IdRegistration,IdStudent, IdCourse, Condition, Mark FROM StudentsRegistrations WHERE IdStudent = @IdStudent", Conn);
                List<Entidades.StudentsRegistrations> StudentsRegistrationsList = new List<Entidades.StudentsRegistrations>();
                comm.Parameters.AddWithValue("@IdStudent", IdStudent);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
                        objStudentsRegistrations.IdRegistration = (int)oReader["IdRegistration"];
                        objStudentsRegistrations.IdStudent = (int)oReader["IdStudent"];
                        objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];
                        objStudentsRegistrations.Condition = (string)oReader["Condition"];
                        if (objStudentsRegistrations.Condition == "HAY QUE CAMBIAR ESTO PARA QUE QUEDE MEJOR")
                        {
                            objStudentsRegistrations.Mark = (int)oReader["Mark"];
                        }

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
                SqlCommand comm = new SqlCommand("SELECT IdCourse FROM StudentsRegistrations WHERE @IdRegistration = IdRegistration AND IdStudent =@IdStudent ", Conn);
                comm.Parameters.AddWithValue("@IdStudent", IdStudent);
                comm.Parameters.AddWithValue("@IdRegistration", IdRegistration);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();
                    objStudentsRegistrations.IdCourse = (int)oReader["IdCourse"];                     
                    return objStudentsRegistrations.IdCourse;                                                     // SEGURAMENTE TIRE ERROR SI NO LO ENCUENTRA
                                                                      //NO SE QUE DEVULEVE SI UN NULL O UN 0 PONELE
                }
            }
            finally
            {
                objStudentsRegistrations = null;
                this.Disconnect();
            }
        }
    }
}
