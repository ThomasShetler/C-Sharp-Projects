using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLdatabaseStuff
{
    class Program
    {
       
        

        static void Main(string[] args)
        {
            Console.WriteLine("what your name?");
            string name = Console.ReadLine();
            if (name == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exceptions in Exceptions)
                {
                    Console.Write(Exception.Id )
                }
            }
            theAge age = new theAge();
            try
            {
                age.Age();
            }
            catch (AgeException ex)
            {
                Console.WriteLine("that is not a correct age! you stupid idiot! try again! Jesus christ....");
                UpdateDbWithExeption(ex);
                Console.ReadLine();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("you messed something up! try entering an actual age!");
                UpdateDbWithExeption(ex);
                Console.ReadLine();
                return;
            }

        }
        private static void UpdateDbWithExeption(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DataBaseStuff; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Exceptiontype", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@Exceptiontype"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@timeStamp"].Value = DateTime.Now;

                connection.Open();

                command.ExecuteNonQuery();
                connection.Close();
            }

        }
            public static List<ExceptionEntity> ReadExceptions()
            {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DataBaseStuff; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exception";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ExceptionEntity exception = new ExceptionEntity();
                        exception.id = Convert.ToInt32(reader["Id"]);
                        exception.ExceptionType = reader["ExceptionType"].ToString();
                        exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                        exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                        Exceptions.Add(exception);
                    }
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            

            }
    }
}
