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
        public void Add(string desc)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Specialities (SpecialityDescription) VALUES (@SpecialityDescription)", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", desc);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar especialidad", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Update(int IdSpeciality, string SpecialityDescription)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Specialities SET SpecialityDescription = @SpecialityDescription WHERE IdSpeciality = @IdSpeciality", Conn);
                comm.Parameters.AddWithValue("@SpecialityDescription", SpecialityDescription);
                comm.Parameters.AddWithValue("@IdSpeciality", IdSpeciality);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar especialidad", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Delete(int IdSpeciality)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE FROM Specialities WHERE IdSpeciality = @IdSpeciality", Conn);
                comm.Parameters.AddWithValue("@IdSpeciality", IdSpeciality);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar especialidad ", Ex);
               // throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public List<Entidades.Specialities> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Specialities", Conn);
                List<Entidades.Specialities> SpecialitiesList = new List<Entidades.Specialities>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Specialities objSpecialities = new Entidades.Specialities();
                        objSpecialities.IdSpeciality = (int)oReader["IdSpeciality"];
                        objSpecialities.SpecialityDescription = (string)oReader["SpecialityDescription"];

                        SpecialitiesList.Add(objSpecialities);
                        objSpecialities = null;
                    }
                    return SpecialitiesList;
                }
            }
            finally
            {
                // objSpecialities = null;
                this.Disconnect();
            }
        }
        public Entidades.Specialities GetOne(int IdSpeciality)
        {
            Entidades.Specialities objSpecialities = new Entidades.Specialities();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Specialities WHERE IdSpeciality = @IdSpeciality", Conn)) 
                {
                    comm.Parameters.AddWithValue("@IdSpeciality", IdSpeciality);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objSpecialities.IdSpeciality = (int)oReader["IdSpeciality"];
                            objSpecialities.SpecialityDescription = (string)oReader["SpecialityDescription"];
                        }
                    }
                    return objSpecialities;
                }
            }
            finally
            {
                this.Disconnect( );
                objSpecialities = null;
            }
        }
    }
}