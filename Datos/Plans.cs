using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Plans:Connection
    {
        public int Add(int IdSpeciality, string PlanDescription)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("INSERT INTO Plans (PlanDescription, IdSpeciality) VALUES (@PlanDescription, @IdSpeciality)", Conn);
                comm.Parameters.AddWithValue("@PlanDescription", PlanDescription);
                comm.Parameters.AddWithValue("@IdSpeciality", IdSpeciality);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar plan ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Update(int IdPlan, string PlanDescription, int IdSpeciality)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE Plans SET PlanDescription = @PlanDescription, @IdSpeciality = IdSpeciality WHERE @IdPlan = IdPlan", Conn);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.Parameters.AddWithValue("@PlanDescription", PlanDescription);
                comm.Parameters.AddWithValue("@IdSpeciality", IdSpeciality);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar el plan", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public void Delete(int IdPlan)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("DELETE FROM Plans WHERE IdPlan = @IdPlan", Conn);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar el plan ", Ex);
                // throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }
        public List<Entidades.Plans> GetAll()
        {

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM Plans", Conn);
                List<Entidades.Plans> PlansList = new List<Entidades.Plans>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.Plans objPlans = new Entidades.Plans();
                        objPlans.IdPlan = (int)oReader["IdPlan"];
                        objPlans.PlanDescription = (string)oReader["PlanDescription"];
                        objPlans.IdSpeciality = (int)oReader["IdSpeciality"];

                        PlansList.Add(objPlans);
                        objPlans = null;
                    }
                    return PlansList;
                }
            }
            finally
            {
                this.Disconnect();
                //objPlans = null;
            }
        }
        public Entidades.Plans GetOne(int IdPlan)
        {
            Entidades.Plans objPlans = new Entidades.Plans();
            try
            {
                this.Connect();
                using (SqlCommand comm = new SqlCommand("SELECT * FROM Plans WHERE @IdPlan = IdPlan", Conn))
                {
                    comm.Parameters.AddWithValue("@IdPlan", IdPlan);

                    using (SqlDataReader oReader = comm.ExecuteReader())
                    {
                        if (oReader.Read())
                        {
                            objPlans.IdPlan = (int)(oReader["IdPlan"]);
                            objPlans.PlanDescription = (string)(oReader["PlanDescription"]);
                            objPlans.IdSpeciality = (int)(oReader["IdSpeciality"]);
                        }
                    }
                }

                return objPlans;

            } catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al buscar plan ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
                objPlans = null;
            }
        }
    }
}
