using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebAuthentication
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebAuthentication : System.Web.Services.WebService
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private DataSet loginDataSet;
        private DataSet employeesDataSet;
        private DataSet clientsDataSet;

        [WebMethod(Description = "Receives username and password as parameters and makes a search in the database for the entry, if it exists.")]
        public int FindAccount(string username, string password)
        {
            int userId = -1;

            InitializeDatabseConnection();

            var loginRows = loginDataSet.Tables["Login"].Rows;

            foreach(DataRow loginRow in loginRows)
            {
                if(loginRow.ItemArray[1].ToString().Equals(username) && loginRow.ItemArray[2].ToString().Equals(password))
                {
                    userId = int.Parse(loginRow.ItemArray[0].ToString());
                    break;
                }
            }

            return userId;
        }

        [WebMethod]
        public bool IsEmployee(int userId)
        {
            bool isEmployee = false;

            InitializeDatabseConnection();

            var employees = employeesDataSet.Tables["Employees"].Rows;

            foreach (DataRow employee in employees)
            {
                if (int.Parse(employee.ItemArray[5].ToString()) == userId)
                {
                    isEmployee = true;
                    break;
                }
            }

            return isEmployee;
        }

        [WebMethod]
        public bool IsClient(int userId)
        {
            bool isClient = false;

            InitializeDatabseConnection();

            var clients = clientsDataSet.Tables["Clients"].Rows;

            foreach (DataRow client in clients)
            {
                if (int.Parse(client.ItemArray[5].ToString()) == userId)
                {
                    isClient = true;
                    break;
                }
            }

            return isClient;
        }

        [WebMethod]
        public bool CreateAccount(List<string> details)
        {
            var username = details.ElementAt(0);
            var password = details.ElementAt(1);
            var isUsernameNotTaken = IsUsernameNotTaken(username);
            bool isCreatedClientEntry;

            if (!isUsernameNotTaken)
            {
                return false;
            }

            var isCreatedLoginEntry = CreateLoginEntry(username, password);

            if (isCreatedLoginEntry)
            {
                isCreatedClientEntry = CreateClientEntry(details);

                if (!isCreatedClientEntry)
                {
                    RollbackLoginEntry(username, password);
                }

                return isCreatedClientEntry;
            }

            return false;
        }

        private bool IsUsernameNotTaken(string username)
        {
            var isUsernameNotTaken = true;

            InitializeDatabseConnection();

            var users = loginDataSet.Tables["Login"].Rows;

            foreach(DataRow user in users)
            {
                if (user.ItemArray[1].ToString().Equals(username))
                {
                    isUsernameNotTaken = false;
                    break;
                }
            }

            return isUsernameNotTaken;
        }

        private bool CreateLoginEntry(string username, string password)
        {
            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand createLogin = new SqlCommand("INSERT INTO Login (Username, Password) VALUES (@username, @password)", sqlConnection);
            createLogin.Parameters.AddWithValue("@username", username);
            createLogin.Parameters.AddWithValue("@password", password);

            try
            {
                createLogin.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private bool CreateClientEntry(List<string> details)
        {
            var username = details.ElementAt(0);
            var password = details.ElementAt(1);
            var name = details.ElementAt(2);
            var surname = details.ElementAt(3);
            var phoneNumber = details.ElementAt(4);
            var email = details.ElementAt(5);
            var birthDate = details.ElementAt(6);
            int userId = -1;

            InitializeDatabseConnection();

            var credentials = loginDataSet.Tables["Login"].Rows;

            foreach (DataRow dataRow in credentials)
            {
                if(dataRow.ItemArray[1].ToString().Equals(username) && dataRow.ItemArray[2].ToString().Equals(password))
                {
                    userId = int.Parse(dataRow.ItemArray[0].ToString());
                    break;
                }
            }

            if(userId == -1)
            {
                return false;
            }

            sqlConnection.Open();

            SqlCommand createClient = new SqlCommand("INSERT INTO Clients (Name, Surname, PhoneNumber, Email, UserId, BirthDate) VALUES (@name, @surname, @phoneNumber, @email, @userId, @birthDate)", sqlConnection);
            createClient.Parameters.AddWithValue("@name", name);
            createClient.Parameters.AddWithValue("@surname", surname);
            createClient.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            createClient.Parameters.AddWithValue("@email", email);
            createClient.Parameters.AddWithValue("@userId", userId);
            createClient.Parameters.AddWithValue("@birthDate", birthDate);

            try
            {
                createClient.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private bool RollbackLoginEntry(string username, string password)
        {
            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand rollback = new SqlCommand("DELETE FROM Login WHERE Username = @username AND Password = @password", sqlConnection);
            rollback.Parameters.AddWithValue("@username", username);
            rollback.Parameters.AddWithValue("@password", password);

            try
            {
                rollback.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void InitializeDatabseConnection()
        {
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-9N4ISG2\MSSQLSERVER01;Initial Catalog=CinemaManagement;Integrated Security=True";

            try
            {
                sqlConnection.Open();
                loginDataSet = new DataSet();
                employeesDataSet = new DataSet();
                clientsDataSet = new DataSet();

                SqlDataAdapter loginDataAdapter = new SqlDataAdapter("SELECT * FROM Login", sqlConnection);
                loginDataAdapter.Fill(loginDataSet, "Login");

                SqlDataAdapter employeesDataAdapter = new SqlDataAdapter("SELECT * FROM Employees", sqlConnection);
                employeesDataAdapter.Fill(employeesDataSet, "Employees");

                SqlDataAdapter clientsDataAdapter = new SqlDataAdapter("SELECT * FROM Clients", sqlConnection);
                clientsDataAdapter.Fill(clientsDataSet, "Clients");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
