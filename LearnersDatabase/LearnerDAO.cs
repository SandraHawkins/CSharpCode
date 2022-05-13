using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;   // allows access to the Learner class
using System.Data.SqlClient;    // SqlConnection, SqlCommand
using System.Data;              // SqlDbType (Insert statement)
using System.Diagnostics;

namespace controller
{
    internal class LearnerDAO
    {
        // Global connection object to the database, it is global because it will
        // be used from the GetAllLearners() method, the UpdateLearner(), 
        // DeleteLearner() etc. 
        private SqlConnection connection;  // default is null

        // Write my own constructor
        public LearnerDAO()
        {
            //connection = new SqlConnection();
            //connection.ConnectionString = "";

            connection = new SqlConnection
            {
                //ConnectionString = "Data Source=FTCLAPTOP-13;Initial Catalog=Learners;" +
                // "Integrated Security=True"

                // Login setup in SQL Server for user sandra
                ConnectionString = "Data Source=FTCLAPTOP-13;Initial Catalog=Learners;" +
                                   "User ID=sandra;password=test"
            };
        }

        /*
         * This method will connect to the Learners database, select all rows from
         * the Learner table, loop though those rows, convert each row into a Learner
         * object, add that object to a list and return the list.
         * This method will assign a value to the out parameter success before it returns.
         */
        public List<Learner> GetAllLearners(out bool success)
        {
            // 1. Declare a list to hold all learner objects
            List<Learner> listOfLearners = new List<Learner>();

            try
            {
                // 2. Declare a Command object, this will hold the SQL
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Learner"
                };

                // 3. Open a connection to the database
                connection.Open();

                // 4. Execute the command, which will return a DataReader
                SqlDataReader dataReader = command.ExecuteReader();

                // 5. Loop through the DataReader object to access each row 
                //    that was returned from the database
                while (dataReader.Read())
                {
                    // 6. Turn each row of data into a Learner object 
                    // One-liner: using the object initialiser
                    //Learner learner = new Learner
                    //{
                    //    Id = (int)dataReader["Id"],
                    //    Name = dataReader["name"].ToString(),
                    //    Address = dataReader["address"].ToString(),
                    //    DateOfBirth = (DateTime)dataReader["dateOfBirth"],
                    //    RegistrationFee = (decimal)dataReader["registrationFee"],
                    //    IsEnrolled = (bool)dataReader["enrolled"]
                    //};

                    // Many lines instead:
                    int Id = (int)dataReader["Id"];
                    string Name = dataReader["name"].ToString();
                    string Address = dataReader["address"].ToString();
                    DateTime DateOfBirth = (DateTime)dataReader["dateOfBirth"];
                    decimal RegistrationFee = (decimal)dataReader["registrationFee"];
                    bool IsEnrolled = (bool)dataReader["enrolled"];

                    Learner learner = new Learner(Id, Name, Address, DateOfBirth, 
                                                  RegistrationFee, IsEnrolled);

                    Console.WriteLine(learner.ToString());

                    // 7. Add that learner to the list
                    listOfLearners.Add(learner);
                }

                // Everything was successful, assign true to the out parameter
                success = true;

                // 8. Close the database connection
                connection.Close();

                // 9. Deal with any database errors
            } catch (SqlException ex)
            {
                // Something went wrong, assign false to the out parameter
                success = false;
                Console.WriteLine(ex.ToString());
            }

            // 10. Return the list of learners
            return listOfLearners;
        }

        public bool InsertLearner(Learner learner)
        {
            // SQL, @Name is a placeholder for a paramter (you must assign a value to it)
            // which must be declared below.
            string sql = "INSERT INTO Learner " +
                "(name, address, dateOfBirth, registrationFee, enrolled) " +
                "VALUES (@Name, @Address, @Dob, @RegFee, @Enrolled)";

            try
            {
                // Set up a SqlCommand object
                //SqlCommand command = new SqlCommand();
                //command.Connection = connection; 
                //command.CommandText = sql; 

                SqlCommand command = new SqlCommand(sql, connection);

                SetUpCommandParameters(command, learner);

                // Open the connection
                connection.Open();

                // Execute the SqlCommand
                int numRows = command.ExecuteNonQuery();

                if (numRows == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex);
                //Console.WriteLine(ex);
                return false;
            }
            catch (Exception ex2) 
            {
                Console.WriteLine(ex2);
                return false;
            } finally
            {
                if (connection.State != ConnectionState.Closed) 
                    connection.Close();
            }
        }

        public bool DeleteLearner(int id)
        {
            try
            {
                // Set up a command object
                SqlCommand command = new SqlCommand(
                    $"DELETE FROM Learner WHERE id = {id}", connection);

                // open the connection
                connection.Open();

                // execute the command
                // if the command successfully executes, it will return the number of
                // rows affected, if that value is 1, then the delete was successful.
                // report on the success - return true or false
                int numRows = command.ExecuteNonQuery();

                // If numRows is 1, true gets returned, otherwise false gets returned.
                return numRows == 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            } finally // A finally block will always execute
            {
                // close the connection
                // This operator ?. is called a Null-Conditional operator or "Elvis" 
                // operator. If the operand on the left is null (e.g. the connenction
                // reference) then the expression evaluated to null, intead of throwing
                // a NullReferenceException.
                // If the connection was not sucessfully opened due to an error with
                // the connection string, the connection object will be null, if you 
                // call a method on a null reference, e.g. conneciton.Close(), it will
                // throw a NullReferenceException. This null-conditional operator is 
                // a short-circuit operator, so if the left hand side is null, the right
                // hand side will not execute. 
                connection?.Close();

                // This is the alternative
                //if (connection != null)
                //    connection.Close();

                // If execution gets this far, the then connection reference was 
                // successfully set up in the constructor, so best to check if the state
                // of the connetion is open before closing it. 
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Inside the if statement");
                    connection.Close();
                }
            }
        }

        public bool UpdateLearner(Learner learner)
        {
            string sql = "UPDATE Learner SET name = @Name, address = @Address, " +
                         "dateOfBirth = @Dob, registrationFee=@RegFee, " +
                         "enrolled = @Enrolled WHERE id = @Id";
            try
            {
                // Create a command object
                // assign the sql 
                // set the connection
                SqlCommand command = new SqlCommand
                {
                    CommandText = sql,
                    Connection = connection
                };

                SetUpCommandParameters(command, learner);

                // Set up one more parameter for the ID
                command.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Value = learner.Id
                });

                // open the connetion
                connection.Open();

                // execute the command
                int numRows = command.ExecuteNonQuery();

                Console.WriteLine("Num of row affected from update: " + numRows);

                // check that it was successful, i.e. it will return an int for the number
                // of rows updated
                return numRows == 1; // returns true if 1 row was updated
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void SetUpCommandParameters(SqlCommand command, Learner learner)
        {
            // Add new parameters onto the parameters collection of the command
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Name",
                Value = learner.Name,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "@Address",
                Value = learner.Address,
                SqlDbType = SqlDbType.VarChar,
                Size = 200
            };
            command.Parameters.Add(sqlParameter);

            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Dob",
                Value = learner.DateOfBirth,
                SqlDbType = SqlDbType.DateTime
            });

            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@RegFee",
                Value = learner.RegistrationFee,
                SqlDbType = SqlDbType.Decimal
            });

            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Enrolled",
                Value = learner.IsEnrolled,
                SqlDbType = SqlDbType.Bit
            });
        }

        public DataSet SearchLearner(string field, string @operator, string value)
        {
            // Construct SQL from the three values passed int
            string sql = $"SELECT * FROM Learner WHERE {field} {@operator} '{value}'";

            Console.WriteLine("The SQL: " + sql);

            // Create a SqlCommand object
            SqlCommand command = new SqlCommand(sql, connection);

            // This will hold the results from executing the command.
            DataSet dataSet = new DataSet();

            try
            {
                // The DataAdapter object is used to execute a statement against
                // the database and it will populate a DataTable in a DataSet.
                // We are using a DataAdapter object because it fills up a DataSet
                // and it will be used to populate the DataGridView on the Search form
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                // Calling the Fill command will execute the Select statement of the
                // command object and put the results into the dataset declared above
                // and into a DataTable called LearnerTable (in that dataset).
                dataAdapter.Fill(dataSet, "LearnerTable");

            } catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return dataSet;
        }
    }
}
