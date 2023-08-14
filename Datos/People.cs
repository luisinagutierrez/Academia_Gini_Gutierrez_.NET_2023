using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class People:Connection
    {
        public int Add(Entidades.People item)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO People (Name, Surname, Address, Email, Telephone, BirthDate, FileId, PersonType, IdPlan) VALUES (@Name, @Surname, @Address, @Email, @Telephone, @BirthDate, @FileId, @PersonType, @IdPlan)", Conn);
                comm.Parameters.AddWithValue("@Name", item.Name);
                comm.Parameters.AddWithValue("@Surname", item.Surname);
                comm.Parameters.AddWithValue("@Address", item.Address);
                comm.Parameters.AddWithValue("@Email", item.Email);
                comm.Parameters.AddWithValue("@Telephone", item.Telephone);
                comm.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                comm.Parameters.AddWithValue("@FileId", item.FileId);
                comm.Parameters.AddWithValue("@PersonType", item.PersonType);
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                return comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al agregar persona ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Update(Entidades.People item, int id)
        {
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE People SET (Name, Surname, Address, Email, Telephone, BirthDate, FileId, PersonType, IdPlan) = (@Name, @Surname, @Address, @Email, @Telephone, @BirthDate, @FileId, @PersonType, @IdPlan) WHERE IdPerson = @Id", Conn);
                comm.Parameters.AddWithValue("@Name", item.Name);
                comm.Parameters.AddWithValue("@Surname", item.Surname);
                comm.Parameters.AddWithValue("@Address", item.Address);
                comm.Parameters.AddWithValue("@Email", item.Email);
                comm.Parameters.AddWithValue("@Telephone", item.Telephone);
                comm.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                comm.Parameters.AddWithValue("@FileId", item.FileId);
                comm.Parameters.AddWithValue("@PersonType", item.PersonType);     
                comm.Parameters.AddWithValue("@IdPlan", item.IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar persona ", Ex);
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
                SqlCommand comm = new SqlCommand("DELETE People WHERE IdPerson = @Id", Conn);

                comm.Parameters.AddWithValue("@IdPerson", id);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al eliminar persona ", Ex);
                throw HandledException;
            }
            finally
            {
                Conn.Close();
            }
        }
        public List<Entidades.People> GetAll()
        {
            Entidades.People objPeople = new Entidades.People();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM People", Conn);
                List<Entidades.People> PeopleList = new List<Entidades.People>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        objPeople.IdPerson = Convert.ToInt32(oReader["IdPerson"]);
                        objPeople.Name = Convert.ToString(oReader["Name"]);
                        objPeople.Address = Convert.ToString(oReader["Address"]);
                        objPeople.Email = Convert.ToString(oReader["Email"]);
                        objPeople.Telephone = Convert.ToString(oReader["Telephone"]);
                        objPeople.BirthDate = Convert.ToDateTime(oReader["BirthDate"]);
                        objPeople.FileId = Convert.ToInt32(oReader["FileId"]);
                        objPeople.PersonType = Convert.ToInt32(oReader["PersonType"]);
                        objPeople.IdPlan = Convert.ToInt32(oReader["IdPlan"]);

                        PeopleList.Add(objPeople);
                        objPeople = null;
                    }
                    return PeopleList;
                }
            }
            finally
            {
                objPeople = null;
            }
        }
        public Entidades.People GetOne(int id)
        {
            Entidades.People objPeople = new Entidades.People();
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM People WHERE @IdUser = id", Conn);
                comm.Parameters.AddWithValue("@IdUser", id);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objPeople.IdPerson = Convert.ToInt32(oReader["IdPerson"]);
                    objPeople.Name = Convert.ToString(oReader["Name"]);
                    objPeople.Address = Convert.ToString(oReader["Address"]);
                    objPeople.Email = Convert.ToString(oReader["Email"]);
                    objPeople.Telephone = Convert.ToString(oReader["Telephone"]);
                    objPeople.BirthDate = Convert.ToDateTime(oReader["BirthDate"]);
                    objPeople.FileId = Convert.ToInt32(oReader["FileId"]);
                    objPeople.PersonType = Convert.ToInt32(oReader["PersonType"]);
                    objPeople.IdPlan = Convert.ToInt32(oReader["IdPlan"]);
                

                    objPeople = null;

                    return objPeople;

                }
            }
            finally
            {
                objPeople = null;
            }
        }
    }
}
