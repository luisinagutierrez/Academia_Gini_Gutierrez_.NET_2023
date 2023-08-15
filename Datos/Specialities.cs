using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Specialities : Connection
    {
        public int Add(Entidades.Specialities item)
        {
            try 
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Specialities (SpecialityDescription) VALUES (@SpecialityDescription)", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex) 
            {
                Exception HandledException = new Exception("Error al agregar especialidad", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.Specialities item, int id)
        {
            try 
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE Specialities SET SpecialityDescription = @SpecialityDescription WHERE IdSpeciality = @Id", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", item.SpecialityDescription);
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
                SqlCommand comm = new SqlCommand("DELETE Specialities WHERE IdSpeciality = @Id", Conn);
     
                comm.Parameters.AddWithValue("@IdSpeciality", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar especialidad ", Ex);
                throw HandledException;
            }
            finally 
            { 
                Conn.Close();
            }
        }
        public List<Entidades.Specialities> GetAll()
        {
            Entidades.Specialities objSpecialities = new Entidades.Specialities();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Specialities", Conn);
                List<Entidades.Specialities> SpecialitiesList = new List<Entidades.Specialities>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        objSpecialities.IdSpeciality = Convert.ToInt32(oReader["IdSpeciality"]);
                        objSpecialities.SpecialityDescription = Convert.ToString(oReader["SpecialityDescription"]);

                        SpecialitiesList.Add(objSpecialities);
                        objSpecialities = null;
                    }
                    return SpecialitiesList;
                }
            }
            finally
            {
                objSpecialities = null;
            }
        }
        public Entidades.Specialities GetOne(int id)
        {
            Entidades.Specialities objSpecialities = new Entidades.Specialities();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Specialities WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objSpecialities.IdSpeciality = Convert.ToInt32(oReader["IdSpeciality"]);
                    objSpecialities.SpecialityDescription = Convert.ToString(oReader["SpecialityDescription"]);

                    return objSpecialities;
                    
                }
                
            }
            finally
            {
                objSpecialities = null;
            }
        }
    }
}