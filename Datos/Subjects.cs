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
        public List<Entidades.Subjects> GetAll()
        {
            Entidades.Subjects objSubjects = new Entidades.Subjects();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Subjects", Conn);
                List<Entidades.Subjects> SubjectsList = new List<Entidades.Subjects>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        objSubjects.IdSubject = Convert.ToInt32(oReader["IdSubject"]);
                        objSubjects.SubjectDescription = Convert.ToString(oReader["SubjectDescription"]);
                        objSubjects.WeeklyHours = Convert.ToInt32(oReader["WeeklyHours"]);
                        objSubjects.TotalHours = Convert.ToInt32(oReader["TotalHours"]);
                        objSubjects.IdPlan = Convert.ToInt32(oReader["IdPlan"]);

                        SubjectsList.Add(objSubjects);
                        objSubjects = null;
                    }
                    return SubjectsList;
                }
            }
            finally
            {
                objSubjects = null;
            }
        }
        public Entidades.Subjects GetOne(int id)
        {
            Entidades.Subjects objSubjects = new Entidades.Subjects();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Subjects WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objSubjects.IdSubject = Convert.ToInt32(oReader["IdSubject"]);
                    objSubjects.SubjectDescription = Convert.ToString(oReader["SubjectDescription"]);
                    objSubjects.WeeklyHours = Convert.ToInt32(oReader["WeeklyHours"]);
                    objSubjects.TotalHours = Convert.ToInt32(oReader["TotalHours"]);
                    objSubjects.IdPlan = Convert.ToInt32(oReader["IdPlan"]);

                    objSubjects = null;

                    return objSubjects;

                }
            }
            finally
            {
                objSubjects = null;
            }
        }
    }
}
