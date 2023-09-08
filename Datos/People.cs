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
                this.Connect();
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
                this.Disconnect();
            }
        }

        public void Update(int IdPerson, int FileId, string Name, string Surname, string Address, string Email, DateTime BirthDate, string Telephone, int IdPlan)
        {
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("UPDATE People SET FileId = @FileId, Name = @Name, Surname = @Surname, Address = @Address, Email = @Email, BirthDate = @BirthDate, Telephone = @Telephone, IdPlan = @IdPlan WHERE IdPerson = @IdPerson", Conn);
                comm.Parameters.AddWithValue("@IdPerson", IdPerson);
                comm.Parameters.AddWithValue("FileId", FileId);
                comm.Parameters.AddWithValue("@Name", Name);
                comm.Parameters.AddWithValue("@Surname", Surname);
                comm.Parameters.AddWithValue("@Address", Address);
                comm.Parameters.AddWithValue("@Email", Email);
                comm.Parameters.AddWithValue("@BirthDate", BirthDate);
                comm.Parameters.AddWithValue("@Telephone", Telephone);
                comm.Parameters.AddWithValue("@IdPlan", IdPlan);
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception HandledException = new Exception("Error al actualizar persona ", Ex);
                throw HandledException;
            }
            finally
            {
                this.Disconnect();
            }
        }

        public void Delete(int IdPerson)
        {
            try
            {
                this.Connect();            
                SqlCommand comm = new SqlCommand("DELETE People WHERE IdPerson = @IdPerson", Conn);

                comm.Parameters.AddWithValue("@IdPerson", IdPerson);
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

            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM People", Conn);
                List<Entidades.People> PeopleList = new List<Entidades.People>();

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    while (oReader.Read())
                    {
                        Entidades.People objPeople = new Entidades.People();
                        objPeople.IdPerson = (int)oReader["IdPerson"];
                        objPeople.Name = (string)oReader["Name"];
                        objPeople.Surname = (string)oReader["Surname"];
                        objPeople.Address = (string)oReader["Address"];
                        objPeople.Email = (string)oReader["Email"];
                        objPeople.Telephone = (string)oReader["Telephone"];
                        objPeople.BirthDate = Convert.ToDateTime(oReader["BirthDate"]);
                        objPeople.FileId = (int)oReader["FileId"];
                        objPeople.PersonType = (int)oReader["PersonType"];
                        objPeople.IdPlan = (int)oReader["IdPlan"];

                        PeopleList.Add(objPeople);
                        objPeople = null;
                    }
                    return PeopleList;
                }
            }
            finally
            {
                this.Disconnect();
                //objPeople = null;
            }
        }
        public Entidades.People GetOne(int IdPerson)
        {
            Entidades.People objPeople = new Entidades.People();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT * FROM People WHERE IdPerson = @IdPerson", Conn);
                comm.Parameters.AddWithValue("@IdPerson", IdPerson);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();

                    objPeople.IdPerson = (int)(oReader["IdPerson"]);
                    objPeople.Name = (string)(oReader["Name"]);
                    objPeople.Address = (string)(oReader["Address"]);
                    objPeople.Email = (string)(oReader["Email"]);
                    objPeople.Telephone = (string)(oReader["Telephone"]);
                    objPeople.BirthDate = (DateTime)(oReader["BirthDate"]);
                    objPeople.FileId = (int)(oReader["FileId"]);
                    objPeople.PersonType = (int)(oReader["PersonType"]);
                    objPeople.IdPlan = (int)(oReader["IdPlan"]);
                

                    return objPeople;

                }
            }
            finally
            {
                this.Disconnect();
                objPeople = null;
            }
        }
        public int GetTypePerson(int IdPerson)
        {
            Entidades.People objPeople = new Entidades.People();
            try
            {
                this.Connect();
                SqlCommand comm = new SqlCommand("SELECT PersonType FROM People WHERE @IdPerson = IdPerson", Conn);
                comm.Parameters.AddWithValue("@IdPerson", IdPerson);

                SqlDataReader oReader = comm.ExecuteReader();
                using (oReader)
                {
                    oReader.Read();
                    objPeople.PersonType = Convert.ToInt32(oReader["PersonType"]);

                    return objPeople.PersonType;

                }
            }
            finally
            {
                this.Disconnect();  
                objPeople = null;
            }
        }
    }
}
