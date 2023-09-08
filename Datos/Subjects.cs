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
    public class Subjects:Connection
    {
        public void Add(int IdPlan, string SubjectDescription, int TotalHours, int WeeklyHours)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Subjects (SubjectDescription, WeeklyHours, TotalHours, IdPlan) VALUES (@SubjectDescription, @WeeklyHours, @TotalHours, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@SubjectDescription", SubjectDescription);
                comm.Parameters.AddWithValue("@WeeklyHours", WeeklyHours);
                comm.Parameters.AddWithValue("@TotalHours", TotalHours);    
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar materia ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Update(int IdSubject, string SubjectDescription, int TotalHours, int WeeklyHours, int IdPlan)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Subjects SET (SubjectDescription, WeeklyHours, TotalHours, IdPlan) = (@SubjectDescription, @WeeklyHours, @TotalHours, @IdPlan) WHERE IdSubject = @Id", Conn);
                comm.Parameters.AddWithValue("@IdSubject", IdSubject);
                comm.Parameters.AddWithValue("@SubjectDescription", SubjectDescription);
                comm.Parameters.AddWithValue("@WeeklyHours", WeeklyHours);
                comm.Parameters.AddWithValue("@TotalHours",TotalHours);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar materia ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Delete(int IdSubject)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE Subjects WHERE IdSubject = @IdSubject", Conn);

                comm.Parameters.AddWithValue("@IdSubject", IdSubject);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar materia ", Ex);
                //throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public List<Entidades.Subjects> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Subjects", Conn);
                List<Entidades.Subjects> SubjectsList = new List<Entidades.Subjects>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Subjects objSubjects = new Entidades.Subjects();
                        objSubjects.IdSubject = (int)oReader["IdSubject"];
                        objSubjects.SubjectDescription = (string)oReader["SubjectDescription"];
                        objSubjects.WeeklyHours = (int)oReader["WeeklyHours"];
                        objSubjects.TotalHours = (int)oReader["TotalHours"];
                        objSubjects.IdPlan = (int)oReader["IdPlan"];

                        SubjectsList.Add(objSubjects);
                        objSubjects = null;
                    }
                    return SubjectsList;
                }
            }
            finally
            {
                //objSubjects = null;
                this.Disconnect();
            }
        }

        public Entidades.Subjects GetOne(int IdSubject)
        {
            Entidades.Subjects objSubjects = new Entidades.Subjects();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Subjects WHERE @IdSubject = IdSubject", Conn);
                comm.Parameters.AddWithValue("@IdSubject", IdSubject);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objSubjects.IdSubject = (int)oReader["IdSubject"];
                    objSubjects.SubjectDescription = (string)oReader["SubjectDescription"];
                    objSubjects.WeeklyHours = (int)oReader["WeeklyHours"];
                    objSubjects.TotalHours = (int)oReader["TotalHours"];
                    objSubjects.IdPlan = (int)oReader["IdPlan"];


                    return objSubjects;

                }
            }
            finally
            {
                objSubjects = null;
                this.Disconnect();
            }
        }
    }
}
