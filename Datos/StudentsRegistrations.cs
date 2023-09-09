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
                comm.Parameters.AddWithValue("@Condition", item.Condition);    // Al inscribirse desde un principio debería ser inscripto desde el principio 
                //comm.Parameters.AddWithValue("@Mark", item.Mark);     
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
        public List<Entidades.StudentsRegistrations> GetAll()
        {
            Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
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
                objStudentsRegistrations = null;
            }
        }
        public Entidades.StudentsRegistrations GetOne(int id)
        {
            Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM StudentsRegistrations WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objStudentsRegistrations.IdRegistration = Convert.ToInt32(oReader["IdRegistration"]);
                    objStudentsRegistrations.IdStudent = Convert.ToInt32(oReader["IdStudent"]);
                    objStudentsRegistrations.IdCourse = Convert.ToInt32(oReader["IdCourse"]);
                    objStudentsRegistrations.Condition = Convert.ToString(oReader["Condition"]);
                    objStudentsRegistrations.Mark = Convert.ToInt32(oReader["Mark"]);

                    return objStudentsRegistrations;

                }
            }
            finally
            {
                objStudentsRegistrations = null;
            }
        }
        public List<Entidades.StudentsRegistrations> GetStudentsRegByIdCourse(int IdCourse)
        {
            //Entidades.StudentsRegistrations objStudentsRegistrations = new Entidades.StudentsRegistrations();

            try
            {
                this.Connect();

                SqlCommand comm = new SqlCommand("SELECT IdRegistration, IdStudent, IdCourse, Condition FROM StudentsRegistrations WHERE IdCourse = @IdCourse", Conn);
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







    }
}
